namespace TTR
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using TTR.Code;
    using TTR.Common;
    using TTR.Logging;

    /// <summary>
    /// TimeToRun Form
    /// </summary>
    public partial class TimeToRun : Form
    {
        public List<string> CreatedDllList = new List<string>();

        private TTRCompiler compiler;

        private TTRCodeRunner codeRunner;

        #region Constructors and Initialization methods

        public TimeToRun()
        {
            this.InitializeComponent();

            this.compiler = new TTRCompiler();
            this.codeRunner = new TTRCodeRunner();
        }

        #endregion

        public void OnApplicationExit(object sender, EventArgs e)
        {
            if (Directory.Exists(TTRPath.AssemblyOutputPath))
            {
                Directory.Delete(TTRPath.AssemblyOutputPath, true);
            }            
        }

        #region Get and Set text boxes

        private TempCodeSnippet GetCurrentTempCodeSnippet()
        {
            TempCodeSnippet codeSnippet = new TempCodeSnippet(this.GetCurrentCodeSnippet());

            return codeSnippet;
        }

        private CodeSnippet GetCurrentCodeSnippet()
        {
            CodeSnippet currentSnippet = new CodeSnippet()
                {
                    CodeName = this.inputTextCodeName.GetText(false),
                    UsingStatements = this.inputTextUsingStatements.GetText(false),
                    VariableDeclarations = this.inputTextVarDeclaration.GetText(false),
                    VariableInitialization = this.inputTextVarInitialization.GetText(false),
                    CodeToTime= this.inputTextCodeToTime.GetText(false)
                };

            return currentSnippet;
        }

        private void SetCurrentCodeSnippet(CodeSnippet codeSnippet)
        {
            this.inputTextCodeName.SetText(codeSnippet.CodeName);
            this.inputTextUsingStatements.SetText(codeSnippet.UsingStatements);
            this.inputTextVarDeclaration.SetText(codeSnippet.VariableDeclarations);
            this.inputTextVarInitialization.SetText(codeSnippet.VariableInitialization);
            this.inputTextCodeToTime.SetText(codeSnippet.CodeToTime);
        }

        #endregion

        #region Form control events

        private void CompileButton_Click(object sender, EventArgs e)
        {
            var codeSnippet = this.GetCurrentTempCodeSnippet();

            var results = this.compiler.Compile(codeSnippet);

            this.CreatedDllList.Add(results.PathToAssembly);

            this.sourceCodeText.Text = codeSnippet.AsCompilableString();

            Log.Instance.Add(results.GetCompilationReport());

            this.UpdateOutputLog();
        }


        private void RunButton_Click(object sender, EventArgs e)
        {
            this.codeRunner.TimeExecution(CreatedDllList.Last());

            this.UpdateOutputLog();
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