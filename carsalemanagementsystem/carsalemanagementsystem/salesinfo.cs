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
    public partial class salesinfo : Form
    {
        public salesinfo()
        {
            InitializeComponent();
        }

        static string connectionstring = "Data Source=DESKTOP-K41TQKU\\SQLEXPRESS;Initial Catalog=csms;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionstring);

        private void salesinfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'csmsDataSet2.salesinfotable' table. You can move, or remove it, as needed.
            this.salesinfotableTableAdapter.Fill(this.csmsDataSet2.salesinfotable);

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
            //Clear the Textboxes
            textboxsaleid.Clear();
            textboxcustomerid.Clear();
            textboxcarid.Clear();
            textboxsaledate.Clear();
            textboxsaleprice.Clear();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            //Exit from the salesinfo
            Application.Exit();
        }

        private void buttoninsert_Click(object sender, EventArgs e)
        {
            //taking data from textboxes
            string SaleID = textboxsaleid.Text;
            string CustomerID = textboxcustomerid.Text;
            string CarID = textboxcarid.Text;
            string SaleDate = textboxsaledate.Text;
            string SalePrice = textboxsaleprice.Text;

            //SQL Query
            string Insert_Query = "INSERT INTO salesinfotable VALUES ('" + SaleID + "', '" + CustomerID + "', '" + CarID + "', '" + SaleDate + "', '" + SalePrice + "')";

            //SQL command
            SqlCommand cmd = new SqlCommand(Insert_Query, con);

            //open th eSQL connection
            con.Open();

            //Command Execute
            cmd.ExecuteNonQuery();

            //Message showing
            MessageBox.Show("Insert Successful");

            //SQL connection close
            con.Close();

        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            //taking data from textboxes
            string SaleID = textboxsaleid.Text;
            string CustomerID = textboxcustomerid.Text;
            string CarID = textboxcarid.Text;
            string SaleDate = textboxsaledate.Text;
            string SalePrice = textboxsaleprice.Text;

            //Open the SQL connection
            con.Open();

            //SQL Query
            string Update_Query = "UPDATE salesinfotable SET SaleID = '" + SaleID + "', CustomerID = '" + CustomerID + "', CarID = '" + CarID + "', SaleDate = '" + SaleDate + "', SalePrice = '" + SalePrice + "' WHERE SaleID = '" + SaleID + "'";

            //SQL Command
            SqlCommand cmd = new SqlCommand(Update_Query, con);

            //Command Execute
            cmd.ExecuteNonQuery();

            //Message showing
            MessageBox.Show("Update Successful");

            //Close the SQL Connection
            con.Close();


        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            //open the SQL connection
            con.Open();

            //Taking data from datagridviewsalesinfo
            string SaleID = textboxsaleid.Text;

            //SQL QUrey
            string Delete_Query = "DELETE FROM salesinfotable WHERE SaleID = '" + SaleID + "'";

            //SQL command
            SqlCommand cmd = new SqlCommand(Delete_Query, con);

            //Execute the command
            cmd.ExecuteNonQuery();

            //Message Showing
            MessageBox.Show("Delete Successful");

            //Close the SQL connection
            con.Close();
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            //Taking data from textboxsaleid
            string SaleID = textboxsaleid.Text;

            //SQL Query
            string Selectall_Query = "SELECT * FROM salesinfotable WHERE SaleID = '" + SaleID + "'";

            //SQL command
            SqlCommand cmd = new SqlCommand(Selectall_Query, con);
            SqlDataAdapter sda = new SqlDataAdapter(Selectall_Query, con);
            DataSet set = new DataSet();

            //SQL connection Open 
            con.Open();
            sda.Fill(set, "SaleID");

            //Close the SQL connection
            con.Close();

            datagridviewsalesinfo.DataSource = set;
            datagridviewsalesinfo.DataMember = "SaleID";
        }

        private void buttonshowall_Click(object sender, EventArgs e)
        {
            //SQL Query
            string Selectall_Query = "SELECT * FROM salesinfotable";
            SqlDataAdapter sda = new SqlDataAdapter(Selectall_Query, con);
            DataSet set = new DataSet();

            //SQL connection Open 
            con.Open();
            sda.Fill(set, "SaleID");

            //Close the SQL connection
            con.Close();

            datagridviewsalesinfo.DataSource = set;
            datagridviewsalesinfo.DataMember = "SaleID";
        }

        private void datagridviewsalesinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Filling textboxes by clicking corner of the datagridviewcarinfo
            textboxsaleid.Text = datagridviewsalesinfo.SelectedRows[0].Cells[0].Value.ToString();
            textboxcustomerid.Text = datagridviewsalesinfo.SelectedRows[0].Cells[0].Value.ToString();
            textboxcarid.Text = datagridviewsalesinfo.SelectedRows[0].Cells[0].Value.ToString();
            textboxsaledate.Text = datagridviewsalesinfo.SelectedRows[0].Cells[0].Value.ToString();
            textboxsaleprice.Text = datagridviewsalesinfo.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
