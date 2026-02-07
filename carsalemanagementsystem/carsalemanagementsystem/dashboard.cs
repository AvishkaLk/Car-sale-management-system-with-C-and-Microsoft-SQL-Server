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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void buttoncarinfo_Click(object sender, EventArgs e)
        {
            //Go to Carinfo
            carinfo car = new carinfo();
            this.Hide();
            car.Show();
        }

        private void buttoncustomerinfo_Click(object sender, EventArgs e)
        {
            //Go to Customerinfo
            customerinfo customer = new customerinfo();
            this.Hide();
            customer.Show();
        }

        private void buttonsalesinfo_Click(object sender, EventArgs e)
        {
            //Go to salesinfo
            salesinfo sales = new salesinfo();
            this.Hide();
            sales.Show();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            //Exit from the dashboard
            Application.Exit();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            //go back to login form
            login log = new login();
            this.Hide();
            log.Show();
        }
    }
}
