Imports System.Data.OleDb

Public Class CafeOwnerTransactionHistory
    Private Sub BtnNotification_Click(sender As Object, e As EventArgs) Handles btnNotification.Click
        Dim CafeOwnerHomepage As CafeOwnerHomepage = TryCast(Me.ParentForm, CafeOwnerHomepage)
        Dim panel As Panel = TryCast(ParentForm.Controls("pnlContainer"), Panel)
        If panel IsNot Nothing Then
            'change usercontrol
            Dim CafeOwnerNotification As New CafeOwnerNotification
            panel.Controls.Clear()
            panel.Controls.Add(CafeOwnerNotification)
        End If
        CafeOwnerHomepage.btnTransaction.BackColor = Color.FromArgb(30, 30, 30)
        CafeOwnerHomepage.iconTransaction.BackColor = Color.FromArgb(30, 30, 30)
    End Sub

    Private Sub CafeOwnerTransactionHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
        Dim ordersql As String = "SELECT * FROM [Transaction History] WHERE [Status] = 'Done'"
        Dim ordercmd As New OleDbCommand(ordersql, mycon)

        Dim TransactionItem As New TransactionItem
        mycon.Open()
        Dim orderreader As OleDbDataReader = ordercmd.ExecuteReader
        While orderreader.Read()
            Dim cartsql As String = "SELECT * FROM [CART] WHERE [Cafe Name] = '" & CafeOwnerHomepage.lblCafeName.Text & "'"
            Dim cartcmd As New OleDbCommand(cartsql, mycon)
            Dim cartreader As OleDbDataReader = cartcmd.ExecuteReader
            TransactionItem.lblOrder.Text = "Order" & orderreader("Order ID")
            TransactionItem.lblDate.Text = orderreader("Datetime")
            While cartreader.Read()
                TransactionItem.lblCorner.Text = "Food Name: " & cartreader("Food Name") & " x" & cartreader("Quantity")
                TransactionItem.lblTotal.Text = "Total: RM" & cartreader("Cost")
            End While
            PanelTransactionHistory.Controls.Add(TransactionItem)
        End While
        mycon.Close()
    End Sub
End Class
