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
        private int _dWidth = 0;
        private int _dHeight = 0;
        private int _rightCenter = 0;

        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            _dHeight = Screen.GetWorkingArea(this).Height;
            _dWidth = Screen.GetWorkingArea(this).Width;
            _rightCenter = (_dHeight / 2) - (this.Height / 2);

            this.Location = new Point(_dWidth - 1, _rightCenter);

            richTextBoxNote.Text = Settings.Default.noteMessage;

            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            key.SetValue(Application.ProductName,Application.ExecutablePath);
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
            Settings.Default.noteMessage = richTextBoxNote.Text;
            Settings.Default.Save();
        }

    }
}
