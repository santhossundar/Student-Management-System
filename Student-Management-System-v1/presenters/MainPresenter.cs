using Student_Management_System_v1.forms;
using Student_Management_System_v1.views;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Student_Management_System_v1.presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private IStudentView studentView;
        private IStudentAddView studentAddView;

        public MainPresenter(IMainView mainView) 
        {
            this.mainView = mainView;
            this.mainView.StudentBtnClicked += ShowStudentView;
            this.mainView.StudentAddBtnClicked += ShowStudentAddView;
        }

        private void ShowStudentAddView(object sender, EventArgs e)
        {
            studentAddView = StudentAddView.GetInstance();

            if (mainView.ChildFormPanel.Controls.Count > 0)
                mainView.ChildFormPanel.Controls.Clear();
            mainView.ChildFormPanel.Controls.Add((Form)studentAddView);

            string sqlConnectionString = ConfigurationManager
                .ConnectionStrings["SQlConnection"]
                .ConnectionString;
            new StudentAddPresenter(studentAddView, sqlConnectionString);
        }

        private void ShowStudentView(object sender, EventArgs e)
        {
            studentView = StudentView.GetInstance();
            
            if (mainView.ChildFormPanel.Controls.Count > 0)
                mainView.ChildFormPanel.Controls.Clear();
            mainView.ChildFormPanel.Controls.Add((Form)studentView);
            
            new StudentPresenter(studentView);       
        }
    }
}
