Imports System.Collections.ObjectModel

Namespace AutoPopulateColumns

    Public Class Customer

        Public Property Name As String

        Public Property City As String
    End Class

    Public Class DataModel

        Public Shared Function GetCustomers() As ObservableCollection(Of Customer)
            Dim people As ObservableCollection(Of Customer) = New ObservableCollection(Of Customer)()
            people.Add(New Customer() With {.Name = "Gregory S. Price", .City = "Hong Kong"})
            people.Add(New Customer() With {.Name = "Irma R. Marshall", .City = "Madrid"})
            people.Add(New Customer() With {.Name = "John C. Powell", .City = "Los Angeles"})
            people.Add(New Customer() With {.Name = "Christian P. Laclair", .City = "London"})
            people.Add(New Customer() With {.Name = "Karen J. Kelly", .City = "Hong Kong"})
            people.Add(New Customer() With {.Name = "Brian C. Cowling", .City = "Los Angeles"})
            people.Add(New Customer() With {.Name = "Thomas C. Dawson", .City = "Madrid"})
            people.Add(New Customer() With {.Name = "Angel M. Wilson", .City = "Los Angeles"})
            people.Add(New Customer() With {.Name = "Winston C. Smith", .City = "London"})
            people.Add(New Customer() With {.Name = "Harold S. Brandes", .City = "Bangkok"})
            people.Add(New Customer() With {.Name = "Michael S. Blevins", .City = "Hong Kong"})
            people.Add(New Customer() With {.Name = "Jan K. Sisk", .City = "Bangkok"})
            people.Add(New Customer() With {.Name = "Sidney L. Holder", .City = "London"})
            Return people
        End Function
    End Class
End Namespace
