namespace TimeToRun.Types
{
    using System.Windows.Forms;

    /*
     * This class provides a means to easily link textboxes with a default text
     * 
     * This class 'effectively' extends the TextBox, and indeed could, 
     * but for the moment this is sufficient
     */
    public class InputTextBox
    {
        public TextBox TextBox
        {
            protected set;
            get;
        }

        public string DefaultText
        {
            protected set;
            get;
        }

        public InputTextBox(TextBox textBox, string defaultText)
        {
            this.TextBox = textBox;
            this.DefaultText = defaultText;
        }

        public static bool operator ==(InputTextBox itb, TextBox tb)
        {
            return itb.TextBox == tb;
        }

        public static bool operator !=(InputTextBox itb, TextBox tb)
        {
            return itb.TextBox != tb;
        }
    }
}