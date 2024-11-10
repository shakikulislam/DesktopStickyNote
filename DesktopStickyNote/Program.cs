using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Drawing;

namespace DesktopStickyNote
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                //Set autorun path
                RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (key != null) key.SetValue("Desktop Sticky Note", Application.ExecutablePath);

                //Create SubKey
                RegistryKey createSubKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
                if (createSubKey != null) createSubKey.CreateSubKey("Desktop Sticky Note");

                //Get all values
                bool alwaysVisible;
                bool.TryParse(GlobalSs.GetValue(GlobalSs.KeyVariable.AlwaysVisible), out alwaysVisible);
                GlobalSs.AlwaysVisible = alwaysVisible;

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

                var theme = GlobalSs.GetValue(GlobalSs.KeyVariable.Theme);
                var themeDetails = new string[] { };

                if (theme != null)
                {
                    themeDetails = theme.Split('|');
                    var themeCode = int.Parse(theme[0].ToString());
                    if (themeCode >= 1 && themeCode <= 3)
                    {
                        GlobalSs.CurrentTheme = (GlobalSs.Theme) themeCode;
                    }
                }

                switch (GlobalSs.CurrentTheme)
                {
                    case GlobalSs.Theme.Default:
                        GlobalSs.ThemeTopBarBackColor = ColorTranslator.FromHtml("#D3D3D3");
                        GlobalSs.ThemeFooterBarBackColor = ColorTranslator.FromHtml("#D3D3D3");
                        GlobalSs.ThemeBodyBackColor = ColorTranslator.FromHtml("#F0F0F0");
                        GlobalSs.ThemeBodyTextColor = ColorTranslator.FromHtml("#000000");
                        break;
                    case GlobalSs.Theme.Dark:
                        GlobalSs.ThemeTopBarBackColor = ColorTranslator.FromHtml("#252526");
                        GlobalSs.ThemeFooterBarBackColor = ColorTranslator.FromHtml("#252526");
                        GlobalSs.ThemeBodyBackColor = ColorTranslator.FromHtml("#1E1E1E");
                        GlobalSs.ThemeBodyTextColor = ColorTranslator.FromHtml("#F1F1F1");
                        break;
                    case GlobalSs.Theme.Custom:
                        GlobalSs.ThemeTopBarBackColor = Color.FromArgb(int.Parse(themeDetails[1]));
                        GlobalSs.ThemeFooterBarBackColor = Color.FromArgb(int.Parse(themeDetails[2]));
                        GlobalSs.ThemeBodyBackColor = Color.FromArgb(int.Parse(themeDetails[3]));
                        GlobalSs.ThemeBodyTextColor = Color.FromArgb(int.Parse(themeDetails[4]));
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





            Application.Run(new FormMain());
        }
    }
}
