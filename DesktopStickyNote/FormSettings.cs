using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DesktopStickyNote.Theme;

namespace DesktopStickyNote
{
    public partial class FormSettings : Form
    {
        private readonly Font _newFont;
        private string _categories;
        private string _dateFormat = "dd-MMM-yy HH:mm:ss";
        private string _events;

        public FormSettings()
        {

            InitializeComponent();
            LoadSettings();

            _newFont = GlobalSs.GetFont();

            labelFontFamily.Text = _newFont.Name;
            labelFontFamily.ForeColor = GlobalSs.FontColor;
            labelFontSize.Text = _newFont.Size.ToString("");
            labelFontStyle.Text = _newFont.Style.ToString();


            dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerFrom.CustomFormat = _dateFormat;

            dateTimePickerTo.Format = DateTimePickerFormat.Custom;
            dateTimePickerTo.CustomFormat = _dateFormat;

            LoadCategory();
            LoadEvent();
        }
        
        private void LoadEvent()
        {
            try
            {
                GlobalSs.Events = GlobalSs.GetValue("Events");
                _events = GlobalSs.Events;

                if (!string.IsNullOrEmpty(_events))
                {
                    listViewEventList.Items.Clear();

                    var events = _events.Split('|');
                    foreach (var @event in events)
                    {
                        var item = @event.Split('~');
                        
                        var lvi=new ListViewItem(item[0]);
                        lvi.SubItems.Add(item[1]);
                        lvi.SubItems.Add(Convert.ToDateTime(item[2]).ToString("dd-MMM-yy"));
                        lvi.SubItems.Add(Convert.ToDateTime(item[3]).ToString("dd-MMM-yy"));
                        lvi.SubItems.Add(item[4]);
                        lvi.SubItems.Add(item[2]);
                        lvi.SubItems.Add(item[3]);

                        listViewEventList.Items.Add(lvi);
                    }
                }

                listViewEventList.Refresh();

                if (buttonCancelEvent.Visible)
                {
                    buttonCancelEvent.PerformClick();
                }
                
                Application.DoEvents();
            }
            catch
            {
                //
            }
            
        }
        
        private void LoadCategory()
        {
            try
            {
                _categories = GlobalSs.GetValue("Category");

                comboBoxCaregory.Items.Clear();
                foreach (var category in _categories.Split(','))
                {
                    comboBoxCaregory.Items.Add(category);
                }
                comboBoxCaregory.Refresh();
            }
            catch (Exception)
            {
                //
            }
        }

        private void ShowForm(Control control=null)
        {
            foreach (var pnl in Controls.OfType<Panel>())
            {
                if (pnl.Name != "panelSideMenu" && pnl.Name!="panelTopBar")
                {
                    pnl.Hide();
                }

                if (control != null)
                {
                    var type = control.GetType();

                    if (type == typeof(Panel))
                    {
                        control.Dock = DockStyle.Fill;
                        control.Visible = true;
                    }
                    else if (type==typeof(Form))
                    {
                        
                    }
                }
            }
        }

        private void LoadSettings()
        {
            checkBoxAlwaysVisible.Checked = GlobalSs.AlwaysVisible;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            ActiveSection.ActiveButton(sender, panelSideMenu);
            ShowForm(panelSetting);
        }

        private void buttonReminder_Click(object sender, EventArgs e)
        {
            ActiveSection.ActiveButton(sender, panelSideMenu);
            ShowForm(panelReminder);
            buttonCancelEvent.PerformClick();
        }

        private void checkBoxAlwaysVisible_CheckedChanged(object sender, EventArgs e)
        {
            GlobalSs.SetValue("AlwaysVisible", checkBoxAlwaysVisible.Checked.ToString());
        }

        private void buttonSelectFont_Click(object sender, EventArgs e)
        {
            var fontDialog = new FontDialog()
            {
                Font = GlobalSs.GetFont(),
                ShowColor = true,
                Color = GlobalSs.FontColor
            };

                        
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                var fontDtl = fontDialog.Font.Name + "," + fontDialog.Font.Size + "," + fontDialog.Font.Style;

                GlobalSs.SetValue("Font", fontDtl);
                GlobalSs.SetValue("FontColor", fontDialog.Color.Name);

                fontDialog.Dispose();

                Application.Restart();
            }
        }

        private void pictureBoxAddCategory_Click(object sender, EventArgs e)
        {
            labelNewCategory.Visible = true;
            textBoxNewCategory.Visible = true;
            buttonAddCategory.Visible = true; 
            buttonCancelCategory.Visible = true;

            textBoxNewCategory.Clear();
            textBoxNewCategory.Focus();

            groupBoxEvent.Visible = false;
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            var newCategory = textBoxNewCategory.Text.Trim();

            try
            {
                if (_categories.Split(',').Any(item => item == newCategory))
                {
                    MessageBox.Show(@"This category already exist",@"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    textBoxNewCategory.SelectAll();
                    textBoxNewCategory.Focus();
                    return;
                }
            }
            catch
            {
                //
            }

            if (string.IsNullOrEmpty(_categories))
            {
                _categories = newCategory;
            }
            else
            {
                _categories += "," + newCategory;
            }

            GlobalSs.SetValue("Category", _categories);

            LoadCategory();

            comboBoxCaregory.Text = newCategory;

            buttonCancelCategory.PerformClick();
        }

        private void buttonCancelCategory_Click(object sender, EventArgs e)
        {
            labelNewCategory.Visible = false;
            textBoxNewCategory.Visible = false;
            buttonAddCategory.Visible = false;
            buttonCancelCategory.Visible = false;

            groupBoxEvent.Visible = true;
        }

        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxCaregory.Text))
            {
                MessageBox.Show(@"Please Select Category", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dateTimePickerFrom.Value > dateTimePickerTo.Value)
            {
                MessageBox.Show(@"Invalid Date Range", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var category = comboBoxCaregory.Text;
            var fromDate = dateTimePickerFrom.Value;
            var toDate = dateTimePickerTo.Value;
            var details = string.IsNullOrEmpty(richTextBoxDetails.Text.Trim())
                ? "No Details"
                : richTextBoxDetails.Text.Trim();
            

            if (buttonAddEvent.Text == @"Add Event")
            {
                var date = DateTime.Now;
                var id =  date.Year.ToString().Substring(2) + "" + date.Month + "" + date.Day + "" + date.Hour + "" + date.Minute + "" + date.Second;

                var newEvent = id + "~" + category + "~" + fromDate + "~" + toDate + "~" + details;
            
                var allEvents = string.IsNullOrEmpty(_events) ? newEvent : _events + "|" + newEvent;

                try
                {
                    GlobalSs.SetValue("Events", allEvents);
                    LoadEvent();
                }
                catch 
                {
                    //
                }
            }
            else if (buttonAddEvent.Text == @"Update")
            {
                if (string.IsNullOrEmpty(_events)) return;

                var events = _events.Split('|').ToList();

                for (int i = 0; i < events.Count; i++)
                {
                    var eventItems = events[i].Split('~');

                    if (eventItems[0] == labelRemainder.Tag.ToString())
                    {
                        // Update the event with new details
                        eventItems[1] = category;
                        eventItems[2] = fromDate + "";
                        eventItems[3] = toDate + "";
                        eventItems[4] = details;

                        // Rebuild the updated event string
                        events[i] = string.Join("~", eventItems);
                        break;
                    }
                }

                var newList = string.Join("|", events);
                GlobalSs.SetValue("Events", newList);

                LoadEvent();
            }

        }

        private void listViewEventList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var lv = listViewEventList.SelectedItems;
            if (lv.Count==1)
            {
                buttonAddEvent.Size = new Size(100, 30);
                buttonAddEvent.Text = @"Update";
                pictureBoxDeleteEvent.Visible = true;
                buttonCancelEvent.Visible = true;

                labelRemainder.Tag = lv[0].SubItems[columnHeaderId.Index].Text;
                comboBoxCaregory.Text = lv[0].SubItems[columnHeaderCategory.Index].Text;
                richTextBoxDetails.Text = lv[0].SubItems[columnHeaderDetails.Index].Text;
                dateTimePickerFrom.Value = Convert.ToDateTime(lv[0].SubItems[columnHeaderFromDateFull.Index].Text);
                dateTimePickerTo.Value = Convert.ToDateTime(lv[0].SubItems[columnHeaderToDateFull.Index].Text);
            }
        }

        private void buttonCancelEvent_Click(object sender, EventArgs e)
        {
            labelRemainder.Tag = "";
            richTextBoxDetails.Clear();
            dateTimePickerFrom.Value = DateTime.Today;
            dateTimePickerTo.Value = DateTime.Today;

            buttonAddEvent.Size = new Size(100, 54);
            buttonAddEvent.Text = @"Add Event";
            pictureBoxDeleteEvent.Visible = false;
            buttonCancelEvent.Visible = false;
        }

        private void pictureBoxDeleteEvent_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_events)) return;

                var events = _events.Split('|').ToList();

                // Find and remove the event by ID
                events.RemoveAll(s =>
                {
                    var eventItems = s.Split('~');
                    return eventItems[0] == labelRemainder.Tag.ToString();
                });

                // Join the updated list back into a single string
                var newList = string.Join("|", events);
                GlobalSs.SetValue("Events", newList);

                LoadEvent();
            }
            catch
            {
                //
            }
        }


    }
}
