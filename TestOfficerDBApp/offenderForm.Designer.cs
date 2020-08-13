namespace TestOfficerDBApp
{
    partial class offenderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(offenderForm));
            this.lNameTextbox = new System.Windows.Forms.TextBox();
            this.fNametxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submitBTN = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.offenderpicbox = new System.Windows.Forms.PictureBox();
            this.OLtxtbox = new System.Windows.Forms.TextBox();
            this.notestxtbox = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.genderbox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.offenderpicbox)).BeginInit();
            this.SuspendLayout();
            // 
            // lNameTextbox
            // 
            this.lNameTextbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lNameTextbox.Location = new System.Drawing.Point(223, 83);
            this.lNameTextbox.Name = "lNameTextbox";
            this.lNameTextbox.Size = new System.Drawing.Size(204, 20);
            this.lNameTextbox.TabIndex = 7;
            this.lNameTextbox.TextChanged += new System.EventHandler(this.lNameTextbox_TextChanged);
            // 
            // fNametxtbox
            // 
            this.fNametxtbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.fNametxtbox.Location = new System.Drawing.Point(223, 36);
            this.fNametxtbox.Name = "fNametxtbox";
            this.fNametxtbox.Size = new System.Drawing.Size(204, 20);
            this.fNametxtbox.TabIndex = 6;
            this.fNametxtbox.TextChanged += new System.EventHandler(this.fNametxtbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 18F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "DOB:";
            // 
            // submitBTN
            // 
            this.submitBTN.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBTN.Image = ((System.Drawing.Image)(resources.GetObject("submitBTN.Image")));
            this.submitBTN.Location = new System.Drawing.Point(268, 389);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(115, 47);
            this.submitBTN.TabIndex = 10;
            this.submitBTN.Text = "Add Entry";
            this.submitBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.submitBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.submitBTN.UseVisualStyleBackColor = true;
            this.submitBTN.Click += new System.EventHandler(this.submitBTN_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(223, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 18F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 27);
            this.label4.TabIndex = 15;
            this.label4.Text = "Operators License";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 18F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 27);
            this.label5.TabIndex = 16;
            this.label5.Text = "Notes";
            // 
            // offenderpicbox
            // 
            this.offenderpicbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.offenderpicbox.InitialImage = ((System.Drawing.Image)(resources.GetObject("offenderpicbox.InitialImage")));
            this.offenderpicbox.Location = new System.Drawing.Point(625, 29);
            this.offenderpicbox.Name = "offenderpicbox";
            this.offenderpicbox.Size = new System.Drawing.Size(372, 305);
            this.offenderpicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.offenderpicbox.TabIndex = 17;
            this.offenderpicbox.TabStop = false;
            // 
            // OLtxtbox
            // 
            this.OLtxtbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.OLtxtbox.Location = new System.Drawing.Point(223, 225);
            this.OLtxtbox.Name = "OLtxtbox";
            this.OLtxtbox.Size = new System.Drawing.Size(204, 20);
            this.OLtxtbox.TabIndex = 18;
            this.OLtxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // notestxtbox
            // 
            this.notestxtbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.notestxtbox.Location = new System.Drawing.Point(223, 272);
            this.notestxtbox.Multiline = true;
            this.notestxtbox.Name = "notestxtbox";
            this.notestxtbox.Size = new System.Drawing.Size(204, 110);
            this.notestxtbox.TabIndex = 19;
            this.notestxtbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(748, 340);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(115, 47);
            this.btnBrowse.TabIndex = 20;
            this.btnBrowse.Text = "Browse..";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btbBrowse_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(792, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Photo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Garamond", 18F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(27, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 27);
            this.label7.TabIndex = 22;
            this.label7.Text = "Gender";
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
            this.genderbox1.Location = new System.Drawing.Point(223, 130);
            this.genderbox1.Name = "genderbox1";
            this.genderbox1.Size = new System.Drawing.Size(204, 21);
            this.genderbox1.TabIndex = 35;
            // 
            // offenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1009, 534);
            this.Controls.Add(this.genderbox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.notestxtbox);
            this.Controls.Add(this.OLtxtbox);
            this.Controls.Add(this.offenderpicbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.submitBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lNameTextbox);
            this.Controls.Add(this.fNametxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "offenderForm";
            this.Text = "Add Offender Form";
            this.Load += new System.EventHandler(this.offenderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.offenderpicbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lNameTextbox;
        private System.Windows.Forms.TextBox fNametxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitBTN;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox offenderpicbox;
        private System.Windows.Forms.TextBox OLtxtbox;
        private System.Windows.Forms.TextBox notestxtbox;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox genderbox1;
    }
}