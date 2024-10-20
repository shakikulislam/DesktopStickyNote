using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DesktopStickyNote.Properties;
using DesktopStickyNote.Theme;

namespace DesktopStickyNote
{
    public partial class FormSettings : Form
    {
        private string _categories;
        private string _dateFormat = "dd-MMM-yy HH:mm:ss";
        private string _events;

        public FormSettings()
        {
            InitializeComponent();
            LoadSettings();

            var newFont = GlobalSs.GetFont();

            labelFontFamily.Text = newFont.Name;
            labelFontFamily.ForeColor = GlobalSs.FontColor;
            labelFontSize.Text = newFont.Size.ToString("");
            labelFontStyle.Text = newFont.Style.ToString();

            RemainderTimeLoad();
        }

        private void RemainderTimeLoad()
        {
            for (var s = 0; s <= 12; s++)
            {
                comboBoxRemainderHour.Items.Add(s < 10 ? "0" + s : s.ToString());
            }

            for (var s = 1; s <= 59; s++)
            {
                comboBoxRemainderMunite.Items.Add(s < 10 ? "0" + s : s.ToString());
            }

            var hour = GlobalSs.RemainTimeHour;
            var minute = GlobalSs.RemainTimeMinutes;
            var showHour = hour < 10 ? "0" + hour : hour.ToString();
            var showMinute = minute < 10 ? "0" + minute : minute.ToString();
            comboBoxRemainderHour.Text = showHour;
            comboBoxRemainderMunite.Text = showMinute;
            labelNewRemainderTime.Text = showHour + @"." + showMinute;
        }

        private void LoadEvent()
        {
            try
            {
                _events = GlobalSs.GetValue(GlobalSs.KeyVariable.Events);

                if (!string.IsNullOrEmpty(_events))
                {
                    listViewEventList.Items.Clear();

                    GlobalSs.Events = _events.Split('|');
                    foreach (var @event in GlobalSs.Events)
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
                GlobalSs.Category = GlobalSs.GetValue(GlobalSs.KeyVariable.Category);
                _categories = GlobalSs.Category;

                if (!string.IsNullOrEmpty(_categories))
                {
                    comboBoxCaregory.Items.Clear();
                    listViewCategory.Items.Clear();

                    var categories = _categories.Split('|');
                    foreach (var category in categories)
                    {
                        var item = category.Split('~');

                        comboBoxCaregory.Items.Add(item[1]);

                        var lvi = new ListViewItem(item[0]);
                        lvi.SubItems.Add(item[1]);

                        listViewCategory.Items.Add(lvi);
                    }
                    comboBoxCaregory.Refresh();
                }

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

            dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerFrom.CustomFormat = _dateFormat;

            dateTimePickerTo.Format = DateTimePickerFormat.Custom;
            dateTimePickerTo.CustomFormat = _dateFormat;

            groupBoxCategory.Location = new Point(10, 70);
            groupBoxCategory.Height = 180;
            groupBoxCategory.Visible = false;

            groupBoxEvent.Location=new Point(10,70);
            groupBoxEvent.Height = 180;
            groupBoxEvent.Visible = true;

            LoadCategory();
            LoadEvent();
        }

        private void checkBoxAlwaysVisible_CheckedChanged(object sender, EventArgs e)
        {
            GlobalSs.SetValue(GlobalSs.KeyVariable.AlwaysVisible, checkBoxAlwaysVisible.Checked.ToString());
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

                GlobalSs.SetValue(GlobalSs.KeyVariable.Font, fontDtl);
                GlobalSs.SetValue(GlobalSs.KeyVariable.FontColor, fontDialog.Color.Name);

                fontDialog.Dispose();

                if (MessageBox.Show(@"Restart Application for Change"+Environment.NewLine+@"Press 'Cancel or Close' for Restart Letter", @"Restart", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
        }

        private void pictureBoxAddCategory_Click(object sender, EventArgs e)
        {
            if (pictureBoxAddCategory.Tag == null)
            {
                groupBoxEvent.Visible = false;
                groupBoxCategory.Visible = true;

                pictureBoxAddCategory.Image = Resources.minus_64;
                pictureBoxAddCategory.Tag = "update";
            }
            else if (pictureBoxAddCategory.Tag.ToString() == "update")
            {
                if (buttonCancelCategory.Visible)
                {
                    buttonCancelCategory.PerformClick();
                }

                groupBoxEvent.Visible = true;
                groupBoxCategory.Visible = false;

                pictureBoxAddCategory.Image = Resources.edit_property_64;
                pictureBoxAddCategory.Tag = null;
            }

        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            var category = textBoxNewCategory.Text.Trim();

            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show(@"Please Enter Category", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (buttonAddCategory.Text == @"Add Category")
            {
                var date = DateTime.Now;
                var id = date.Year.ToString().Substring(2) + "" + date.Month + "" + date.Day + "" + date.Hour + "" + date.Minute + "" + date.Second;

                var newCategory = id + "~" + category;

                var allCategories = string.IsNullOrEmpty(_categories) ? newCategory : _categories + "|" + newCategory;

                try
                {
                    GlobalSs.SetValue(GlobalSs.KeyVariable.Category, allCategories);
                }
                catch
                {
                    //
                }
            }
            else if (buttonAddCategory.Text == @"Update")
            {
                if (string.IsNullOrEmpty(_categories)) return;

                var categoryList = _categories.Split('|').ToList();

                for (int i = 0; i < categoryList.Count; i++)
                {
                    var categoryItems = categoryList[i].Split('~');

                    if (categoryItems[0] == textBoxNewCategory.Tag.ToString())
                    {
                        categoryItems[1] = category;

                        categoryList[i] = string.Join("~", categoryItems);
                        break;
                    }
                }

                var newList = string.Join("|", categoryList);
                GlobalSs.SetValue(GlobalSs.KeyVariable.Category, newList);
            }

            LoadCategory();

            comboBoxCaregory.Text = category;

            groupBoxCategory.Visible = false;
            groupBoxEvent.Visible = true;
            pictureBoxAddCategory.Image = Resources.edit_property_64;
            pictureBoxAddCategory.Tag = null;
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
                    GlobalSs.SetValue(GlobalSs.KeyVariable.Events, allEvents);
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
                GlobalSs.SetValue(GlobalSs.KeyVariable.Events, newList);
            }

            LoadEvent();

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

                groupBoxEvent.Text = @"Update/Delete Event";
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

            groupBoxEvent.Text = @"New Event";
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
                GlobalSs.SetValue(GlobalSs.KeyVariable.Events, newList);

                LoadEvent();
            }
            catch
            {
                //
            }
        }

        private void buttonCancelCategory_Click(object sender, EventArgs e)
        {
            buttonDeleteCategory.Visible = false;
            buttonCancelCategory.Visible = false;
            textBoxNewCategory.Tag = null;
            textBoxNewCategory.Clear();
            textBoxNewCategory.Focus();

            buttonAddCategory.Text = @"Add Category";
            groupBoxCategory.Text = @"New Category";
            buttonAddCategory.Text = @"Add Category";
        }

        private void listViewCategory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var lv = listViewCategory.SelectedItems;
            if (lv.Count == 1)
            {
                buttonAddCategory.Text = @"Update";
                buttonCancelCategory.Visible = true;
                buttonDeleteCategory.Visible = true;

                textBoxNewCategory.Tag = lv[0].SubItems[columnHeaderCategoryId.Index].Text;
                textBoxNewCategory.Text = lv[0].SubItems[columnHeaderCategoryName.Index].Text;
                
                groupBoxCategory.Text = @"Update/Delete Category";
            }
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_categories)) return;

                var categories = _categories.Split('|').ToList();

                categories.RemoveAll(s =>
                {
                    var items = s.Split('~');
                    return items[0] == textBoxNewCategory.Tag.ToString();
                });

                var newList = string.Join("|", categories);
                GlobalSs.SetValue(GlobalSs.KeyVariable.Category, newList);

                LoadCategory();
            }
            catch
            {
                //
            }
        }

        private void buttonRemainderUpdate_Click(object sender, EventArgs e)
        {
            GlobalSs.SetValue(GlobalSs.KeyVariable.RemainTime,labelNewRemainderTime.Text);
            GlobalSs.RemainTimeHour = int.Parse(comboBoxRemainderHour.Text);
            GlobalSs.RemainTimeMinutes = int.Parse(comboBoxRemainderMunite.Text);

            MessageBox.Show(@"Remaining Time Updated", @"Confirmation", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void comboBoxRemainderHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelNewRemainderTime.Text = comboBoxRemainderHour.Text + @"." + comboBoxRemainderMunite.Text;
        }
    }
}
