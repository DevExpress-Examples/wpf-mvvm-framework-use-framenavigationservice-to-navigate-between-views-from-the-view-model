using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace DXSample.ViewModel {
    public class NextDetailViewModel {
        public virtual INavigationService NavigationService { get { return null; } }
        public void NavigateHome() {
            NavigationService.Navigate("HomeView");
        }
    }
}
