Imports System.Data.OleDb

Public Class CafeOwnerNotification
    Public Shared id As Integer
    Private Sub CafeOwnerNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")

        Dim ordersql As String = "SELECT * FROM [Cart] WHERE [Cafe Name] = '" & CafeOwnerHomepage.lblCafeName.Text & "' AND [Status] = 'History'"
        Dim ordercmd As New OleDbCommand(ordersql, mycon)

        mycon.Open()
        Dim orderreader As OleDbDataReader = ordercmd.ExecuteReader

        While orderreader.Read()
            Dim AcceptOrder As New AcceptOrder
            id = orderreader("Order ID")
            AcceptOrder.lblOrderID.Text = orderreader("Order ID")
            AcceptOrder.lblFoodName.Text = orderreader("Food Name")
            AcceptOrder.lblCost.Text = "RM" & orderreader("Cost")
            AcceptOrder.lblQuantity.Text = "x" & orderreader("Quantity")
            AcceptOrder.lblUserID.Text = orderreader("User ID")
            AcceptOrder.Anchor = AnchorStyles.Left Or AnchorStyles.Right
            PanelNotification.Controls.Add(AcceptOrder)
        End While

        mycon.Close()
    End Sub
End Class
