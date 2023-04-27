using Student_Management_System_v1.presenters;
using Student_Management_System_v1.views;
using System;
using System.Windows.Forms;

namespace Student_Management_System_v1.forms
{
    public partial class StudentAddView : Form, IStudentAddView
    {
        private static StudentAddView studentAddView;

        private StudentAddView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnAdd.Click += delegate
            {
                AddBtnClicked?.Invoke(this, EventArgs.Empty);
            };
        }

        public static StudentAddView GetInstance()
        {
            if (studentAddView == null)
            {
                studentAddView = new StudentAddView();
                studentAddView.TopLevel = false;
                studentAddView.BringToFront();
                studentAddView.FormBorderStyle = FormBorderStyle.None;
                studentAddView.Dock = DockStyle.Fill;
                studentAddView.Show();
            }
            else
                if (studentAddView.WindowState == FormWindowState.Minimized)
                    studentAddView.WindowState = FormWindowState.Normal;
                else
                    studentAddView.BringToFront();

            return studentAddView;
        }

        public string FirstName
        {
            get => FirstNameTxtBox.Text;
            set => FirstNameTxtBox.Text = value;
        }

        public string LastName
        {
            get => LastNameTxtBox.Text;
            set => LastNameTxtBox.Text = value;
        }

        public string DOB
        {
            get => DOBDateTimePicker.Text;
        }

        public string AddressNo
        {
            get => AddressNoiTxtBox.Text;
            set => AddressNoiTxtBox.Text = value;
        }

        public string AddressStreet
        {
            get => AddressStreetTxtBox.Text;
            set => AddressStreetTxtBox.Text = value;
        }

        public string AddressCity
        {
            get => AddressCityTxtBox.Text;
            set => AddressCityTxtBox.Text = value;
        }

        public string StdNo
        {
            get => StdNoTxtBox.Text;
            set => StdNoTxtBox.Text = value;
        }

        public event EventHandler AddBtnClicked;
    }
}