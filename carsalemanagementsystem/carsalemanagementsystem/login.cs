using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carsalemanagementsystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            //Clear the textboxes
            textboxusername.Clear();
            textboxpassword.Clear();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            //Exit from the login form
            Application.Exit();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            //Username and Password Info
            string username = "Admin";
            string password = "1234";

            if (username == textboxusername.Text && password == textboxpassword.Text)
            {
                //Message showing
                MessageBox.Show("Login Successful");
                //Go to Dashboard Form
                dashboard dash = new dashboard();
                this.Hide();
                dash.Show();
            }

            else
            {
                //Message showing if username or password is invalid
                MessageBox.Show("Invalid Username or Password");
            }

        }
    }
}
