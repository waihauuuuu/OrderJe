Public Class TransactionItem
    Public Property ID As Integer
    Public Property CardNumber As String
    Public Property OrderItem As String
    Public Property Quantity As Integer
    Public Property Cost As Decimal
    Public Property TimePurchased As DateTime
    Public Property UserID As Integer
    Private Sub TransactionItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblOrderItem.Text = OrderItem
        lblQuantity.Text = Quantity.ToString()
        lblCost.Text = "RM" & Cost.ToString()
        lblDate.Text = TimePurchased.ToString()
    End Sub
End Class
