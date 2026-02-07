using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace carsalemanagementsystem
{
    public partial class customerinfo : Form
    {
        public customerinfo()
        {
            InitializeComponent();
        }

        static string connectionstring = "Data Source=DESKTOP-K41TQKU\\SQLEXPRESS;Initial Catalog=csms;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionstring);

        private void labelbrand_Click(object sender, EventArgs e)
        {

        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            //Go back to dashboard
            dashboard dash = new dashboard();
            this.Hide();
            dash.Show();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            //Clear the textboxes
            textboxcustomerid.Clear();
            textboxname.Clear();
            textboxaddress.Clear();
            textboxtelno.Clear();
            textboxemail.Clear();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            //Exit from the customerinfo
            Application.Exit();
        }


        private void customerinfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'csmsDataSet1.customerinfotable' table. You can move, or remove it, as needed.
            this.customerinfotableTableAdapter.Fill(this.csmsDataSet1.customerinfotable);

        }

        private void buttoninsert_Click(object sender, EventArgs e)
        {
            //Taking data from textboxes
            string CustomerID = textboxcustomerid.Text;
            string Name = textboxname.Text;
            string Address = textboxaddress.Text;
            string TelNo = textboxtelno.Text;
            string Email = textboxemail.Text;

            //SQL Query
            string Insert_Query = "INSERT INTO customerinfotable VALUES('"+CustomerID+"', '"+Name+"', '"+Address+"', '"+TelNo+"', '"+Email+"')";

            //SQL command
            SqlCommand cmd = new SqlCommand(Insert_Query,con);

            //Open the SQL connection
            con.Open();

            //Execute th ecommand
            cmd.ExecuteNonQuery();

            //Message Showing
            MessageBox.Show("Added Successful");

            //Close th SQL connection
            con.Close();

        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            //Taking data from textboxes
            string CustomerID = textboxcustomerid.Text;
            string Name = textboxname.Text;
            string Address = textboxaddress.Text;
            string TelNo = textboxtelno.Text;
            string Email = textboxemail.Text;

            //Open the SQL connection
            con.Open();

            //SQL Query
            string Update_Query = "UPDATE customerinfotable SET CustomerID = '"+CustomerID+"', Name = '"+Name+"', Address = '"+Address+"', TelNo = '"+TelNo+"', Email = '"+Email+"' WHERE CustomerID = '"+CustomerID+"'";

            //SQL command
            SqlCommand cmd = new SqlCommand(Update_Query, con);

            //Execute the command
            cmd.ExecuteNonQuery();

            //Message Showing
            MessageBox.Show("Update Successful");

            //Close the SQL Connection
            con.Close();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            //Open the SQL Connection
            con.Open();

            //taking data from datagridviewcustomerinfo
            string CustomerID = textboxcustomerid.Text;

            //SQL Query
            string Delete_Query = "DELETE FROM customerinfotable WHERE CustomerID  = '"+CustomerID+"'";

            //SQL Command
            SqlCommand cmd = new SqlCommand(Delete_Query, con);

            //Execute the Command
            cmd.ExecuteNonQuery();

            //Message Showing
            MessageBox.Show("Delete Successful");

            //Close the SQL Connection
            con.Close();
        
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            //Teking data from textboxcustomerid
            string CustomerID = textboxcustomerid.Text;

            //SQL Query
            string Selectall_Query = "SELECT * FROM customerinfotable WHERE customerID = '" + CustomerID + "'";

            //SQL command
            SqlCommand cmd = new SqlCommand(Selectall_Query, con);
            SqlDataAdapter sda = new SqlDataAdapter(Selectall_Query, con);
            DataSet set = new DataSet();

            //Open the SQL connection
            con.Open();
            sda.Fill(set, "CustomerID");

            //Close the SQL connection
            con.Close();

            datagridviewcustomerinfo.DataSource = set;
            datagridviewcustomerinfo.DataMember = "CustomerID";
        }

        private void buttonshowall_Click(object sender, EventArgs e)
        {
            //SQL Query
            string Selectall_Query = "SELECT * FROM customerinfotable";
            SqlDataAdapter sda = new SqlDataAdapter(Selectall_Query, con);
            DataSet set = new DataSet();

            //Open the SQL connection
            con.Open();
            sda.Fill(set, "CustomerID");

            //Close the SQL connection
            con.Close();

            datagridviewcustomerinfo.DataSource = set;
            datagridviewcustomerinfo.DataMember = "CustomerID";
        }

        private void datagridviewcustomerinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Filling textboxes by clicking corner of the datagridviewcarinfo
            textboxcustomerid.Text = datagridviewcustomerinfo.SelectedRows[0].Cells[0].Value.ToString();
            textboxname.Text = datagridviewcustomerinfo.SelectedRows[0].Cells[1].Value.ToString();
            textboxaddress.Text = datagridviewcustomerinfo.SelectedRows[0].Cells[2].Value.ToString();
            textboxtelno.Text = datagridviewcustomerinfo.SelectedRows[0].Cells[3].Value.ToString();
            textboxemail.Text = datagridviewcustomerinfo.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
