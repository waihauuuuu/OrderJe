Imports System.Data.OleDb

Public Class CustomerReceipt
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

    End Sub

    Private Sub CustomerReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")

        Dim cartsql As String = "SELECT * FROM [Cart] WHERE [User ID] = '" & GlobalVariables.UserID & "'"
        Dim cartcmd As New OleDbCommand(cartsql, mycon)

        Dim ordersql As String = "SELECT * FROM [Transaction History] WHERE [Order ID] = '" & Payment.orderID & "'"
        Dim ordercmd As New OleDbCommand(ordersql, mycon)
        mycon.Open()

        Dim cartreader As OleDbDataReader = cartcmd.ExecuteReader
        While cartreader.Read()
                lstFood.Items.Add(cartreader("Food Name"))
                lstQuantity.Items.Add("x" & cartreader("Quantity"))
                lstCost.Items.Add(cartreader("Cost"))
        End While

        Dim orderreader As OleDbDataReader = ordercmd.ExecuteReader
        While orderreader.Read()
            If orderreader("Order ID") = Payment.orderID Then
                lblOrder.Text = orderreader("Order ID")
                lblDatetime.Text = orderreader("Datetime")
                lblSubtotal.Text = orderreader("Subtotal")
                lblPoints.Text = orderreader("Points")
                lblDelivery.Text = orderreader("Delivery/Pickup")
                lblTotal.Text = orderreader("Total")
            End If
        End While
        mycon.Close()

        Dim updatesql As String = "UPDATE [Cart] SET [Status] = @status"
        Dim updatecmd As New OleDbCommand(updatesql, mycon)
        mycon.Open()

        updatecmd.Parameters.AddWithValue("@status", "History")

        updatecmd.ExecuteNonQuery()
        mycon.Close()
    End Sub
End Class
