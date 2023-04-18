using ComponentFactory.Krypton.Toolkit;
using Student_Management_System_v1.presenters;
using Student_Management_System_v1.views;
using System;

namespace Student_Management_System_v1
{
    public partial class Main : KryptonForm, IMainView
    {
        private MainPresenter mainPresenter;
        public Main()
        {
            InitializeComponent();
            mainPresenter = new MainPresenter(this);
        }

        public int MaleCount { 
            get => throw new System.NotImplementedException(); 
            set => throw new System.NotImplementedException(); 
        }

        public int FemaleCount { 
            get => throw new System.NotImplementedException(); 
            set => throw new System.NotImplementedException(); 
        }

        public event EventHandler NavRegisterBtnClicked;

        private void NavBtnRegister_Click(object sender, System.EventArgs e)
        {
            mainPresenter.Perform();
        }
    }
}
