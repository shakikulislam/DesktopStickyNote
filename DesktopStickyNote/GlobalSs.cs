using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;

namespace DesktopStickyNote
{
    public class GlobalSs
    {
        private static readonly RegistryKey KeyNote = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Desktop Sticky Note", true);
        private static readonly Font DefaultFont = new Font("Microsoft Sans Serif", 5, FontStyle.Regular);

        public static KeyVariables KeyVariable = new KeyVariables();
        
        //Settings
        public static bool AlwaysVisible = false;
        public static int RemainTimeHour = 0;
        public static int RemainTimeMinutes = 5;
        public static string RemainLaterItems;
        public static bool RemainTimerStop = false;
        public static Position CurrentPosition = Position.RightCenter;
        public static Theme CurrentTheme = Theme.Default;

        public static Color ThemeTopBarBackColor;
        public static Color ThemeFooterBarBackColor;
        public static Color ThemeBodyBackColor;
        public static Color ThemeBodyTextColor;

        public enum Position
        {
            LeftBottom = 1,
            LeftCenter = 2,
            LeftTop = 3,
            TopLeft = 4,
            TopCenter = 5,
            TopRight = 6,
            RightTop = 7,
            RightCenter = 8,
            RightBottom = 9
        }

        public enum Theme
        {
            Default = 0,
            Dark = 1,
            Custom = 2
        }

        public static string[] Events { get; set; }

        public static string Category { get; set; }

        public static void SetValue(string keyVariable, string value)
        {
            KeyNote.SetValue(keyVariable, value);
        }
        
        public static string GetValue(string keyVariable)
        {
            if (KeyNote == null) return null;
            var value = KeyNote.GetValue(keyVariable);

            return value != null ? value.ToString() : null;
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

        public static string Encrypt(string text)
        {
            var data = Encoding.UTF8.GetBytes(text);
            using (var md5 = new MD5CryptoServiceProvider())
            {
                var keys = md5.ComputeHash(Encoding.UTF8.GetBytes("$15s*9S@"));
                using (var tripleDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    var cryptoTransform = tripleDes.CreateEncryptor();
                    var result = cryptoTransform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(result, 0, result.Length);
                }
            }
        }

        public static string Decrypt(string text)
        {
            var data = Convert.FromBase64String(text);
            using (var md5 = new MD5CryptoServiceProvider())
            {
                var keys = md5.ComputeHash(Encoding.UTF8.GetBytes("$15s*9S@"));
                using (var tripleDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    var cryptoTransform = tripleDes.CreateDecryptor();
                    var result = cryptoTransform.TransformFinalBlock(data, 0, data.Length);
                    return Encoding.UTF8.GetString(result);
                }
            }
        }
        
    }

    public class KeyVariables
    {
        // Properties
        public string AlwaysVisible = "AlwaysVisible";
        public string Category = "Category";
        public string Font = "Font";
        public string Events = "Events";
        public string Note = "Note";
        public string RemainTime = "RemainTime";
        public string Position = "Position";
        public string Theme = "Theme";
        public string TextAlignment = "TextAlignment";

    }
}
