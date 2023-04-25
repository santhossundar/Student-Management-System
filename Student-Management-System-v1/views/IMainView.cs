using System;
using System.Collections.Generic;

namespace Student_Management_System_v1.views
{
    public interface IMainView
    {
        event EventHandler StudentBtnClicked;
        event EventHandler StudentAddBtnClicked;
        event EventHandler StudentManageBtnClicked;
        event EventHandler CourseBtnClicked;
        event EventHandler CourseAddBtnClicked;
        event EventHandler CourseManageBtnClicked;

        event EventHandler TopPanelMouseDown;
    }
}
