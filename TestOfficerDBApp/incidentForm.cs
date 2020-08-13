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
    public partial class incidentForm : Form
    {

        // create connection
        SqlConnection con = new SqlConnection("Data Source =LOCALHOST\\SQLEXPRESS; Initial Catalog = officerDB; Integrated Security = True");

        public incidentForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'officerDBDataSet2.offenders' table. You can move, or remove it, as needed.
            this.offendersTableAdapter1.Fill(this.officerDBDataSet2.offenders);
            // TODO: This line of code loads data into the 'officerDBDataSet11.offenders' table. You can move, or remove it, as needed.
            this.offendersTableAdapter.Fill(this.officerDBDataSet11.offenders);
            // TODO: This line of code loads data into the 'officerDBDataSet1.officers' table. You can move, or remove it, as needed.
            this.officersTableAdapter.Fill(this.officerDBDataSet1.officers);

        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.offendersTableAdapter.Fill(this.officerDBDataSet11.offenders);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_Format(object sender, ListControlConvertEventArgs e)
        {

        }
    }
}
