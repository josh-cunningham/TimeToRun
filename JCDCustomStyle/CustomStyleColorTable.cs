namespace JCDCustomStyle
{
    using System.Drawing;
    using System.Windows.Forms;

    public partial class CustomStyleColorTable
    {
        public ControlStyle AllControlSettings
        {
            get;
            set;
        }

        public ButtonStyle ButtonSettings
        {
            get;
            set;
        }

        public CustomStyleColorTable()
        {
            this.AllControlSettings = null;
            this.ButtonSettings = null;
        }
    }

    public abstract class AbCustomStyleSettings
    {
    }

    public class ControlStyle : AbCustomStyleSettings
    {
        public Color ControlBackColor { get; set; }
    }

    public class ButtonStyle : AbCustomStyleSettings
    {
        public FlatStyle? FlatStyle { get; set; }
        public int? BorderSize { get; set; }
    }

    public static class ApplyExtensionMethods
    {
        public static void ApplyCustomStyle(this Control control, ControlStyle style)
        {
            control.BackColor = style.ControlBackColor;
            control.Font = new Font(new FontFamily("Segoe UI"), 8);
        }

        public static void ApplyCustomStyle(this Button button, ButtonStyle style)
        {
            if (style.FlatStyle.HasValue)
            {
                button.FlatStyle = style.FlatStyle.Value;
            }

            if (style.BorderSize.HasValue)
            {
                button.FlatAppearance.BorderSize = style.BorderSize.Value;
            }
        }
    }
}