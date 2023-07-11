'Customer 'Cafe'
Imports System.Data.OleDb
Imports System.Diagnostics.Eventing

Public Class FoodOrder
    Private Sub FoodOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
        Dim strsql As String = "SELECT [Menu Name], [Menu Picture], [Description], [Cost], [User ID] FROM [Cafe Menu]"
        Dim mycmd As New OleDbCommand(strsql, mycon)
        Try
            mycon.Open()

            Dim row As Integer = 0
            Dim column As Integer = 0

            Dim reader As OleDbDataReader = mycmd.ExecuteReader()
            While reader.Read()

                Dim MenuPicture As New MenuPicture With {
                .Dock = DockStyle.Fill
            }
                If reader("User ID").ToString = "C002" Then
                    MenuPicture.lblCafe.Text = "V2 Gee & S Café"
                ElseIf reader("User ID").ToString = "C003" Then
                    MenuPicture.lblCafe.Text = "V3 Island One Café"
                ElseIf reader("User ID").ToString = "C004" Then
                    MenuPicture.lblCafe.Text = "V4 Razak zaitom Café"
                ElseIf reader("User ID").ToString = "C005" Then
                    MenuPicture.lblCafe.Text = "V5 Afifah Beta Café"
                ElseIf reader("User ID").ToString = "C007" Then
                    MenuPicture.lblCafe.Text = "V5 Dapur Ibrahim Café"
                ElseIf reader("User ID").ToString = "C008" Then
                    MenuPicture.lblCafe.Text = "V5 Manje Burger"
                ElseIf reader("User ID").ToString = "C006" Then
                    MenuPicture.lblCafe.Text = "V6 Harraz Café"
                ElseIf reader("User ID").ToString = "C009" Then
                    MenuPicture.lblCafe.Text = "Sayang Café"
                ElseIf reader("User ID").ToString = "C001" Then
                    MenuPicture.lblCafe.Text = "Café Mesra"
                End If


                MenuPicture.lblFood.Text = reader("Menu Name").ToString()
                MenuPicture.lblCost.Text = "RM" & reader("Cost").ToString()
                MenuPicture.picFood.Image = Image.FromFile(reader("Menu Picture").ToString())

                TLPMenu.Controls.Add(MenuPicture, column, row)
                If column >= 3 Then
                    column = 0
                    row += 1
                End If
            End While
            reader.Close()
            mycon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        btnFood.BackColor = Color.White
        btnFood.ForeColor = Color.Black
    End Sub
End Class
