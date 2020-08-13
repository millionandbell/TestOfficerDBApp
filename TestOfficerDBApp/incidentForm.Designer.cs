namespace TestOfficerDBApp
{
    partial class incidentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.submitBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.officerDBDataSet1 = new TestOfficerDBApp.officerDBDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.officerDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officersTableAdapter = new TestOfficerDBApp.officerDBDataSetTableAdapters.officersTableAdapter();
            this.officerDBDataSet11 = new TestOfficerDBApp.officerDBDataSet1();
            this.offendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.offendersTableAdapter = new TestOfficerDBApp.officerDBDataSet1TableAdapters.offendersTableAdapter();
            this.officerDBDataSet2 = new TestOfficerDBApp.officerDBDataSet2();
            this.offendersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.offendersTableAdapter1 = new TestOfficerDBApp.officerDBDataSet2TableAdapters.offendersTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.officersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offendersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offendersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Incident Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Offender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Officer";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.richTextBox1.Location = new System.Drawing.Point(15, 114);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(773, 324);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Incident Type";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // submitBTN
            // 
            this.submitBTN.Location = new System.Drawing.Point(691, 13);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(75, 23);
            this.submitBTN.TabIndex = 18;
            this.submitBTN.Text = "Submit";
            this.submitBTN.UseVisualStyleBackColor = true;
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(691, 49);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(75, 23);
            this.exitBTN.TabIndex = 19;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // officerDBDataSet1
            // 
            this.officerDBDataSet1.DataSetName = "officerDBDataSet";
            this.officerDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.officersBindingSource;
            this.comboBox1.DisplayMember = "LastName";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(66, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.ValueMember = "LastName";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // officerDBDataSet1BindingSource
            // 
            this.officerDBDataSet1BindingSource.DataSource = this.officerDBDataSet1;
            this.officerDBDataSet1BindingSource.Position = 0;
            // 
            // officersBindingSource
            // 
            this.officersBindingSource.DataMember = "officers";
            this.officersBindingSource.DataSource = this.officerDBDataSet1BindingSource;
            // 
            // officersTableAdapter
            // 
            this.officersTableAdapter.ClearBeforeFill = true;
            // 
            // officerDBDataSet11
            // 
            this.officerDBDataSet11.DataSetName = "officerDBDataSet1";
            this.officerDBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // offendersBindingSource
            // 
            this.offendersBindingSource.DataMember = "offenders";
            this.offendersBindingSource.DataSource = this.officerDBDataSet11;
            // 
            // offendersTableAdapter
            // 
            this.offendersTableAdapter.ClearBeforeFill = true;
            // 
            // officerDBDataSet2
            // 
            this.officerDBDataSet2.DataSetName = "officerDBDataSet2";
            this.officerDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // offendersBindingSource1
            // 
            this.offendersBindingSource1.DataMember = "offenders";
            this.offendersBindingSource1.DataSource = this.officerDBDataSet2;
            // 
            // offendersTableAdapter1
            // 
            this.offendersTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.officersBindingSource1;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(67, 40);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(203, 21);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBox2_Format);
            // 
            // officersBindingSource1
            // 
            this.officersBindingSource1.DataMember = "officers";
            this.officersBindingSource1.DataSource = this.officerDBDataSet1BindingSource;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fix drop down menu so it shows Lastname, firstname DOB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Add incident types in SQL and add dropdown menu here";
            // 
            // incidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.submitBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "incidentForm";
            this.RightToLeftLayout = true;
            this.Text = "Add Incident Form";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offendersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offendersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button submitBTN;
        private System.Windows.Forms.Button exitBTN;
        private officerDBDataSet officerDBDataSet1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource officerDBDataSet1BindingSource;
        private System.Windows.Forms.BindingSource officersBindingSource;
        private officerDBDataSetTableAdapters.officersTableAdapter officersTableAdapter;
        private officerDBDataSet1 officerDBDataSet11;
        private System.Windows.Forms.BindingSource offendersBindingSource;
        private officerDBDataSet1TableAdapters.offendersTableAdapter offendersTableAdapter;
        private officerDBDataSet2 officerDBDataSet2;
        private System.Windows.Forms.BindingSource offendersBindingSource1;
        private officerDBDataSet2TableAdapters.offendersTableAdapter offendersTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource officersBindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}