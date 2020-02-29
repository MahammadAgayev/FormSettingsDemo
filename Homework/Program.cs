using System;
using System.IO;
using System.Windows.Forms;
using Homework.Infrastructure;
using Homework.Views;


namespace Homework
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Directory.Exists(SystemDefaults.ApplicationConfigurationDirectory))
            {
                Directory.CreateDirectory(SystemDefaults.ApplicationConfigurationDirectory);
            }
            if (!File.Exists(SystemDefaults.ApplicationConfigurationFile))
            {
                using (FormSettings frm = new FormSettings())
                {
                    frm.ShowDialog();
                }
            }
            Application.Run(new FormMain());
        }

       
    }
}
