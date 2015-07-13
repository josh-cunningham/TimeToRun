namespace TimeToRun
{
    using Microsoft.CSharp;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using System.Reflection;
    using System.Text;

    public class TimeToRunCompiler : IDisposable
    {
        private readonly string filename = "TestNamespace.dll";

        private CompilerParameters compilerParameters;

        private string AssemblyOutputPath
        {
            get
            {
                return Directory.GetCurrentDirectory();
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
                if (this.AssemblyOutputPath != Directory.GetCurrentDirectory())
                {
                    Directory.Delete(this.AssemblyOutputPath);
                }
            }
        }

        public CompilerResults Compile(string code)
        {
            CSharpCodeProvider codeProvider = new CSharpCodeProvider(new Dictionary<String, String> { { "CompilerVersion", "v4.0" } });

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

        static readonly string path = @"C:\Users\Josh\Development\github\TimeToRun\TimeToRun\bin\Debug";

        public static void LoadAssembly()
        {
            Assembly assemblyReflected = Assembly.ReflectionOnlyLoadFrom(path + "\\" + "TestNamespace.dll");

            foreach (AssemblyName ass in assemblyReflected.GetReferencedAssemblies())
            {
                Assembly.Load(ass.FullName);
            }

            Assembly assembly = Assembly.Load(assemblyReflected.FullName);
            Module module = assembly.GetModule("TestNamespace.dll");

            Type testType = null;
            MethodInfo initializeMethodInfo = null;
            MethodInfo runCodeMethodInfo = null;

            object testClass = null;

            if (module != null)
            {
                testType = module.GetType("TestNamespace.TestClass");
            }

            if (testType != null && testType.Assembly != null)
            {
                initializeMethodInfo = testType.GetMethod("Initialize");
                runCodeMethodInfo = testType.GetMethod("Run");
                testClass = AppDomain.CurrentDomain.CreateInstanceAndUnwrap(testType.Assembly.FullName, "TestNamespace.TestClass");
            }

            if (initializeMethodInfo != null && runCodeMethodInfo != null)
            {
                try
                {
                    initializeMethodInfo.Invoke(testClass, new object[] { });
                    runCodeMethodInfo.Invoke(testClass, new object[] { });

                    File.AppendAllLines(path + "\\Results.txt", new string[] { "Run Complete" });
                }
                catch (Exception ex)
                {
                    File.AppendAllLines(path + "\\Results.txt", new string[] { "Run Failed" });
                }
            }
        }
        
        public void RunCode()
        {
            AppDomainSetup domainInfo = new AppDomainSetup();
            domainInfo.PrivateBinPath = this.AssemblyOutputPath;

            AppDomain dom = AppDomain.CreateDomain("dom", null, domainInfo);

            dom.DoCallBack(LoadAssembly);

            AppDomain.Unload(dom);
        }
    }
}