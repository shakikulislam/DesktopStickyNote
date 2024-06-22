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
        FormMain formMain = new FormMain();
        private Font newFont;
        public FormSettings()
        {

            InitializeComponent();
            LoadSettings();

            var font = formMain._keyNote.GetValue("Font").ToString().Split(',');
            newFont = new Font(font[0], float.Parse(font[1]), (FontStyle)Enum.Parse(typeof(FontStyle), font[2]));

            labelFontFamily.Text = newFont.Name;
            labelFontSize.Text = newFont.Size.ToString();
            labelFontStyle.Text = newFont.Style.ToString();

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

        private void buttonSelectFont_Click(object sender, EventArgs e)
        {
            var fontDialog = new FontDialog() {
                Font = new Label() { Font = newFont }.Font
            };
                        
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                var fontDtl = fontDialog.Font.Name + "," + fontDialog.Font.Size + "," + fontDialog.Font.Style;

                formMain._keyNote.SetValue("Font", fontDtl);

                labelFontFamily.Text = fontDialog.Font.Name.ToString();
                labelFontSize.Text = fontDialog.Font.Size.ToString();
                labelFontStyle.Text = fontDialog.Font.Style.ToString();

                fontDialog.Dispose();

                Application.Restart();
            }
        }
    }
}
