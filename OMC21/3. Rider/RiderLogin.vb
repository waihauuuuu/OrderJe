Imports System.Data.OleDb

Public Class RiderLogin
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'change form
        Me.Hide()
        AccSelect.Show()
    End Sub

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        'change form
        Me.Hide()
        RiderSignUp.Show()
    End Sub

    Private Sub CboShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cboShowPassword.CheckedChanged
        If txtPassword.ForeColor = Color.FromName("InactiveCaption") Then
            txtPassword.UseSystemPasswordChar = False
        Else
            'user can show or hide password
            If cboShowPassword.Checked = True Then
                txtPassword.UseSystemPasswordChar = False
            Else
                txtPassword.UseSystemPasswordChar = True
            End If

        End If
    End Sub

    Private Sub TxtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        If txtUsername.ForeColor = Color.FromName("InactiveCaption") Then
            txtUsername.Clear()
            txtUsername.ForeColor = Color.FromName("ControlText")
        End If
    End Sub

    Private Sub TxtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            txtUsername.ForeColor = Color.FromName("InactiveCaption")
            txtUsername.Text = "Username"
        End If
    End Sub

    Private Sub TxtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.ForeColor = Color.FromName("InactiveCaption") Then
            txtPassword.Clear()
            txtPassword.ForeColor = Color.FromName("ControlText")
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TxtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            txtPassword.ForeColor = Color.FromName("InactiveCaption")
            txtPassword.Text = "Password"
            txtPassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'connect to database
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
        Dim strsql As String = "SELECT * FROM UserDatabase WHERE Username = @username"
        Dim mycmd As New OleDbCommand(strsql, mycon)

        'sets the value of the parameter to the text entered in the "txtUsername" control
        mycmd.Parameters.AddWithValue("@username", txtUsername.Text)

        mycon.Open()

        'reader: input for "username" from user can find in database or not
        Dim reader As OleDbDataReader = mycmd.ExecuteReader()
        If reader.Read() Then
            If reader("User Type") = "Rider" Then
                Dim storedPassword As String = reader("Password (encrypted)").ToString()
                If EncryptPassword(txtPassword.Text) = storedPassword Then
                    'Username and password match
                    MsgBox("Login successful!", 0 + MsgBoxStyle.Information, "Login Status")
                    'retrieve the user ID and username from the database
                    'Share the data to another form 
                    GlobalVariables.UserID = reader("ID")
                    GlobalVariables.Username = reader("Username")
                    If Not IsDBNull(reader("Picture")) Then
                        GlobalVariables.ProfilePicture = reader("Picture")
                    End If
                    'change form
                    Me.Hide()
                    RiderHomepage.Show()
                Else
                    'Password is incorrect
                    MsgBox("Incorrect password!", 0 + MsgBoxStyle.Exclamation, "Login Status")
                End If
            Else
                'Username is incorrect
                MsgBox("Username not found!", 0 + MsgBoxStyle.Exclamation, "Login Status")
            End If
        Else
            MsgBox("Username not found!", 0 + MsgBoxStyle.Exclamation, "Login Status")
        End If
        reader.Close()

        mycon.Close()

    End Sub
End Class