namespace Ticket_booking
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdDataSet1 = new Ticket_booking.bdDataSet();
            this.tblCustomersTableAdapter = new Ticket_booking.bdDataSetTableAdapters.tblCustomersTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Password_txt = new MetroFramework.Controls.MetroTextBox();
            this.Name1_txt = new MetroFramework.Controls.MetroTextBox();
            this.Phone_txt = new MetroFramework.Controls.MetroTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.PasswordID_txt = new MetroFramework.Controls.MetroTextBox();
            this.Name_txt = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviesTableAdapter1 = new Ticket_booking.bdDataSetTableAdapters.MoviesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label2.Location = new System.Drawing.Point(126, 191);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.label2.Size = new System.Drawing.Size(237, 82);
            this.label2.TabIndex = 18;
            this.label2.Text = "Check in";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.telNumberDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCustomersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(484, 325);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 26;
            // 
            // tblCustomersBindingSource
            // 
            this.tblCustomersBindingSource.DataMember = "tblCustomers";
            this.tblCustomersBindingSource.DataSource = this.bdDataSet1;
            // 
            // bdDataSet1
            // 
            this.bdDataSet1.DataSetName = "bdDataSet1";
            this.bdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCustomersTableAdapter
            // 
            this.tblCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Violet;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(553, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 38);
            this.label3.TabIndex = 28;
            this.label3.Text = "         Перейти к \r\nбронированию билетов";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton1.BackgroundImage")));
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton1.Location = new System.Drawing.Point(521, 440);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(221, 100);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButton1.TabIndex = 27;
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Violet;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(517, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 38);
            this.label1.TabIndex = 25;
            this.label1.Text = "  Последнее занятое ID   ⬇\r\n(Введите следующий № п/п) ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 68);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Password_txt
            // 
            this.Password_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            // 
            // 
            // 
            this.Password_txt.CustomButton.Image = null;
            this.Password_txt.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.Password_txt.CustomButton.Name = "";
            this.Password_txt.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.Password_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Password_txt.CustomButton.TabIndex = 1;
            this.Password_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Password_txt.CustomButton.UseSelectable = true;
            this.Password_txt.CustomButton.Visible = false;
            this.Password_txt.DisplayIcon = true;
            this.Password_txt.ForeColor = System.Drawing.Color.DimGray;
            this.Password_txt.Icon = ((System.Drawing.Image)(resources.GetObject("Password_txt.Icon")));
            this.Password_txt.Lines = new string[0];
            this.Password_txt.Location = new System.Drawing.Point(484, 341);
            this.Password_txt.MaxLength = 32767;
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.PasswordChar = '*';
            this.Password_txt.PromptText = "Enter your new password";
            this.Password_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Password_txt.SelectedText = "";
            this.Password_txt.SelectionLength = 0;
            this.Password_txt.SelectionStart = 0;
            this.Password_txt.ShortcutsEnabled = true;
            this.Password_txt.ShowClearButton = true;
            this.Password_txt.Size = new System.Drawing.Size(289, 57);
            this.Password_txt.Style = MetroFramework.MetroColorStyle.Silver;
            this.Password_txt.TabIndex = 22;
            this.Password_txt.UseSelectable = true;
            this.Password_txt.WaterMark = "Enter your new password";
            this.Password_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Password_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Name1_txt
            // 
            this.Name1_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            // 
            // 
            // 
            this.Name1_txt.CustomButton.Image = null;
            this.Name1_txt.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.Name1_txt.CustomButton.Name = "";
            this.Name1_txt.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.Name1_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Name1_txt.CustomButton.TabIndex = 1;
            this.Name1_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Name1_txt.CustomButton.UseSelectable = true;
            this.Name1_txt.CustomButton.Visible = false;
            this.Name1_txt.DisplayIcon = true;
            this.Name1_txt.ForeColor = System.Drawing.Color.DimGray;
            this.Name1_txt.Icon = ((System.Drawing.Image)(resources.GetObject("Name1_txt.Icon")));
            this.Name1_txt.Lines = new string[0];
            this.Name1_txt.Location = new System.Drawing.Point(484, 215);
            this.Name1_txt.MaxLength = 32767;
            this.Name1_txt.Name = "Name1_txt";
            this.Name1_txt.PasswordChar = '\0';
            this.Name1_txt.PromptText = "Enter your last name";
            this.Name1_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Name1_txt.SelectedText = "";
            this.Name1_txt.SelectionLength = 0;
            this.Name1_txt.SelectionStart = 0;
            this.Name1_txt.ShortcutsEnabled = false;
            this.Name1_txt.ShowClearButton = true;
            this.Name1_txt.Size = new System.Drawing.Size(289, 57);
            this.Name1_txt.Style = MetroFramework.MetroColorStyle.Silver;
            this.Name1_txt.TabIndex = 21;
            this.Name1_txt.UseSelectable = true;
            this.Name1_txt.WaterMark = "Enter your last name";
            this.Name1_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Name1_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Phone_txt
            // 
            this.Phone_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            // 
            // 
            // 
            this.Phone_txt.CustomButton.Image = null;
            this.Phone_txt.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.Phone_txt.CustomButton.Name = "";
            this.Phone_txt.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.Phone_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Phone_txt.CustomButton.TabIndex = 1;
            this.Phone_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Phone_txt.CustomButton.UseSelectable = true;
            this.Phone_txt.CustomButton.Visible = false;
            this.Phone_txt.DisplayIcon = true;
            this.Phone_txt.ForeColor = System.Drawing.Color.DimGray;
            this.Phone_txt.Icon = ((System.Drawing.Image)(resources.GetObject("Phone_txt.Icon")));
            this.Phone_txt.Lines = new string[0];
            this.Phone_txt.Location = new System.Drawing.Point(484, 278);
            this.Phone_txt.MaxLength = 32767;
            this.Phone_txt.Name = "Phone_txt";
            this.Phone_txt.PasswordChar = '\0';
            this.Phone_txt.PromptText = "Enter your phone or e-mail";
            this.Phone_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Phone_txt.SelectedText = "";
            this.Phone_txt.SelectionLength = 0;
            this.Phone_txt.SelectionStart = 0;
            this.Phone_txt.ShortcutsEnabled = true;
            this.Phone_txt.ShowClearButton = true;
            this.Phone_txt.Size = new System.Drawing.Size(289, 57);
            this.Phone_txt.Style = MetroFramework.MetroColorStyle.Silver;
            this.Phone_txt.TabIndex = 20;
            this.Phone_txt.UseSelectable = true;
            this.Phone_txt.WaterMark = "Enter your phone or e-mail";
            this.Phone_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Phone_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(785, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 309);
            this.button3.TabIndex = 19;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.PasswordID_txt.Location = new System.Drawing.Point(484, 89);
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
            this.PasswordID_txt.TabIndex = 16;
            this.PasswordID_txt.UseSelectable = true;
            this.PasswordID_txt.WaterMark = "Enter your id : is ?";
            this.PasswordID_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordID_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Name_txt
            // 
            this.Name_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            // 
            // 
            // 
            this.Name_txt.CustomButton.Image = null;
            this.Name_txt.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.Name_txt.CustomButton.Name = "";
            this.Name_txt.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.Name_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Name_txt.CustomButton.TabIndex = 1;
            this.Name_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Name_txt.CustomButton.UseSelectable = true;
            this.Name_txt.CustomButton.Visible = false;
            this.Name_txt.DisplayIcon = true;
            this.Name_txt.ForeColor = System.Drawing.Color.DimGray;
            this.Name_txt.Icon = ((System.Drawing.Image)(resources.GetObject("Name_txt.Icon")));
            this.Name_txt.Lines = new string[0];
            this.Name_txt.Location = new System.Drawing.Point(484, 152);
            this.Name_txt.MaxLength = 32767;
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.PasswordChar = '\0';
            this.Name_txt.PromptText = "Enter your first name";
            this.Name_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Name_txt.SelectedText = "";
            this.Name_txt.SelectionLength = 0;
            this.Name_txt.SelectionStart = 0;
            this.Name_txt.ShortcutsEnabled = false;
            this.Name_txt.ShowClearButton = true;
            this.Name_txt.Size = new System.Drawing.Size(289, 57);
            this.Name_txt.Style = MetroFramework.MetroColorStyle.Silver;
            this.Name_txt.TabIndex = 15;
            this.Name_txt.UseSelectable = true;
            this.Name_txt.WaterMark = "Enter your first name";
            this.Name_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Name_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(886, 517);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telNumberDataGridViewTextBoxColumn
            // 
            this.telNumberDataGridViewTextBoxColumn.DataPropertyName = "TelNumber";
            this.telNumberDataGridViewTextBoxColumn.HeaderText = "TelNumber";
            this.telNumberDataGridViewTextBoxColumn.Name = "telNumberDataGridViewTextBoxColumn";
            this.telNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moviesTableAdapter1
            // 
            this.moviesTableAdapter1.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 515);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.Name1_txt);
            this.Controls.Add(this.Phone_txt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordID_txt);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(884, 515);
            this.MinimumSize = new System.Drawing.Size(884, 515);
            this.Name = "Form3";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox PasswordID_txt;
        private MetroFramework.Controls.MetroTextBox Name_txt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTextBox Phone_txt;
        private MetroFramework.Controls.MetroTextBox Name1_txt;
        private MetroFramework.Controls.MetroTextBox Password_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bdDataSet bdDataSet1;
        private System.Windows.Forms.BindingSource tblCustomersBindingSource;
        private bdDataSetTableAdapters.tblCustomersTableAdapter tblCustomersTableAdapter;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private bdDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter1;
    }
}