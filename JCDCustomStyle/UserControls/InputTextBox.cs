namespace JCDCustomStyle.UserControls
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class InputTextBox : UserControl
    {
        public string DefaultText
        {
            get;
            set;
        }

        public TextBox TextInput
        {
            get
            {
                return this.textInput;
            }

            set
            {
                this.textInput = value;
            }
        }

        public InputTextBox()
        {
            InitializeComponent();

            //This will set the default text
            this.Load += this.InputText_LostFocus;

            this.textInput.GotFocus += this.InputText_GotFocus;
            this.textInput.LostFocus += this.InputText_LostFocus;
        }

        public string GetText(bool evenIfDefault)
        {
            if (evenIfDefault || !this.ContainsDefaultText())
            {
                return this.textInput.Text;
            }
            else 
            {
                return string.Empty;
            }
        }

        public void SetText(string text)
        {
            this.textInput.Text = text;

            this.InputText_LostFocus(this, null);
        }

        public void SetToDefaultText()
        {
            this.textInput.Text = this.GetDefaultText();
        }

        protected bool ContainsDefaultText()
        {
            return this.TextInput.Text == this.GetDefaultText();
        }

        protected virtual string GetDefaultText()
        {
            return this.DefaultText;
        }

        private void InputText_GotFocus(object sender, EventArgs e)
        {
            if (this.ContainsDefaultText())
            {
                textInput.Text = string.Empty;
                textInput.ForeColor = Color.Black;
            }
        }

        private void InputText_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textInput.Text))
            {
                this.SetToDefaultText();
            }
        }
    }
}