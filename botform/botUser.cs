using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace botform
{
    public class botUser
    {

        
        public string username;
        public string botName;
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
        public string getAuth() { return oAuth; }
        public void activateBot(bool state) { active = state; }
        public bool getState() { return active; }
    }



}
