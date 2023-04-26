using Student_Management_System_v1.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System_v1.presenters
{
    public class StudentPresenter
    {
        private IStudentView studentView; 
        public StudentPresenter(IStudentView studentView) 
        {
            this.studentView = studentView;
        }
    }
}
