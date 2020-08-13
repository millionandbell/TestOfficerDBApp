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
    public partial class offenderForm : Form
    {
        //Create initial connection to DB

        SqlConnection con = new SqlConnection("Data Source =LOCALHOST\\SQLEXPRESS; Initial Catalog = officerDB; Integrated Security = True");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public offenderForm()
        {
            InitializeComponent();
            DisplayData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            if (fNametxtbox.Text != "" && lNameTextbox.Text != "")
            {
                cmd = new SqlCommand("insert into offenders (Lastname, Firstname, Gender, DOB, Notes, Photo, OperatorsLicense) VALUES (@lastname,@firstname, @gender, @dob, @notes, @photos, @operatorslicense) ", con);
                con.Open();
                cmd.Parameters.AddWithValue("@lastname", lNameTextbox.Text);
                cmd.Parameters.AddWithValue("@firstname", fNametxtbox.Text);
                cmd.Parameters.AddWithValue("@gender", genderbox1.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@notes", notestxtbox.Text);
                cmd.Parameters.AddWithValue("@photos", new ImageConverter().ConvertTo(offenderpicbox.Image, typeof(Byte[])));
                cmd.Parameters.AddWithValue("@operatorslicense", OLtxtbox.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully added offender.");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Unsuccessfully added Officer. Did you fill all data?");
            }
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select FirstName, Lastname,dob from offenders", con);
            adapt.Fill(dt);
           // dataGridView1.DataSource = dt;
            con.Close();

        }

        private void ClearData()
        {
            fNametxtbox.Text = "";
            lNameTextbox.Text = "";
            

        }

        private void submitBTN_Click_1(object sender, EventArgs e)
        {
            if (fNametxtbox.Text != "" && lNameTextbox.Text != "")
            {
                cmd = new SqlCommand("insert into offenders (Lastname, Firstname, Gender, DOB, Notes, Photo, OperatorsLicense) VALUES (@lastname,@firstname, @gender, @dob, @notes, @photos, @operatorslicense) ", con);
                con.Open();
                cmd.Parameters.AddWithValue("@lastname", lNameTextbox.Text);
                cmd.Parameters.AddWithValue("@firstname", fNametxtbox.Text);
                cmd.Parameters.AddWithValue("@gender", genderbox1.Text );
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@notes", notestxtbox.Text);
                cmd.Parameters.AddWithValue("@photos", new ImageConverter().ConvertTo(offenderpicbox.Image, typeof(Byte[])));
                cmd.Parameters.AddWithValue("@operatorslicense", OLtxtbox.Text);

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Successfully added offender.");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Unsuccessfully added Offender. Did you fill all data?");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void offenderForm_Load(object sender, EventArgs e)
        {

        }

        private void fNametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btbBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Support Images |*.jpg;*.jpeg;*.png";
            if(OD.ShowDialog() == DialogResult.OK)
            {
                offenderpicbox.Load(OD.FileName);
            }
        }
    }
}
