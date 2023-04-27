using System;

namespace Student_Management_System_v1.views
{
    public interface IStudentAddView
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string DOB { get; }
        string AddressNo { get; set; }
        string AddressStreet { get; set; }
        string AddressCity { get; set; }
        string StdNo { get; set; }

        event EventHandler AddBtnClicked;
    }
}
