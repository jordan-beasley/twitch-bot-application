using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace botform
{
    public partial class SignIn : UserControl
    {

        private static SignIn _instance;
        public static SignIn Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SignIn();
                }

                return _instance;
            }
        }

        public SignIn()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
    }
}
