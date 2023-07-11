Imports System.Data.OleDb
Imports System.IO

Public Class NewMenu
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If String.IsNullOrWhiteSpace(txtMenuName.Text) OrElse
            String.IsNullOrWhiteSpace(txtDescription.Text) OrElse
            String.IsNullOrWhiteSpace(txtCost.Text) Then
            MsgBox("Please fill in all the required fields.", 0 + MsgBoxStyle.Exclamation, "Mising Information")
        ElseIf picMenu.Image Is Nothing Then
            MsgBox("Please upload picture.", 0 + MsgBoxStyle.Exclamation, "Mising Information")
        Else
            Dim imageName As String = Guid.NewGuid().ToString() + ".png" 'create unique name for doc or image 
            Dim imagePath As String = Path.Combine(Path.GetTempPath(), imageName) 'combine guid and image name = image path
            picMenu.Image?.Save(imagePath, System.Drawing.Imaging.ImageFormat.Png) 'if picturebox contain image, then save image as png
            'Connect database
            Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
            'insert into is a statement of SQL, CustomerDatabase is datatable name
            Dim strsql As String = "INSERT INTO [Cafe Menu] ([Menu Name], [Menu Picture], [Description], [Cost], [User ID]) Values(@menuname, @picture, @description, @cost, @id)"
            Dim mycmd As New OleDbCommand(strsql, mycon)

            mycon.Open()

            mycmd.Parameters.AddWithValue("@menuname", UCase(txtMenuName.Text))
            mycmd.Parameters.AddWithValue("@picture", imagePath)
            mycmd.Parameters.AddWithValue("@description", txtDescription.Text)
            mycmd.Parameters.AddWithValue("@cost", Format(CDbl(txtCost.Text), "0.00"))
            mycmd.Parameters.AddWithValue("@id", GlobalVariables.UserID)
            Try
                mycmd.ExecuteNonQuery()
                mycon.Close()

                MsgBox("New Menu has been successfully added!", 0 + MsgBoxStyle.Information, "Add Menu")
                Dim CafeOwnerHomepage As CafeOwnerHomepage = TryCast(Me.ParentForm, CafeOwnerHomepage)
                Dim panel As Panel = TryCast(ParentForm.Controls("pnlContainer"), Panel)
                If panel IsNot Nothing Then
                    'change usercontrol
                    Dim Menu As New Menu
                    panel.Controls.Clear()
                    panel.Controls.Add(Menu)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        'Remember to put "OpenFileDialog" control before code

        'User can upload image from their file
        OpenFileDialog1.Title = "Open Picture"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Images|*.jpg;*.png;*.bmp;*.gif"

        'Check either user click on OK button in fileDialog
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picMenu.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub TxtDescription_Enter(sender As Object, e As EventArgs) Handles txtDescription.Enter
        If txtDescription.ForeColor = Color.FromName("InactiveCaption") Then
            txtDescription.Clear()
            txtDescription.ForeColor = Color.FromName("ControlText")
        End If
    End Sub

    Private Sub TxtDescription_Leave(sender As Object, e As EventArgs) Handles txtDescription.Leave
        If String.IsNullOrWhiteSpace(txtDescription.Text) Then
            txtDescription.ForeColor = Color.FromName("InactiveCaption")
            txtDescription.Text = "Description"
        End If
    End Sub

    Private Sub TxtMenuName_Leave(sender As Object, e As EventArgs) Handles txtMenuName.Leave
        txtMenuName.Text = UCase(txtMenuName.Text)
    End Sub

    Private Sub TxtCost_Leave(sender As Object, e As EventArgs) Handles txtCost.Leave
        txtCost.Text = Format(CDbl(txtCost.Text), "0.00")
    End Sub
End Class
