using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PasswordManager
{
    public partial class Form1 : Form
    {
        private List<Profile> Profiles;
        private Profile profile;
        private PhraseHashJson _phraseHash;
        public Form1()
        {
            InitializeComponent();
            profileSelect.Items.Clear();
            Profiles = Database.GetProfiles();
            if (Profiles.Count != 0)
            {
                foreach (Profile profile in Profiles)
                {
                    profileSelect.Items.Add(profile.Name);
                }
            }
            else
            {
                profileSelect.Items.Add(new ListViewItem("No Profiles Found"));
            }
        }

        private void createProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProfile newForm = new NewProfile();
            newForm.ShowDialog();
            profileSelect.Items.Clear();
            Profiles = Database.GetProfiles();
            if (Profiles.Count != 0)
            {
                foreach (Profile profile in Profiles)
                {
                    profileSelect.Items.Add(profile.Name);
                }
            }
            else
            {
                profileSelect.Items.Add(new ListViewItem("No Profiles Found"));
            }
        }

        private void importProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Import_Profile newPoop = new Import_Profile();
            newPoop.ShowDialog();
            profileSelect.Items.Clear();
            Profiles = Database.GetProfiles();
            if (Profiles.Count != 0)
            {
                foreach (Profile profile in Profiles)
                {
                    profileSelect.Items.Add(profile.Name);
                }
            }
            else
            {
                profileSelect.Items.Add(new ListViewItem("No Profiles Found"));
            }
        }

        private void profileSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            accountsTable.Rows.Clear();
            if (profileSelect.SelectedItem.ToString() != "No Profiles Found")
            {
                profile = Database.GetProfile(profileSelect.SelectedItem.ToString());
                deleteProfileButton.Visible = true;
                passwordInput.Text = null;
                serviceInput.Text = null;
                usernameInput.Text = null;
                passwordLabel.Visible = true;
                passwordInput.Visible = true;
                logInButton.Visible = true;
                _phraseHash = null;
                accountsTable.Visible = false;
                accountsLabel.Visible = false;
                addAccountLabel.Visible = false;
                serviceInput.Visible = false;
                serviceLabel.Visible = false;
                usernameInput.Visible = false;
                usernameLabel.Visible = false;
                addAccountButton.Visible = false;
                logOutButton.Visible = false;
            }
            else
            {
                deleteProfileButton.Visible = false;
                passwordInput.Text = null;
                serviceInput.Text = null;
                usernameInput.Text = null;
                profile = null;
                _phraseHash = null;
                passwordLabel.Visible = false;
                passwordInput.Visible = false;
                logInButton.Visible = false;
                accountsTable.Visible = false;
                accountsLabel.Visible = false;
                addAccountLabel.Visible = false;
                serviceInput.Visible = false;
                serviceLabel.Visible = false;
                usernameInput.Visible = false;
                usernameLabel.Visible = false;
                addAccountButton.Visible = false;
                logOutButton.Visible = false;
            }
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(passwordInput.Text))
            {
                string passwordHash = Crypto.GenerateHash(passwordInput.Text);
                try
                {
                    string encryptedphrasehash = Crypto.DecryptStringAES(profile.PhraseHash, passwordHash);
                    _phraseHash = JsonConvert.DeserializeObject<PhraseHashJson>(encryptedphrasehash);
                    passwordInput.Text = null;
                    serviceInput.Text = null;
                    usernameInput.Text = null;
                    passwordLabel.Visible = false;
                    passwordInput.Visible = false;
                    logInButton.Visible = false;
                    accountsTable.Visible = true;
                    accountsLabel.Visible = true;
                    addAccountLabel.Visible = true;
                    serviceInput.Visible = true;
                    serviceLabel.Visible = true;
                    usernameInput.Visible = true;
                    usernameLabel.Visible = true;
                    addAccountButton.Visible = true;
                    logOutButton.Visible = true;
                    foreach (Account account in profile.Accounts)
                    {
                        var row = new DataGridViewRow();
                        row.CreateCells(accountsTable);
                        row.Cells[0].Value = account.ServiceName;
                        row.Cells[1].Value = account.Username;
                        row.Cells[2].Value = "Copy to clipboard";
                        accountsTable.Rows.Add(row);
                    }
                }
                catch(Exception)
                {
                    _phraseHash = null;
                    MessageBox.Show("Wrong password");
                }
            }
            else
            {
                MessageBox.Show("You must enter a password");
            }
        }

        private void accountsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == 2)
            {
                Account account = profile.Accounts[e.RowIndex];
                Clipboard.SetText(Crypto.DecryptStringAES(account.EncryptedPassword, _phraseHash.PhraseHash));
            }
            if (e.ColumnIndex == 3)
            {
                Account account = profile.Accounts[e.RowIndex];
                profile.Accounts.Remove(account);
                Database.SaveProfile(profile);
                senderGrid.Rows.Remove(senderGrid.Rows[e.RowIndex]);
            }
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(serviceInput.Text) && !string.IsNullOrEmpty(usernameInput.Text))
            {
                string service = serviceInput.Text.ToLower();
                string username = usernameInput.Text.ToLower();
                string password = Crypto.GenerateHashWithSeed(service + username, _phraseHash.PhraseHash);
                string encryptedpassword = Crypto.EncryptStringAES(password, _phraseHash.PhraseHash);
                Account newAccount = new Account(serviceInput.Text, usernameInput.Text, encryptedpassword);
                if (!profile.Accounts.Contains(newAccount))
                {
                    profile.Accounts.Add(newAccount);
                    Database.SaveProfile(profile);
                    var row = new DataGridViewRow();
                    row.CreateCells(accountsTable);
                    row.Cells[0].Value = newAccount.ServiceName;
                    row.Cells[1].Value = newAccount.Username;
                    row.Cells[2].Value = "Copy to clipboard";
                    accountsTable.Rows.Add(row);
                    serviceInput.Text = null;
                    usernameInput.Text = null;
                }
                else
                {
                    MessageBox.Show("You already have an account for that service and username.");
                }
            }
            else
            {
                MessageBox.Show("You must enter a service and username.");
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            profileSelect.SelectedItem = profileSelect.Items[0];
            profileSelect_SelectedIndexChanged(new object(), new EventArgs());
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteProfileButton_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("Really delete?", "Delete account", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Database.DeleteProfile(profile.Name);
                profileSelect.Items.Remove(profileSelect.SelectedItem);
                if (profileSelect.Items.Count == 0)
                {
                    profileSelect.Items.Add(new ListViewItem("No Profiles Found"));
                }
                profileSelect.SelectedItem = profileSelect.Items[0];
                profileSelect_SelectedIndexChanged(new object(), new EventArgs());   
            }
        }

    }
}
