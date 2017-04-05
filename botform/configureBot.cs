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

           
            tblCommands.ReadOnly = true;
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

                tblCommands.Rows.Add(bot.getCommandCount());
                //Console.WriteLine("rows: " + bot.getCommandCount());
                for (int i = 0; i < bot.getCommandCount(); i++)
                {
                    tblCommands.Rows[i].Cells[0].Value = bot.botCommands[i];
                    tblCommands.Rows[i].Cells[1].Value = bot.botResponse[i];
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

 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            

            if (tblCommands.Rows.Count > 1)
            {
                // remove command from the table
                int index = tblCommands.CurrentCell.RowIndex;
                Console.WriteLine(index);
                tblCommands.Rows.RemoveAt(index);

                // make sure we update the array for the bots
                // then refill the table
                // btnUpdate_Click(sender, e);
                // fillTable();
            }
            

        }
    }


}
