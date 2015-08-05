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
    using TTR.Common;

    public class TTRCompiler
    {
        private readonly string baseFilename = "TestNamespace";

        public TTRCompiler()
        {
            if (!Directory.Exists(TTRPath.AssemblyOutputPath))
            {
                Directory.CreateDirectory(TTRPath.AssemblyOutputPath);
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