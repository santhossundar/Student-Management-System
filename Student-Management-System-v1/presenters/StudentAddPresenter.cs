using Student_Management_System_v1.models;
using Student_Management_System_v1.repositories;
using Student_Management_System_v1.views;
using System;
using System.Collections.Generic;

namespace Student_Management_System_v1.presenters
{
    public class StudentAddPresenter
    {
        IStudentAddView studentAddView;
        private string connectionString;

        public StudentAddPresenter(
            IStudentAddView studentAddView,
            string connectionString) 
        {
            this.studentAddView = studentAddView;
            this.connectionString = connectionString;
            studentAddView.AddBtnClicked += AddStudentDetails;
        }

        private void AddStudentDetails(object sender, EventArgs e)
        {
            IStudentRepository studentRepository = new StudentRepository(connectionString);

            List<string> student = new List<string>();
            student.Add(studentAddView.StdNo);
            student.Add(studentAddView.FirstName);
            student.Add(studentAddView.LastName);
            student.Add(studentAddView.DOB);
            student.Add(studentAddView.AddressNo);
            student.Add(studentAddView.AddressStreet);
            student.Add(studentAddView.AddressCity);

            studentRepository.Add(student);
        }
    }
}
