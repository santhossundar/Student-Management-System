using ComponentFactory.Krypton.Toolkit;
using Student_Management_System_v1.presenters;
using Student_Management_System_v1.views;

namespace Student_Management_System_v1.forms
{
    public partial class UiRegister : KryptonForm, IUiRegisterView
    {
        UiRegisterPresenter presenter;
        UiRegisterView view;
        public UiRegister()
        {
            InitializeComponent();
            presenter = new UiRegisterPresenter(this);
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

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            presenter.Perform();
        }
    }
}