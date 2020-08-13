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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            officerForm frm2 = new officerForm();
            frm2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            incidentForm frm4 = new incidentForm();
            frm4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            offenderForm frm3 = new offenderForm();
            frm3.Show();
        }

        private void addNewIncidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            incidentForm frm4 = new incidentForm();
            frm4.Show();
        }

        private void addNewOffenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            offenderForm frm3 = new offenderForm();
            frm3.Show();
        }

        private void addNewOfficerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            officerForm frm2 = new officerForm();
            frm2.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void allIncidentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an app built to help organize the department by Officer McMillion on 8/10/2020, " +
                "with it you can search for patients that come in and " +
                "see if they have a known history, you can see who dealt with the patient and different things of that nature." +
                "It is my hope that this program helps. ");
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To get help, email jmcmillion@wyandotmemorial.org. Include what you are doing and what errors come up." +
                "if the database won't allow you to enter information, forward that information to the same email and we will get it entered." +
                " Thank you");
        }

        private void byOffenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imagine a world where the offender query was running," +
                              " keep thinking about it until i get it running. :)");
        }

        private void allActiveOfficersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllActiveOfficersForm qry1 = new AllActiveOfficersForm();
            qry1.Show();
        }

        private void allOffendersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllOffendersForm qry2 = new AllOffendersForm();
            qry2.Show();
        }

        private void byIncidentTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imagine a world where the offender by incident query was running, " +
                              " keep thinking about it until i get it running. :)");
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("M/d/yyyy HH:mm");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString();
        }
    }
    }

