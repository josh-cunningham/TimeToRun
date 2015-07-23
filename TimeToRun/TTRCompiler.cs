namespace TimeToRun
{
    using Microsoft.CSharp;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Security.Policy;
    using System.Text;

    public class TTRCompiler
    {
        private readonly string baseFilename = "TestNamespace";

        private static string assemblyOutputPath;

        public static string AssemblyOutputPath
        {
            get
            {
                if (assemblyOutputPath == null)
                {
                    string startupPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

                    assemblyOutputPath = Path.Combine(startupPath, "TTRCompilations");
                }
                return assemblyOutputPath;
            }
        }

        public CompilerResults Compile(string code)
        {
            CSharpCodeProvider codeProvider = new CSharpCodeProvider(new Dictionary<String, String> { { "CompilerVersion", "v4.0" } });

            if (!Directory.Exists(AssemblyOutputPath))
            {
                Directory.CreateDirectory(AssemblyOutputPath);
            }

            CompilerResults results = codeProvider.CompileAssemblyFromSource(this.GetCompilerParameters(), new string[] { code });

            codeProvider.Dispose();

            return results;
        }

        public string CompileReport(CompilerResults results)
        {
            StringBuilder logs = new StringBuilder();

            if (results.Errors.HasErrors)
            {
                logs.AppendLine("Following Compilation Errors: \r\n");

                foreach (var error in results.Errors)
                {
                    logs.AppendLine(error.ToString());
                }
            }
            else
            {
                logs.Append("Compilation Success!");
            }

            string logsString = logs.ToString();

            Log.Instance.Add(logsString);

            return logsString;
        }

        private CompilerParameters GetCompilerParameters()
        {
            CompilerParameters compilerParameters = new CompilerParameters()
            {
                GenerateInMemory = false,
                TreatWarningsAsErrors = false,
                GenerateExecutable = false,
                CompilerOptions = "/optimize",
                OutputAssembly = AssemblyOutputPath + "\\" + this.GetNextFilename()
            };

            compilerParameters.ReferencedAssemblies.Add("mscorlib.dll");
            compilerParameters.ReferencedAssemblies.Add("System.dll");
            
            TimeToRun.CreatedDllList.Add(compilerParameters.OutputAssembly);

            return compilerParameters;
        }

        private string GetNextFilename()
        {
            return this.baseFilename + TimeToRun.CreatedDllList.Count + ".dll";
        }
    }
}