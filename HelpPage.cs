using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    public partial class HelpPage : Component
    {
        public HelpPage()
        {
            InitializeComponent();
        }

        public HelpPage(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
