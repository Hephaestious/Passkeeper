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
    public partial class LoginForm : Form
    {
        private string Password { get { return passwordInput.Text; } }
        private ProfileButton _Button;
        private Profile _Profile;
        private Action<string, ProfileButton, Profile> Callback;
        public LoginForm(ProfileButton parentButton, Profile profile, Action<string, ProfileButton, Profile> callback)
        {
            InitializeComponent();
            passwordInput.Text = null;
            loggingIntoLabel.Text = "~\\Profiles>login " + profile.ProfileName;
            _Profile = profile;
            _Button = parentButton;
            Callback = callback;
            FormClosed += LoginForm_FormClosed;
            Point parentAbsolutePosition = parentButton.PointToScreen(Point.Empty);
            int x = parentAbsolutePosition.X + 227;
            int y = parentAbsolutePosition.Y;
            //loginButton.MouseLeave += loginButton_MouseLeave;
            //loginButton.MouseEnter += loginButton_MouseEnter;
            Location = new Point(x, y);
            passwordInput.PreviewKeyDown += passwordInput_PreviewKeyDown;
            Paint += Main_Paint;
            //loginButton.Click +=loginButton_Click;
        }

        private void LoginForm_FormClosed(object sender, EventArgs e)
        {
            // I use a callback here with form.Show() instead of just using form.ShowDialog() because I want
            // the login form to close when you click the main form and with ShowDialog() that causes an
            // annoying dinging sound when the password input has focus
            Callback(Password, _Button, _Profile);
        }



        protected override void OnLeave(EventArgs e)
        {
            Close();
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {

            //e.Graphics.DrawRectangle(new Pen(Color.Red, 3),
                                     //DisplayRectangle);
        }

        private void passwordInput_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter;
            if (e.IsInputKey)
            {
                Close();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
