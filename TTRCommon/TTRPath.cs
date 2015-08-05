namespace TTR.Common
{
    using System.IO;
    using System.Reflection;

    public class TTRPath
    {
        public static string BasePath
        {
            get
            {
                return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            }
        }

        public static string SavedCodePath
        {
            get
            {
                return Path.Combine(BasePath, "TTRCode");
            }
        }

        public static string ExampleCodePath
        {
            get
            {
                return Path.Combine(SavedCodePath, "Examples");
            }
        }

        public static string AssemblyOutputPath
        {
            get
            {
                return Path.Combine(BasePath, "TTRCompilations");
            }
        }
    }
}