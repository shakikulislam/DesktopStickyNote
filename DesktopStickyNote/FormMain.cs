using System;
using System.Drawing;
using System.Windows.Forms;
using DesktopStickyNote.Properties;

namespace DesktopStickyNote
{
    public partial class FormMain : Form
    {
        private int _dWidth;
        private int _dHeight;
        private int _formLocationX;
        private int _formLocationY;
        private int _formHeightDefault = 250;
        private int _formWidthDefault = 220;
        private int _formHeight;
        private int _formWidth;

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
                
                richTextBoxNote.Text = GlobalSs.GetValue(GlobalSs.KeyVariable.Note) ?? "";

                var events = GlobalSs.GetValue(GlobalSs.KeyVariable.Events);
                GlobalSs.Events = !string.IsNullOrEmpty(events) ? events.Split('|') : null;

                var remainTime = GlobalSs.GetValue(GlobalSs.KeyVariable.RemainTime);
                if (remainTime != null)
                {
                    var time = remainTime.Split('.');
                    if (time.Length == 2)
                    {
                        GlobalSs.RemainTimeHour = int.Parse(time[0]);
                        GlobalSs.RemainTimeMinutes = int.Parse(time[1]);
                    }
                }

                var position = GlobalSs.GetValue(GlobalSs.KeyVariable.Position);
                if (position != null)
                {
                    var positionCode = int.Parse(position);
                    if (positionCode >= 1 && positionCode <= 9)
                    {
                        GlobalSs.CurrentPosition = (GlobalSs.Position) positionCode;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            richTextBoxNote.Font = GlobalSs.GetFont();
            richTextBoxNote.ForeColor = GlobalSs.FontColor;


            ViewSticky(true);
        }

        private void ViewSticky(bool loadTime = false, bool mouseHover = false)
        {
            if (loadTime)
            {
                _dHeight = Screen.GetWorkingArea(this).Height;
                _dWidth = Screen.GetWorkingArea(this).Width;

                switch (GlobalSs.CurrentPosition)
                {
                    case GlobalSs.Position.LeftBottom:
                        _formWidth = _formWidthDefault;
                        _formHeight = _dHeight - 150;
                        _formLocationX = GlobalSs.AlwaysVisible ? 0 : -_formWidth + 1;
                        _formLocationY = _dHeight - _formHeight;
                        break;
                    case GlobalSs.Position.LeftCenter:
                        _formWidth = _formWidthDefault;
                        _formHeight = _dHeight - 150;
                        _formLocationX = GlobalSs.AlwaysVisible ? 0 : -_formWidth + 1;
                        _formLocationY = (_dHeight / 2) - (_formHeight / 2);
                        break;
                    case GlobalSs.Position.LeftTop:
                        _formWidth = _formWidthDefault;
                        _formHeight = _dHeight - 150;
                        _formLocationX = GlobalSs.AlwaysVisible ? 0 : -_formWidth + 1;
                        _formLocationY = 0;
                        break;
                    case GlobalSs.Position.TopLeft:
                        _formWidth = _dWidth - 500;
                        _formHeight = _formHeightDefault;
                        _formLocationX = 0;
                        _formLocationY = GlobalSs.AlwaysVisible ? 0 : -_formHeight + 1;
                        break;
                    case GlobalSs.Position.TopCenter:
                        _formWidth = _dWidth - 500;
                        _formHeight = _formHeightDefault;
                        _formLocationX = (_dWidth / 2) - (_formWidth / 2);
                        _formLocationY = GlobalSs.AlwaysVisible ? 0 : -_formHeight + 1;
                        break;
                    case GlobalSs.Position.TopRight:
                        _formWidth = _dWidth - 500;
                        _formHeight = _formHeightDefault;
                        _formLocationX = _dWidth - _formWidth;
                        _formLocationY = GlobalSs.AlwaysVisible ? 0 : -_formHeight + 1;
                        break;
                    case GlobalSs.Position.RightTop:
                        _formWidth = _formWidthDefault;
                        _formHeight = _dHeight - 150;
                        _formLocationX = GlobalSs.AlwaysVisible ? _dWidth - _formWidth : _dWidth - 1;
                        _formLocationY = 0;
                        break;
                    case GlobalSs.Position.RightCenter:
                        _formWidth = _formWidthDefault;
                        _formHeight = _dHeight - 150;
                        _formLocationX = GlobalSs.AlwaysVisible ? _dWidth - _formWidth : _dWidth - 1;
                        _formLocationY = (_dHeight / 2) - (_formHeight / 2);
                        break;
                    case GlobalSs.Position.RightBottom:
                        _formWidth = _formWidthDefault;
                        _formHeight = _dHeight - 150;
                        _formLocationX = GlobalSs.AlwaysVisible ? _dWidth - _formWidth : _dWidth - 1;
                        _formLocationY = _dHeight - _formHeight;
                        break;
                }

                this.Width = _formWidth;
                this.Height = _formHeight;
            }
            else
            {
                if (mouseHover)
                {
                    if (!GlobalSs.AlwaysVisible)
                    {
                        switch (GlobalSs.CurrentPosition)
                        {
                            case GlobalSs.Position.LeftBottom:
                            case GlobalSs.Position.LeftCenter:
                            case GlobalSs.Position.LeftTop:
                                _formLocationX = 0;
                                break;
                            case GlobalSs.Position.TopLeft:
                            case GlobalSs.Position.TopCenter:
                            case GlobalSs.Position.TopRight:
                                _formLocationY = 0;
                                break;
                            case GlobalSs.Position.RightTop:
                            case GlobalSs.Position.RightCenter:
                            case GlobalSs.Position.RightBottom:
                                _formLocationX = _dWidth - _formWidth;
                                break;
                        }
                    }
                }
                else
                {
                    if (!GlobalSs.AlwaysVisible)
                    {
                        var mousePositionX = MousePosition.X;
                        var mousePositionY = MousePosition.Y;

                        switch (GlobalSs.CurrentPosition)
                        {
                            case GlobalSs.Position.LeftBottom:
                            case GlobalSs.Position.LeftCenter:
                            case GlobalSs.Position.LeftTop:
                                if (mousePositionX >= (this.Location.X + _formWidth) ||
                                    mousePositionY >= (this.Location.Y + _formHeight) ||
                                    mousePositionY <= this.Location.Y)
                                {
                                    _formLocationX = -_formWidth + 1;
                                }

                                break;
                            case GlobalSs.Position.TopLeft:
                            case GlobalSs.Position.TopCenter:
                            case GlobalSs.Position.TopRight:
                                if (mousePositionX <= this.Location.X ||
                                    mousePositionY >= (this.Location.Y + _formHeight) ||
                                    mousePositionX >= (this.Location.X + _formWidth))
                                {
                                    _formLocationY = -_formHeight + 1;
                                }

                                break;
                            case GlobalSs.Position.RightTop:
                            case GlobalSs.Position.RightCenter:
                            case GlobalSs.Position.RightBottom:
                                if (mousePositionX <= this.Location.X ||
                                    mousePositionY >= (this.Location.Y + _formHeight) ||
                                    mousePositionY <= this.Location.Y)
                                {
                                    _formLocationX = _dWidth - 1;
                                }

                                break;
                        }
                    }
                }
            }

            this.Location = new Point(_formLocationX, _formLocationY);
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
