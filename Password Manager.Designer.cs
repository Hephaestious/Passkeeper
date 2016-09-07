namespace PasswordManager
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileSelect = new System.Windows.Forms.ComboBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.accountsLabel = new System.Windows.Forms.Label();
            this.addAccountLabel = new System.Windows.Forms.Label();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.serviceInput = new System.Windows.Forms.TextBox();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.accountsTable = new System.Windows.Forms.DataGridView();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.logOutButton = new System.Windows.Forms.Button();
            this.deleteProfileButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Menu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProfileToolStripMenuItem,
            this.importProfileToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(58, 20);
            this.toolStripMenuItem1.Text = "Profiles";
            // 
            // createProfileToolStripMenuItem
            // 
            this.createProfileToolStripMenuItem.Name = "createProfileToolStripMenuItem";
            this.createProfileToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.createProfileToolStripMenuItem.Text = "Create Profile";
            this.createProfileToolStripMenuItem.Click += new System.EventHandler(this.createProfileToolStripMenuItem_Click);
            // 
            // importProfileToolStripMenuItem
            // 
            this.importProfileToolStripMenuItem.Name = "importProfileToolStripMenuItem";
            this.importProfileToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.importProfileToolStripMenuItem.Text = "Import Profile";
            this.importProfileToolStripMenuItem.Click += new System.EventHandler(this.importProfileToolStripMenuItem_Click);
            // 
            // profileSelect
            // 
            this.profileSelect.FormattingEnabled = true;
            this.profileSelect.Location = new System.Drawing.Point(54, 39);
            this.profileSelect.Name = "profileSelect";
            this.profileSelect.Size = new System.Drawing.Size(191, 21);
            this.profileSelect.TabIndex = 1;
            this.profileSelect.SelectedIndexChanged += new System.EventHandler(this.profileSelect_SelectedIndexChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(299, 42);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Profile";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(358, 39);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(155, 20);
            this.passwordInput.TabIndex = 4;
            this.passwordInput.Visible = false;
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(551, 37);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(75, 23);
            this.logInButton.TabIndex = 5;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Visible = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // addAccountButton
            // 
            this.addAccountButton.Location = new System.Drawing.Point(431, 155);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(82, 23);
            this.addAccountButton.TabIndex = 7;
            this.addAccountButton.Text = "Add Account";
            this.addAccountButton.UseVisualStyleBackColor = true;
            this.addAccountButton.Visible = false;
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // accountsLabel
            // 
            this.accountsLabel.AutoSize = true;
            this.accountsLabel.Location = new System.Drawing.Point(12, 199);
            this.accountsLabel.Name = "accountsLabel";
            this.accountsLabel.Size = new System.Drawing.Size(52, 13);
            this.accountsLabel.TabIndex = 8;
            this.accountsLabel.Text = "Accounts";
            this.accountsLabel.Visible = false;
            // 
            // addAccountLabel
            // 
            this.addAccountLabel.AutoSize = true;
            this.addAccountLabel.Location = new System.Drawing.Point(10, 103);
            this.addAccountLabel.Name = "addAccountLabel";
            this.addAccountLabel.Size = new System.Drawing.Size(69, 13);
            this.addAccountLabel.TabIndex = 9;
            this.addAccountLabel.Text = "Add Account";
            this.addAccountLabel.Visible = false;
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Location = new System.Drawing.Point(27, 132);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(43, 13);
            this.serviceLabel.TabIndex = 10;
            this.serviceLabel.Text = "Service";
            this.serviceLabel.Visible = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(238, 132);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 11;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Visible = false;
            // 
            // serviceInput
            // 
            this.serviceInput.Location = new System.Drawing.Point(30, 157);
            this.serviceInput.Name = "serviceInput";
            this.serviceInput.Size = new System.Drawing.Size(155, 20);
            this.serviceInput.TabIndex = 12;
            this.serviceInput.Visible = false;
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(241, 157);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(155, 20);
            this.usernameInput.TabIndex = 13;
            this.usernameInput.Visible = false;
            // 
            // accountsTable
            // 
            this.accountsTable.AllowUserToAddRows = false;
            this.accountsTable.AllowUserToDeleteRows = false;
            this.accountsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Service,
            this.Username,
            this.Password,
            this.DeleteColumn});
            this.accountsTable.Location = new System.Drawing.Point(30, 232);
            this.accountsTable.Name = "accountsTable";
            this.accountsTable.Size = new System.Drawing.Size(643, 293);
            this.accountsTable.TabIndex = 14;
            this.accountsTable.Visible = false;
            this.accountsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountsTable_CellContentClick);
            // 
            // Service
            // 
            this.Service.HeaderText = "Service";
            this.Service.Name = "Service";
            this.Service.Width = 150;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.Width = 150;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.Width = 150;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "Delete Account";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.Text = "Delete";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            this.DeleteColumn.Width = 150;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(551, 37);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 23);
            this.logOutButton.TabIndex = 15;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Visible = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // deleteProfileButton
            // 
            this.deleteProfileButton.Location = new System.Drawing.Point(551, 66);
            this.deleteProfileButton.Name = "deleteProfileButton";
            this.deleteProfileButton.Size = new System.Drawing.Size(104, 23);
            this.deleteProfileButton.TabIndex = 16;
            this.deleteProfileButton.Text = "Delete Profile";
            this.deleteProfileButton.UseVisualStyleBackColor = true;
            this.deleteProfileButton.Visible = false;
            this.deleteProfileButton.Click += new System.EventHandler(this.deleteProfileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 563);
            this.Controls.Add(this.deleteProfileButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.accountsTable);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.serviceInput);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.serviceLabel);
            this.Controls.Add(this.addAccountLabel);
            this.Controls.Add(this.accountsLabel);
            this.Controls.Add(this.addAccountButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.profileSelect);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Password Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importProfileToolStripMenuItem;
        private System.Windows.Forms.ComboBox profileSelect;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.Label accountsLabel;
        private System.Windows.Forms.Label addAccountLabel;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox serviceInput;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.DataGridView accountsTable;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
        private System.Windows.Forms.Button deleteProfileButton;
    }
}

