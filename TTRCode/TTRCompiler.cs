namespace TTR.Code
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
                    string startupPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                    assemblyOutputPath = Path.Combine(startupPath, "TTRCompilations");
                }
                return assemblyOutputPath;
            }
        }

        public TTRCompiler()
        {
            if (!Directory.Exists(AssemblyOutputPath))
            {
                Directory.CreateDirectory(AssemblyOutputPath);
            }
        }

        public CompilerResults Compile(TempCodeSnippet codeSnippet)
        {
            CompilerParameters compilerParameters = this.GetCompilerParameters(codeSnippet.SessionName);

            return this.Compile(codeSnippet.AsCompilableString(), compilerParameters);
        }

        private CompilerResults Compile(string code, CompilerParameters compilerParameters)
        {
            CSharpCodeProvider codeProvider = new CSharpCodeProvider(new Dictionary<String, String> { { "CompilerVersion", "v4.0" } });

            CompilerResults results = codeProvider.CompileAssemblyFromSource(compilerParameters, new string[] { code });

            codeProvider.Dispose();

            return results;
        }

        private CompilerParameters GetCompilerParameters(string outputAssemblyName)
        {
            TTRCompilerParameters compilerParameters = new TTRCompilerParameters();

            compilerParameters.SetTTRDefaults();

            compilerParameters.SetTTROutputAssembly(outputAssemblyName);

            return compilerParameters;
        }
    }
}