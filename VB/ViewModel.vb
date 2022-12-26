Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel

Namespace AutoPopulateColumns

    Public Class ViewModel
        Inherits ViewModelBase

        Public Sub New()
            Source = DataModel.GetCustomers()
        End Sub

        Public ReadOnly Property Source As ObservableCollection(Of Customer)
    End Class
End Namespace
