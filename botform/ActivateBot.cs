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

        /*private static ActivateBot _instance;
        public static ActivateBot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ActivateBot(); 
                }

                return _instance;
            }
        }*/


        public botUser bot;
        string file;
        string auth;


        public ActivateBot(ref botUser b)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            bot = b;
            btnLoadAuth.Visible = false;
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

            bool gotUser = false;
            bool gotBot = false;
            bool gotAuth = false;


            if (usernameBox.Text != "")
            {
                gotUser = true;

            }else
            {
                lblError.Text = "Enter A User Name";
            }

            if (botnameBox.Text != "")
            {
                gotBot = true;

            }else
            {
                lblError.Text = "Enter A Bot Name";
            }

            if (authBox.Text != "")
            {
                file = authBox.Text;
                gotAuth = true;

            } else if (file != "") {
            }
            else
            {
                lblError.Text = "Enter An Auth Token";
            }


            if (gotUser && gotBot && gotAuth)
            {
                if (File.Exists(file))
                {
                    auth = File.ReadAllText(file);

                    bot.setAuth(auth);

                    Console.WriteLine("worked");

                }else
                {

                    lblError.Text = "could not locate file";
                }

            }
        }

    }
}
