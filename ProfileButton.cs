using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordManager.Properties;

namespace PasswordManager
{
    public sealed class ProfileButton : Button
    {
        public string ProfileName;

        public ProfileButton(string profilename)
        {
            ProfileName = profilename;
            TextImageRelation = TextImageRelation.ImageBeforeText;
            ImageAlign = ContentAlignment.MiddleLeft;
            Margin = new Padding(0, 0, 0, 0);
            Padding = Margin;
            Image = Resources.locked_icon;
            Font = new Font("Courier New", 16);
            BackColor = Color.Lime;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            Text = profilename;
            Width = 160;
            Height = 38;
            ForeColor = Color.Black;
            Cursor = Cursors.Hand;
        }

        public void Lock()
        {
            Image = Resources.unlocked_icon;
        }

        public void UnLock()
        {
            Image = Resources.unlocked_icon;
        }
    }
}
