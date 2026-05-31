using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iqamah
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Splash screen göster (ilk açılış)
            using (var splash = new FormSplash())
            {
                splash.ShowDialog();
            }

            // Ana formu başlat
            Application.Run(new FormMain());
        }
    }
}
