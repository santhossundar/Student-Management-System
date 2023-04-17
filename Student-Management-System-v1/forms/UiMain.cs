using ComponentFactory.Krypton.Toolkit;
using Student_Management_System_v1.views;

namespace Student_Management_System_v1
{
    public partial class UiMain : KryptonForm, IUiMainView
    {
        public UiMain()
        {
            InitializeComponent();
        }

        public int MaleCount { 
            get => throw new System.NotImplementedException(); 
            set => throw new System.NotImplementedException(); 
        }

        public int FemaleCount { 
            get => throw new System.NotImplementedException(); 
            set => throw new System.NotImplementedException(); 
        }
    }
}
