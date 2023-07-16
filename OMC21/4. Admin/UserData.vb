Imports System.Data.OleDb

Public Class UserData
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
    Private Sub UserData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strsql As String = "SELECT * FROM [Userdatabase] WHERE [User Type] = 'Customer'"
        Dim mycmd As New OleDbCommand(strsql, mycon)
        Dim dt As New DataTable()
        mycon.Open()
        dt.Load(mycmd.ExecuteReader())
        mycon.Close()
        UserDataGrid.DataSource = dt
        btnCustomer.BackColor = Color.Gray
    End Sub
    Sub Resett()
        btnCustomer.BackColor = Color.Gainsboro
        btnRider.BackColor = Color.Gainsboro
        btnCafeOwner.BackColor = Color.Gainsboro
    End Sub
    Private Sub BtnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Dim strsql As String = "SELECT * FROM [Userdatabase] WHERE [User Type] = 'Customer'"
        Dim mycmd As New OleDbCommand(strsql, mycon)
        Dim dt As New DataTable()
        mycon.Open()
        dt.Load(mycmd.ExecuteReader())
        mycon.Close()
        UserDataGrid.DataSource = dt
        Resett()
        btnCustomer.BackColor = Color.Gray
    End Sub

    Private Sub BtnRider_Click(sender As Object, e As EventArgs) Handles btnRider.Click
        Dim strsql As String = "SELECT * FROM [Userdatabase] WHERE [User Type] = 'Rider'"
        Dim mycmd As New OleDbCommand(strsql, mycon)
        Dim dt As New DataTable()
        mycon.Open()
        dt.Load(mycmd.ExecuteReader())
        mycon.Close()
        UserDataGrid.DataSource = dt
        Resett()
        btnRider.BackColor = Color.Gray
    End Sub

    Private Sub BtnCafeOwner_Click(sender As Object, e As EventArgs) Handles btnCafeOwner.Click
        Dim strsql As String = "SELECT * FROM [Userdatabase] WHERE [User Type] = 'Café Owner'"
        Dim mycmd As New OleDbCommand(strsql, mycon)
        Dim dt As New DataTable()
        mycon.Open()
        dt.Load(mycmd.ExecuteReader())
        mycon.Close()
        UserDataGrid.DataSource = dt
        Resett()
        btnCafeOwner.BackColor = Color.Gray
    End Sub
End Class
