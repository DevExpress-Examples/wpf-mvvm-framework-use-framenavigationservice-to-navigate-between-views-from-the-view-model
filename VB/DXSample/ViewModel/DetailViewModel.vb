Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO

Namespace DXSample.ViewModel

    Public Class DetailViewModel

        Private ReadOnly Property NavigationService As INavigationService
            Get
                Return GetService(Of INavigationService)()
            End Get
        End Property

        Public Sub NavigateNextDetail()
            NavigationService.Navigate("NextDetailView", Nothing, Me)
        End Sub

        Public Sub NavigateBack()
            NavigationService.GoBack()
        End Sub

        Public Function CanNavigateBack() As Boolean
            Return NavigationService.CanGoBack
        End Function

        Public Sub NavigateForward()
            NavigationService.GoForward()
        End Sub

        Public Function CanNavigateForward() As Boolean
            Return NavigationService IsNot Nothing AndAlso NavigationService.CanGoForward
        End Function
    End Class
End Namespace
