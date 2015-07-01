namespace TimeToRun
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using Microsoft.CSharp;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class TimeToRun : Form
    {
        private CSharpCodeProvider codeProvider;
        
        private CompilerParameters compilerParameters;

        Dictionary<TextBox, string> defaultTextsDictionary;

        #region Constructors and Initialization methods

        public TimeToRun()
        {
            this.InitializeComponent();

            this.InitializeInputTextBoxes();

            this.InitializeCompiler();
        }

        private void InitializeInputTextBoxes()
        {
            defaultTextsDictionary = new Dictionary<TextBox, string>();
            defaultTextsDictionary.Add(this.usingStatementsTextBox, "Enter 'Using' statements here\r\n\r\nNote: If unchanged, this text will not be compiled");
            defaultTextsDictionary.Add(this.variablesTextBox, "Declare you variables here\r\n\r\nNote: If unchanged, this text will not be compiled");
            defaultTextsDictionary.Add(this.initializationTextBox, "Initialise your variables here\r\nInclude any other code that you don't want to be timed\r\n\r\nNote: If unchanged, this text will not be compiled");
            defaultTextsDictionary.Add(this.inputTextBox, "Enter the code you want to be timed here\r\n\r\nNote: If unchanged, this text will not be compiled");

            foreach (TextBox textBox in this.defaultTextsDictionary.Keys)
            {
                this.SetToDefaultText(textBox);
                textBox.GotFocus += this.InputTextBox_GotFocus;
                textBox.LostFocus += this.InputTextBox_LostFocus;
            }
        }

        private void InitializeCompiler()
        {
            compilerParameters = new CompilerParameters();
            compilerParameters.GenerateInMemory = true;
            compilerParameters.TreatWarningsAsErrors = false;
            compilerParameters.GenerateExecutable = false;
            compilerParameters.CompilerOptions = "/optimize";
 
            string[] references = { "System.dll" };
            compilerParameters.ReferencedAssemblies.AddRange(references);

            codeProvider = new CSharpCodeProvider();
        }

        #endregion

        #region Get and Set text boxes

        private string GetCompilableString()
        {
            StringBuilder compilableStringBuilder = new StringBuilder();

            compilableStringBuilder.Append(this.GetCompilableString(this.usingStatementsTextBox));
            compilableStringBuilder.Append("static class TestProgram { public static void Main() {");
            compilableStringBuilder.Append("TestClass test = new TestClass(); test.Initialize(); test.RunCode();");
            compilableStringBuilder.Append("} } public class TestClass { ");
            compilableStringBuilder.Append(this.GetCompilableString(this.variablesTextBox));
            compilableStringBuilder.Append("public void Initialize() {");
            compilableStringBuilder.Append(this.GetCompilableString(this.initializationTextBox));
            compilableStringBuilder.Append("} public void RunCode() {");
            compilableStringBuilder.Append(this.GetCompilableString(this.inputTextBox));
            compilableStringBuilder.Append("} }");

            return compilableStringBuilder.ToString();
        }

        private string GetCompilableString(TextBox textBox)
        {
            return (textBox.Text != this.defaultTextsDictionary[textBox]) ? textBox.Text : string.Empty;
        }

        private void SetToDefaultText(TextBox textBox)
        {
            textBox.Text = this.defaultTextsDictionary[textBox];
            textBox.ForeColor = Color.Gray;
        }

        #endregion

        #region Compilation Methods

        private CompilerResults Compile(string code)
        {
            return codeProvider.CompileAssemblyFromSource(this.compilerParameters, new string[] { code });
        }

        private string CompilationReport(CompilerResults results)
        {
            if (results.Errors.HasErrors)
            {
                StringBuilder errorMessage = new StringBuilder("Following Compilation Errors: \r\n");

                foreach (var error in results.Errors)
                {
                    errorMessage.AppendLine(error.ToString());
                }

                return errorMessage.ToString();
            }
            else
            {
                return "Compilation Success!";
            }
        }

        #endregion

        #region Form control events

        private void CompileBtn_Click(object sender, EventArgs e)
        {
            var results = this.Compile(this.GetCompilableString());

            this.OutputTextBox.Text = this.CompilationReport(results);
        }
        
        private void InputTextBox_GotFocus(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox is TextBox
                && textBox.Text == this.defaultTextsDictionary[textBox])
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
                SetToDefaultText(textBox);
            }
        }

        #endregion

    }
}