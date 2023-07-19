Imports System.Data.OleDb

Public Class AdminTransactionHistory
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
    Private Sub AdminTransactionHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strsql As String = "SELECT * FROM [Transaction History]"
        Dim mycmd As New OleDbCommand(strsql, mycon)
        Dim dt As New DataTable()
        mycon.Open()
        dt.Load(mycmd.ExecuteReader())
        mycon.Close()
        TransactionDataGrid.DataSource = dt
    End Sub
End Class
