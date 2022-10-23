using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopStickyNote.Properties;
using DesktopStickyNote.Theme;

namespace DesktopStickyNote
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            checkBoxAllwaseVisible.Checked = Settings.Default.AllwaseVisible;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            ActiveSection.ActiveButton(sender, panelSideMenu);
            panelSetting.Dock = DockStyle.Fill;
            panelSetting.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveSection.ActiveButton(sender, panelSideMenu);
        }

        private void checkBoxAllwaseVisible_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.AllwaseVisible = checkBoxAllwaseVisible.Checked;
            Settings.Default.Save();
        }
    }
}
