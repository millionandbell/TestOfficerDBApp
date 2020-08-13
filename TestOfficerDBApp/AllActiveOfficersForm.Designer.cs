namespace TestOfficerDBApp
{
    partial class AllActiveOfficersForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.officerDBDataSet = new TestOfficerDBApp.officerDBDataSet();
            this.officerDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officersTableAdapter = new TestOfficerDBApp.officerDBDataSetTableAdapters.officersTableAdapter();
            this.officerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Active Officers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.officerIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.officersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(342, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // officerDBDataSet
            // 
            this.officerDBDataSet.DataSetName = "officerDBDataSet";
            this.officerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // officerDBDataSetBindingSource
            // 
            this.officerDBDataSetBindingSource.DataSource = this.officerDBDataSet;
            this.officerDBDataSetBindingSource.Position = 0;
            // 
            // officersBindingSource
            // 
            this.officersBindingSource.DataMember = "officers";
            this.officersBindingSource.DataSource = this.officerDBDataSetBindingSource;
            // 
            // officersTableAdapter
            // 
            this.officersTableAdapter.ClearBeforeFill = true;
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
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AllActiveOfficersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "AllActiveOfficersForm";
            this.Text = "AllActiveOfficersForm";
            this.Load += new System.EventHandler(this.AllActiveOfficersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource officerDBDataSetBindingSource;
        private officerDBDataSet officerDBDataSet;
        private System.Windows.Forms.BindingSource officersBindingSource;
        private officerDBDataSetTableAdapters.officersTableAdapter officersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn officerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
    }
}