'Customer Sign Up
Imports System.Data.OleDb
Imports System.IO
Imports System.Text.RegularExpressions
Public Class CustomerSignUp
    Private Sub LblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        'change form when button clicked
        Me.Hide()
        CustomerLogin.Show()
    End Sub
    Public ReadOnly Property TextBoxValue As String
        'Transfer the password textbox value to the module, name = "ModuleEncrypt"
        'to create "encryption" for password
        Get
            Return txtPassword.Text
        End Get
    End Property
    Private Sub BtnCreateAnAccount_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        'When Button Create an Account clicked

        'Ensure password and confirm password are the same
        If txtPassword.Text <> txtConfirmPassword.Text Then
            MsgBox("Confirm password did not match.", 0 + MsgBoxStyle.Exclamation, "Password Mismatch")

            'Ensure no empty textbox
        ElseIf String.IsNullOrWhiteSpace(txtFullName.Text) OrElse
            String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
            String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
            Not (txtPhone.MaskFull OrElse txtPhone.Text.Length = 11) OrElse
            String.IsNullOrWhiteSpace(txtVillage.Text) OrElse
            String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
            String.IsNullOrWhiteSpace(txtConfirmPassword.Text) Then
            MsgBox("Please fill in all the required fields.", 0 + MsgBoxStyle.Exclamation, "Mising Information")

            'Ensure valid email format
        ElseIf Not ValidateEmailFormat(txtEmail.Text) Then
            MsgBox("Please enter a valid email address.", 0 + MsgBoxStyle.Exclamation, "Invalid Email")

            'Update data to database
        Else
            'Save image
            Dim imageName As String = Guid.NewGuid().ToString() + ".png" 'create unique name for doc or image 
            Dim imagePath As String = Path.Combine(Path.GetTempPath(), imageName) 'combine guid and image name = image path
            picProfile.Image?.Save(imagePath, System.Drawing.Imaging.ImageFormat.Png) 'if picturebox contain image, then save image as png

            'Connect database
            Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
            'insert into is a statement of SQL, CustomerDatabase is datatable name
            Dim strsql As String = "INSERT INTO UserDatabase ([User ID], [Full Name], [Username], [Email], [Phone Number], [Village], [Password (encrypted)], [Picture], [User Type]) Values(@id, @fullname, @username, @email, @phone, @village, @password, @picture, @usertype)"
            Dim mycmd As New OleDbCommand(strsql, mycon)

            mycon.Open()

            Dim rowCount As Integer = 0
            Dim sqlCount As String = "SELECT COUNT(*) FROM UserDatabase WHERE [User Type] = 'Customer'"
            Using commandCount As New OleDbCommand(sqlCount, mycon)
                rowCount = CInt(commandCount.ExecuteScalar())
            End Using

            'Generate the ID based on the row count
            Dim UserID As String = "U" & (rowCount + 1).ToString("D3")

            mycmd.Parameters.AddWithValue("@id", UserID)
            mycmd.Parameters.AddWithValue("@fullname", txtFullName.Text)
            mycmd.Parameters.AddWithValue("@username", txtUsername.Text)
            mycmd.Parameters.AddWithValue("@email", txtEmail.Text)
            mycmd.Parameters.AddWithValue("@phone", txtPhone.Text)
            mycmd.Parameters.AddWithValue("@village", txtVillage.Text)
            mycmd.Parameters.AddWithValue("@password", EncryptPassword(txtPassword.Text)) 'call module created, name = "ModuleEncrypt"

            'Check either picturebox is empty
            If picProfile.Image IsNot Nothing Then
                mycmd.Parameters.AddWithValue("@picture", imagePath) 'If
            Else
                mycmd.Parameters.AddWithValue("@picture", DBNull.Value) 'If empty, store nothing
            End If

            mycmd.Parameters.AddWithValue("@usertype", "Customer")

            mycmd.ExecuteNonQuery()
            mycon.Close()
            'pop out messagebox
            MsgBox("Your account has been successfully created!", 0 + MsgBoxStyle.Information, "Sign Up Account")
            'Change form
            Me.Hide()
            CustomerLogin.Show()
        End If
    End Sub

    Private Function ValidateEmailFormat(email As String) As Boolean
        'Function for email format
        Dim pattern As String = "^([\w\d_]+@([a-zA-Z0-9_]+\.(com))|([\w\d_]+@utp\.edu\.my))$"
        Return Regex.IsMatch(email, pattern)
    End Function

    Private Sub ChkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        'User can show or hide password
        If chkShowPassword.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
            txtConfirmPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
            txtConfirmPassword.UseSystemPasswordChar = True
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
            picProfile.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub TxtFullName_Leave(sender As Object, e As EventArgs) Handles txtFullName.Leave
        txtFullName.Text = UCase(txtFullName.Text)
    End Sub

    Private Sub LblLogin_MouseEnter(sender As Object, e As EventArgs) Handles lblLogin.MouseEnter
        lblLogin.ForeColor = Color.FromArgb(128, 255, 255)
    End Sub

    Private Sub LblLogin_MouseLeave(sender As Object, e As EventArgs) Handles lblLogin.MouseLeave
        lblLogin.ForeColor = Color.FromName("MenuHighlight")
    End Sub

End Class