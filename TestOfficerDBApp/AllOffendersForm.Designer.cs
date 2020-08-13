namespace TestOfficerDBApp
{
    partial class AllOffendersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllOffendersForm));
            this.label1 = new System.Windows.Forms.Label();
            this.offendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officerDBDataSet1 = new TestOfficerDBApp.officerDBDataSet1();
            this.offendersTableAdapter = new TestOfficerDBApp.officerDBDataSet1TableAdapters.offendersTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.genderbox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.offenderbox = new System.Windows.Forms.PictureBox();
            this.notestxtbox = new System.Windows.Forms.TextBox();
            this.oltxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lNameTextbox = new System.Windows.Forms.TextBox();
            this.fNametxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.offendersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offenderbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Offender:";
            // 
            // offendersBindingSource
            // 
            this.offendersBindingSource.DataMember = "offenders";
            this.offendersBindingSource.DataSource = this.officerDBDataSet1;
            // 
            // officerDBDataSet1
            // 
            this.officerDBDataSet1.DataSetName = "officerDBDataSet1";
            this.officerDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // offendersTableAdapter
            // 
            this.offendersTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(408, 485);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(104, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genderbox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.offenderbox);
            this.groupBox1.Controls.Add(this.notestxtbox);
            this.groupBox1.Controls.Add(this.oltxtbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lNameTextbox);
            this.groupBox1.Controls.Add(this.fNametxtbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(426, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 522);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Offender";
            // 
            // genderbox1
            // 
            this.genderbox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.genderbox1.FormattingEnabled = true;
            this.genderbox1.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Unknown",
            "Other"});
            this.genderbox1.Location = new System.Drawing.Point(139, 243);
            this.genderbox1.Name = "genderbox1";
            this.genderbox1.Size = new System.Drawing.Size(354, 21);
            this.genderbox1.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Garamond", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(24, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 18);
            this.label8.TabIndex = 33;
            this.label8.Text = "Gender:";
            // 
            // btnEdit
            // 
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Location = new System.Drawing.Point(139, 477);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(354, 35);
            this.btnEdit.TabIndex = 32;
            this.btnEdit.Text = "Edit Offender";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Photo";
            // 
            // offenderbox
            // 
            this.offenderbox.Location = new System.Drawing.Point(186, 23);
            this.offenderbox.Name = "offenderbox";
            this.offenderbox.Size = new System.Drawing.Size(260, 121);
            this.offenderbox.TabIndex = 30;
            this.offenderbox.TabStop = false;
            // 
            // notestxtbox
            // 
            this.notestxtbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.notestxtbox.Location = new System.Drawing.Point(139, 306);
            this.notestxtbox.Multiline = true;
            this.notestxtbox.Name = "notestxtbox";
            this.notestxtbox.Size = new System.Drawing.Size(354, 147);
            this.notestxtbox.TabIndex = 29;
            // 
            // oltxtbox
            // 
            this.oltxtbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.oltxtbox.Location = new System.Drawing.Point(139, 275);
            this.oltxtbox.Name = "oltxtbox";
            this.oltxtbox.Size = new System.Drawing.Size(354, 20);
            this.oltxtbox.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(24, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Notes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(24, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "OL:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 212);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(354, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(24, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "DOB:";
            // 
            // lNameTextbox
            // 
            this.lNameTextbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lNameTextbox.Location = new System.Drawing.Point(139, 181);
            this.lNameTextbox.Name = "lNameTextbox";
            this.lNameTextbox.Size = new System.Drawing.Size(354, 20);
            this.lNameTextbox.TabIndex = 23;
            // 
            // fNametxtbox
            // 
            this.fNametxtbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.fNametxtbox.Location = new System.Drawing.Point(139, 150);
            this.fNametxtbox.Name = "fNametxtbox";
            this.fNametxtbox.Size = new System.Drawing.Size(354, 20);
            this.fNametxtbox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(24, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Garamond", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(24, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "First Name:";
            // 
            // AllOffendersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(1009, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllOffendersForm";
            this.Opacity = 0.95D;
            this.Text = "AllOffendersForm";
            this.Load += new System.EventHandler(this.AllOffendersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.offendersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offenderbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private officerDBDataSet1 officerDBDataSet1;
        private System.Windows.Forms.BindingSource offendersBindingSource;
        private officerDBDataSet1TableAdapters.offendersTableAdapter offendersTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox notestxtbox;
        private System.Windows.Forms.TextBox oltxtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lNameTextbox;
        private System.Windows.Forms.TextBox fNametxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox offenderbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox genderbox1;
    }
}