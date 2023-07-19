Imports System.Data.OleDb

Public Class RiderOrder
    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Dim response As String = MsgBox("Are you confirm to accept this order?", 4 + MsgBoxStyle.Question, "Order")
        If response = vbYes Then
            Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
            Dim strsql As String = "UPDATE [Transaction History] SET [Status] = @status, [Rider ID] = @id WHERE [Status] = '2nd Stage' AND [Order ID] = @orderid"
            Dim mycmd As New OleDbCommand(strsql, mycon)
            mycon.Open()

            mycmd.Parameters.AddWithValue("@status", "3rd Stage")
            mycmd.Parameters.AddWithValue("@id", GlobalVariables.UserID)
            mycmd.Parameters.AddWithValue("@orderid", RiderNotification.id)

            mycmd.ExecuteNonQuery()
            mycon.Close()

            MsgBox("Order Accepted!", 0 + MsgBoxStyle.Information, "Order")
            Me.Dispose()
        End If
    End Sub

    Private Sub BtnDecline_Click(sender As Object, e As EventArgs) Handles btnDecline.Click
        Dim response As String = MsgBox("Are you confirm to decline this order?", 4 + MsgBoxStyle.Question, "Order")
        If response = vbYes Then
            Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
            Dim strsql As String = "UPDATE [Transaction History] SET [Status] = @status WHERE [Status] = '2nd Stage' AND [Order ID] = @orderid"
            Dim mycmd As New OleDbCommand(strsql, mycon)
            mycon.Open()

            mycmd.Parameters.AddWithValue("@status", "Declined")
            mycmd.Parameters.AddWithValue("@orderid", RiderNotification.id)

            mycmd.ExecuteNonQuery()
            mycon.Close()

            MsgBox("Order declined!", 0 + MsgBoxStyle.Information, "Order")
            Me.Dispose()
        End If
    End Sub

    Private Sub LblDetails_Click(sender As Object, e As EventArgs) Handles lblDetails.Click
        RiderDetails.Show()
    End Sub

    Private Sub LblDetails_MouseEnter(sender As Object, e As EventArgs) Handles lblDetails.MouseEnter
        lblDetails.ForeColor = Color.FromArgb(128, 255, 255)
    End Sub

    Private Sub LblDetails_MouseLeave(sender As Object, e As EventArgs) Handles lblDetails.MouseLeave
        lblDetails.ForeColor = Color.FromName("MenuHighlight")
    End Sub
End Class
