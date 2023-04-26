using Student_Management_System_v1.views;
using System;
using System.Windows.Forms;

namespace Student_Management_System_v1.presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private IStudentView studentView;

        public MainPresenter(IMainView mainView) 
        {
            this.mainView = mainView;
            this.mainView.StudentBtnClicked += ShowStudentView;
        }
        private void ShowStudentView(object sender, EventArgs e)
        {
            //studentView = StudentView.GetInstance((MainView)mainView);

            StudentView studentView = new StudentView();
            studentView.TopLevel = false;
            if (mainView.ChildFormPanel.Controls.Count > 0)
            {
                mainView.ChildFormPanel.Controls.Clear();
            }
            mainView.ChildFormPanel.Controls.Add(studentView);
            studentView.BringToFront();
            studentView.FormBorderStyle = FormBorderStyle.None;
            studentView.Dock = DockStyle.Fill;
            studentView.Show();
            new StudentPresenter(studentView);  
           
            
            
        }

        /*
        public void Perform()
        {
            Register uiRegister = new Register();
            uiRegister.Show();
        }

        public BindingSource UpdateGridView()
        {
            connection.Connect();
            string query = "select * from student;";
            DataSet ds = connection.ExcecuteAdapter(query);
            
            bindingSource.DataSource = ds.Tables["student"];

            return bindingSource;
        }
        */
    }
}
