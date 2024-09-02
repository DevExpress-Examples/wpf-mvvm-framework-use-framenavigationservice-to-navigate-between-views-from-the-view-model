<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128659476/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4697)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Use FrameNavigationService to Navigate between Views from the ViewModel

This example shows you how to use the FrameNavigationService to navigate between Views within a NavigationFrame.

<img src="/images/NavigationFrame.gif"/>

In this example, the MainWindow contains a NavigationFrame, which shows a HomeView at startup. The HomeView contains a Tile, which invokes a command to navigate to a DetailView when clicked. The DetailView contains the Back button for backward navigation.

<!-- default file list -->
## Files to Look At

* [DetailView.xaml](./CS/DXSample/View/DetailView.xaml) (VB: [DetailView.xaml](./VB/DXSample/View/DetailView.xaml))
* [HomeView.xaml](./CS/DXSample/View/HomeView.xaml) (VB: [HomeView.xaml](./VB/DXSample/View/HomeView.xaml))
* [MainView.xaml](./CS/DXSample/View/MainView.xaml) (VB: [MainView.xaml](./VB/DXSample/View/MainView.xaml))
* [DetailViewModel.cs](./CS/DXSample/ViewModel/DetailViewModel.cs) (VB: [DetailViewModel.vb](./VB/DXSample/ViewModel/DetailViewModel.vb))
* [HomeViewModel.cs](./CS/DXSample/ViewModel/HomeViewModel.cs) (VB: [HomeViewModel.vb](./VB/DXSample/ViewModel/HomeViewModel.vb))
* [MainViewModel.cs](./CS/DXSample/ViewModel/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/DXSample/ViewModel/MainViewModel.vb))
<!-- default file list end -->

## Documentation

 * [FrameNavigationService](https://docs.devexpress.com/WPF/113944/mvvm-framework/services/predefined-set/framenavigationservice)
 * [UI Services](https://docs.devexpress.com/WPF/17414/mvvm-framework/services)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-mvvm-framework-use-framenavigationservice-to-navigate-between-views-from-the-view-model&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-mvvm-framework-use-framenavigationservice-to-navigate-between-views-from-the-view-model&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
