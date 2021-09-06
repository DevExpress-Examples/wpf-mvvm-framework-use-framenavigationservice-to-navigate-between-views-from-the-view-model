Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO

Namespace DXSample.ViewModel
	Public Class HomeViewModel
		Private ReadOnly Property NavigationService() As INavigationService
			Get
				Return Me.GetService(Of INavigationService)()
			End Get
		End Property

		Public Sub New()
		End Sub

		Public Sub NavigateDetails()
			NavigationService.Navigate("DetailView", Nothing, Me)
		End Sub
	End Class
End Namespace
