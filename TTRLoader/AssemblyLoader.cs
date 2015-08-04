namespace TTR.Loader
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    public class AssemblyLoader : MarshalByRefObject
    {
        //execution time in milliseconds
        public long timeToRun = -1;

        public Assembly testAssembly;
    
        public void LoadAssembly(string fullAssemblyName)
        {
            //set this first so if anything goes wrong at any time a wrong time cannot be returned
            timeToRun = -1;

            Assembly assembly = Assembly.ReflectionOnlyLoadFrom(fullAssemblyName);

            AssemblyName[] referencedAssemblies = assembly.GetReferencedAssemblies();

            foreach (AssemblyName referencedAssembly in referencedAssemblies)
            {
                if (!AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName == referencedAssembly.FullName).Any())
                {
                    AppDomain.CurrentDomain.Load(referencedAssembly.FullName);
                }
            }

            byte[] bytes = File.ReadAllBytes(assembly.Location);

            testAssembly = AppDomain.CurrentDomain.Load(bytes);
        }

        public void TimeCode()
        {
            Module module = testAssembly.Modules.First();

            Type testType = null;
            MethodInfo initializeMethodInfo = null;
            MethodInfo runCodeMethodInfo = null;

            object testClass = null;

            if (module != null)
            {
                testType = module.GetType("TestNamespace.TestClass");
            }

            if (testType != null)
            {
                initializeMethodInfo = testType.GetMethod("Initialize");
                runCodeMethodInfo = testType.GetMethod("Run");
                testClass = Activator.CreateInstance(testType);
            }

            if (initializeMethodInfo != null && runCodeMethodInfo != null && testClass != null)
            {
                try
                {
                    initializeMethodInfo.Invoke(testClass, new object[] { });
                    Stopwatch stopWatch = new Stopwatch();
                    stopWatch.Start();
                    runCodeMethodInfo.Invoke(testClass, new object[] { });
                    this.timeToRun = stopWatch.ElapsedMilliseconds;
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}