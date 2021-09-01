Imports System.Data

Namespace AutoPopulateColumns
	Public Class SimpleData
		Private Shared dt As New DataTable()
		Public Shared ReadOnly Property Numbers() As DataView
			Get
				If dt.Rows.Count = 0 Then
					CreateSimpleData()
				End If
				Return dt.DefaultView
			End Get
		End Property
		Private Shared Sub CreateSimpleData()
			dt.Columns.Add("col1")
			dt.Columns.Add("col2")
			dt.Rows.Add(New Object() { 1, "one" })
			dt.Rows.Add(New Object() { 2, "two" })
			dt.Rows.Add(New Object() { 3, "three" })
			dt.Rows.Add(New Object() { 4, "four" })
			dt.Rows.Add(New Object() { 5, "five" })
		End Sub
	End Class
End Namespace
