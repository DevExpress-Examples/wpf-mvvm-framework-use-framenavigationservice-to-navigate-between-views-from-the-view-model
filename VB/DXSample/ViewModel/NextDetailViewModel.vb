Imports DevExpress.Mvvm

Namespace DXSample.ViewModel

    Public Class NextDetailViewModel

        Public Overridable ReadOnly Property NavigationService As INavigationService
            Get
                Return Nothing
            End Get
        End Property

        Public Sub NavigateHome()
            NavigationService.Navigate("HomeView")
        End Sub
    End Class
End Namespace
