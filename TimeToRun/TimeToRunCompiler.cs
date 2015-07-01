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
            CSharpCodeProvider codeProvider = new CSharpCodeProvider();

            if (!Directory.Exists(this.AssemblyOutputPath))
            {
                Directory.CreateDirectory(this.AssemblyOutputPath);
            }

            CompilerResults results = codeProvider.CompileAssemblyFromSource(this.compilerParameters, new string[] { code });

            codeProvider.Dispose();

            return results;
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

        public void RunCode(CompilerResults compilerResults, out string outputText)
        {
            object testClass = null;
            Module module = compilerResults.CompiledAssembly.GetModules()[0];
            Type mt = null;
            MethodInfo initializeMethodInfo = null;
            MethodInfo runCodeMethodInfo = null;
            outputText = string.Empty;

            if (module != null)
            {
                mt = module.GetType("TestNamespace.TestClass");
            }

            if (mt != null)
            {
                testClass = Activator.CreateInstance(mt);
                initializeMethodInfo = mt.GetMethod("Initialize");
                runCodeMethodInfo = mt.GetMethod("RunCode");
            }

            if (initializeMethodInfo != null && runCodeMethodInfo != null)
            {
                try
                {
                    initializeMethodInfo.Invoke(testClass, new object[] { });
                    runCodeMethodInfo.Invoke(testClass, new object[] { });
                }
                catch (Exception ex)
                {
                    outputText = "Exception Thrown during execution\r\n" + ex.InnerException.ToString();
                }
            }
        }
    }
}