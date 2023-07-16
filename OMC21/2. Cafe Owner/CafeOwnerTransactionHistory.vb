Imports System.Data.OleDb

Public Class CafeOwnerTransactionHistory
    Private transactions As List(Of Transaction)
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb"
    Private Function GetTransactions() As List(Of Transaction)
        Dim transactions As New List(Of Transaction)()
        Dim strsql As String = "SELECT * FROM [Transaction History] WHERE [User ID] = '" & GlobalVariables.UserID & "'"
        Using mycon As New OleDbConnection(connectionString)
            Using mycmd As New OleDbCommand(strsql, mycon)
                mycon.Open()
                Using reader As OleDbDataReader = mycmd.ExecuteReader()
                    While reader.Read()
                        'Retrieve transaction data from the reader and create a transaction Object
                        Dim transaction As New Transaction With {
                            .CardNumber = reader("Card Number").ToString(),
                            .OrderItem = reader("Order Item").ToString(),
                            .Quantity = Integer.Parse(reader("Quantity").ToString()),
                            .Cost = Decimal.Parse(reader("Cost").ToString()),
                            .TimePurchased = DateTime.Parse(reader("Time Purchased").ToString())
                        }
                        transactions.Add(transaction)
                    End While
                End Using
            End Using
        End Using
        Return transactions
    End Function
    Private Function GetTransactions(datePicked As DateTime, cafeName As String) As List(Of Transaction)
        Dim transactions As New List(Of Transaction)()
        Dim strsql As String = "SELECT * FROM [Transaction History] WHERE [User ID] = @userID"
        Using mycon As New OleDbConnection(connectionString)
            Using mycmd As New OleDbCommand(strsql, mycon)
                mycmd.Parameters.AddWithValue("@userID", GlobalVariables.UserID)
                mycon.Open()
                Dim reader As OleDbDataReader = mycmd.ExecuteReader()
                While reader.Read()
                    If cafeName = reader("Cafe Name") AndAlso datePicked = reader.GetDateTime(reader.GetOrdinal("Time Purchased")).Date Then
                        Dim transaction As New Transaction With {
                            .CardNumber = reader("Card Number").ToString(),
                            .OrderItem = reader("Order Item").ToString(),
                            .Quantity = Integer.Parse(reader("Quantity").ToString()),
                            .Cost = Decimal.Parse(reader("Cost").ToString()),
                            .TimePurchased = DateTime.Parse(reader("Time Purchased").ToString())
                        }
                        'Add the transaction to the list
                        transactions.Add(transaction)
                    End If
                End While
            End Using
        End Using
        Return transactions
    End Function
    Public Class Transaction
        Public Property ID As Integer
        Public Property CardNumber As String
        Public Property OrderItem As String
        Public Property Quantity As Integer
        Public Property Cost As Decimal
        Public Property TimePurchased As DateTime
        Public Property UserID As Integer
    End Class
    Private Sub CustomerTransactionHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        transactions = GetTransactions()
        DisplayTransactions(transactions)
    End Sub
    Private Sub DisplayTransactions(transactions As List(Of Transaction))
        PanelTransactionHistory.Controls.Clear()
        If transactions IsNot Nothing AndAlso transactions.Count > 0 Then
            For Each transaction In transactions
                'Assign the transaction details to the UserControl's properties
                Dim transactionItem As New TransactionItem With {
                    .ID = transaction.ID,
                    .CardNumber = transaction.CardNumber,
                    .OrderItem = transaction.OrderItem,
                    .Quantity = transaction.Quantity,
                    .Cost = transaction.Cost,
                    .TimePurchased = transaction.TimePurchased,
                    .UserID = transaction.UserID
}
                PanelTransactionHistory.Controls.Add(transactionItem)
                transactionItem.Width = PanelTransactionHistory.ClientSize.Width
            Next
        Else
            'Handle the case where no transactions are found
            Dim noTransactionLabel As New Label With {
                .Text = "No transactions found.",
                .Font = New Font("Comic Sans MS", 12, FontStyle.Bold),
                .ForeColor = Color.Red,
                .TextAlign = ContentAlignment.MiddleCenter,
                .AutoSize = False,
                .Width = PanelTransactionHistory.Width,
                .Height = PanelTransactionHistory.Height
            }
            PanelTransactionHistory.Controls.Add(noTransactionLabel)
        End If
    End Sub
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Take the date from the DateTimePicker 
        Dim datePicked As Date = DateTimePicker1.Value.Date
    End Sub
End Class
