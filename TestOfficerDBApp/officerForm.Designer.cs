namespace TestOfficerDBApp
{
    partial class officerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.lNameTxtBox = new System.Windows.Forms.TextBox();
            this.exitBTN = new System.Windows.Forms.Button();
            this.submitBTN = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.officerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officerDBDataSet = new TestOfficerDBApp.officerDBDataSet();
            this.officersTableAdapter = new TestOfficerDBApp.officerDBDataSetTableAdapters.officersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.Location = new System.Drawing.Point(113, 18);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(204, 20);
            this.fNameTextBox.TabIndex = 2;
            // 
            // lNameTxtBox
            // 
            this.lNameTxtBox.Location = new System.Drawing.Point(113, 59);
            this.lNameTxtBox.Name = "lNameTxtBox";
            this.lNameTxtBox.Size = new System.Drawing.Size(204, 20);
            this.lNameTxtBox.TabIndex = 3;
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(242, 187);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(75, 23);
            this.exitBTN.TabIndex = 4;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // submitBTN
            // 
            this.submitBTN.Location = new System.Drawing.Point(39, 187);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(75, 23);
            this.submitBTN.TabIndex = 5;
            this.submitBTN.Text = "Submit";
            this.submitBTN.UseVisualStyleBackColor = true;
            this.submitBTN.Click += new System.EventHandler(this.submitBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.officerIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.officersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(429, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 192);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // officerIDDataGridViewTextBoxColumn
            // 
            this.officerIDDataGridViewTextBoxColumn.DataPropertyName = "officerID";
            this.officerIDDataGridViewTextBoxColumn.HeaderText = "officerID";
            this.officerIDDataGridViewTextBoxColumn.Name = "officerIDDataGridViewTextBoxColumn";
            this.officerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // officersBindingSource
            // 
            this.officersBindingSource.DataMember = "officers";
            this.officersBindingSource.DataSource = this.officerDBDataSet;
            // 
            // officerDBDataSet
            // 
            this.officerDBDataSet.DataSetName = "officerDBDataSet";
            this.officerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // officersTableAdapter
            // 
            this.officersTableAdapter.ClearBeforeFill = true;
            // 
            // officerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(864, 355);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.submitBTN);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.lNameTxtBox);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "officerForm";
            this.Text = "Add Officer Form";
            this.Load += new System.EventHandler(this.officerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox lNameTxtBox;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Button submitBTN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private officerDBDataSet officerDBDataSet;
        private System.Windows.Forms.BindingSource officersBindingSource;
        private officerDBDataSetTableAdapters.officersTableAdapter officersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn officerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
    }
}