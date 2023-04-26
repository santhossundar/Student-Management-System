using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System_v1.views
{
    public partial class StudentView : Form, IStudentView
    {
        private static StudentView studentView;
        public StudentView()
        {
            InitializeComponent();
        }

        public string title { 
            get => label1.Text; 
            set => label1.Text = value; 
        }

        public static StudentView GetInstance(Form parent)
        {
            if(studentView == null)
            {
                studentView = new StudentView();
                
            } else
            {
                if(studentView.WindowState == FormWindowState.Minimized)
                {
                    studentView.WindowState = FormWindowState.Normal;
                } else
                {
                    studentView.BringToFront();
                }
            }
            
            return studentView;
        }
    }
}
