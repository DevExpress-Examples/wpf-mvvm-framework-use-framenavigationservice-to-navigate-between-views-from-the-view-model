using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace DXSample.ViewModel {
    public class MainViewModel {
        private INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }

        public MainViewModel() {  }

        public void OnViewLoaded() {
            NavigationService.Navigate("HomeView", null, this);
        }
    }
}
