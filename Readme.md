<!-- default file list -->
*Files to look at*:

* [DetailView.xaml](./CS/DXSample/View/DetailView.xaml) (VB: [DetailView.xaml](./VB/DXSample/View/DetailView.xaml))
* [HomeView.xaml](./CS/DXSample/View/HomeView.xaml) (VB: [HomeView.xaml](./VB/DXSample/View/HomeView.xaml))
* [MainView.xaml](./CS/DXSample/View/MainView.xaml) (VB: [MainView.xaml](./VB/DXSample/View/MainView.xaml))
* [DetailViewModel.cs](./CS/DXSample/ViewModel/DetailViewModel.cs) (VB: [DetailViewModel.vb](./VB/DXSample/ViewModel/DetailViewModel.vb))
* [HomeViewModel.cs](./CS/DXSample/ViewModel/HomeViewModel.cs) (VB: [HomeViewModel.vb](./VB/DXSample/ViewModel/HomeViewModel.vb))
* [MainViewModel.cs](./CS/DXSample/ViewModel/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/DXSample/ViewModel/MainViewModel.vb))
<!-- default file list end -->
# How to: Initiate Navigation between Views from the View Model Using FrameNavigationService


<p>The FrameNavigationService provides methods to navigate between Views within a NavigationFrame. This example shows how to use this service.</p><p>In this example, the MainWindow contains a NavigationFrame, which shows a HomeView at startup. The HomeView contains a Tile, which invokes a command to navigate to a DetailView when clicked. The DetailView contains the Back button for backward navigation.</p>

<br/>


