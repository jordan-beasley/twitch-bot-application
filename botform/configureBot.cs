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
    public partial class configureBot : UserControl
    {

        public botUser bot;

        public configureBot(ref botUser b)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            bot = b;

            DataGridViewColumn left = tblCommands.Columns[0];
            DataGridViewColumn right = tblCommands.Columns[1];
            left.Width = tblCommands.Width / 2;
            right.Width = tblCommands.Width / 2;

            tblCommands.Rows.Add(10);
            fillTable();
        }

        private void fillTable()
        {
            // check if the bot has any values in its arrays

            bot.fillCommands();

            if (bot.botCommands == null)
            {
                Console.WriteLine("no commands");
                lblError.Text = "No Commands Found";

            }
            else
            {

                // since I'm limiting the user to 10
                for (int i = 0; i < 10; i++)
                {

                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string directory = Directory.GetCurrentDirectory();
            StreamWriter outfile = new StreamWriter(directory + "\\" + "botcommands.txt");

            for (int i = 1; i < tblCommands.Rows.Count; i++)
            {
                if (tblCommands.Rows[i].Cells[0].Value == null)
                {
                    outfile.WriteLine(tblCommands.Rows[i].Cells[0].Value + ";"
                        + tblCommands.Rows[i].Cells[1].Value);
                }
            }

            outfile.Close();

            //bot.saveBotCommands();
            //fillTable();
        }
    }


}
