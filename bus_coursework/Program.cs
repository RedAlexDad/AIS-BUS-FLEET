using bus_coursework.MyClass;
using Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bus_coursework
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Edit_DB());
            //Application.Run(new Report_admin());
            //Application.Run(new Edit_status_bus());
            //Application.Run(new Search_bus());
            //Application.Run(new Administrator());
            //Application.Run(new Administrator());
            Application.Run(new Autorization());
        }
    }
}
