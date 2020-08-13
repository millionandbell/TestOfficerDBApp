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

namespace TestOfficerDBApp
{
    public partial class officerForm : Form
    {

        SqlConnection con = new SqlConnection("Data Source =LOCALHOST\\SQLEXPRESS; Initial Catalog = officerDB; Integrated Security = True");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public officerForm()
        {
            InitializeComponent();
            DisplayData();
        }


        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            if (fNameTextBox.Text != "" && lNameTxtBox.Text != "") 
            {
                cmd = new SqlCommand("insert into officers (Lastname, FirstName) VALUES (@lastname,@firstname) ", con);
                con.Open();
                cmd.Parameters.AddWithValue("@lastname", lNameTxtBox.Text);
                cmd.Parameters.AddWithValue("@firstname", fNameTextBox.Text);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Successfully added officer.");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Unsuccessfully added Officer. Did you fill in both first and lastname?");
            }

        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select FirstName, Lastname from officers", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        //clear data
        private void ClearData()
        {
            fNameTextBox.Text = "";
            lNameTxtBox.Text = "";
        }

        private void officerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'officerDBDataSet.officers' table. You can move, or remove it, as needed.
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
