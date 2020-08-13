using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOfficerDBApp
{
    public partial class AllActiveOfficersForm : Form
    {
        public AllActiveOfficersForm()
        {
            InitializeComponent();
        }

        private void AllActiveOfficersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'officerDBDataSet.officers' table. You can move, or remove it, as needed.
            this.officersTableAdapter.Fill(this.officerDBDataSet.officers);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.officersTableAdapter.Fill(this.officerDBDataSet.officers);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
