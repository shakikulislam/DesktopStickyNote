using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopStickyNote
{
    public partial class FormMain : Form
    {
        private int _dWidth;
        private int _dHeight;
        private int _rightCenter;

        public FormMain()
        {
            InitializeComponent();

            try
            {
                bool alwaysVisible;
                bool.TryParse(GlobalSs.GetValue("AlwaysVisible"), out alwaysVisible);
                GlobalSs.AlwaysVisible = alwaysVisible;

                var fontColor = GlobalSs.GetValue("FontColor");
                if (fontColor != null)
                {
                    GlobalSs.FontColor = Color.FromName(fontColor);
                }

                ViewSticky(true);

                richTextBoxNote.Text = GlobalSs.GetValue("Note") ?? "";

                GlobalSs.Events = GlobalSs.GetValue("Events") ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            richTextBoxNote.Font = GlobalSs.GetFont();
            richTextBoxNote.ForeColor = GlobalSs.FontColor;
        }

        private void ViewSticky(bool loadTime = false, bool mouseHover = false)
        {
            if (loadTime)
            {
                _dHeight = Screen.GetWorkingArea(this).Height;
                _dWidth = Screen.GetWorkingArea(this).Width;
                this.Height = _dHeight - 150;
                _rightCenter = (_dHeight / 2) - (this.Height / 2);

                if (GlobalSs.AlwaysVisible)
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
                    if (!GlobalSs.AlwaysVisible)
                    {
                        this.Location = new Point(_dWidth - this.Width, _rightCenter);
                    }
                }
                else
                {
                    if (!GlobalSs.AlwaysVisible)
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
        
        private void FormMain_MouseHover(object sender, EventArgs e)
        {
            ViewSticky(false, true);
        }

        private void FormMain_MouseLeave(object sender, EventArgs e)
        {
            ViewSticky();
        }

        private void richTextBoxNote_TextChanged(object sender, EventArgs e)
        {
            GlobalSs.SetValue("Note", richTextBoxNote.Text.Trim());
        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            new FormSettings().ShowDialog();
        }

        private void timerRemainder_Tick(object sender, EventArgs e)
        {
            labelTotalEvents.Text = @"Total Events " + GlobalSs.Events.Split('|').Length;
            labelTotalEvents.Refresh();
        }

    }
}
