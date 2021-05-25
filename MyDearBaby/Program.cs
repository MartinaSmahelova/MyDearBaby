using System;
using System.Reflection;
using System.Windows.Forms;

namespace MyDearBaby
{
    static class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MyDearChildMainForm());
            }
            catch (Exception ex)
            {
                log.Error($"There are some problems in main method.", ex);
            }
   
        }
    }
}
