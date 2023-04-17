using Student_Management_System_v1.forms;
using Student_Management_System_v1.views;

namespace Student_Management_System_v1.presenters
{
    public class UiMainPresenter
    {
        private IUiMainView uiMainView;
        public UiMainPresenter(IUiMainView uiMainView) 
        {
            this.uiMainView = uiMainView;
        }

        public void Perform()
        {
            UiRegister uiRegister = new UiRegister();
            uiRegister.Show();
        }
    }
}
