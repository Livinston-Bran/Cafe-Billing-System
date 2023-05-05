using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Billing
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uname.ResetText();
            pass.ResetText();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String username = uname.Text;
            String password = pass.Text;

            

            if (username.Equals("admin") && password.Equals("12345"))
            {
                dashboard dash = new dashboard();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password Incorrect !");
            }
        }
    }
}
