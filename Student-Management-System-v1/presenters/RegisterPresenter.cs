using Student_Management_System_v1.models;
using Student_Management_System_v1.views;
using System;
using System.Collections.Generic;

namespace Student_Management_System_v1.presenters
{
    public class RegisterPresenter
    {
        IRegisterView registerView;
        IStudent student;

        public RegisterPresenter(IRegisterView registerView) 
        {
            this.registerView = registerView;

            registerView.AddBtnClicked += SaveInfo;
        }

        private void BindModelView()
        {
            student = new models.Student(
                registerView.StdNo,
                registerView.FirstName,
                registerView.LastName,
                registerView.DOB,
                registerView.AddressNo,
                registerView.AddressStreet,
                registerView.AddressCity
                );   
        }

        public void SaveInfo(object sender, EventArgs e)
        {
            BindModelView();
            student.SaveInfo();
        }
    }
}
