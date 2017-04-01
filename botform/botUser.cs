using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace botform
{
    public class botUser
    {

        
        private string username;
        private string botName;
        private string monitorChat;
        private string oAuth;
        private bool active = false;

        public string[] botCommands = null; // command, response
        public string[] botResponse = null;
        private int commandCount = 0;

        private bool strictMode = false;
        private string[] strictWatch = new string[10];





        public void strictModeWatch(string chatMessage)
        {
            // check message for any of the words in the strictWatch list
            // if it returns true, do something


        }


        public void setAuth(string auth) { oAuth = auth; }
        public void setUserName(string UN) { username = UN; }
        public string getUserName() { return username; }
        public void setBotName(string BN) { botName = BN; }
        public string getBotName() { return botName; }
        public string getAuth() { return oAuth; }
        public void activateBot(bool state) { active = state; }
        public bool getState() { return active; }
        public void setMonitor(string chat) { monitorChat = chat; }
        public string getMonitor() { return monitorChat; }

        public void saveBotInfo()
        {
            string directory = Directory.GetCurrentDirectory();

            StreamWriter infoFile = new StreamWriter(directory + '\\' + "botinfo.txt");

            infoFile.WriteLine(username);
            infoFile.WriteLine(botName);
            infoFile.WriteLine(oAuth);
            infoFile.WriteLine(monitorChat);

            infoFile.Close();

        }

        public void saveBotCommands()
        {
            // add the saving of the commands
            if (botCommands != null)
            {
                string directory = Directory.GetCurrentDirectory();
                StreamWriter outfile = new StreamWriter(directory + "\\" + "botcommands.txt");

                for (int i = 0; i < botCommands.Length; i++)
                {
                    outfile.WriteLine(botCommands[i] + ";" + botResponse[i]);
                }

                outfile.Close();
            }

        }

        public void fillCommands()
        {
            string directory = Directory.GetCurrentDirectory();
            

            if (File.Exists(directory + "\\" + "botcommands.txt"))
            {
                botCommands = new string[10];
                botResponse = new string[10];
                string path = directory + "\\" + "botcommands.txt";
                string[] commands = File.ReadAllLines(path);
                //string[] temp = new string[commands.Length];

                // creates a list of string arrays, max size 2, lenght 10
                List<string[]> temp2 = new List<string[]>();

                foreach (string comm in commands)
                {
                    temp2.Add(comm.Split(';'));
                }

                for (int i = 0; i < commands.Length; i++)
                {
                    botCommands[i] = temp2[i][0].ToString();
                    botResponse[i] = temp2[i][1].ToString();
                }


                //Console.WriteLine(temp2[0][1].ToString());

                //saveBotCommands();

            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
    }



}
