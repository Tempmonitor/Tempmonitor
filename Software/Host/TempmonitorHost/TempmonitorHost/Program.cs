using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempmonitorHost
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
            Form form = new mainform();

            if (Properties.Settings.Default.FirstRun)
            {
                form.Show();

                Autostart start = new Autostart();
                start.CreateTask();

                Properties.Settings.Default.FirstRun = false;
                Properties.Settings.Default.Save();
            }
            
            Application.Run();
        }
    }
}
