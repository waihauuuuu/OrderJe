Public Class AdminLogin
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'goes back to the previous form
        Me.Hide()
        AccSelect.Show()
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
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtPassword.Text = "1234" Then
            MsgBox("Login successful!", 0 + MsgBoxStyle.Information, "Login Status")
            'change form
            Me.Hide()
            AdminHomepage.Show()
        Else
            'Password is incorrect
            MsgBox("Incorrect password!", 0 + MsgBoxStyle.Information, "Login Status")
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
End Class