using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace botform
{
    public partial class mainForm : Form
    {
        TcpClient tcpClient;
        StreamReader s_reader = null;
        StreamWriter s_writer = null;

        static botUser bot = new botUser();

        // initialize the user controls
        UserControl currentControl = null;
        ActivateBot acControl = new ActivateBot(ref bot);
        configureBot configBotControl = new configureBot(ref bot);

        // use for delaying response
        Queue<string> commandPool = new Queue<string>();


        public mainForm()
        {
            InitializeComponent();

            setForm();

        }


        private void setForm()
        {


            if (getUserInfo(ref bot))// try to get the users info from file
            {

                Connect();

            }
            else // if it can't be found, load the filler page
            {
                currentControl = acControl;
                ContentPanel.Controls.Add(currentControl);
                acControl.BringToFront();

            }

        }

        bool getUserInfo(ref botUser b)
        {
            bool retrived = false;

            string directory = Directory.GetCurrentDirectory();

            if (File.Exists(directory + "\\" + "botinfo.txt"))
            {
                

                StreamReader infofile = new StreamReader(directory + "\\" + "botinfo.txt");

                string un = infofile.ReadLine();
                string bn = infofile.ReadLine();
                string auth = infofile.ReadLine();
                string monChat = infofile.ReadLine();

                bot.setUserName(un.ToLower());
                bot.setBotName(bn.ToLower());
                bot.setAuth(auth.ToLower());
                bot.setMonitor(monChat.ToLower());
                bot.activateBot(true);

                infofile.Close();
                
                retrived = true;

            }

            
            return retrived;
        }

        void Connect()
        {
            // trouble connecting through tcp client
            //tcpClient = new TcpClient("irc.twitch.tv", 6667);
            tcpClient = new TcpClient();
            tcpClient.Connect("irc.twitch.tv", 80);
            s_reader = new StreamReader(tcpClient.GetStream());
            s_writer = new StreamWriter(tcpClient.GetStream());


            s_writer.WriteLine("PASS " + bot.getAuth() + Environment.NewLine
                + "NICK " + bot.getBotName() + Environment.NewLine
                + "USER " + bot.getBotName() + " 8 * :" + bot.getBotName());

            s_writer.Flush();
            s_writer.WriteLine("JOIN #" + bot.getMonitor());
            s_writer.Flush();

        }

        private void chatDisplay_Tick(object sender, EventArgs e)
        {
            if (bot.getState()) {


                if (tcpClient != null && !tcpClient.Connected)
                {
                    chatDisplay.Text += "\r\nAttempting to connect";
                    Connect();

                }

                if (tcpClient != null)
                {

                    if (tcpClient.Available > 0 || s_reader.Peek() > 0)
                    {
                        string stream = s_reader.ReadLine();
                        string message = parseMessage(stream);
                        
                        if (message != "") {

                            chatDisplay.AppendText(Environment.NewLine + message + Environment.NewLine);

                        }
                       
                        checkForCommand(message);

                    }
                }
            }
        }

        private string parseMessage(string message)
        {

            //:<user>!<user>@<user>.tmi.twitch.tv PRIVMSG #<channel> :This is a sample message
            string chat_message = message;
            string[] temp = message.Split(':');
            // length will either be 3 or 2

            if (temp.Length >= 3)
            {
                Console.WriteLine(message);
                string[] stream_message = temp[1].Split('@');

                if(stream_message.Length > 1)
                {
                    if (stream_message[0].Contains('!'))
                    {
                        stream_message = stream_message[0].Split('!');
                        string un = stream_message[1];

                        chat_message = un + ": " + temp[2];
                    }else
                    {
                        chat_message = temp[1] + ": " + temp[2];
                    }

                }else
                {

                    chat_message = temp[1] + ": " + temp[2];

                }

            
            }

            return chat_message;
        }

        private string checkForCommand(string message)
        {
            string response = "";

            if (bot.botCommands != null)
            {
                Console.WriteLine("Checking commands: " + message);

                // remove user name
                string[] temp = message.Split(':');

                string chat_message = temp[1];

                if (!string.IsNullOrWhiteSpace(chat_message))
                {

                    string[] words = chat_message.Split(' ');

                    for (int i = 0; i < words.Length; i++)
                    {
                        string s = words[i].ToLower();

                        if (!string.IsNullOrWhiteSpace(s) && s[0] == '!')
                        {

                            // if we find a command, strip all special
                            // characters and place in pool
                            string command = Regex.Replace(s, @"[^0-9a-zA-Z]+", "");
                            commandPool.Enqueue(command);
                            
                        }
                        
                    }

                }
            }


            return response;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (bot.getState()) {

                if (tcpClient != null)
                {

                    if (!string.IsNullOrWhiteSpace(chatBox.Text))
                    {
                        //:<user>!<user>@<user>.tmi.twitch.tv PRIVMSG #<channel> :This is a sample message
                        string prefix = $":{bot.getBotName()}!{bot.getBotName()}@{bot.getBotName()}.tmi.twitch.tv PRIVMSG #{bot.getMonitor()} :";
                        string message = $"{prefix}{chatBox.Text}";
                        s_writer.WriteLine(message);
                        s_writer.Flush();
                        chatDisplay.AppendText($"\r\n{bot.getBotName()} : {chatBox.Text}\r\n");
                        chatBox.Clear();
                    }

                }
            }

        }

        private void commResponse_Tick_1(object sender, EventArgs e)
        {
            
            if (commandPool.Count > 0)
            {
                string command = commandPool.Dequeue();
                int index = bot.getIndex(command);
                if (index != -1)
                {
                    string response = bot.botResponse[index];
                    string prefix = $":{bot.getBotName()}!{bot.getBotName()}@{bot.getBotName()}.tmi.twitch.tv PRIVMSG #{bot.getMonitor()} :";
                    string message = $"{prefix}{response}";
                    s_writer.WriteLine(message);
                    s_writer.Flush();
                    chatDisplay.AppendText($"\r\n{bot.getBotName()} : {response}\r\n");

                }

            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // home page is always loaded so it should be
            // behind the current user control
            if (currentControl != null)
            {
                ContentPanel.Controls.Remove(currentControl);
            }

        }

        private void setUpBotToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (currentControl != null)
            {
                ContentPanel.Controls.Remove(currentControl);
            }

            currentControl = acControl;
            ContentPanel.Controls.Add(currentControl);
            currentControl.BringToFront();


        }

        private void configBotToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (currentControl != null)
            {
                ContentPanel.Controls.Remove(currentControl);
            }

            currentControl = configBotControl;
            ContentPanel.Controls.Add(currentControl);
            currentControl.BringToFront();


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {


            if (tcpClient != null)
            {

                s_reader.Close();
                s_writer.Close();
                tcpClient.Close();

            }
           
        }

        private void btnReconnect_Click(object sender, EventArgs e)
        {

            updateChat.Enabled = false;
            commResponse.Enabled = false;
            chatDisplay.Clear(); // clear current chat


            if (tcpClient != null && tcpClient.Connected)
            {
                s_reader.Close();
                s_writer.Close();
                tcpClient.Close();
            }        

            
            if (getUserInfo(ref bot)) 
            {

                Connect();

                updateChat.Enabled = true; // restart the timer
                commResponse.Enabled = true;
            }
            
        }

    }
}
