using System;
using System.Linq;
using System.Windows.Forms;

namespace DesktopStickyNote
{
    public partial class FormAlert : Form
    {
        private string _id;
        public FormAlert(string[] singleEvent)
        {
            InitializeComponent();

            _id = singleEvent[0];
            labelCategory.Text = singleEvent[1];
            richTextBoxMessage.Text = singleEvent[4];
            labelToDate.Text = Convert.ToDateTime(singleEvent[3]).ToString("dd-MMM-yy");

            var hour = GlobalSs.RemainTimeHour;
            var minute = GlobalSs.RemainTimeMinutes;
            var showHour = hour < 10 ? "0" + hour : hour.ToString();
            var showMinute = minute < 10 ? "0" + minute : minute.ToString();
            labelRemainAfter.Text = @"Next alert after " + showHour + @"." + showMinute + @" hour";

            GlobalSs.RemainTimerStop = true;
        }

        private void buttonRemainLater_Click(object sender, EventArgs e)
        {
            var today = DateTime.Now;

            var totalMinutes = today.Minute + GlobalSs.RemainTimeMinutes;
            var additionalHours = totalMinutes / 60;
            var newMinutes = totalMinutes % 60;

            var totalHours = today.Hour + GlobalSs.RemainTimeHour + additionalHours;
            var newHours = totalHours % 24;

            var remainingTime = new DateTime(today.Year, today.Month, today.Day, newHours, newMinutes, 0);

            var remainderIdItems = GlobalSs.RemainLaterItems;
            
            if (remainderIdItems!=null)
            {
                var remainLaterIds = remainderIdItems.Split('|').ToList();
                var isFind = false;

                for (int i = 0; i < remainLaterIds.Count; i++)
                {
                    var remainItem = remainLaterIds[i].Split(',');

                    if (remainItem[0] == _id)
                    {
                        remainItem[1] = remainingTime.ToString("");

                        remainLaterIds[i] = string.Join(",", remainItem);
                        isFind = true;
                        break;
                    }
                }

                if (isFind)
                {
                    GlobalSs.RemainLaterItems = string.Join("|", remainLaterIds);
                }
                else
                {
                    GlobalSs.RemainLaterItems = GlobalSs.RemainLaterItems + "|" + _id + "," + remainingTime;
                }
            }
            else
            {
                GlobalSs.RemainLaterItems = _id + "," + remainingTime;
            }

            GlobalSs.RemainTimerStop = false;
            Close();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure! Remove this EVENT", @"Confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) != DialogResult.Yes) return;

            // Remove Remain Later Item
            var remainderList = GlobalSs.RemainLaterItems.Split('|').ToList();

            remainderList.RemoveAll(s =>
            {
                var remainRemoveItem = s.Split(',');
                return remainRemoveItem[0] == _id;
            });

            var newRemainList = string.Join("|", remainderList);
            GlobalSs.RemainLaterItems = newRemainList;

            // Remove Event From Store
            var eventList = GlobalSs.Events.ToList();

            eventList.RemoveAll(ss =>
            {
                var eventItems = ss.Split('~');
                return eventItems[0] == _id;
            });

            var newList = string.Join("|", eventList);
            GlobalSs.SetValue("Events", newList);

            var events = GlobalSs.GetValue("Events");
            GlobalSs.Events = !string.IsNullOrEmpty(events) ? events.Split('|') : null;

            GlobalSs.RemainTimerStop = false;
            Close();
        }
    }
}
