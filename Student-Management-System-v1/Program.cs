using Student_Management_System_v1.presenters;
using Student_Management_System_v1.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System_v1
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

            IMainView mainView = new MainView();
            new MainPresenter(mainView);
            Application.Run((Form)mainView);
        }
    }
}
