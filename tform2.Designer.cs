namespace PasswordManager
{
    partial class tform2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tform2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pageTabControl = new PasswordManager.MainForm.CustomTabControl();
            this.accountPage = new System.Windows.Forms.TabPage();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.profileDeleteButton = new System.Windows.Forms.Button();
            this.accountsTable = new System.Windows.Forms.DataGridView();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.profileNameLabel = new System.Windows.Forms.Button();
            this.helpPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.helpPageHeader = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pageTabControl.SuspendLayout();
            this.accountPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTable)).BeginInit();
            this.helpPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageTabControl
            // 
            this.pageTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.pageTabControl.Controls.Add(this.accountPage);
            this.pageTabControl.Controls.Add(this.helpPage);
            this.pageTabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.pageTabControl.Location = new System.Drawing.Point(312, 71);
            this.pageTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.pageTabControl.Multiline = true;
            this.pageTabControl.Name = "pageTabControl";
            this.pageTabControl.Padding = new System.Drawing.Point(0, 0);
            this.pageTabControl.SelectedIndex = 0;
            this.pageTabControl.Size = new System.Drawing.Size(458, 442);
            this.pageTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.pageTabControl.TabIndex = 1;
            // 
            // accountPage
            // 
            this.accountPage.BackColor = System.Drawing.Color.SeaShell;
            this.accountPage.BackgroundImage = global::PasswordManager.Properties.Resources.dark_dotted2;
            this.accountPage.Controls.Add(this.addAccountButton);
            this.accountPage.Controls.Add(this.profileDeleteButton);
            this.accountPage.Controls.Add(this.accountsTable);
            this.accountPage.Controls.Add(this.profileNameLabel);
            this.accountPage.Location = new System.Drawing.Point(4, 5);
            this.accountPage.Margin = new System.Windows.Forms.Padding(0);
            this.accountPage.Name = "accountPage";
            this.accountPage.Size = new System.Drawing.Size(450, 433);
            this.accountPage.TabIndex = 0;
            this.accountPage.Text = "tabPage1";
            // 
            // addAccountButton
            // 
            this.addAccountButton.BackColor = System.Drawing.Color.Transparent;
            this.addAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAccountButton.FlatAppearance.BorderSize = 0;
            this.addAccountButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAccountButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAccountButton.ForeColor = System.Drawing.Color.White;
            this.addAccountButton.Image = ((System.Drawing.Image)(resources.GetObject("addAccountButton.Image")));
            this.addAccountButton.Location = new System.Drawing.Point(0, 27);
            this.addAccountButton.Margin = new System.Windows.Forms.Padding(0);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(32, 32);
            this.addAccountButton.TabIndex = 33;
            this.addAccountButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addAccountButton.UseVisualStyleBackColor = false;
            // 
            // profileDeleteButton
            // 
            this.profileDeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.profileDeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileDeleteButton.FlatAppearance.BorderSize = 0;
            this.profileDeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.profileDeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.profileDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileDeleteButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileDeleteButton.ForeColor = System.Drawing.Color.White;
            this.profileDeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("profileDeleteButton.Image")));
            this.profileDeleteButton.Location = new System.Drawing.Point(419, 0);
            this.profileDeleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.profileDeleteButton.Name = "profileDeleteButton";
            this.profileDeleteButton.Size = new System.Drawing.Size(32, 32);
            this.profileDeleteButton.TabIndex = 28;
            this.profileDeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.profileDeleteButton.UseVisualStyleBackColor = false;
            // 
            // accountsTable
            // 
            this.accountsTable.AllowUserToAddRows = false;
            this.accountsTable.AllowUserToDeleteRows = false;
            this.accountsTable.AllowUserToResizeColumns = false;
            this.accountsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.accountsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.accountsTable.BackgroundColor = System.Drawing.Color.SeaShell;
            this.accountsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.accountsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Service,
            this.Username,
            this.PasswordColumn,
            this.DeleteColumn});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.accountsTable.DefaultCellStyle = dataGridViewCellStyle7;
            this.accountsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.accountsTable.GridColor = System.Drawing.Color.Black;
            this.accountsTable.Location = new System.Drawing.Point(0, 98);
            this.accountsTable.Name = "accountsTable";
            this.accountsTable.ReadOnly = true;
            this.accountsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.accountsTable.RowHeadersVisible = false;
            this.accountsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.accountsTable.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.accountsTable.Size = new System.Drawing.Size(451, 320);
            this.accountsTable.TabIndex = 27;
            // 
            // Service
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Service.DefaultCellStyle = dataGridViewCellStyle3;
            this.Service.HeaderText = "Service";
            this.Service.Name = "Service";
            this.Service.ReadOnly = true;
            this.Service.Width = 130;
            // 
            // Username
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.DefaultCellStyle = dataGridViewCellStyle4;
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 130;
            // 
            // PasswordColumn
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.PasswordColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordColumn.HeaderText = "Password";
            this.PasswordColumn.Name = "PasswordColumn";
            this.PasswordColumn.ReadOnly = true;
            this.PasswordColumn.Text = "Copy";
            this.PasswordColumn.UseColumnTextForButtonValue = true;
            this.PasswordColumn.Width = 110;
            // 
            // DeleteColumn
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.DeleteColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Text = "Delete";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            this.DeleteColumn.Width = 80;
            // 
            // profileNameLabel
            // 
            this.profileNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.profileNameLabel.FlatAppearance.BorderSize = 0;
            this.profileNameLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.profileNameLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.profileNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileNameLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileNameLabel.ForeColor = System.Drawing.Color.White;
            this.profileNameLabel.Location = new System.Drawing.Point(0, -5);
            this.profileNameLabel.Name = "profileNameLabel";
            this.profileNameLabel.Size = new System.Drawing.Size(458, 46);
            this.profileNameLabel.TabIndex = 26;
            this.profileNameLabel.Text = "Stinkboy";
            this.profileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileNameLabel.UseVisualStyleBackColor = false;
            // 
            // helpPage
            // 
            this.helpPage.BackColor = System.Drawing.Color.SeaShell;
            this.helpPage.BackgroundImage = global::PasswordManager.Properties.Resources.dark_dotted2;
            this.helpPage.Controls.Add(this.label2);
            this.helpPage.Controls.Add(this.label3);
            this.helpPage.Controls.Add(this.label1);
            this.helpPage.Controls.Add(this.helpPageHeader);
            this.helpPage.Controls.Add(this.label5);
            this.helpPage.Location = new System.Drawing.Point(4, 5);
            this.helpPage.Margin = new System.Windows.Forms.Padding(0);
            this.helpPage.Name = "helpPage";
            this.helpPage.Size = new System.Drawing.Size(450, 433);
            this.helpPage.TabIndex = 1;
            this.helpPage.Text = "tabPage2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(19, 283);
            this.label2.MaximumSize = new System.Drawing.Size(435, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 144);
            this.label2.TabIndex = 30;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(3, 265);
            this.label3.MaximumSize = new System.Drawing.Size(400, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Accounts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(19, 62);
            this.label1.MaximumSize = new System.Drawing.Size(435, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 176);
            this.label1.TabIndex = 28;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // helpPageHeader
            // 
            this.helpPageHeader.BackColor = System.Drawing.Color.Transparent;
            this.helpPageHeader.FlatAppearance.BorderSize = 0;
            this.helpPageHeader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.helpPageHeader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.helpPageHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpPageHeader.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpPageHeader.ForeColor = System.Drawing.Color.Lime;
            this.helpPageHeader.Location = new System.Drawing.Point(0, -5);
            this.helpPageHeader.Name = "helpPageHeader";
            this.helpPageHeader.Size = new System.Drawing.Size(458, 46);
            this.helpPageHeader.TabIndex = 27;
            this.helpPageHeader.Text = "Password Manager";
            this.helpPageHeader.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(3, 44);
            this.label5.MaximumSize = new System.Drawing.Size(400, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Profiles";
            // 
            // tform2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 586);
            this.Controls.Add(this.pageTabControl);
            this.Name = "tform2";
            this.Text = "tform2";
            this.pageTabControl.ResumeLayout(false);
            this.accountPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountsTable)).EndInit();
            this.helpPage.ResumeLayout(false);
            this.helpPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MainForm.CustomTabControl pageTabControl;
        private System.Windows.Forms.TabPage accountPage;
        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.Button profileDeleteButton;
        private System.Windows.Forms.DataGridView accountsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewButtonColumn PasswordColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
        private System.Windows.Forms.Button profileNameLabel;
        private System.Windows.Forms.TabPage helpPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button helpPageHeader;
        private System.Windows.Forms.Label label5;
    }
}