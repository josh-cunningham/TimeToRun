namespace TimeToRun
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Types;

    public partial class TimeToRun : Form
    {
        private TimeToRunCompiler compiler;

        private InputTextBox[] textBoxes;

        #region Constructors and Initialization methods

        public TimeToRun()
        {
            this.InitializeComponent();

            this.InitializeInputTextBoxes();

            compiler = new TimeToRunCompiler();
            compiler.Initialize();
        }

        private void InitializeInputTextBoxes()
        {
            textBoxes = new InputTextBox[]
            {
                new InputTextBox(this.usingStatementsTextBox, "Enter 'Using' statements here\r\n\r\nNote: If unchanged, this text will not be compiled"),
                new InputTextBox(this.variablesTextBox, "Declare you variables here\r\n\r\nNote: If unchanged, this text will not be compiled"),
                new InputTextBox(this.initializationTextBox, "Initialise your variables here\r\nInclude any other code that you don't want to be timed\r\n\r\nNote: If unchanged, this text will not be compiled"),
                new InputTextBox(this.inputTextBox, "Enter the code you want to be timed here\r\n\r\nNote: If unchanged, this text will not be compiled")
            };

            foreach (TextBox textBox in this.textBoxes.Select<InputTextBox, TextBox>(itb => itb.TextBox))
            {
                textBox.Text = this.GetDefaultText(textBox);
                textBox.GotFocus += this.InputTextBox_GotFocus;
                textBox.LostFocus += this.InputTextBox_LostFocus;
            }
        }

        #endregion

        public void OnApplicationExit(object sender, EventArgs e)
        {
            compiler.Dispose();
        }

        #region Get and Set text boxes

        private string GetCompilableString()
        {
            CompilableString compilableString =  new CompilableString(this.GetCompilableString(this.usingStatementsTextBox),
                                                                      this.GetCompilableString(this.variablesTextBox),
                                                                      this.GetCompilableString(this.usingStatementsTextBox),
                                                                      this.GetCompilableString(this.usingStatementsTextBox));
            return compilableString.ToString();
        }

        private string GetCompilableString(TextBox textBox)
        {
            return (!this.ContainsDefaultText(textBox)) ? textBox.Text : string.Empty;
        }

        private bool ContainsDefaultText(TextBox textBox)
        {
            return textBox.Text == this.GetDefaultText(textBox);
        }

        private string GetDefaultText(TextBox textBox)
        {
            try
            {
                return textBoxes.Where<InputTextBox>(tb => tb == textBox).First().DefaultText;
            }
            catch (InvalidOperationException ex)
            {
                //this should never happen
                return string.Empty;
            }
        }

        #endregion

        #region Form control events

        private void CompileBtn_Click(object sender, EventArgs e)
        {
            var results = compiler.Compile(this.GetCompilableString());

            this.OutputTextBox.Text = compiler.CompilationReport(results);

            this.compiler.RunCode();
        }
        
        private void InputTextBox_GotFocus(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox is TextBox
                && this.ContainsDefaultText(textBox))
            {
                textBox.Text = string.Empty;
                textBox.ForeColor = Color.Black;
            }
        }

        private void InputTextBox_LostFocus(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null
                && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = this.GetDefaultText(textBox);
                textBox.ForeColor = Color.Gray;
            }
        }

        #endregion

    }
}