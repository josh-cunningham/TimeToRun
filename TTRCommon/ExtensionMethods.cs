namespace TTR.Common
{
    using System;
    using System.CodeDom.Compiler;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public static class TTRExtensionMethods
    {
        public static void AddDependentAssemblies(this AppDomain appDomain, Assembly assembly)
        {
            AssemblyName[] referencedAssemblies = assembly.GetReferencedAssemblies();

            foreach (AssemblyName dependentAssembly in referencedAssemblies)
            {
                bool dependencyAlreadyLoaded = appDomain.GetAssemblies().Where(a => a.FullName == dependentAssembly.FullName).Any();

                if (!dependencyAlreadyLoaded)
                {
                    appDomain.Load(dependentAssembly.FullName);
                }
            }
        }

        public static string GetCompilationReport(this CompilerResults results)
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

            return logsString;
        }
    }
}