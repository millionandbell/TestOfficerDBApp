using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace TestOfficerDBApp
{
    public partial class AllOffendersForm : Form
    {
        public AllOffendersForm()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection("Data Source =LOCALHOST\\SQLEXPRESS; Initial Catalog = officerDB; Integrated Security = True");
        private List<Offenders> offenders = new List<Offenders>();

        private void updateList(string search = " ")
        {
            con.Open();
            SqlCommand command = con.CreateCommand();
            SqlParameter sqlParameter = command.Parameters.AddWithValue("@search", search + "%");
            command.CommandText = //"Select offenderID, ISNULL(firstname, 0), ISNULL(lastname,0), ISNULL(gender, 0) , ISNULL(notes,'test'), ISNULL(photo), + ISNULL(operatorslicense, 0) " +
                "select * FROM Offenders Where firstname like @search or lastname like @search or dob like @search or CONCAT(firstname, ' ', lastname) like @search";

            SqlDataReader reader = command.ExecuteReader();

            offenders.Clear();
            listBox1.Items.Clear();
            // this is broken here, for some reason it errors this: System.InvalidCastException: 'Unable to cast object of type 'System.DateTime' to type 'System.String'.'
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string firstname = reader.GetString(1);
                string lastname = reader.GetString(2);
                //string gender = reader.GetString(3);
                //var dob = reader.GetInt32(4);
                string notes = reader.GetString(3);
                Image photo = Image.FromStream(new MemoryStream(reader.GetSqlBytes(4).Buffer));
                string operatorslicense = reader.GetString(5);
                offenders.Add(new Offenders(id, firstname, lastname, notes, photo, operatorslicense));
                listBox1.Items.Add(firstname + " " + lastname);
            }

            con.Close();
            {
                // TODO: This line of code loads data into the 'officerDBDataSet1.offenders' table. You can move, or remove it, as needed.
                this.offendersTableAdapter.Fill(this.officerDBDataSet1.offenders);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            updateList(textBox1.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fNametxtbox.Text = offenders[listBox1.SelectedIndex].firstname;
            lNameTextbox.Text = offenders[listBox1.SelectedIndex].lastname;
            notestxtbox.Text = offenders[listBox1.SelectedIndex].notes;
            offenderbox.Image = offenders[listBox1.SelectedIndex].photo;
          
        }

        private void AllOffendersForm_Load(object sender, EventArgs e)
        {
            updateList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditOffender edit = new EditOffender(offenders[listBox1.SelectedIndex]);
            Hide();
            edit.ShowDialog();
            Show();
        }
    } 
}

