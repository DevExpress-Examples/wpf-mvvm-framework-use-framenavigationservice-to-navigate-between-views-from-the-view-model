using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace DXSample.ViewModel {
    public class HomeViewModel {
        private INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }

        public HomeViewModel() {  }

        public void NavigateDetails() {
            NavigationService.Navigate("DetailView", null, this);
        }
    }
}
