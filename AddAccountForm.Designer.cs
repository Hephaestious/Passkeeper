namespace PasswordManager
{
    partial class AddAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccountForm));
            this.firstLineLabel = new System.Windows.Forms.Label();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.serviceInput = new System.Windows.Forms.TextBox();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordOptionLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordOptionInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstLineLabel
            // 
            this.firstLineLabel.AutoSize = true;
            this.firstLineLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstLineLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstLineLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLineLabel.ForeColor = System.Drawing.Color.Lime;
            this.firstLineLabel.Location = new System.Drawing.Point(9, 9);
            this.firstLineLabel.Margin = new System.Windows.Forms.Padding(0);
            this.firstLineLabel.Name = "firstLineLabel";
            this.firstLineLabel.Size = new System.Drawing.Size(348, 18);
            this.firstLineLabel.TabIndex = 2;
            this.firstLineLabel.Text = "~\\Profiles\\profilename>add account";
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.BackColor = System.Drawing.Color.Transparent;
            this.serviceLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.serviceLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceLabel.ForeColor = System.Drawing.Color.Lime;
            this.serviceLabel.Location = new System.Drawing.Point(9, 30);
            this.serviceLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(138, 18);
            this.serviceLabel.TabIndex = 3;
            this.serviceLabel.Text = "service name:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Lime;
            this.usernameLabel.Location = new System.Drawing.Point(9, 51);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(98, 18);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "username:";
            this.usernameLabel.Visible = false;
            // 
            // serviceInput
            // 
            this.serviceInput.BackColor = System.Drawing.Color.Black;
            this.serviceInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serviceInput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceInput.ForeColor = System.Drawing.Color.Lime;
            this.serviceInput.Location = new System.Drawing.Point(147, 30);
            this.serviceInput.Margin = new System.Windows.Forms.Padding(0);
            this.serviceInput.Name = "serviceInput";
            this.serviceInput.Size = new System.Drawing.Size(293, 19);
            this.serviceInput.TabIndex = 1;
            // 
            // usernameInput
            // 
            this.usernameInput.BackColor = System.Drawing.Color.Black;
            this.usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameInput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.ForeColor = System.Drawing.Color.Lime;
            this.usernameInput.Location = new System.Drawing.Point(107, 51);
            this.usernameInput.Margin = new System.Windows.Forms.Padding(0);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(293, 19);
            this.usernameInput.TabIndex = 2;
            this.usernameInput.Visible = false;
            // 
            // passwordOptionLabel
            // 
            this.passwordOptionLabel.AutoSize = true;
            this.passwordOptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordOptionLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordOptionLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordOptionLabel.ForeColor = System.Drawing.Color.Lime;
            this.passwordOptionLabel.Location = new System.Drawing.Point(9, 72);
            this.passwordOptionLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.passwordOptionLabel.Name = "passwordOptionLabel";
            this.passwordOptionLabel.Size = new System.Drawing.Size(288, 18);
            this.passwordOptionLabel.TabIndex = 5;
            this.passwordOptionLabel.Text = "Generate new password (Y/N)?";
            this.passwordOptionLabel.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Lime;
            this.passwordLabel.Location = new System.Drawing.Point(9, 97);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(98, 18);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "password:";
            this.passwordLabel.Visible = false;
            // 
            // passwordOptionInput
            // 
            this.passwordOptionInput.BackColor = System.Drawing.Color.Black;
            this.passwordOptionInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordOptionInput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordOptionInput.ForeColor = System.Drawing.Color.Lime;
            this.passwordOptionInput.Location = new System.Drawing.Point(303, 72);
            this.passwordOptionInput.Margin = new System.Windows.Forms.Padding(0);
            this.passwordOptionInput.Name = "passwordOptionInput";
            this.passwordOptionInput.Size = new System.Drawing.Size(54, 19);
            this.passwordOptionInput.TabIndex = 7;
            this.passwordOptionInput.Visible = false;
            // 
            // passwordInput
            // 
            this.passwordInput.BackColor = System.Drawing.Color.Black;
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordInput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.ForeColor = System.Drawing.Color.Lime;
            this.passwordInput.Location = new System.Drawing.Point(107, 97);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(0);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(293, 19);
            this.passwordInput.TabIndex = 8;
            this.passwordInput.Visible = false;
            // 
            // AddAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(537, 183);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.passwordOptionInput);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordOptionLabel);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.serviceInput);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.serviceLabel);
            this.Controls.Add(this.firstLineLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAccountForm";
            this.Text = "Password Manager Console";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstLineLabel;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox serviceInput;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label passwordOptionLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordOptionInput;
        private System.Windows.Forms.TextBox passwordInput;
    }
}