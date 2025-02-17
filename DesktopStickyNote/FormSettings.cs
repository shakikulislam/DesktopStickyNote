using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DesktopStickyNote.Properties;
using DesktopStickyNote.ThemeDetails;
using System.Diagnostics;

namespace DesktopStickyNote
{
    public partial class FormSettings : Form
    {
        private string _categories;
        private string _dateFormat = "dd-MMM-yy HH:mm:ss";
        private string _events;
        private bool _showEventPanel;

        public FormSettings(bool showEventPanel=false)
        {
            InitializeComponent();
            this.Icon = new FormMain().Icon;

            _showEventPanel = showEventPanel;
        }

        private string PositionNameFormat(string name)
        {
            var stringBuilder = new StringBuilder();
            for (var i = 0; i < name.Length; i++)
            {
                if (i > 0 && char.IsUpper(name[i]))
                {
                    stringBuilder.Append(' ');
                }
                stringBuilder.Append(name[i]);
            }
            return stringBuilder.ToString();
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
                else
                {
                    listViewEventList.Items.Clear();
                    GlobalSs.Events = new string[0];
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

            //Load Font
            var newFont = GlobalSs.GetFont();

            labelFontFamily.Text = newFont.Name;
            labelFontSize.Text = newFont.Size.ToString("");
            labelFontStyle.Text = newFont.Style.ToString();

            //Load Positions in Combobox
            var positionTable = new DataTable();
            positionTable.Columns.Add("Id");
            positionTable.Columns.Add("Name");

            foreach (GlobalSs.Position pos in Enum.GetValues(typeof(GlobalSs.Position)))
            {
                var sIndex = (int)pos;

                var formattedName = PositionNameFormat(pos.ToString());

                positionTable.Rows.Add(sIndex, formattedName);
            }

            comboBoxWindoPosition.ValueMember = "Id";
            comboBoxWindoPosition.DisplayMember = "Name";
            comboBoxWindoPosition.DataSource = positionTable;

            comboBoxWindoPosition.SelectedValue = (int)GlobalSs.CurrentPosition;

            //Remainder Time
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

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            ActiveSection.ActiveButton(sender, panelSideMenu);
            ShowForm(panelSetting);

            LoadSettings();
        }

        private void buttonReminder_Click(object sender, EventArgs e)
        {
            ActiveSection.ActiveButton(sender, panelSideMenu);
            ShowForm(panelReminder);

            dateTimePickerAlertFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerAlertFrom.CustomFormat = _dateFormat;

            dateTimeEventDate.Format = DateTimePickerFormat.Custom;
            dateTimeEventDate.CustomFormat = _dateFormat;

            groupBoxCategory.Location = new Point(10, 70);
            groupBoxCategory.Size = new Size(370, 180);
            groupBoxCategory.Visible = false;

            listViewCategory.Location = new Point(6, 81);
            listViewCategory.Size = new Size(358, 94);

            groupBoxEvent.Location=new Point(10,70);
            groupBoxEvent.Size = new Size(370, 180);
            groupBoxEvent.Visible = true;

            listViewEventList.Location = new Point(10, 256);
            listViewEventList.Size = new Size(370, 175);

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
                Font = GlobalSs.GetFont()
                //ShowColor = true,
                //Color = GlobalSs.FontColor
            };

                        
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                var fontDtl = fontDialog.Font.Name + "," + fontDialog.Font.Size + "," + fontDialog.Font.Style;

                GlobalSs.SetValue(GlobalSs.KeyVariable.Font, fontDtl);
                //GlobalSs.SetValue(GlobalSs.KeyVariable.FontColor, fontDialog.Color.Name);

                fontDialog.Dispose();
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

            if (dateTimePickerAlertFrom.Value > dateTimeEventDate.Value)
            {
                MessageBox.Show(@"Invalid Date Range", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var category = comboBoxCaregory.Text;
            var eventDate = dateTimeEventDate.Value;
            var alertFromDate = dateTimePickerAlertFrom.Value;
            var details = string.IsNullOrEmpty(richTextBoxDetails.Text.Trim())
                ? "No Details"
                : richTextBoxDetails.Text.Trim();
            

            if (buttonAddEvent.Text == @"Add Event")
            {
                var date = DateTime.Now;
                var id =  date.Year.ToString().Substring(2) + "" + date.Month + "" + date.Day + "" + date.Hour + "" + date.Minute + "" + date.Second;

                var newEvent = id + "~" + category + "~" + eventDate + "~" + alertFromDate + "~" + details;
            
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
                        eventItems[2] = eventDate + "";
                        eventItems[3] = alertFromDate + "";
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
                dateTimeEventDate.Value = Convert.ToDateTime(lv[0].SubItems[columnHeaderEventDateFull.Index].Text);
                dateTimePickerAlertFrom.Value = Convert.ToDateTime(lv[0].SubItems[columnHeaderAlertFromDateFull.Index].Text);

                groupBoxEvent.Text = @"Update/Delete Event";
            }
        }

        private void buttonCancelEvent_Click(object sender, EventArgs e)
        {
            labelRemainder.Tag = "";
            richTextBoxDetails.Clear();
            dateTimePickerAlertFrom.Value = DateTime.Today;
            dateTimeEventDate.Value = DateTime.Today;

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
                if (MessageBox.Show(@"Are you sure! Remove this EVENT", @"Confirmation", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) != DialogResult.Yes) return;

                // Remove Remain Later Item
                var remainder = GlobalSs.RemainLaterItems;

                if (remainder!=null)
                {
                    var remainderList = remainder.Split('|').ToList();
                    remainderList.RemoveAll(s =>
                    {
                        var remainRemoveItem = s.Split(',');
                        return remainRemoveItem[0] == labelRemainder.Tag.ToString();
                    });

                    var newRemainList = string.Join("|", remainderList);
                    GlobalSs.RemainLaterItems = newRemainList;
                }

                // Remove Event From Store
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

        private void comboBoxWindoPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalSs.SetValue(GlobalSs.KeyVariable.Position, comboBoxWindoPosition.SelectedValue.ToString());
        }

        private void buttonRestartApplication_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            if (_showEventPanel)
            {
                buttonReminder.PerformClick();
            }
            else
            {
                buttonSettings.PerformClick();
            }
        }

        private void buttonBackupRestore_Click(object sender, EventArgs e)
        {
            ActiveSection.ActiveButton(sender, panelSideMenu);
            ShowForm(panelBackupRestore);

            textBoxBackupFolderLocation.Text = Application.StartupPath + @"\";
            linkLabelBackupFileName.Text = string.Empty;
        }
        
        private void linkLabelBrowse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    var selectedPath = fbd.SelectedPath;
                    if (selectedPath.Length==3)
                    {
                        selectedPath = selectedPath.Substring(0, 2);
                    }
                    textBoxBackupFolderLocation.Text = selectedPath + @"\";
                }
            }
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxBackupFolderLocation.Text == "")
                {
                    MessageBox.Show(@"Please select a Backup folder");
                    return;
                }

                var currentDate = DateTime.Now;
                var fileName = @"DSN_" + currentDate.Year + "" + currentDate.Month + "" + currentDate.Day + "_" +
                               currentDate.Hour + "" + currentDate.Minute + "" + currentDate.Second + ".sdsn";
                linkLabelBackupFileName.Text = fileName;
                var filePath = textBoxBackupFolderLocation.Text.Trim() + @"DSN_Backup";

                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                var keyVariables = typeof(KeyVariables).GetFields();
                var backupString = new StringBuilder();

                foreach (var property in keyVariables)
                {
                    try
                    {
                        var value = GlobalSs.GetValue(property.Name);
                        backupString.AppendLine(GlobalSs.Encrypt(property.Name) + ":" + GlobalSs.Encrypt(value));
                    }
                    catch (Exception)
                    {
                        //
                    }
                }

                File.WriteAllText(filePath + @"\" + fileName, backupString.ToString());
                MessageBox.Show(@"Backup completed successfully.");

                Settings.Default.LastBackupLocation = filePath;
                Settings.Default.Save();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void linkLabelBrowseFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {

                using (var ofd = new OpenFileDialog())
                {
                    ofd.Title = @"Select a DSN Backup File";
                    ofd.Filter = @"DSN Backup files (*.sdsn)|*.sdsn";
                    ofd.InitialDirectory = Settings.Default.LastBackupLocation;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        textBoxBackupFIleLocation.Tag = ofd.FileName;
                        textBoxBackupFIleLocation.Text = ofd.SafeFileName;
                        buttonRestore.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            try
            {
                var filePath = textBoxBackupFIleLocation.Tag.ToString();

                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath);

                    foreach (var line in lines)
                    {
                        var parts = line.Split(new[] { ":" }, StringSplitOptions.None);

                        if (parts.Length == 2)
                        {
                            var keyVariable = GlobalSs.Decrypt(parts[0].Trim());
                            var keyValue = GlobalSs.Decrypt(parts[1].Trim());

                            GlobalSs.SetValue(keyVariable, keyValue);
                        }
                    }

                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonTheme_Click(object sender, EventArgs e)
        {
            ActiveSection.ActiveButton(sender, panelSideMenu);
            ShowForm(panelTheme);

            //Load Positions in Combobox
            var table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Name");

            foreach (GlobalSs.Theme thm in Enum.GetValues(typeof(GlobalSs.Theme)))
            {
                var sIndex = (int) thm;
                table.Rows.Add(sIndex, thm.ToString());
            }

            comboBoxTheme.ValueMember = "Id";
            comboBoxTheme.DisplayMember = "Name";
            comboBoxTheme.DataSource = table;

            comboBoxTheme.SelectedValue = (int)GlobalSs.CurrentTheme;
        }

        private void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTheme.Text==GlobalSs.Theme.Custom.ToString())
            {
                groupBoxCustomTheme.Visible = true;
                groupBoxCustomTheme.Location=new Point(9,70);

                panelThemeTopPanel.BackColor = GlobalSs.ThemeTopBarBackColor;
                panelThemeBodyPanel.BackColor = GlobalSs.ThemeBodyBackColor;
                panelThemeButtomPanel.BackColor = GlobalSs.ThemeFooterBarBackColor;
                labelBodyTextColor.ForeColor = GlobalSs.ThemeBodyTextColor;
            }
            else
            {
                groupBoxCustomTheme.Visible = false;
            }
        }

        private void buttonHeaderColor_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog())
            {
                colorDialog.Color = GlobalSs.ThemeTopBarBackColor;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    GlobalSs.ThemeTopBarBackColor = colorDialog.Color;
                    panelThemeTopPanel.BackColor = GlobalSs.ThemeTopBarBackColor;
                }
            }

        }

        private void buttonBodyColor_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog())
            {
                colorDialog.Color = GlobalSs.ThemeBodyBackColor;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    GlobalSs.ThemeBodyBackColor = colorDialog.Color;
                    panelThemeBodyPanel.BackColor = GlobalSs.ThemeBodyBackColor;
                }
            }
        }
        
        private void buttonFontColor_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog())
            {
                colorDialog.Color = GlobalSs.ThemeBodyTextColor;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    GlobalSs.ThemeBodyTextColor = colorDialog.Color;
                    labelBodyTextColor.ForeColor = GlobalSs.ThemeBodyTextColor;
                }
            }
        }

        private void buttonButtonColor_Click(object sender, EventArgs e)
        {
            using (var colorDialog = new ColorDialog())
            {
                colorDialog.Color = GlobalSs.ThemeFooterBarBackColor;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    GlobalSs.ThemeFooterBarBackColor = colorDialog.Color;
                    panelThemeButtomPanel.BackColor = GlobalSs.ThemeFooterBarBackColor;
                }
            }
        }

        private void buttonThemeUpdate_Click(object sender, EventArgs e)
        {
            var activeTheme = (int) (GlobalSs.Theme) Enum.Parse(typeof(GlobalSs.Theme), comboBoxTheme.Text);
            
            var themeDetails = activeTheme + "|" + GlobalSs.ThemeTopBarBackColor.ToArgb() + "|" +
                               GlobalSs.ThemeFooterBarBackColor.ToArgb() + "|" + GlobalSs.ThemeBodyBackColor.ToArgb() + "|" +
                               GlobalSs.ThemeBodyTextColor.ToArgb();

            GlobalSs.SetValue(GlobalSs.KeyVariable.Theme, themeDetails);

            MessageBox.Show(@"The theme has been successfully updated.", @"Theme Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabelBackupFileName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var folderPath = Settings.Default.LastBackupLocation;

            if (Directory.Exists(folderPath))
            {
                Process.Start("explorer.exe", folderPath);
            }
            else
            {
                MessageBox.Show(@"Backup folder does not exist.");
            }
        }
    }
}
