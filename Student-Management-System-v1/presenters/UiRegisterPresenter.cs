using Student_Management_System_v1.views;

namespace Student_Management_System_v1.presenters
{
    public class UiRegisterPresenter
    {
        IUiRegisterView uiRegisterView;
        public UiRegisterPresenter(IUiRegisterView uiRegisterView) 
        {
            this.uiRegisterView = uiRegisterView;
        }

        public void Perform()
        {
            
        }
    }
}
