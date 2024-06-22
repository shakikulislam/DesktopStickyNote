using System;
using System.Drawing;
using System.Windows.Forms;
using DesktopStickyNote.Properties;
using Microsoft.Win32;

namespace DesktopStickyNote
{
    public partial class FormMain : Form
    {
        public RegistryKey _keyNote = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Desktop Sticky Note", true);
        public string[] _font = { "Microsoft Sans Serif", "10", "Regular" };
        public Font _newFont;

        private int _dWidth = 0;
        private int _dHeight = 0;
        private int _rightCenter = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        private void ViewSticky(bool loadTime = false, bool mouseHover = false)
        {
            var allwaseVisible = Settings.Default.AllwaseVisible;
            if (loadTime)
            {
                _dHeight = Screen.GetWorkingArea(this).Height;
                _dWidth = Screen.GetWorkingArea(this).Width;
                this.Height = _dHeight - 150;
                _rightCenter = (_dHeight / 2) - (this.Height / 2);

                if (allwaseVisible)
                {
                    this.Location = new Point(_dWidth - this.Width, _rightCenter);
                }
                else
                {
                    this.Location = new Point(_dWidth - 1, _rightCenter);
                }
                
            }
            else
            {
                if (mouseHover)
                {
                    if (!allwaseVisible)
                    {
                        this.Location = new Point(_dWidth - this.Width, _rightCenter);
                    }
                }
                else
                {
                    if (!allwaseVisible)
                    {
                        var mousePositionX = MousePosition.X;
                        var mousePositionY = MousePosition.Y;

                        if (mousePositionX <= this.Location.X || mousePositionY >= (this.Location.Y + this.Height) ||
                            mousePositionY <= this.Location.Y)
                        {
                            this.Location = new Point(_dWidth - 1, _rightCenter);
                        }
                    }
                }

            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                ViewSticky(true);

                richTextBoxNote.Text = Settings.Default.noteMessage;

                //Autorun path when Windows starts
                RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.SetValue("Desktop Sticky Note", Application.ExecutablePath);

                //Store key create
                RegistryKey createSubKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
                createSubKey.CreateSubKey("Desktop Sticky Note");

                _font = _keyNote.GetValue("Font").ToString().Split(',');

                richTextBoxNote.Text = _keyNote.GetValue("Note").ToString();
                
            }
            catch { }

            _newFont = new Font(_font[0], float.Parse(_font[1]), (FontStyle)Enum.Parse(typeof(FontStyle), _font[2]));
            richTextBoxNote.Font = _newFont;
            richTextBoxNote.ForeColor = Color.Black;
        }

        private void FormMain_MouseHover(object sender, EventArgs e)
        {
            ViewSticky(false, true);
        }

        private void FormMain_MouseLeave(object sender, EventArgs e)
        {
            ViewSticky(false, false);
        }

        private void richTextBoxNote_TextChanged(object sender, EventArgs e)
        {
            _keyNote.SetValue("Note", richTextBoxNote.Text);

            richTextBoxNote.Font = _newFont;
            richTextBoxNote.Refresh();
            Application.DoEvents();
        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            new FormSettings().ShowDialog();
        }

    }
}
