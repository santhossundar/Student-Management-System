using Student_Management_System_v1.forms;
using Student_Management_System_v1.presenters;
using Student_Management_System_v1.repositories;
using Student_Management_System_v1.views;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;
            
            IMainView mainView = new MainView();
            IStudentRepository studentRepository = new StudentRepository(sqlConnectionString);
            new MainPresenter(mainView);
            Application.Run((Form)mainView);
        }
    }
}
