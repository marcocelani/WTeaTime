using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTeaTime
{
    static class Program
    {
        static Mutex mutex = new Mutex(true, "WTeaTime_{d2b33fa2-df60-4a0d-89bd-504cd7ba65a7}");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new StartForm());
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("Another instance is running...");
            }
        }
    }
}
