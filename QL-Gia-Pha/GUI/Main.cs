using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login frm_Login = new Login();
            frm_Login.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Users frm_Users = new Users();
            frm_Users.Show();
       }
    }
}
