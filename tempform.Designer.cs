namespace PasswordManager
{
    partial class tempform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tempform));
            this.importProfileButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.createProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // importProfileButton
            // 
            this.importProfileButton.BackColor = System.Drawing.Color.Transparent;
            this.importProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importProfileButton.FlatAppearance.BorderSize = 0;
            this.importProfileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.importProfileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.importProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importProfileButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importProfileButton.ForeColor = System.Drawing.Color.White;
            this.importProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("importProfileButton.Image")));
            this.importProfileButton.Location = new System.Drawing.Point(298, 193);
            this.importProfileButton.Margin = new System.Windows.Forms.Padding(0);
            this.importProfileButton.Name = "importProfileButton";
            this.importProfileButton.Size = new System.Drawing.Size(32, 32);
            this.importProfileButton.TabIndex = 9;
            this.importProfileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.importProfileButton.UseVisualStyleBackColor = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Red;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(910, 199);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 24);
            this.closeButton.TabIndex = 7;
            this.closeButton.UseVisualStyleBackColor = false;
            // 
            // createProfileButton
            // 
            this.createProfileButton.BackColor = System.Drawing.Color.Transparent;
            this.createProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createProfileButton.FlatAppearance.BorderSize = 0;
            this.createProfileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.createProfileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.createProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createProfileButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createProfileButton.ForeColor = System.Drawing.Color.White;
            this.createProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("createProfileButton.Image")));
            this.createProfileButton.Location = new System.Drawing.Point(249, 193);
            this.createProfileButton.Margin = new System.Windows.Forms.Padding(0);
            this.createProfileButton.Name = "createProfileButton";
            this.createProfileButton.Size = new System.Drawing.Size(32, 32);
            this.createProfileButton.TabIndex = 8;
            this.createProfileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createProfileButton.UseVisualStyleBackColor = false;
            // 
            // tempform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 419);
            this.Controls.Add(this.importProfileButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.createProfileButton);
            this.Name = "tempform";
            this.Text = "tempform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button importProfileButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button createProfileButton;
    }
}