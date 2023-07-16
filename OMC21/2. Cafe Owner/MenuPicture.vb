Imports System.Reflection

Public Class MenuPicture
    Private Sub MenuPicture_Click(sender As Object, e As EventArgs) Handles picFood.Click, Panel1.Click, MyBase.Click, lblFood.Click, lblCost.Click, lblCafe.Click
        FoodOrder.strCafe = lblCafe.Text
        FoodOrder.strFood = lblFood.Text
        FoodOrder.strCost = lblCost.Text
        FoodOrder.imgFood = picFood.Image
        Dim AddOrderForm As New AddOrder()
        AddOrderForm.Show()
    End Sub
End Class
