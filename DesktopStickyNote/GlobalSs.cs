using System;
using System.Drawing;
using Microsoft.Win32;

namespace DesktopStickyNote
{
    public class GlobalSs
    {
        private static readonly RegistryKey KeyNote = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Desktop Sticky Note", true);
        private static readonly Font DefaultFont = new Font("Microsoft Sans Serif", 5, FontStyle.Regular);

        //Settings
        public static bool AlwaysVisible = false;
        public static Color FontColor = Color.Black;


        public static string Events { get; set; }
        public static string Category { get; set; }

        public static void SetValue(string keyVariable, string value)
        {
            KeyNote.SetValue(keyVariable, value);
        }
        
        public static string GetValue(string keyVariable)
        {
            if (KeyNote != null)
            {
                var value = KeyNote.GetValue(keyVariable);
                if (value != null)
                {
                    return value.ToString();
                }
            }
            return null;
        }
        
        public static Font GetFont()
        {
            var font = GetValue("Font");

            if (string.IsNullOrEmpty(font))
            {
                return DefaultFont;
            }

            try
            {
                var fontParts = font.Split(',');

                if (fontParts.Length < 3)
                {
                    return DefaultFont;
                }

                string fontName = fontParts[0].Trim();
                float fontSize;
                FontStyle fontStyle;


                if (!float.TryParse(fontParts[1], out fontSize))
                {
                    return DefaultFont;
                }

                if (!Enum.TryParse(fontParts[2], true, out fontStyle))
                {
                    return DefaultFont;
                }

                return new Font(fontName, fontSize, fontStyle);
            }
            catch
            {
                return DefaultFont;
            }
        }

    }
}
