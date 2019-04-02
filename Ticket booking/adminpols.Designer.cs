namespace Ticket_booking
{
    partial class adminpols
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminpols));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdDataSet = new Ticket_booking.bdDataSet();
            this.PasswordID_txt = new MetroFramework.Controls.MetroTextBox();
            this.tblCustomersTableAdapter = new Ticket_booking.bdDataSetTableAdapters.tblCustomersTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.telNumberDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblCustomersBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(37, 90);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(788, 313);
            this.dataGridView2.TabIndex = 27;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // telNumberDataGridViewTextBoxColumn
            // 
            this.telNumberDataGridViewTextBoxColumn.DataPropertyName = "TelNumber";
            this.telNumberDataGridViewTextBoxColumn.HeaderText = "TelNumber";
            this.telNumberDataGridViewTextBoxColumn.Name = "telNumberDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // tblCustomersBindingSource
            // 
            this.tblCustomersBindingSource.DataMember = "tblCustomers";
            this.tblCustomersBindingSource.DataSource = this.bdDataSet;
            // 
            // bdDataSet
            // 
            this.bdDataSet.DataSetName = "bdDataSet";
            this.bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PasswordID_txt
            // 
            this.PasswordID_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            // 
            // 
            // 
            this.PasswordID_txt.CustomButton.Image = null;
            this.PasswordID_txt.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.PasswordID_txt.CustomButton.Name = "";
            this.PasswordID_txt.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.PasswordID_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordID_txt.CustomButton.TabIndex = 1;
            this.PasswordID_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordID_txt.CustomButton.UseSelectable = true;
            this.PasswordID_txt.CustomButton.Visible = false;
            this.PasswordID_txt.DisplayIcon = true;
            this.PasswordID_txt.ForeColor = System.Drawing.Color.DimGray;
            this.PasswordID_txt.Icon = ((System.Drawing.Image)(resources.GetObject("PasswordID_txt.Icon")));
            this.PasswordID_txt.Lines = new string[0];
            this.PasswordID_txt.Location = new System.Drawing.Point(400, 409);
            this.PasswordID_txt.MaxLength = 32767;
            this.PasswordID_txt.Name = "PasswordID_txt";
            this.PasswordID_txt.PasswordChar = '\0';
            this.PasswordID_txt.PromptText = "Enter your id : is ?";
            this.PasswordID_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordID_txt.SelectedText = "";
            this.PasswordID_txt.SelectionLength = 0;
            this.PasswordID_txt.SelectionStart = 0;
            this.PasswordID_txt.ShortcutsEnabled = true;
            this.PasswordID_txt.ShowClearButton = true;
            this.PasswordID_txt.Size = new System.Drawing.Size(289, 57);
            this.PasswordID_txt.Style = MetroFramework.MetroColorStyle.Silver;
            this.PasswordID_txt.TabIndex = 28;
            this.PasswordID_txt.UseSelectable = true;
            this.PasswordID_txt.WaterMark = "Enter your id : is ?";
            this.PasswordID_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordID_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tblCustomersTableAdapter
            // 
            this.tblCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label2.Location = new System.Drawing.Point(102, 417);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label2.Size = new System.Drawing.Size(283, 49);
            this.label2.TabIndex = 29;
            this.label2.Text = "Всего пользователей";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminpols
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 486);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordID_txt);
            this.Controls.Add(this.dataGridView2);
            this.Name = "adminpols";
            this.Text = "Пользователи";
            this.Load += new System.EventHandler(this.adminpols_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private MetroFramework.Controls.MetroTextBox PasswordID_txt;
        private bdDataSet bdDataSet;
        private System.Windows.Forms.BindingSource tblCustomersBindingSource;
        private bdDataSetTableAdapters.tblCustomersTableAdapter tblCustomersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}