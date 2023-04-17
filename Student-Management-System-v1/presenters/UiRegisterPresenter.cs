using Student_Management_System_v1.models;
using Student_Management_System_v1.views;
using System.Collections.Generic;

namespace Student_Management_System_v1.presenters
{
    public class UiRegisterPresenter
    {
        IUiRegisterView uiRegisterView;
        IStudent student;
        public UiRegisterPresenter(
            IUiRegisterView uiRegisterView,
            IStudent student) 
        {
            this.uiRegisterView = uiRegisterView;
            this.student = student;
        }

        private void BindModelView()
        {
            List<string> list = student.SetInfo();
            uiRegisterView.StdNo = list[0];
            uiRegisterView.FirstName = list[1];
            uiRegisterView.LastName = list[2];
        }

        public void Init()
        {
            // Code Logic
        }

        public void Perform()
        {
            Init();
        }
    }
}
