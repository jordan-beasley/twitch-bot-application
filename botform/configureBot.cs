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

           
            //tblCommands.ReadOnly = true;
            fillTable();
        }

        private void fillTable()
        {
            // check if the bot has any values in its arrays

            bot.fillCommands();

            if (bot.getCommandCount() > 0) {

                lblError.Text = "";
                tblCommands.Rows.Add(bot.getCommandCount());

                for (int i = 0; i < bot.getCommandCount(); i++)
                {
                    tblCommands.Rows[i].Cells[0].Value = bot.botCommands[i];
                    tblCommands.Rows[i].Cells[1].Value = bot.botResponse[i];
                }

            }else
            {

                Console.WriteLine("no commands");
                lblError.Text = "No Commands Found";

            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string directory = Directory.GetCurrentDirectory();
            StreamWriter outfile = new StreamWriter(directory + "\\" + "botcommands.txt");

            for (int i = 0; i < tblCommands.Rows.Count - 1; i++)
            {
                if (tblCommands.Rows[i] != null)
                {

                    outfile.WriteLine(tblCommands.Rows[i].Cells[0].Value.ToString() + ";"
                        + tblCommands.Rows[i].Cells[1].Value.ToString());


                }
            }

            outfile.Close();

            tblCommands.Rows.Clear();
            tblCommands.Refresh();

            fillTable();


        }

 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            

            if (tblCommands.Rows.Count > 1)
            {
                // remove command from the table
                int index = tblCommands.CurrentCell.RowIndex;
                tblCommands.Rows.RemoveAt(index);

                // update the table after deleting from it
                btnUpdate_Click(sender, e);

            }
            

        }
    }


}
