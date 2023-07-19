Imports System.Data.OleDb
Imports System.Globalization

Public Class CustomerTransactionHistory
    Public Shared order As String
    Private Sub CustomerTransactionHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
        Dim ordersql As String = "SELECT * FROM [Transaction History] WHERE [Status] = 'Done' AND [User ID] = '" & GlobalVariables.UserID & "'"
        Dim ordercmd As New OleDbCommand(ordersql, mycon)

        Dim TransactionItem As New TransactionItem
        mycon.Open()
        Dim orderreader As OleDbDataReader = ordercmd.ExecuteReader
        While orderreader.Read()
            TransactionItem.lblOrder.Text = "Order" & orderreader("Order ID")
            order = TransactionItem.lblOrder.Text
            TransactionItem.lblCorner.Text = "Card Number: " & orderreader("Card Number")
            TransactionItem.lblDate.Text = orderreader("Datetime")
            TransactionItem.lblTotal.Text = "Total: RM" & orderreader("Total")
            PanelTransactionHistory.Controls.Add(TransactionItem)
        End While
        mycon.Close()
    End Sub
End Class
