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
    using TTR.Logging;
    using TTR.Loader;
    
    public class TTRCodeRunner
    {
        private readonly string domainName = "TestDomain";

        public void TimeExecution(string fullAssemblyName)
        {
            try
            {
                AppDomainSetup setup = new AppDomainSetup();
                setup.ApplicationName = "MyApplication";

                AppDomain domain = AppDomain.CreateDomain("MyApplication", AppDomain.CurrentDomain.Evidence, setup);

                AssemblyLoader loader = (AssemblyLoader)domain.CreateInstanceAndUnwrap(typeof(AssemblyLoader).Assembly.FullName, "TTR.Loader.AssemblyLoader");

                loader.LoadAssembly(fullAssemblyName);

                loader.TimeCode();

                long ttr = loader.timeToRun;

                Log.Instance.Add(string.Format("Code execution time: {0} milliseconds", ttr.ToString()));

                AppDomain.Unload(domain);
            }
            catch (Exception ex)
            {

            }
        }
    }
}