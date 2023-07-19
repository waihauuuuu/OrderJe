Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography.X509Certificates

Public Class Cart
    Public Shared CartID As String
    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")

        Dim strsql As String = "SELECT * FROM [Cart] WHERE [User ID] = '" & GlobalVariables.UserID & "'"
        Dim mycmd As New OleDbCommand(strsql, mycon)

        mycon.Open()

        Dim reader As OleDbDataReader = mycmd.ExecuteReader
        While reader.Read()
            If reader("Status") = "Cart" Then
                Dim AddedCart As New AddedCart()
                CartID = reader("Cart ID")
                AddedCart.lblFoodName.Text = reader("Food Name")
                AddedCart.lblCafeName.Text = reader("Cafe Name")
                AddedCart.lblCost.Text = reader("Cost")
                AddedCart.lblQuantity.Text = "X" & reader("Quantity")
                If Not String.IsNullOrEmpty(reader("Picture")) AndAlso File.Exists(reader("Picture")) Then
                    AddedCart.picFood.Image = Image.FromFile(reader("Picture"))
                End If
                CartPanel.Controls.Add(AddedCart)
            Else
                Dim label As New Label With {
                    .Text = "Empty",
                    .AutoSize = True
                }

                'Calculate the center position of the form
                Dim centerX As Integer = Me.Width \ 2
                Dim centerY As Integer = Me.Height \ 2

                'Calculate the label position based on its size
                Dim labelX As Integer = centerX - (label.Width \ 2)
                Dim labelY As Integer = centerY - (label.Height \ 2)

                label.Location = New Point(labelX, labelY)
                label.Anchor = AnchorStyles.None

                Me.Controls.Add(label)
            End If
        End While
        mycon.Close()
    End Sub

    Private Sub BtnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        Dim CustomerHomepage As CustomerHomepage = TryCast(Me.ParentForm, CustomerHomepage)
        Dim panel As Panel = TryCast(ParentForm.Controls("pnlContainer"), Panel)
        If panel IsNot Nothing Then
            'change usercontrol
            Dim Payment As New Payment
            panel.Controls.Clear()
            panel.Controls.Add(Payment)
        End If
    End Sub
End Class
