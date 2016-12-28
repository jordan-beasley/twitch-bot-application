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

namespace botform
{
    public partial class Form1 : Form
    {
        TcpClient tcpClient;
        StreamReader s_reader;
        StreamWriter s_writer;

        static botUser bot = new botUser();

        // initialize the user controls
        UserControl currentControl = null;
        ActivateBot acControl = new ActivateBot(ref bot);


        public Form1()
        {
            InitializeComponent();
            ContentPanel.Dock = DockStyle.Fill;

            if (bot.getUserName() == "")
            {

                ContentPanel.Controls.Add(acControl);
                acControl.BringToFront();
            }
            else
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

            tcpClient = new TcpClient("irc.twitch.tv", 6667);
            s_reader = new StreamReader(tcpClient.GetStream());
            s_writer = new StreamWriter(tcpClient.GetStream());


            s_writer.WriteLine("PASS " + bot.getAuth() + Environment.NewLine
                + "NICK " + bot.getBotName() + Environment.NewLine
                + "USER " + bot.getBotName() + " 8 * :" + bot.getBotName());

            s_writer.Flush();
            s_writer.WriteLine("JOIN #" + bot.getMonitor());
            s_writer.Flush();
        }


        private void timer1_Tick(object sender, EventArgs e)
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
                        string message = s_reader.ReadLine();

                        chatDisplay.Text += $"\r\n{message}";

                    }
                }
            }
        }


        // when button is clicked to submit, check text then post reply in chat
        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (currentControl != null)
            {
                ContentPanel.Controls.Remove(currentControl);
            }

        }

        private void setUpBotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentControl = acControl;

            ContentPanel.Controls.Add(currentControl);
            currentControl.BringToFront();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tcpClient != null)
            {

                tcpClient.Close();

            }
           
        }

        private void btnReconnect_Click(object sender, EventArgs e)
        {

            timer1.Enabled = false;
            chatDisplay.Text = "Chat: "; // clear current chat            
            // reinitialize the bot
            if (getUserInfo(ref bot)) // if the bot was successfully reinitialized
            {

                Connect(); // run connect script

                timer1.Enabled = true; // restart the timer
            }
            
        }
    }
}
