namespace TimeToRun
{
    using Microsoft.CSharp;
    using System;
    using System.CodeDom.Compiler;
    using System.Configuration;
    using System.IO;
    using System.Reflection;
    using System.Text;

    public class TimeToRunCompiler : IDisposable
    {
        private readonly string filename = "compiledCode";

        private CSharpCodeProvider codeProvider;

        private CompilerParameters compilerParameters;

        private string AssemblyOutputPath
        {
            get
            {
                return Directory.GetCurrentDirectory() + ConfigurationManager.AppSettings["AssemblyOutputPath"];
            }
        }

        public void Initialize()
        {
            compilerParameters = new CompilerParameters();
            compilerParameters.GenerateInMemory = false;
            compilerParameters.OutputAssembly = this.AssemblyOutputPath + "\\" + this.filename;
            compilerParameters.TreatWarningsAsErrors = false;
            compilerParameters.GenerateExecutable = false;
            compilerParameters.CompilerOptions = "/optimize";

            codeProvider = new CSharpCodeProvider();
        }

        public void Dispose()
        {
            if (Directory.Exists(this.AssemblyOutputPath))
            {
                File.Delete(this.AssemblyOutputPath + "\\" + this.filename);
                Directory.Delete(this.AssemblyOutputPath);
            }
        }

        public CompilerResults Compile(string code)
        {
            if (!Directory.Exists(this.AssemblyOutputPath))
            {
                Directory.CreateDirectory(this.AssemblyOutputPath);
            }

            return codeProvider.CompileAssemblyFromSource(this.compilerParameters, new string[] { code });
        }

        public string CompilationReport(CompilerResults results)
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

        public void RunCode(CompilerResults compilerResults)
        {
            Module module = compilerResults.CompiledAssembly.GetModules()[0];
            Type mt = null;
            MethodInfo methInfo = null;

            if (module != null)
            {
                mt = module.GetType("DynaCore.DynaCore");
            }

            if (mt != null)
            {
                methInfo = mt.GetMethod("Main");
            }

            if (methInfo != null)
            {
                Console.WriteLine(methInfo.Invoke(null, new object[] { "here in dyna code" }));
            }
        }
    }
}