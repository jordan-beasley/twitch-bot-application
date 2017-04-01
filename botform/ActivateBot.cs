using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace botform
{
    public partial class ActivateBot : UserControl
    {

        public botUser bot;
        string file;
        string auth;



        public ActivateBot(ref botUser b)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            bot = b;
            btnLoadAuth.Visible = false;
            cbMonChat1.Checked = true;
            cbMonChat2.Checked = false;
            monChatBox.Visible = false;

        }

        private void btnLoadAuth_Click(object sender, EventArgs e)
        {

            OpenFileDialog path = new OpenFileDialog();
            path.Filter = "Image Files(*.txt)|*.txt";

            if (path.ShowDialog() == DialogResult.OK)
            {

                 file = path.FileName;

            }else
            {

                lblError.Text = "Unable to access file";

            }

        }

        private void cbLoadFile_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLoadFile.Checked == true)
            {
                authBox.Visible = false;
                btnLoadAuth.Visible = true;

            }else
            {

                authBox.Visible = true;
                btnLoadAuth.Visible = false;

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(usernameBox.Text))
            {
                lblUsername.ForeColor = Color.Red;
            }
            else
            {
                lblUsername.ForeColor = Color.Black;


            }

            if (string.IsNullOrWhiteSpace(botnameBox.Text))
            {
                lblBotUsername.ForeColor = Color.Red;

            }else
            {

                lblBotUsername.ForeColor = Color.Black;

            }

            if (string.IsNullOrWhiteSpace(authBox.Text) && file == null)
            {
                lblAuth.ForeColor = Color.Red;
            }
            else
            {

                lblAuth.ForeColor = Color.Black;


            }

            if (cbMonChat2.Checked == true && string.IsNullOrWhiteSpace(monChatBox.Text))
            {
                lblMonChat.ForeColor = Color.Red;
            }
            else
            {

                lblMonChat.ForeColor = Color.Black;


            }

            //check if the text name and bot name are empty

            if (!string.IsNullOrWhiteSpace(usernameBox.Text) && !string.IsNullOrWhiteSpace(botnameBox.Text))
            {

                // check if the file or path are empty
                if (!string.IsNullOrWhiteSpace(authBox.Text))
                {

                    auth = authBox.Text.ToLower();

                    setupBot(auth);

                }
                else if (file != null) // check if they entered a path for the 
                {
                    auth = File.ReadAllText(file).ToLower();

                    setupBot(auth);

                }

            }

            
        }

        void setupBot(string auth)
        {
            bot.setAuth(auth);
            bot.setUserName(usernameBox.Text.ToLower());
            bot.setBotName(botnameBox.Text.ToLower());
            bot.activateBot(true);

            if (cbMonChat1.Checked == true)
            {

                bot.setMonitor(bot.getUserName());

            }else if(cbMonChat2.Checked == true)
            {
                bot.setMonitor(monChatBox.Text.ToLower());

            }

            bot.saveBotInfo();
            this.Parent.Controls.Remove(this);

        }

        private void cbMonChat1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbMonChat1.Checked == true)
            {
                cbMonChat2.Checked = false;
                monChatBox.Visible = false;
            }

        }

        private void cbMonChat2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMonChat2.Checked == true)
            {
                cbMonChat1.Checked = false;
                monChatBox.Visible = true;
            }

        }
    }
}
