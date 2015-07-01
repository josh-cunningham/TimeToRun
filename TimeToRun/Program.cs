using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeToRun
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TimeToRun timeToRun = new TimeToRun();
            Application.ApplicationExit += timeToRun.OnApplicationExit;
            Application.Run(timeToRun);
        }
    }
}

/*
Using System;
Using System;
namespace TestNamespace
{ 
    static class TestProgram 
    {
        public static void Main() 
        { 
            TestClass test = new TestClass(); 
            test.Initialize(); test.RunCode(); 
        } 
    } 
    public class TestClass 
    {
        public void Initialize() 
        {
        }
        public void RunCode() 
        {
            Console.WriteLine("Hello World");
            Console.ReadKey();
        }
    } 
}*/