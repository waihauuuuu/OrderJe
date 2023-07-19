Imports System.Data.Common
Imports System.Data.OleDb

Public Class AddedCart
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim response = MsgBox("Are you sure to remove this order?", 4 + MsgBoxStyle.Question, "Remove Order")
        If response = MsgBoxResult.Yes Then
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb"
            Dim strsql As String = "DELETE FROM [Cart] WHERE [Cart ID] = " & Cart.CartID
            Using mycon As New OleDbConnection(connectionString)
                Using mycmd As New OleDbCommand(strsql, mycon)
                    mycon.Open()
                    mycmd.ExecuteNonQuery()
                    MsgBox("Remove successfully!", 0 + MessageBoxIcon.Information, "Deletion Successful")
                End Using
            End Using
        End If
        Me.Dispose()
    End Sub
End Class
