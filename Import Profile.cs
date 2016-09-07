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
    public partial class Import_Profile : Form
    {
        public Import_Profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(profileNameInput.Text) && !string.IsNullOrEmpty(profilePasswordInput.Text))
            {
                if (!string.IsNullOrEmpty(phraseInput.Text))
                {
                    bool real = true;
                    var profileName = profileNameInput.Text;
                    if (!Database.IsProfile(profileName))
                    {
                        var profilePassword = profilePasswordInput.Text;
                        var phrase = phraseInput.Text.ToLower();
                        string[] words = phrase.Split(' ');
                        List<string> wordlist = Properties.Resources.wordlist.Split(new[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries).ToList();
                        if (words.Length != 12) real = false;
                        foreach (string word in words)
                        {
                            if (!wordlist.Contains(word)) real = false;
                        }
                        if (real)
                        {
                            Database.CreateProfile(profileName, profilePassword, phrase);
                            MessageBox.Show("Imported profile");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("That is not a valid phrase");
                        }
                    }
                    else
                    {
                        MessageBox.Show("A profile by that name already exists.");
                    }
                }
                else
                {
                    MessageBox.Show("You must input a phrase.");
                }
            }
            else
            {
                MessageBox.Show("You must enter a profile name and password. These do not need to be the original profile name and password.");
            }
        }
    }
}
