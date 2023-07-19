Imports System.Data.OleDb

Public Class RiderTransactionHistory
    Private Sub RiderTransactionHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
        Dim ordersql As String = "SELECT * FROM [Transaction History] WHERE [Status] = 'Done'"
        Dim ordercmd As New OleDbCommand(ordersql, mycon)

        Dim TransactionItem As New TransactionItem
        mycon.Open()
        Dim orderreader As OleDbDataReader = ordercmd.ExecuteReader
        While orderreader.Read()
            TransactionItem.lblOrder.Text = "Order" & orderreader("Order ID")
            Dim strsql As String = "SELECT * FROM [UserDatabase]"
            Dim mycmd As New OleDbCommand(strsql, mycon)
            Dim reader As OleDbDataReader = mycmd.ExecuteReader
            While reader.Read()
                If reader("User ID") = orderreader("User ID") Then
                    TransactionItem.lblCorner.Text = "Village: " & reader("Village")
                End If
            End While
            TransactionItem.lblDate.Text = orderreader("Datetime")
            TransactionItem.lblTotal.Text = "Delivery Fee: RM" & orderreader("Delivery/Pickup")
            PanelTransactionHistory.Controls.Add(TransactionItem)
        End While
        mycon.Close()
    End Sub
End Class
