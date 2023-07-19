Imports System.Data.OleDb
Imports System.Runtime.Remoting.Messaging

Public Class RiderDetails
    Private Sub BtnClose_MouseEnter(sender As Object, e As EventArgs) Handles btnClose.MouseEnter
        btnClose.ForeColor = Color.White
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        btnClose.ForeColor = Color.Black
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub RiderDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
        Dim strsql As String = "SELECT * FROM [Cart] WHERE [Order ID] = '" & RiderNotification.id & "'"
        Dim mycmd As New OleDbCommand(strsql, mycon)

        mycon.Open()
        Dim reader As OleDbDataReader = mycmd.ExecuteReader
        While reader.Read()
            lstFood.Items.Add(reader("Food Name"))
            lstCafeName.Items.Add(reader("Cafe Name"))
        End While
        mycon.Close()
    End Sub
End Class