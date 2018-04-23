Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO

Namespace DXSample.ViewModel
	Public Class MainViewModel
		Private ReadOnly Property NavigationService() As INavigationService
			Get
				Return Me.GetService(Of INavigationService)()
			End Get
		End Property

		Public Sub New()
		End Sub

		Public Sub OnViewLoaded()
			NavigationService.Navigate("HomeView", Nothing, Me)
		End Sub
	End Class
End Namespace
