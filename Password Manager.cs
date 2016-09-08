using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PasswordManager
{
    public partial class FrmMain : Form
    {
        private List<Database.Profile> _profiles;
        private Database.Profile _profile;
        private Database.PhraseHashJson _phraseHash;

        public FrmMain()
        {
            InitializeComponent();
            profileSelect.Items.Clear();
            _profiles = Database.GetProfiles();

            if (_profiles.Count != 0)
                foreach (var profile in _profiles)
                    profileSelect.Items.Add(profile.Name);
            else
                profileSelect.Items.Add("No Profiles Found");
        }

        private void createProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newProfile = new NewProfile();
            newProfile.ShowDialog();

            profileSelect.Items.Clear();
            _profiles = Database.GetProfiles();

            if (_profiles.Count != 0)
                foreach (var profile in _profiles)
                    profileSelect.Items.Add(profile.Name);
            else
                profileSelect.Items.Add("No Profiles Found");
        }

        private void importProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var importPro = new Import_Profile();
            importPro.ShowDialog();

            profileSelect.Items.Clear();
            _profiles = Database.GetProfiles();
            
            if (_profiles.Count != 0)
                foreach (var profile in _profiles)
                    profileSelect.Items.Add(profile.Name);
            else
                profileSelect.Items.Add("No Profiles Found");
        }

        private void profileSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            accountsTable.Rows.Clear(); //clear accounts

            if (profileSelect.SelectedItem.ToString() != "No Profiles Found")
            {
                _profile = Database.GetProfile(profileSelect.SelectedItem.ToString());
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
                _profile = null;
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
                var passwordHash = Crypto.GenerateHash(passwordInput.Text);
                try
                {
                    var encryptedphrasehash = Crypto.DecryptStringAES(_profile.PhraseHash, passwordHash);
                    _phraseHash = JsonConvert.DeserializeObject<Database.PhraseHashJson>(encryptedphrasehash);
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

                    foreach (var account in _profile.Accounts)
                    {
                        var row = new DataGridViewRow();
                        row.CreateCells(accountsTable);
                        row.Cells[0].Value = account.ServiceName;
                        row.Cells[1].Value = account.Username;
                        row.Cells[2].Value = "Copy to clipboard!";
                        accountsTable.Rows.Add(row);
                    }
                }
                catch(Exception ex)
                {
                    _phraseHash = null;
                    MessageBox.Show("Incorrect password!", "Password Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("Error: {0}", ex);
                }
            }
            else
                MessageBox.Show("You must enter a password");
            
        }

        private void accountsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            switch (e.ColumnIndex)
            {
                case 2:
                    var accountCopy = _profile.Accounts[e.RowIndex];
                    Clipboard.SetText(Crypto.DecryptStringAES(accountCopy.EncryptedPassword, _phraseHash.PhraseHash));
                    break;
                case 3:
                    var accountRemove = _profile.Accounts[e.RowIndex];
                    _profile.Accounts.Remove(accountRemove);
                    Database.SaveProfile(_profile);
                    senderGrid.Rows.Remove(senderGrid.Rows[e.RowIndex]);
                    break;
            }
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(serviceInput.Text) && !string.IsNullOrEmpty(usernameInput.Text))
            {
                var service = serviceInput.Text.ToLower();
                var username = usernameInput.Text.ToLower();
                var password = Crypto.GenerateHashWithSeed(service + username, _phraseHash.PhraseHash);
                var encryptedpassword = Crypto.EncryptStringAES(password, _phraseHash.PhraseHash);

                var newAccount = new Database.Account(serviceInput.Text, usernameInput.Text, encryptedpassword);

                if (!_profile.Accounts.Contains(newAccount))
                {
                    _profile.Accounts.Add(newAccount);
                    Database.SaveProfile(_profile);
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
                    MessageBox.Show("You already have an account for that service and username.");
            }
            else
                MessageBox.Show("You must enter a service and username.");
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            profileSelect.SelectedItem = profileSelect.Items[0];
            profileSelect_SelectedIndexChanged(new object(), new EventArgs());
        }

        private void deleteProfileButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really delete?", "Delete account", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.Yes) return;
            
            Database.DeleteProfile(_profile.Name);
            profileSelect.Items.Remove(profileSelect.SelectedItem);
                
            if (profileSelect.Items.Count == 0)
                profileSelect.Items.Add("No Profiles Found");
                
            profileSelect.SelectedItem = profileSelect.Items[0];
            profileSelect_SelectedIndexChanged(new object(), new EventArgs());
        }

    }
}
