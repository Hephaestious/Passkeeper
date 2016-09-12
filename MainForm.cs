using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PasswordManager.Properties;

namespace PasswordManager
{
    public partial class MainForm : Form
    {
        public static Dictionary<string, ProfileButton> ProfileButtons = new Dictionary<string, ProfileButton>();
        public static ProfileButton ActiveProfileButton;
        public static Profile ActiveProfile;
        private Dictionary<string, Profile> _profiles = new Dictionary<string, Profile>();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public MainForm()
        {
            InitializeComponent();
            pageTabControl.SelectTab(helpPage);
            addAccountButton.MouseEnter += addAccountButton_MouseEnter;
            addAccountButton.MouseLeave += addAccountButton_MouseLeave;
            MouseDown += MainForm_MouseDown;
            accountsTable.CellContentClick += accountsTable_CellContentClick;
            addAccountButton.Click += addAccountButton_Click;
            createProfileButton.Click += createProfileButton_Click;
            createProfileButton.MouseLeave += createProfileButton_MouseLeave;
            createProfileButton.MouseEnter += createProfileButton_MouseEnter;
            importProfileButton.MouseEnter += importProfileButton_MouseEnter;
            importProfileButton.MouseLeave += importProfileButton_MouseLeave;
            importProfileButton.Click += importProfileButton_Click;
            var profiles = Database.GetProfiles(); // Get profile objects from database
            foreach (var profile in profiles)
            {
                Profile newProfile = new Profile(profile);
                _profiles[newProfile.ProfileName] = newProfile;
                AddProfileButton(newProfile.ProfileName);
            }
            //loginForm.Show();
            // Testing
            /*AddProfileButton("stinkboy");
            AddProfileButton("dinkler");
            DisplayAccount("jinsadasd","asdasda");*/
        }

        void importProfileButton_MouseLeave(object sender, EventArgs e)
        {
            importProfileButton.Image = Resources.key_import;
        }

        void importProfileButton_MouseEnter(object sender, EventArgs e)
        {
            importProfileButton.Image = Resources.key_import_dark;
        }

        private void createProfileButton_MouseEnter(object sender, EventArgs e)
        {
            createProfileButton.Image = Resources.key_add_dark;
        }

        private void createProfileButton_MouseLeave(object sender, EventArgs e)
        {
            createProfileButton.Image = Resources.key_add;
        }

        private void addAccountButton_MouseEnter(Object sender, EventArgs e)
        {
            addAccountButton.Image = Resources.add_green_dark;
            addAccountButton.ForeColor = Color.LimeGreen;
        }

        private void addAccountButton_MouseLeave(Object sender, EventArgs e)
        {
            addAccountButton.Image = Resources.add_green;
            addAccountButton.ForeColor = Color.Lime;
        }

        public void DisplayAccount(string servicename, string username)
        {
            var row = new DataGridViewRow(); // Create empty row
            row.CreateCells(accountsTable); // Set row template to conform to accounts table

            // Load cells with account info
            row.Cells[0].Value = servicename;
            row.Cells[1].Value = username;
            accountsTable.Rows.Add(row);
        }

        private void loginForm_Callback(string password, ProfileButton button, Profile profile)
        {
            if (string.IsNullOrEmpty(password)) return;
            if (!profile.Login(password))
            {
                MessageBox.Show("You entered an incorrect password.");
                return;
            }
            button.Image = Resources.unlocked_icon;
            SetActiveProfile(profile, button);
        }

        private void SetActiveProfile(Profile profile, ProfileButton button)
        {
            if (ActiveProfileButton != null)
            {
                ActiveProfileButton.BackColor = Color.Lime; // Set previous active button's color to default
                ActiveProfileButton.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            }
            accountsTable.Rows.Clear();
            ActiveProfile = profile;
            foreach (Database.Account account in profile.GetAccounts())
            {
                DisplayAccount(account.ServiceName, account.Username);
            }
            ActiveProfileButton = button;
            button.BackColor = Color.Gold;
            button.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            ActiveProfile = _profiles[button.ProfileName];
            pageTabControl.SelectTab(accountPage);
            profileNameLabel.Text = profile.ProfileName;
        }

        private void profileButton_Clicked(Object sender, EventArgs e)
        {
            ProfileButton clickedButton = sender as ProfileButton; // Cast sender object to profile button 
            Profile selectedProfile = _profiles[clickedButton.ProfileName]; // Get profile the button references
            // If user is not logged in to selected profile, prompt him for a password
            if (!selectedProfile.LoggedIn)
            {
                // I use a callback here with form.Show() instead of just using form.ShowDialog() because I want
                // the login form to close when you click the main form and with ShowDialog() that causes an
                // annoying dinging sound when the password input has focus
                LoginForm loginForm = new LoginForm(clickedButton, selectedProfile, loginForm_Callback);
                loginForm.Show();
                return;
            }
            SetActiveProfile(selectedProfile, clickedButton);
        }

        public static void SortProfileButtons()
        {
            List<ProfileButton> profileButtonsList = ProfileButtons.Values.OrderBy(pb => pb.ProfileName).ToList();
            for(int i=0;i<profileButtonsList.Count;i++)
            {
                profileButtonsList[i].Location = new Point(0, 46 + (i * 38));
            }
        }

        private void AddProfileButton(string profilename)
        {
            ProfileButton newProfileButton = new ProfileButton(profilename);
            profilePanel.Controls.Add(newProfileButton);
            ProfileButtons[profilename] = newProfileButton;
            newProfileButton.Click += profileButton_Clicked;
            SortProfileButtons();
        }

        private void RemoveProfileButton(string profilename)
        {
            ProfileButton profileButton = ProfileButtons[profilename];
            if (profileButton == null) return;
            profilePanel.Controls.Remove(profileButton);
            ProfileButtons.Remove(profilename);
        }



        private void importProfileButton_Click(object sender, EventArgs e)
        {
            var newImportForm = new Import_Profile {StartPosition = FormStartPosition.CenterParent};
            newImportForm.ShowDialog();
            Profile newProfile = newImportForm.Profile;
            if (newProfile == null) return;
            _profiles[newProfile.ProfileName] = newProfile;
            AddProfileButton(newProfile.ProfileName);
        }

        private void profileDeleteButton_Click(object sender, EventArgs e)
        {
            // Confirm user wants to delete account
            if (MessageBox.Show("Really delete?", "Delete account", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.Yes) return;

            RemoveProfileButton(ActiveProfile.ProfileName);
            ActiveProfile.Delete(); // Remove account from db
            pageTabControl.SelectTab(helpPage); // Set active tab to help page
        }

        private void createProfileButton_Click(object sender, EventArgs e)
        {
            // Create form for new profile and make it the active form
            var newProfileForm = new NewProfileForm();
            newProfileForm.StartPosition = FormStartPosition.CenterParent;
            newProfileForm.ShowDialog();
            if (newProfileForm.NewProfile == null) return;
            Profile newProfile = newProfileForm.NewProfile;
            _profiles[newProfile.ProfileName] = newProfile;
            AddProfileButton(newProfile.ProfileName);
        }


        private void addAccountButton_Click(object sender, EventArgs e)
        {
            AddAccountForm newAccountForm = new AddAccountForm(ActiveProfile);
            newAccountForm.StartPosition = FormStartPosition.CenterParent;
            newAccountForm.ShowDialog();
            string service = newAccountForm.Service;
            string username = newAccountForm.Username;
            string password = newAccountForm.Password;
            if (string.IsNullOrWhiteSpace(service) || string.IsNullOrWhiteSpace(username)) return;
            Database.Account newAccount = ActiveProfile.AddAccount(service, username, password);
            if (newAccount == null)
            {
                MessageBox.Show("You already have an account for that service and username in this profile.");
                return;
            }
            DisplayAccount(service, username);
        }

        private void accountsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check which cell was clicked
            switch (e.ColumnIndex)
            {
                case 2: // Copy password cell clicked
                    string password = ActiveProfile.GetAccountPassword(e.RowIndex); // Get account for selected row
                    Clipboard.SetText(password); // Copy account password to clipboard
                    break;
                case 3: // Delete account cell clicked
                    ActiveProfile.DeleteAccount(e.RowIndex); 
                    accountsTable.Rows.Remove(accountsTable.Rows[e.RowIndex]); // Remove row for account
                    break;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
