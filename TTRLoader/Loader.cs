using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace TTRLoader
{
    public class Loader : MarshalByRefObject
    {
        public long timeToRun = -1;

        public Assembly testAssembly;
    
        public void LoadAssembly(string fullAssemblyName)
        {
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
            Module module = testAssembly.GetModule("TestNamespace0.dll");

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