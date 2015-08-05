namespace TTR.Code
{
    using System.CodeDom.Compiler;
    using System.IO;
    using TTR.Common;

    public class TTRCompilerParameters : CompilerParameters
    {
        public void SetTTRDefaults()
        {
            this.GenerateInMemory = false;
            this.TreatWarningsAsErrors = false;
            this.GenerateExecutable = false;
            this.CompilerOptions = "/optimize";

            this.SetTTROutputAssembly("TTR_defaultTempAssemblyName");

            this.ReferencedAssemblies.Add("mscorlib.dll");
            this.ReferencedAssemblies.Add("System.dll");
        }

        public void SetTTROutputAssembly(string assemblyOutputName)
        {
            this.OutputAssembly = Path.Combine(TTRPath.AssemblyOutputPath, assemblyOutputName);
        }
    }
}