Imports System.Data.OleDb

Public Class AcceptOrder
    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Dim response As String = MsgBox("Are you confirm that the order is complete?", 4 + MsgBoxStyle.Question, "Order")
        If response = vbYes Then
            Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
            Dim strsql As String = "UPDATE [Transaction History] SET [Status] = @status WHERE [Status] = '1st Stage' AND [Order ID] = @id"
            Dim mycmd As New OleDbCommand(strsql, mycon)
            mycon.Open()

            mycmd.Parameters.AddWithValue("@status", "2nd Stage")
            mycmd.Parameters.AddWithValue("@orderid", CafeOwnerNotification.id)

            mycmd.ExecuteNonQuery()
            mycon.Close()

            MsgBox("Order done!", 0 + MsgBoxStyle.Information, "Order")
            Me.Dispose()
        End If
    End Sub

    Private Sub BtnDecline_Click(sender As Object, e As EventArgs) Handles btnDecline.Click
        Dim response As String = MsgBox("Are you confirm to decline this order?", 4 + MsgBoxStyle.Question, "Order")
        If response = vbYes Then
            Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
            Dim strsql As String = "UPDATE [Transaction History] SET [Status] = @status WHERE [Status] = '1st Stage' AND [Order ID] = @id"
            Dim mycmd As New OleDbCommand(strsql, mycon)
            mycon.Open()

            mycmd.Parameters.AddWithValue("@status", "Declined")
            mycmd.Parameters.AddWithValue("@orderid", CafeOwnerNotification.id)

            mycmd.ExecuteNonQuery()
            mycon.Close()

            MsgBox("Order declined!", 0 + MsgBoxStyle.Information, "Order")
            Me.Dispose()
        End If
    End Sub
End Class
