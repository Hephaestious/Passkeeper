using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class AddAccountForm : Form
    {
        public string Service { get { return (string.IsNullOrEmpty(serviceInput.Text) ? null : serviceInput.Text); } }
        public string Username { get { return (string.IsNullOrEmpty(usernameInput.Text) ? null : usernameInput.Text); } }
        public bool NewPass;
        public string Password { get { return (string.IsNullOrEmpty(passwordInput.Text)) ? null : passwordInput.Text; } }
        private Char[] yesChars = new Char[2]{'y', 'Y'};
        private Char[] noChars = new Char[2] { 'n', 'N' };
        public AddAccountForm(Profile profile)
        {
            InitializeComponent();
            passwordInput.Text = null;
            firstLineLabel.Text = "~\\Profiles\\" + profile.ProfileName + ">add account";
            serviceInput.KeyPress += serviceInput_KeyPress;
            usernameInput.KeyPress += usernameInput_KeyPress;
            passwordOptionInput.KeyPress += passwordOptionInput_KeyPress;
            passwordInput.KeyPress += passwordInput_KeyPress;
        }

        private void serviceInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char) Keys.Enter)
            {
                if (string.IsNullOrEmpty(serviceInput.Text)) return;
                serviceInput.Enabled = false;
                usernameLabel.Visible = true;
                usernameInput.Visible = true;
                usernameInput.Focus();
                e.Handled = true;
            }
        }

        private void usernameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char) Keys.Enter)
            {
                if (string.IsNullOrEmpty(usernameInput.Text)) return;
                usernameInput.Enabled = false;
                passwordOptionLabel.Visible = true;
                passwordOptionInput.Visible = true;
                passwordOptionInput.Focus();
                e.Handled = true;
            }
        }

        private void passwordOptionInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;
            bool yes = yesChars.Contains(keyChar);
            bool no = noChars.Contains(keyChar);
            e.Handled = (yes | no);
            if (!e.Handled) return;
            if (yes)
            {
                NewPass = true;
                Close();
            }
            NewPass = false;
            passwordOptionInput.Enabled = false;
            passwordLabel.Visible = true;
            passwordInput.Visible = true;
            passwordInput.Focus();
        }

        private void passwordInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char) Keys.Enter)
            {
                if (string.IsNullOrEmpty(passwordInput.Text)) return;
                e.Handled = true;
                Close();
            }
        }
    }
}
