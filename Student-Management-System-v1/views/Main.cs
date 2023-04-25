using MySql.Data.MySqlClient;
using Student_Management_System_v1.presenters;
using Student_Management_System_v1.views;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Student_Management_System_v1
{
    public partial class Main : Form, IMainView
    {
        public Main()
        {
            InitializeComponent();
            Design();
            AssociateAndRaiseViewEvents();
        }

        public event EventHandler StudentBtnClicked;
        public event EventHandler StudentAddBtnClicked;
        public event EventHandler StudentManageBtnClicked;
        public event EventHandler CourseBtnClicked;
        public event EventHandler CourseAddBtnClicked;
        public event EventHandler CourseManageBtnClicked;
        public event EventHandler TopPanelMouseDown;

        private void AssociateAndRaiseViewEvents()
        {
            BtnStudent.Click += delegate
            {
                PanelCourse.Visible = false;
                PanelStudent.Visible = true;
                StudentBtnClicked?.Invoke(this, EventArgs.Empty);
            };

            BtnAddStudent.Click += delegate
            {
                StudentAddBtnClicked?.Invoke(this, EventArgs.Empty);
            };

            BtnManageStudent.Click += delegate
            {
                StudentManageBtnClicked?.Invoke(this, EventArgs.Empty);
            };

            BtnCourse.Click += delegate
            {
                PanelStudent.Visible = false;
                PanelCourse.Visible = true;
                CourseBtnClicked?.Invoke(this, EventArgs.Empty);
            };

            BtnAddCourse.Click += delegate
            {
                CourseAddBtnClicked?.Invoke(this, EventArgs.Empty);
            };

            BtnManageCourse.Click += delegate
            {
                CourseManageBtnClicked?.Invoke(this, EventArgs.Empty);
            };

            BtnClose.Click += delegate
            {
                this.Close();
            };

            BtnMaximize.Click += delegate
            {
                if (WindowState == FormWindowState.Normal)
                    WindowState = FormWindowState.Maximized;
                else
                    WindowState = FormWindowState.Normal;
            };

            BtnMinimize.Click += delegate
            {
                WindowState = FormWindowState.Minimized;
            };

            TopPanel.MouseDown += delegate
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            };
        }

        private void Design()
        {
            FormBorderStyle = FormBorderStyle.None;
            PanelStudent.Visible = false;
            PanelCourse.Visible = false;
            TopPanel.BackColor = Color.FromArgb(0, 92, 184);
            PanelContent.BackColor = Color.FromArgb(0, 117, 235);
        }

        [DllImport("user32.DLL", EntryPoint="ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
}
