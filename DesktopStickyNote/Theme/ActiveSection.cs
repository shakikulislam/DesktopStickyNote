using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DesktopStickyNote.Theme
{
    public class ActiveSection
    {
        private static readonly Color ActiveBackColor = Color.White;
        private static readonly Color ActiveForColor = Color.Black;
        private static readonly Font ActiveFont = new Font("Microsoft Sans Serif", 14F);

        private static readonly Color DeactiveBackColor = Color.FromArgb(28,28,28);
        private static readonly Color DeactiveForColor = Color.White;
        private static readonly Font DeactiveFont = new Font("Microsoft Sans Serif", 12F);

        
        public static void ActiveButton(object button, Panel panel)
        {
            if (button!=null)
            {
                // De-active
                foreach (var btn in panel.Controls.OfType<Button>())
                {
                    btn.BackColor = DeactiveBackColor;
                    btn.ForeColor = DeactiveForColor;
                    btn.Font = DeactiveFont;
                }

                // Active
                var currentButton = (Button) button;
                currentButton.BackColor = ActiveBackColor;
                currentButton.ForeColor = ActiveForColor;
                currentButton.Font = ActiveFont;
            }
        }
    }
}
