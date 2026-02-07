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
    public partial class carinfo : Form
    {
        public carinfo()
        {
            InitializeComponent();
        }

        static string connectionstring = "Data Source=DESKTOP-K41TQKU\\SQLEXPRESS;Initial Catalog=csms;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionstring);

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void carinfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'csmsDataSet.carinfotable' table. You can move, or remove it, as needed.
            this.carinfotableTableAdapter.Fill(this.csmsDataSet.carinfotable);

        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            //back to dashboard
            dashboard dash = new dashboard();
            this.Hide();
            dash.Show();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            //clear textboxes
            textboxcarid.Clear();
            textboxbrand.Clear();
            textboxcolour.Clear();
            textboxyear.Clear();
            textboxprice.Clear();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            //exit from the car info
            Application.Exit();
        }

        private void buttoninsert_Click(object sender, EventArgs e)
        {
                //taking data from textboxes
                string CarID = textboxcarid.Text;
                string Brand = textboxbrand.Text;
                string Colour = textboxcolour.Text;
                string Year = textboxyear.Text;
                string Price = textboxprice.Text;

                //SQL Query
                string Insert_Query = "INSERT INTO carinfotable VALUES('" + CarID + "', '" + Brand + "', '" + Colour + "', '" + Year + "', '" + Price + "')";

                //SQL Command
                SqlCommand cmd = new SqlCommand(Insert_Query, con);

                //Open SQL connection
                con.Open();

                //Execute the command
                cmd.ExecuteNonQuery();

                //Message showing
                MessageBox.Show("Added Successful");

                //Close the SQL connection
                con.Close();

        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            //taking data from textboxes
            string CarID = textboxcarid.Text;
            string Brand = textboxbrand.Text;
            string Colour = textboxcolour.Text;
            string Year = textboxyear.Text;
            string Price = textboxprice.Text;

            //Open the SQL connection
            con.Open();

            //SQL Query
            string Update_Query = "UPDATE carinfotable SET CarID = '" + CarID + "', Brand = '" + Brand + "', Colour = '" + Colour + "', Year = '" + Year + "', Price = '" + Price + "' WHERE CarID = '"+CarID+"'";

            //SQL command
            SqlCommand cmd = new SqlCommand(Update_Query, con);

            //Execute the command
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

            //Taking date from datagridviewcarinfo
            string CarID = textboxcarid.Text;

            //SQL query
            string Delete_Query = "DELETE FROM carinfotable WHERE CarID = '" + CarID + "'";

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
            //Taking data from textboxcarid
            string CarID = textboxcarid.Text;

            //SQL Query
            string Selectall_Query = "SELECT * FROM carinfotable WHERE CarID = '" + CarID + "'";

            //SQL command
            SqlCommand cmd = new SqlCommand(Selectall_Query, con);
            SqlDataAdapter sda = new SqlDataAdapter(Selectall_Query, con);
            DataSet set = new DataSet();

            //Open the SQL connection
            con.Open();
            sda.Fill(set, "CarID");

            //Close the SQL connection
            con.Close();

            datagridviewcarinfo.DataSource = set;
            datagridviewcarinfo.DataMember = "CarID";
        }

        private void buttonshowall_Click(object sender, EventArgs e)
        {
            //SQL Query
            string Selectall_Query = "SELECT * FROM carinfotable";
            SqlDataAdapter sda = new SqlDataAdapter(Selectall_Query, con);
            DataSet set = new DataSet();

            //Open the SQL connection
            con.Open();
            sda.Fill(set, "CarID");

            //Close the SQL connection
            con.Close();

            datagridviewcarinfo.DataSource = set;
            datagridviewcarinfo.DataMember = "CarID";

        }

        private void datagridviewcarinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Filling textboxes by clicking corner of the datagridviewcarinfo
            textboxcarid.Text = datagridviewcarinfo.SelectedRows[0].Cells[0].Value.ToString();
            textboxbrand.Text = datagridviewcarinfo.SelectedRows[0].Cells[1].Value.ToString();
            textboxcolour.Text = datagridviewcarinfo.SelectedRows[0].Cells[2].Value.ToString();
            textboxyear.Text = datagridviewcarinfo.SelectedRows[0].Cells[3].Value.ToString();
            textboxprice.Text = datagridviewcarinfo.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
