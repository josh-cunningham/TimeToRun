namespace TimeToRun
{
    using System;
    using System.Linq;
    using System.Reflection;

    public static class TTRExtensionMethods
    {
        public static void AddDependentAssemblies(this AppDomain appDomain, Assembly assembly)
        {
            AssemblyName[] referencedAssemblies = assembly.GetReferencedAssemblies();

            foreach (AssemblyName referencedAssembly in referencedAssemblies)
            {
                if (!appDomain.GetAssemblies().Where(a => a.FullName == referencedAssembly.FullName).Any())
                {
                    appDomain.Load(referencedAssembly.FullName);
                }
            }
        }
    }
}