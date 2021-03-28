using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appDevexpress
{
    static class Program1
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string name;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Login());
            //Application.Run(new inta());
        }
    }
}
