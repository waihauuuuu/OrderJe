Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices

Public Class AddOrder
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")

    Private Sub AddOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCafe.Text = FoodOrder.strCafe
        lblFoodName.Text = FoodOrder.strFood
        txtCost.Text = FoodOrder.strCost
        picFood.Image = FoodOrder.imgFood
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnClose_MouseEnter(sender As Object, e As EventArgs) Handles btnClose.MouseEnter
        btnClose.ForeColor = Color.White
    End Sub

    Private Sub BtnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        btnClose.ForeColor = Color.Black
    End Sub

    Private Sub NudQuantity_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantity.ValueChanged
        Dim Quantity As Integer
        Quantity = nudQuantity.Value
        txtCost.Text = "RM" & CStr(Format((CDbl(FoodOrder.strCost) * CDbl(Quantity)), "0.00"))
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim imageName As String = Guid.NewGuid().ToString() + ".png" 'create unique name for doc or image 
        Dim imagePath As String = Path.Combine(Path.GetTempPath(), imageName) 'combine guid and image name = image path
        picFood.Image?.Save(imagePath, System.Drawing.Imaging.ImageFormat.Png) 'if picturebox contain image, then save image as png

        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
        Dim strsql As String = "INSERT INTO [Cart] ([User ID], [Cafe Name], [Food Name], [Cost], [Quantity], [Picture], [Status]) Values(@id, @cafename, @foodname, @cost, @quantity, @picture, @status)"
        Dim mycmd As New OleDbCommand(strsql, mycon)
        mycon.Open()
        mycmd.Parameters.AddWithValue("@id", GlobalVariables.UserID)
        mycmd.Parameters.AddWithValue("@cafename", lblCafe.Text)
        mycmd.Parameters.AddWithValue("@foodname", lblFoodName.Text)
        mycmd.Parameters.AddWithValue("@cost", FoodOrder.strCost)
        mycmd.Parameters.AddWithValue("@quatity", nudQuantity.Value)
        mycmd.Parameters.AddWithValue("@picture", imagePath)
        mycmd.Parameters.AddWithValue("@status", "Cart")
        mycmd.ExecuteNonQuery()
        mycon.Close()

        MsgBox("Order added sucessfully!")
        Me.Hide()
    End Sub
End Class