namespace TestOfficerDBApp
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewIncidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewOffenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewOfficerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allIncidentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byOffenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byIncidentTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officerReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allActiveOfficersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offenderReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allOffendersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timeLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GrayText;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.helpToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(130, 534);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewIncidentToolStripMenuItem,
            this.addNewOffenderToolStripMenuItem,
            this.addNewOfficerToolStripMenuItem});
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(117, 41);
            this.fileToolStripMenuItem.Text = "Add Entry";
            // 
            // addNewIncidentToolStripMenuItem
            // 
            this.addNewIncidentToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addNewIncidentToolStripMenuItem.Name = "addNewIncidentToolStripMenuItem";
            this.addNewIncidentToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.addNewIncidentToolStripMenuItem.Text = "Add New incident";
            this.addNewIncidentToolStripMenuItem.Click += new System.EventHandler(this.addNewIncidentToolStripMenuItem_Click);
            // 
            // addNewOffenderToolStripMenuItem
            // 
            this.addNewOffenderToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addNewOffenderToolStripMenuItem.Name = "addNewOffenderToolStripMenuItem";
            this.addNewOffenderToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.addNewOffenderToolStripMenuItem.Text = "Add New Offender";
            this.addNewOffenderToolStripMenuItem.Click += new System.EventHandler(this.addNewOffenderToolStripMenuItem_Click);
            // 
            // addNewOfficerToolStripMenuItem
            // 
            this.addNewOfficerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addNewOfficerToolStripMenuItem.Name = "addNewOfficerToolStripMenuItem";
            this.addNewOfficerToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.addNewOfficerToolStripMenuItem.Text = "Add New Officer";
            this.addNewOfficerToolStripMenuItem.Click += new System.EventHandler(this.addNewOfficerToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allIncidentsToolStripMenuItem,
            this.officerReportsToolStripMenuItem,
            this.offenderReportsToolStripMenuItem});
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8);
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(117, 41);
            this.aboutToolStripMenuItem.Text = "Reports";
            this.aboutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // allIncidentsToolStripMenuItem
            // 
            this.allIncidentsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.allIncidentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byOffenderToolStripMenuItem,
            this.byIncidentTypeToolStripMenuItem,
            this.byDateToolStripMenuItem});
            this.allIncidentsToolStripMenuItem.Name = "allIncidentsToolStripMenuItem";
            this.allIncidentsToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.allIncidentsToolStripMenuItem.Text = "Incident Reports";
            this.allIncidentsToolStripMenuItem.Click += new System.EventHandler(this.allIncidentsToolStripMenuItem_Click);
            // 
            // byOffenderToolStripMenuItem
            // 
            this.byOffenderToolStripMenuItem.Name = "byOffenderToolStripMenuItem";
            this.byOffenderToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.byOffenderToolStripMenuItem.Text = "By Offender";
            this.byOffenderToolStripMenuItem.Click += new System.EventHandler(this.byOffenderToolStripMenuItem_Click);
            // 
            // byIncidentTypeToolStripMenuItem
            // 
            this.byIncidentTypeToolStripMenuItem.Name = "byIncidentTypeToolStripMenuItem";
            this.byIncidentTypeToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.byIncidentTypeToolStripMenuItem.Text = "By Incident type";
            this.byIncidentTypeToolStripMenuItem.Click += new System.EventHandler(this.byIncidentTypeToolStripMenuItem_Click);
            // 
            // byDateToolStripMenuItem
            // 
            this.byDateToolStripMenuItem.Name = "byDateToolStripMenuItem";
            this.byDateToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.byDateToolStripMenuItem.Text = "By Date";
            // 
            // officerReportsToolStripMenuItem
            // 
            this.officerReportsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.officerReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allActiveOfficersToolStripMenuItem});
            this.officerReportsToolStripMenuItem.Name = "officerReportsToolStripMenuItem";
            this.officerReportsToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.officerReportsToolStripMenuItem.Text = "Officer Reports";
            // 
            // allActiveOfficersToolStripMenuItem
            // 
            this.allActiveOfficersToolStripMenuItem.Name = "allActiveOfficersToolStripMenuItem";
            this.allActiveOfficersToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.allActiveOfficersToolStripMenuItem.Text = "All Active Officers";
            this.allActiveOfficersToolStripMenuItem.Click += new System.EventHandler(this.allActiveOfficersToolStripMenuItem_Click);
            // 
            // offenderReportsToolStripMenuItem
            // 
            this.offenderReportsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.offenderReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allOffendersToolStripMenuItem});
            this.offenderReportsToolStripMenuItem.Name = "offenderReportsToolStripMenuItem";
            this.offenderReportsToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.offenderReportsToolStripMenuItem.Text = "Offender Reports";
            // 
            // allOffendersToolStripMenuItem
            // 
            this.allOffendersToolStripMenuItem.Name = "allOffendersToolStripMenuItem";
            this.allOffendersToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.allOffendersToolStripMenuItem.Text = "All Offenders";
            this.allOffendersToolStripMenuItem.Click += new System.EventHandler(this.allOffendersToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8);
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(117, 41);
            this.helpToolStripMenuItem.Text = "About";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem1.Image")));
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(8);
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(117, 41);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem1.Image")));
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(8);
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(117, 41);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeLabel.Location = new System.Drawing.Point(133, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(208, 27);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "Current Date/Time";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.timeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(771, 472);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(226, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(872, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 101);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 49;
            this.pictureBox3.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1009, 534);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Garamond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security Database Dashboard";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewIncidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewOffenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewOfficerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allIncidentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byOffenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byIncidentTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem officerReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allActiveOfficersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offenderReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allOffendersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

