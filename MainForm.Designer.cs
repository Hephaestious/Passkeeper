using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PasswordManager
{
    partial class MainForm
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


        public class CustomTabControl : TabControl
        {
            private const int TCM_ADJUSTRECT = 0x1328;

            protected override void WndProc(ref Message m)
            {
                // Hide the tab headers at run-time
                if (m.Msg == TCM_ADJUSTRECT && !DesignMode)
                {
                    m.Result = (IntPtr)1;
                    return;
                }

                // call the base class implementation
                base.WndProc(ref m);
            }
        }

        /*public class splitContainer2 : SplitContainer
        {
            protected override void OnPaintBackground(PaintEventArgs e)
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle,
                                                                           Color.White,
                                                                           Color.Black,
                                                                           90F))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
                using (LinearGradientBrush brush = new LinearGradientBrush(this.Panel1.ClientRectangle,
                                                                           Color.White,
                                                                           Color.Blue,
                                                                           90F))
                {
                    e.Graphics.FillRectangle(brush, this.Panel1.ClientRectangle);
                }
            }
        }*/
        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.profileListHeader = new System.Windows.Forms.Button();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.tabPanel = new System.Windows.Forms.Panel();
            this.pageTabControl = new PasswordManager.MainForm.CustomTabControl();
            this.accountPage = new System.Windows.Forms.TabPage();
            this.addAccountButton = new System.Windows.Forms.Button();
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
            this.importProfileButton = new System.Windows.Forms.Button();
            this.createProfileButton = new System.Windows.Forms.Button();
            this.profilePanel.SuspendLayout();
            this.tabPanel.SuspendLayout();
            this.pageTabControl.SuspendLayout();
            this.accountPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsTable)).BeginInit();
            this.helpPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 250;
            this.toolTip1.BackColor = System.Drawing.Color.SkyBlue;
            this.toolTip1.ForeColor = System.Drawing.Color.White;
            this.toolTip1.ShowAlways = true;
            // 
            // profileListHeader
            // 
            this.profileListHeader.BackColor = System.Drawing.Color.Transparent;
            this.profileListHeader.FlatAppearance.BorderSize = 0;
            this.profileListHeader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.profileListHeader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.profileListHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileListHeader.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileListHeader.Location = new System.Drawing.Point(0, 0);
            this.profileListHeader.Name = "profileListHeader";
            this.profileListHeader.Size = new System.Drawing.Size(156, 31);
            this.profileListHeader.TabIndex = 5;
            this.profileListHeader.Text = "Profiles";
            this.profileListHeader.UseVisualStyleBackColor = false;
            // 
            // profilePanel
            // 
            this.profilePanel.BackgroundImage = global::PasswordManager.Properties.Resources.escheresque_ste;
            this.profilePanel.Controls.Add(this.profileListHeader);
            this.profilePanel.Location = new System.Drawing.Point(0, 0);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(160, 358);
            this.profilePanel.TabIndex = 6;
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.pageTabControl);
            this.tabPanel.Location = new System.Drawing.Point(162, 0);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(524, 419);
            this.tabPanel.TabIndex = 7;
            // 
            // pageTabControl
            // 
            this.pageTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.pageTabControl.Controls.Add(this.accountPage);
            this.pageTabControl.Controls.Add(this.helpPage);
            this.pageTabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.pageTabControl.Location = new System.Drawing.Point(0, 0);
            this.pageTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.pageTabControl.Multiline = true;
            this.pageTabControl.Name = "pageTabControl";
            this.pageTabControl.Padding = new System.Drawing.Point(0, 0);
            this.pageTabControl.SelectedIndex = 0;
            this.pageTabControl.Size = new System.Drawing.Size(526, 419);
            this.pageTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.pageTabControl.TabIndex = 2;
            // 
            // accountPage
            // 
            this.accountPage.BackColor = System.Drawing.Color.SeaShell;
            this.accountPage.BackgroundImage = global::PasswordManager.Properties.Resources.dark_dotted2;
            this.accountPage.Controls.Add(this.addAccountButton);
            this.accountPage.Controls.Add(this.accountsTable);
            this.accountPage.Controls.Add(this.profileNameLabel);
            this.accountPage.Location = new System.Drawing.Point(4, 5);
            this.accountPage.Margin = new System.Windows.Forms.Padding(0);
            this.accountPage.Name = "accountPage";
            this.accountPage.Size = new System.Drawing.Size(518, 410);
            this.accountPage.TabIndex = 0;
            this.accountPage.Text = "tabPage1";
            // 
            // addAccountButton
            // 
            this.addAccountButton.BackColor = System.Drawing.Color.Transparent;
            this.addAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAccountButton.FlatAppearance.BorderSize = 0;
            this.addAccountButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addAccountButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAccountButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAccountButton.ForeColor = System.Drawing.Color.Lime;
            this.addAccountButton.Image = global::PasswordManager.Properties.Resources.add_green;
            this.addAccountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addAccountButton.Location = new System.Drawing.Point(3, 30);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(160, 31);
            this.addAccountButton.TabIndex = 10;
            this.addAccountButton.Text = " Add Account";
            this.addAccountButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addAccountButton.UseVisualStyleBackColor = false;
            // 
            // accountsTable
            // 
            this.accountsTable.AllowUserToAddRows = false;
            this.accountsTable.AllowUserToDeleteRows = false;
            this.accountsTable.AllowUserToResizeColumns = false;
            this.accountsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.LightGray;
            this.accountsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.accountsTable.BackgroundColor = System.Drawing.Color.Black;
            this.accountsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.accountsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Service,
            this.Username,
            this.PasswordColumn,
            this.DeleteColumn});
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.accountsTable.DefaultCellStyle = dataGridViewCellStyle25;
            this.accountsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.accountsTable.GridColor = System.Drawing.Color.Black;
            this.accountsTable.Location = new System.Drawing.Point(0, 67);
            this.accountsTable.Name = "accountsTable";
            this.accountsTable.ReadOnly = true;
            this.accountsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.accountsTable.RowHeadersVisible = false;
            this.accountsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.LightGray;
            this.accountsTable.RowsDefaultCellStyle = dataGridViewCellStyle27;
            this.accountsTable.Size = new System.Drawing.Size(518, 351);
            this.accountsTable.TabIndex = 27;
            // 
            // Service
            // 
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Service.DefaultCellStyle = dataGridViewCellStyle21;
            this.Service.HeaderText = "Service";
            this.Service.Name = "Service";
            this.Service.ReadOnly = true;
            this.Service.Width = 147;
            // 
            // Username
            // 
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.DefaultCellStyle = dataGridViewCellStyle22;
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 150;
            // 
            // PasswordColumn
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordColumn.DefaultCellStyle = dataGridViewCellStyle23;
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
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteColumn.DefaultCellStyle = dataGridViewCellStyle24;
            this.DeleteColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Text = "Delete";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            this.DeleteColumn.Width = 110;
            // 
            // profileNameLabel
            // 
            this.profileNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.profileNameLabel.FlatAppearance.BorderSize = 0;
            this.profileNameLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.profileNameLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.profileNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileNameLabel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileNameLabel.ForeColor = System.Drawing.Color.Lime;
            this.profileNameLabel.Location = new System.Drawing.Point(0, -5);
            this.profileNameLabel.Name = "profileNameLabel";
            this.profileNameLabel.Size = new System.Drawing.Size(518, 46);
            this.profileNameLabel.TabIndex = 26;
            this.profileNameLabel.Text = "Stinkboy";
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
            this.helpPage.Size = new System.Drawing.Size(518, 410);
            this.helpPage.TabIndex = 1;
            this.helpPage.Text = "tabPage2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(27, 257);
            this.label2.MaximumSize = new System.Drawing.Size(480, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 128);
            this.label2.TabIndex = 30;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(3, 239);
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
            this.label1.Location = new System.Drawing.Point(27, 62);
            this.label1.MaximumSize = new System.Drawing.Size(480, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 160);
            this.label1.TabIndex = 28;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // helpPageHeader
            // 
            this.helpPageHeader.BackColor = System.Drawing.Color.Transparent;
            this.helpPageHeader.FlatAppearance.BorderSize = 0;
            this.helpPageHeader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.helpPageHeader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.helpPageHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpPageHeader.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpPageHeader.ForeColor = System.Drawing.Color.Lime;
            this.helpPageHeader.Location = new System.Drawing.Point(6, -5);
            this.helpPageHeader.Name = "helpPageHeader";
            this.helpPageHeader.Size = new System.Drawing.Size(501, 46);
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
            // importProfileButton
            // 
            this.importProfileButton.BackColor = System.Drawing.Color.Orange;
            this.importProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importProfileButton.FlatAppearance.BorderSize = 0;
            this.importProfileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.importProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importProfileButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importProfileButton.ForeColor = System.Drawing.Color.Black;
            this.importProfileButton.Image = global::PasswordManager.Properties.Resources.key_import;
            this.importProfileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importProfileButton.Location = new System.Drawing.Point(0, 388);
            this.importProfileButton.Name = "importProfileButton";
            this.importProfileButton.Size = new System.Drawing.Size(160, 31);
            this.importProfileButton.TabIndex = 8;
            this.importProfileButton.Text = " Import";
            this.importProfileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.importProfileButton.UseVisualStyleBackColor = false;
            // 
            // createProfileButton
            // 
            this.createProfileButton.BackColor = System.Drawing.Color.Lime;
            this.createProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createProfileButton.FlatAppearance.BorderSize = 0;
            this.createProfileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.createProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createProfileButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createProfileButton.ForeColor = System.Drawing.Color.Black;
            this.createProfileButton.Image = global::PasswordManager.Properties.Resources.key_add;
            this.createProfileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createProfileButton.Location = new System.Drawing.Point(0, 359);
            this.createProfileButton.Name = "createProfileButton";
            this.createProfileButton.Size = new System.Drawing.Size(160, 31);
            this.createProfileButton.TabIndex = 9;
            this.createProfileButton.Text = " New";
            this.createProfileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createProfileButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = global::PasswordManager.Properties.Resources.dark_dotted2;
            this.ClientSize = new System.Drawing.Size(685, 418);
            this.Controls.Add(this.createProfileButton);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.profilePanel);
            this.Controls.Add(this.importProfileButton);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Manager";
            this.profilePanel.ResumeLayout(false);
            this.tabPanel.ResumeLayout(false);
            this.pageTabControl.ResumeLayout(false);
            this.accountPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountsTable)).EndInit();
            this.helpPage.ResumeLayout(false);
            this.helpPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ToolTip toolTip1;
        private Button profileListHeader;
        private Panel profilePanel;
        private Panel tabPanel;
        private MainForm.CustomTabControl pageTabControl;
        private TabPage accountPage;
        private DataGridView accountsTable;
        private Button profileNameLabel;
        private TabPage helpPage;
        private Label label2;
        private Label label3;
        private Label label1;
        private Button helpPageHeader;
        private Label label5;
        private Button importProfileButton;
        private Button createProfileButton;
        private Button addAccountButton;
        private DataGridViewTextBoxColumn Service;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewButtonColumn PasswordColumn;
        private DataGridViewButtonColumn DeleteColumn;
    }
}