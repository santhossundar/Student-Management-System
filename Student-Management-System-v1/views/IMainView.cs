using System;

namespace Student_Management_System_v1.views
{
    public interface IMainView
    {
        int MaleCount { get; set; }
        int FemaleCount { get; set; }
        event EventHandler NavRegisterBtnClicked;
    }
}
