Imports System.Data.OleDb

Public Class OrderSummary
    Private Sub OrderSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")

        Dim cartsql As String = "SELECT * FROM [Cart] WHERE [User ID] = '" & GlobalVariables.UserID & "'"
        Dim cartcmd As New OleDbCommand(cartsql, mycon)

        Dim ordersql As String = "SELECT * FROM [Transaction History] WHERE [Order ID] = '" & CustomerTransactionHistory.order & "'"
        Dim ordercmd As New OleDbCommand(ordersql, mycon)
        mycon.Open()

        Dim cartreader As OleDbDataReader = cartcmd.ExecuteReader
        Dim orderreader As OleDbDataReader = ordercmd.ExecuteReader
        If cartreader("Status") = "History" Then
            While cartreader.Read()
                lstFood.Items.Add(cartreader("Food Name"))
                lstQuantity.Items.Add("x" & cartreader("Quantity"))
                lstCost.Items.Add(cartreader("Cost"))
            End While
        End If
        If orderreader("Status") = "Done" Then
            While orderreader.Read()
                lblOrder.Text = orderreader("Order ID")
                lblDatetime.Text = orderreader("Datetime")
                lblSubtotal.Text = orderreader("Subtotal")
                lblPoints.Text = orderreader("Points")
                lblDelivery.Text = orderreader("Delivery/Pickup")
                lblTotal.Text = orderreader("Total")
            End While
        End If
        mycon.Close()
    End Sub
End Class
