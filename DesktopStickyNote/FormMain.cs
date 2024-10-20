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
                bool.TryParse(GlobalSs.GetValue(GlobalSs.KeyVariable.AlwaysVisible), out alwaysVisible);
                GlobalSs.AlwaysVisible = alwaysVisible;

                var fontColor = GlobalSs.GetValue(GlobalSs.KeyVariable.FontColor);
                if (fontColor != null)
                {
                    GlobalSs.FontColor = Color.FromName(fontColor);
                }

                ViewSticky(true);

                richTextBoxNote.Text = GlobalSs.GetValue(GlobalSs.KeyVariable.Note) ?? "";

                var events = GlobalSs.GetValue(GlobalSs.KeyVariable.Events);
                GlobalSs.Events = !string.IsNullOrEmpty(events) ? events.Split('|') : null;

                var remainTime = GlobalSs.GetValue(GlobalSs.KeyVariable.RemainTime);
                if (remainTime!=null)
                {
                    var time = remainTime.Split('.');
                    if (time.Length==2)
                    {
                        GlobalSs.RemainTimeHour = int.Parse(time[0]);
                        GlobalSs.RemainTimeMinutes= int.Parse(time[1]);
                    }
                }
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
            GlobalSs.SetValue(GlobalSs.KeyVariable.Note, richTextBoxNote.Text.Trim());
        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            new FormSettings().ShowDialog();
        }

        private void timerRemainder_Tick(object sender, EventArgs e)
        {
            if (GlobalSs.RemainTimerStop) return;

            if (GlobalSs.Events != null)
            {
                labelTotalEvents.Text = @"Total Events " + GlobalSs.Events.Length;
                labelTotalEvents.Refresh();

                var remainder=new string[0];
                
                if (GlobalSs.RemainLaterItems!=null)
                {
                    remainder = GlobalSs.RemainLaterItems.Split('|');

                }

                var today = DateTime.Now;

                foreach (var events in GlobalSs.Events)
                {
                    var @event = events.Split('~');
                    var toDate = Convert.ToDateTime(@event[2]);
                    if (today >= toDate)
                    {
                        var showForm = true;
                        foreach (var item in remainder)
                        {
                            var remain = item.Split(',');
                            var remainTime = Convert.ToDateTime(remain[1]);

                            if (@event[0] != remain[0]) continue;

                            showForm = false;

                            if (today >= remainTime)
                            {
                                new FormAlert(@event).ShowDialog();
                            }
                        }

                        if (showForm)
                        {
                            new FormAlert(@event).ShowDialog();
                        }
                    }
                }
            }
            else
            {
                labelTotalEvents.Text = @"Total Events 0";
                labelTotalEvents.Refresh();
            }

        }

    }
}
