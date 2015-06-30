using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeToRun
{
    using System.CodeDom.Compiler;
    using System.IO;
    using Microsoft.CSharp;
    using System.Reflection;

    public partial class TimeToRun : Form
    {
        private CSharpCodeProvider codeProvider;

        private CompilerParameters compilerParameters;

        public TimeToRun()
        {
            InitializeComponent();

            InitializeInputTextBox();

            InitializeCompiler();
        }

        private void InitializeInputTextBox()
        {
            this.InputTextBox.Text = "Console.WriteLine(\"Hello World!\"); Console.ReadKey();";
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

        private string GetCompilableString()
        {
            return "public static class TestProgram { public static void Main() {"
                + this.InputTextBox.Text
                + "} }";
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

        private CompilerResults Compile(string code)
        {
            return codeProvider.CompileAssemblyFromSource(this.compilerParameters, new string[] { code });
        }

        private void CompileBtn_Click(object sender, EventArgs e)
        {
            var results = this.Compile(this.GetCompilableString());

            this.OutputTextBox.Text = this.CompilationReport(results);
        }
    }
}