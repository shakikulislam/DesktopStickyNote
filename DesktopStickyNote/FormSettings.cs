using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopStickyNote.Theme;

namespace DesktopStickyNote
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            ActiveSection.ActiveButton(sender, panelSideMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveSection.ActiveButton(sender, panelSideMenu);
        }
    }
}
