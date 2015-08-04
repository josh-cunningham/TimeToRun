namespace TTR.Code
{
    using System.CodeDom.Compiler;
    using System.IO;

    public class TTRCompilerParameters : CompilerParameters
    {
        public void SetTTRDefaults()
        {
            this.GenerateInMemory = false;
            this.TreatWarningsAsErrors = false;
            this.GenerateExecutable = false;
            this.CompilerOptions = "/optimize";

            this.SetTTROutputAssembly("TTR_defaultTempAssemblyName.dll");

            this.ReferencedAssemblies.Add("mscorlib.dll");
            this.ReferencedAssemblies.Add("System.dll");
        }

        public void SetTTROutputAssembly(string assemblyOutputName)
        {
            bool hasDllExtension = false; //ADD REGEX HERE

            if (hasDllExtension)
            {
                this.OutputAssembly = Path.Combine(TTRCompiler.AssemblyOutputPath, assemblyOutputName);
            }
            else
            {
                this.OutputAssembly = Path.Combine(TTRCompiler.AssemblyOutputPath, assemblyOutputName + ".dll");
            }
        }
    }
}
