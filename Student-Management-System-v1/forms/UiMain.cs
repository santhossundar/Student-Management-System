using ComponentFactory.Krypton.Toolkit;
using Student_Management_System_v1.presenters;
using Student_Management_System_v1.views;

namespace Student_Management_System_v1
{
    public partial class UiMain : KryptonForm, IUiMainView
    {
        private UiMainPresenter presenter;
        public UiMain()
        {
            InitializeComponent();
            presenter = new UiMainPresenter(this);
        }

        public int MaleCount { 
            get => throw new System.NotImplementedException(); 
            set => throw new System.NotImplementedException(); 
        }

        public int FemaleCount { 
            get => throw new System.NotImplementedException(); 
            set => throw new System.NotImplementedException(); 
        }

        private void NavBtnRegister_Click(object sender, System.EventArgs e)
        {
            presenter.Perform();
        }
    }
}
