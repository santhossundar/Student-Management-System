using Student_Management_System_v1.forms;
using Student_Management_System_v1.views;

namespace Student_Management_System_v1.presenters
{
    public class MainPresenter
    {
        private IMainView uiMainView;
        public MainPresenter(IMainView uiMainView) 
        {
            this.uiMainView = uiMainView;
        }

        public void Perform()
        {
            Register uiRegister = new Register();
            uiRegister.Show();
        }
    }
}
