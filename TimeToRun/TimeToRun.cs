namespace TimeToRun
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Types;

    public partial class TimeToRun : Form
    {
        public static List<string> CreatedDllList = new List<string>();

        private TTRCompiler compiler;

        private InputTextBox[] textBoxes;

        #region Constructors and Initialization methods

        public TimeToRun()
        {
            this.InitializeComponent();

            this.InitializeInputTextBoxes();

            this.compiler = new TTRCompiler();
        }

        private void InitializeInputTextBoxes()
        {
            this.textBoxes = new InputTextBox[]
            {
                new InputTextBox(this.usingStatementsText, "Enter 'Using' statements here\r\n\r\nNote: If unchanged, this text will not be compiled"),
                new InputTextBox(this.variablesText, "Declare you variables here\r\n\r\nNote: If unchanged, this text will not be compiled"),
                new InputTextBox(this.initializationText, "Initialise your variables here\r\nInclude any other code that you don't want to be timed\r\n\r\nNote: If unchanged, this text will not be compiled"),
                new InputTextBox(this.inputText, "Enter the code you want to be timed here\r\n\r\nNote: If unchanged, this text will not be compiled")
            };

            foreach (TextBox textBox in this.textBoxes.Select<InputTextBox, TextBox>(itb => itb.TextBox))
            {
                textBox.Text = this.GetDefaultText(textBox);
                textBox.GotFocus += this.InputText_GotFocus;
                textBox.LostFocus += this.InputText_LostFocus;
            }
        }

        #endregion

        public void OnApplicationExit(object sender, EventArgs e)
        {
            Directory.Delete(TTRCompiler.AssemblyOutputPath, true);
        }

        #region Get and Set text boxes

        private string GetCompilableString()
        {
            CompilableString compilableString =  new CompilableString(this.GetCompilableString(this.usingStatementsText),
                                                                      this.GetCompilableString(this.variablesText),
                                                                      this.GetCompilableString(this.usingStatementsText),
                                                                      this.GetCompilableString(this.usingStatementsText));
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

        private void CompileButton_Click(object sender, EventArgs e)
        {
            var sourceCode = this.GetCompilableString();

            var results = this.compiler.Compile(sourceCode);

            this.sourceCodeText.Text = sourceCode;

            this.compiler.CompileReport(results);

            this.UpdateOutputLog();
        }


        private void RunButton_Click(object sender, EventArgs e)
        {
            new TTRCodeRunner().TimeLastCompilation();

            this.UpdateOutputLog();
        }
        
        private void InputText_GotFocus(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox is TextBox
                && this.ContainsDefaultText(textBox))
            {
                textBox.Text = string.Empty;
                textBox.ForeColor = Color.Black;
            }
        }

        private void InputText_LostFocus(object sender, EventArgs e)
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

        private void UpdateOutputLog()
        {
            StringBuilder output = new StringBuilder(this.OutputText.Text);

            foreach (string message in Log.Instance.GetMessages())
            {
                output.AppendLine(message);
            }

            Log.Instance.Clear();

            this.OutputText.Text = output.ToString();
        }

    }
}