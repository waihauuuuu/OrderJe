Imports System.Data.OleDb

Public Class MyPoints
    Public Shared Points As Double
    Private Sub MyPoints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
        Dim Count As Integer = 0
        Dim sqlCount As String = "SELECT COUNT(*) FROM [Transaction History] WHERE [User ID] = '" & GlobalVariables.UserID & "'"

        Dim strsql As String = "SELECT * FROM [Transaction History]"
        Dim mycmd As New OleDbCommand(strsql, mycon)

        mycon.Open()
        Dim reader As OleDbDataReader = mycmd.ExecuteReader

        Using commandCount As New OleDbCommand(sqlCount, mycon)
            Count = CInt(commandCount.ExecuteScalar())
        End Using

        While reader.Read()
            If reader("Quantity") > 1 Then
                Count += reader("Quantity")
                Count -= 1
            End If
        End While

        lblPoint.Text = Count
        lblAmount.Text = "RM" & Format((Count / 10), "0.00")
        Points = CDbl(lblAmount.Text)

        mycon.Close()
    End Sub
End Class
