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

        public string[,] commands = new string[10,10]; // command, response
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
    }



}
