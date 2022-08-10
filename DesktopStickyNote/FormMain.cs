using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using DesktopStickyNote.Properties;
using Microsoft.Win32;

namespace DesktopStickyNote
{
    public partial class FormMain : Form
    {
        RegistryKey _keyNote = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Desktop Sticky Note", true);

        private int _dWidth = 0;
        private int _dHeight = 0;
        private int _rightCenter = 0;

        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                _dHeight = Screen.GetWorkingArea(this).Height;
                _dWidth = Screen.GetWorkingArea(this).Width;
                _rightCenter = (_dHeight / 2) - (this.Height / 2);

                this.Location = new Point(_dWidth - 1, _rightCenter);

                richTextBoxNote.Text = Settings.Default.noteMessage;

                RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.SetValue("Desktop Sticky Note", Application.ExecutablePath);

                RegistryKey createSubKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
                createSubKey.CreateSubKey("Desktop Sticky Note");
                
                richTextBoxNote.Text = _keyNote.GetValue("Note").ToString();
            }
            catch { }

        }

        private void FormMain_MouseHover(object sender, EventArgs e)
        {
            this.Location = new Point(_dWidth - this.Width, _rightCenter);
        }

        private void FormMain_MouseLeave(object sender, EventArgs e)
        {
            var mousePositionX = MousePosition.X;
            var mousePositionY = MousePosition.Y;
            
            if (mousePositionX<=this.Location.X || mousePositionY>=(this.Location.Y+this.Height) || mousePositionY<=this.Location.Y)
            {
                this.Location = new Point(_dWidth - 1, _rightCenter);
            }
        }

        private void richTextBoxNote_TextChanged(object sender, EventArgs e)
        {
            //Settings.Default.noteMessage = richTextBoxNote.Text;
            //Settings.Default.Save();
            _keyNote.SetValue("Note", richTextBoxNote.Text);
        }

    }
}
