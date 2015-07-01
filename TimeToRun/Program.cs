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