using ComponentFactory.Krypton.Toolkit;
using Student_Management_System_v1.presenters;
using Student_Management_System_v1.views;
using System;

namespace Student_Management_System_v1.forms
{
    public partial class Register : KryptonForm, IRegisterView
    {
        RegisterPresenter registerPresenter;

        public Register()
        {
            InitializeComponent();
            registerPresenter = new RegisterPresenter(this);
        }

        public string FirstName
        {
            get => firstNameTxtBox.Text;
            set => firstNameTxtBox.Text = value;
        }

        public string LastName
        {
            get => lastNameTxtBox.Text;
            set => lastNameTxtBox.Text = value;
        }

        public string DOB
        {
            get => dobDateTimePicker.Text;
        }

        public string AddressNo
        {
            get => addressNoiTxtBox.Text;
            set => addressNoiTxtBox.Text = value;
        }

        public string AddressStreet
        {
            get => addressStreetTxtBox.Text;
            set => addressStreetTxtBox.Text = value;
        }

        public string AddressCity
        {
            get => addressCityTxtBox.Text;
            set => addressCityTxtBox.Text = value;
        }

        public string StdNo
        {
            get => stdNoTxtBox.Text;
            set => stdNoTxtBox.Text = value;
        }

        public event EventHandler AddBtnClicked;

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            registerPresenter.SaveInfo();
        }
    }
}