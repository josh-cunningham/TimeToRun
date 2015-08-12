namespace TTR.Code
{
    using Microsoft.CSharp;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.IO;
    using TTR.Common;

    public class TTRCompiler
    {
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