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
        FormMain formMain = new FormMain();
        private Font newFont;
        private string _categorie;
        private string _dateFormat = "dd-MMM-yy HH:mm:ss";
        private string _events;

        public FormSettings()
        {

            InitializeComponent();
            LoadSettings();

            try
            {
                var font = formMain._keyNote.GetValue("Font").ToString().Split(',');
                newFont = new Font(font[0], float.Parse(font[1]), (FontStyle)Enum.Parse(typeof(FontStyle), font[2]));
            }
            catch
            {
                // ignored
            }

            labelFontFamily.Text = newFont.Name;
            labelFontSize.Text = newFont.Size.ToString();
            labelFontStyle.Text = newFont.Style.ToString();


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
                _events = formMain._keyNote.GetValue("Events").ToString();
                formMain._events = _events;

                if (!string.IsNullOrEmpty(_events))
                {
                    var events = _events.Split('|');
                    foreach (var @event in events)
                    {
                        var item = @event.Split(',');
                        
                        var lvi=new ListViewItem(item[0]);
                        lvi.SubItems.Add(item[1]);
                        lvi.SubItems.Add(Convert.ToDateTime(item[2]).ToString("dd-MMM-yy"));
                        lvi.SubItems.Add(Convert.ToDateTime(item[3]).ToString("dd-MMM-yy"));
                        lvi.SubItems.Add(item[4]);

                        listViewEventList.Items.Add(lvi);
                    }
                }

                listViewEventList.Refresh();
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
                _categorie = formMain._keyNote.GetValue("Category").ToString();

                comboBoxCaregory.Items.Clear();
                foreach (var category in _categorie.Split(','))
                {
                    comboBoxCaregory.Items.Add(category);
                }
                comboBoxCaregory.Refresh();
            }
            catch (Exception e)
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
            checkBoxAllwaseVisible.Checked = Settings.Default.AllwaseVisible;
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
        }

        private void checkBoxAllwaseVisible_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.AllwaseVisible = checkBoxAllwaseVisible.Checked;
            Settings.Default.Save();
        }

        private void buttonSelectFont_Click(object sender, EventArgs e)
        {
            var fontDialog = new FontDialog() {
                Font = new Label() { Font = newFont }.Font
            };
                        
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                var fontDtl = fontDialog.Font.Name + "," + fontDialog.Font.Size + "," + fontDialog.Font.Style;

                formMain._keyNote.SetValue("Font", fontDtl);

                labelFontFamily.Text = fontDialog.Font.Name.ToString();
                labelFontSize.Text = fontDialog.Font.Size.ToString();
                labelFontStyle.Text = fontDialog.Font.Style.ToString();

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
                if (_categorie.Split(',').Any(item => item == newCategory))
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

            if (string.IsNullOrEmpty(_categorie))
            {
                _categorie = newCategory;
            }
            else
            {
                _categorie += "," + newCategory;
            }

            formMain._keyNote.SetValue("Category", _categorie);

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
            var date = DateTime.Now;
            var id =  date.Year.ToString().Substring(2) + "" + date.Month + "" + date.Day + "" + date.Hour + "" + date.Minute + "" + date.Second;

            var evnt = new Event
            {
                Id = id,
                Category = comboBoxCaregory.Text,
                FromDate = dateTimePickerFrom.Value,
                ToDate = dateTimePickerTo.Value,
                Details = richTextBoxDetails.Text.Trim()
            };

            var newEvent = evnt.Id + "," + evnt.Category + "," + evnt.FromDate + "," + evnt.ToDate + "," + evnt.Details;
            
            var allEvents = string.IsNullOrEmpty(_events) ? newEvent : _events + "|" + newEvent;

            try
            {
                formMain._keyNote.SetValue("Events", allEvents);
                LoadEvent();
            }
            catch 
            {
                //
            }

        }

    }
}
