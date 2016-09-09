using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PasswordManager
{
    public partial class PasswordManagerForm : Form
    {
        // Set form variables
        private List<Database.Profile> _profiles; // List of profile objects
        private Database.Profile _profile; // Current selected profile
        private Database.PhraseHashJson _phraseHash; // Phrase hash object for current profile

        // Load form
        public PasswordManagerForm()
        {
            InitializeComponent();
            LoadProfiles();
        }

        // Load profiles from database into profile objects list and profile selection box
        private void LoadProfiles()
        {
            profileSelect.Items.Clear(); // Empty profile selection list
            _profiles = Database.GetProfiles(); // Get profile objects from database
            // Load profiles into profile selection box 
            if (_profiles.Count != 0)
                foreach (var profile in _profiles)
                    profileSelect.Items.Add(profile.Name);
            else 
                profileSelect.Items.Add("No Profiles Found");
        }

        // Create profile button clicked
        private void createProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create form for new profile and make it the active form
            var newProfileForm = new NewProfileForm();
            newProfileForm.ShowDialog();
            // This point is reached once the form is closed, so we can now reload the list of profiles
            LoadProfiles();
        }

        // Import profile button clicked
        private void importProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create form for importing a profile and make it the active form
            var importForm = new Import_Profile();
            importForm.ShowDialog();
            // This point is reached once the form is closed, so we can now reload the list of profiles
            LoadProfiles();
        }

        // Selected profile changed
        private void profileSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            accountsTable.Rows.Clear(); // Clear accounts table

            // Make sure a profile is selected
            if (profileSelect.SelectedItem.ToString() != "No Profiles Found")
            {
                _profile = Database.GetProfile(profileSelect.SelectedItem.ToString()); // Gets profile info from database
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
            // Selected item is null profile indicator
            else
            {
                _profile = null;
                deleteProfileButton.Visible = false;
                passwordInput.Text = null;
                serviceInput.Text = null;
                usernameInput.Text = null;
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

        // Login button clicked
        private void logInButton_Click(object sender, EventArgs e)
        {
            // Make sure password input is not empty
            if (!string.IsNullOrEmpty(passwordInput.Text))
            {
                var passwordHash = Crypto.GenerateHash(passwordInput.Text); // Get password hash
                
                // Verify password is correct
                try
                {
                    var encryptedphrasehash = Crypto.DecryptStringAES(_profile.PhraseHash, passwordHash); // Try to decrypt profile with given password, throws if invalid
                    _phraseHash = JsonConvert.DeserializeObject<Database.PhraseHashJson>(encryptedphrasehash); // Get phrase hash from decrypted profile

                    // Clear inputs
                    passwordInput.Text = null;
                    serviceInput.Text = null;
                    usernameInput.Text = null;

                    // Hide elements for logging in
                    passwordLabel.Visible = false;
                    passwordInput.Visible = false;
                    logInButton.Visible = false;

                    // Display elements for profile, including logout button and all account elements
                    accountsTable.Visible = true;
                    accountsLabel.Visible = true;
                    addAccountLabel.Visible = true;
                    serviceInput.Visible = true;
                    serviceLabel.Visible = true;
                    usernameInput.Visible = true;
                    usernameLabel.Visible = true;
                    addAccountButton.Visible = true;
                    logOutButton.Visible = true;

                    // Load accounts from profile
                    foreach (var account in _profile.Accounts)
                    {
                        DisplayAccount(account.ServiceName, account.Username);
                    }
                }
                // Decryption failed, password was incorrect
                catch(Exception ex)
                {
                    _phraseHash = null; // Clear phrase hash variable
                    MessageBox.Show("Incorrect password!", "Password Manager", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display incorrect password alert
                }
            }
            // Password input not filled out
            else
                MessageBox.Show("You must enter a password");
            
        }

        // Cell in accounts table clicked
        private void accountsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender; // Get accounts table

            // Check which cell was clicked
            switch (e.ColumnIndex)
            {
                case 2: // Copy password cell clicked
                    var accountCopy = _profile.Accounts[e.RowIndex]; // Get account for selected row
                    Clipboard.SetText(Crypto.DecryptStringAES(accountCopy.EncryptedPassword, _phraseHash.PhraseHash)); // Copy account password to clipboard
                    break;
                case 3: // Delete account cell clicked
                    var accountRemove = _profile.Accounts[e.RowIndex]; // Get account for selected row
                    _profile.Accounts.Remove(accountRemove); // Remove account from profile in database
                    Database.SaveProfile(_profile); // Save changes
                    senderGrid.Rows.Remove(senderGrid.Rows[e.RowIndex]); // Remove row for account
                    break;
            }
        }

        // Add account button clicked
        private void addAccountButton_Click(object sender, EventArgs e)
        {
            // Check if service and username forms are filled out
            if (!string.IsNullOrEmpty(serviceInput.Text) && !string.IsNullOrEmpty(usernameInput.Text))
            {
                // Get inputs
                var service = serviceInput.Text.ToLower(); // Get service name from input form
                var username = usernameInput.Text.ToLower(); // Get username from input form

                // Generate secure password
                var password = Crypto.GenerateHashWithSeed(service + username, _phraseHash.PhraseHash); // Create a hash of service+username with phrase hash for profile as seed
                var encryptedpassword = Crypto.EncryptStringAES(password, _phraseHash.PhraseHash); // Encrypt the password with the phrase hash

                var newAccount = new Database.Account(service, username, encryptedpassword); // Create account object

                // Make sure profile does not already have an account with that name
                if (!_profile.Accounts.Contains(newAccount))
                {
                    // Add account to profile
                    _profile.Accounts.Add(newAccount); // Add account to profile objects list
                    Database.SaveProfile(_profile); // Save account in database
                    DisplayAccount(newAccount.ServiceName, newAccount.Username); // Add account to accounts table

                    // Clear inputs
                    serviceInput.Text = null; 
                    usernameInput.Text = null;
                }
                // Account already exists
                else 
                    MessageBox.Show("You already have an account for that service and username.");
            }
            // Inputs are not filled out
            else
                MessageBox.Show("You must enter a service and username.");
        }

        // Logout button clicked
        private void logOutButton_Click(object sender, EventArgs e)
        {
            // Remove all private info for profile
            profileSelect.SelectedItem = profileSelect.Items[0]; // Set selected profile to the first item in the profile selection box
            profileSelect_SelectedIndexChanged(new object(), new EventArgs()); // Trigger selected profile changed event, this will clear phrase/pw and accounts info
        }

        // Delete profile button clicked
        private void deleteProfileButton_Click(object sender, EventArgs e)
        {
            // Confirm that user wants to delete profile
            if (MessageBox.Show("Really delete?", "Delete account", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.Yes) return;
            
            // Remove profile from all resources
            Database.DeleteProfile(_profile.Name); // Remove profile from database
            profileSelect.Items.Remove(profileSelect.SelectedItem); // Remove profile from profile combo box
            _profiles.Remove(_profile); // Remove profile from profile objects list

            // Check if there are any profiles left
            if (profileSelect.Items.Count == 0)
                profileSelect.Items.Add("No Profiles Found"); // Indicate that there are no profiles
            
            // Handle selection box
            profileSelect.SelectedItem = profileSelect.Items[0]; // Set selected profile to the first item in the profile selection box
            profileSelect_SelectedIndexChanged(new object(), new EventArgs()); // Trigger selected profile changed event
        }

        // Add account to accounts table
        private void DisplayAccount(string servicename, string username)
        {
            var row = new DataGridViewRow(); // Create empty row
            row.CreateCells(accountsTable); // Set row template to conform to accounts table

            // Load cells with account info
            row.Cells[0].Value = servicename; 
            row.Cells[1].Value = username;
            row.Cells[2].Value = "Copy to clipboard";
            accountsTable.Rows.Add(row);
        }
    }
}
