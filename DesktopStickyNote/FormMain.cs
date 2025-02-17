using System;
using System.Drawing;
using System.Windows.Forms;

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

            panelTitleBar.BackColor = GlobalSs.ThemeTopBarBackColor;
            panelFooter.BackColor = GlobalSs.ThemeFooterBarBackColor;
            base.BackColor = GlobalSs.ThemeBodyBackColor;
            richTextBoxNote.BackColor = GlobalSs.ThemeBodyBackColor;
            richTextBoxNote.ForeColor = GlobalSs.ThemeBodyTextColor;
            linkLabelTotalEvent.ForeColor = GlobalSs.ThemeBodyTextColor;
            linkLabelTotalEvent.LinkColor = GlobalSs.ThemeBodyTextColor;
            linkLabelTotalEvent.ActiveLinkColor = GlobalSs.ThemeBodyTextColor;
            linkLabelTotalEvent.VisitedLinkColor = GlobalSs.ThemeBodyTextColor;
            linkLabelTotalEvent.DisabledLinkColor = GlobalSs.ThemeBodyTextColor;

            richTextBoxNote.Text = GlobalSs.GetValue(GlobalSs.KeyVariable.Note) ?? "";
            richTextBoxNote.Font = GlobalSs.GetFont();
            
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
                linkLabelTotalEvent.Text = @"Total Events " + GlobalSs.Events.Length;
                linkLabelTotalEvent.Refresh();

                var remainder=new string[0];
                
                if (GlobalSs.RemainLaterItems!=null)
                {
                    remainder = GlobalSs.RemainLaterItems.Split('|');

                }

                var today = DateTime.Now;

                foreach (var events in GlobalSs.Events)
                {
                    var @event = events.Split('~');
                    var eventDate = Convert.ToDateTime(@event[3]);
                    if (today >= eventDate)
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
                linkLabelTotalEvent.Text = @"Total Events 0";
                linkLabelTotalEvent.Refresh();
            }

        }

        private void linkLabelTotalEvent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormSettings(true).ShowDialog();
        }

    }
}
