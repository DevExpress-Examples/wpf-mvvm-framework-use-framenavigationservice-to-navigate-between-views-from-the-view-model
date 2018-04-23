using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace DXSample.ViewModel {
    public class DetailViewModel {
        private INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
        public void NavigateNextDetail() {
            NavigationService.Navigate("NextDetailView", null, this);
        }
        public void NavigateBack() {
            NavigationService.GoBack();
        }
        public bool CanNavigateBack() {
            return NavigationService.CanGoBack;
        }
        public void NavigateForward() {
            NavigationService.GoForward();
        }
        public bool CanNavigateForward() {
            return NavigationService != null && NavigationService.CanGoForward;
        }
    }
}