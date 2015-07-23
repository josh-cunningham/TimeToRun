namespace TimeToRun
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
    using Types;
    using TTRLoader;
    
    public class TTRCodeRunner
    {
        private readonly string domainName = "TestDomain";

        public void TimeLastCompilation()
        {
            this.RunCode(TimeToRun.CreatedDllList.Last());
        }

        public void RunCode(string fullAssemblyName)
        {
            AppDomainSetup setup = new AppDomainSetup();
            setup.ApplicationName = "MyApplication";

            AppDomain domain = AppDomain.CreateDomain("MyApplication", AppDomain.CurrentDomain.Evidence, setup);

            Loader loader = (Loader)domain.CreateInstanceAndUnwrap(typeof(Loader).Assembly.FullName, "TTRLoader.Loader");

            loader.LoadAssembly(fullAssemblyName);

            loader.TimeCode();

            long ttr = loader.timeToRun;

            Log.Instance.Add(string.Format("Code execution time: {0} milliseconds", ttr.ToString()));

            AppDomain.Unload(domain);
        }
    }
}