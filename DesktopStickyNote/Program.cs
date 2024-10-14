using System;
using System.Windows.Forms;
using Microsoft.Win32;

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

            //Set autorun path
            RegistryKey key =
                Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (key != null) key.SetValue("Desktop Sticky Note", Application.ExecutablePath);

            //Create SubKey
            RegistryKey createSubKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
            if (createSubKey != null) createSubKey.CreateSubKey("Desktop Sticky Note");

            Application.Run(new FormMain());
        }
    }
}
