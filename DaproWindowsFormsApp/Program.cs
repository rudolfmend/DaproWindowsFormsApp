
// C:\Users\rudol\source\repos\DaproWindowsFormsApp\DaproWindowsFormsApp\Program.cs
using System;
using System.Windows.Forms;

namespace DaproWindowsFormsApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            log4net.Config.XmlConfigurator.Configure();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DataViewerForm());
        }
    }
}

