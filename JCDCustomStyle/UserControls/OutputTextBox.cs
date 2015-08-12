namespace JCDCustomStyle.UserControls
{
    using System.Text;
    using System.Windows.Forms;

    public partial class OutputTextBox : UserControl
    {
        public TextBox TextOutput
        {
            get
            {
                return this.textOutput;
            }

            set
            {
                this.textOutput = value;
            }
        }

        public OutputTextBox()
        {
            InitializeComponent();

            this.Enabled = true;

            this.TextOutput.ReadOnly = true;
        }

        public string GetText()
        {
            return this.textOutput.Text;
        }

        public void AppendText(string[] textArray)
        {
            foreach (string text in textArray)
            {
                this.AppendText(text);
            }
        }

        public void AppendText(string text)
        {
            this.TextOutput.AppendText(text + "\r\n");
        }
    }
}