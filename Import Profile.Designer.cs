namespace PasswordManager
{
    partial class Import_Profile
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
            this.profileNameInput = new System.Windows.Forms.TextBox();
            this.profilePasswordInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.phraseInput = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // profileNameInput
            // 
            this.profileNameInput.Location = new System.Drawing.Point(136, 54);
            this.profileNameInput.Name = "profileNameInput";
            this.profileNameInput.Size = new System.Drawing.Size(132, 20);
            this.profileNameInput.TabIndex = 7;
            // 
            // profilePasswordInput
            // 
            this.profilePasswordInput.Location = new System.Drawing.Point(136, 96);
            this.profilePasswordInput.Name = "profilePasswordInput";
            this.profilePasswordInput.Size = new System.Drawing.Size(132, 20);
            this.profilePasswordInput.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Profile Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Profile Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phrase";
            // 
            // phraseInput
            // 
            this.phraseInput.Location = new System.Drawing.Point(136, 134);
            this.phraseInput.Name = "phraseInput";
            this.phraseInput.Size = new System.Drawing.Size(275, 84);
            this.phraseInput.TabIndex = 9;
            this.phraseInput.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Only the phrase needs to be the same as the original profile";
            // 
            // Import_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 274);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phraseInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.profileNameInput);
            this.Controls.Add(this.profilePasswordInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Import_Profile";
            this.Text = "Import Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox profileNameInput;
        private System.Windows.Forms.TextBox profilePasswordInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox phraseInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}