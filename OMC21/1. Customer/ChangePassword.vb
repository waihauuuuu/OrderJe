Public Class ChangePassword
    'when form loads, the textboxes will show the passwords as asterisks
    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
        txtConfirmPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'check if both password is the same for both textboxes

        If txtPassword.Text = txtConfirmPassword.Text Then

            'store the password in the database CustomerDatabase
            Dim mycon As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Msi\source\repos\OMC21\OMC21\OrderJeDatabase.accdb")
            Dim strsql As String = "UPDATE CustomerDatabase SET [Password (encrypted)] = @password WHERE [ID] = @id"
            Dim mycmd As New OleDb.OleDbCommand(strsql, mycon)

            'sets the value of the parameter to the text entered in the "txtUsername" control
            mycmd.Parameters.AddWithValue("@password", EncryptPassword(txtPassword.Text))
            mycmd.Parameters.AddWithValue("@id", GlobalVariables.UserID)

            mycon.Open()
            mycmd.ExecuteNonQuery()
            mycon.Close()

            MsgBox("Password changed!", 0 + MsgBoxStyle.Information, "Change Password Status")

            'change form to CustomerProfile
            Me.Hide()
            Dim CustomerEditProfile As CustomerEditProfile = TryCast(Me.ParentForm, CustomerEditProfile)
            Dim panel As Panel = TryCast(ParentForm.Controls("pnlContainer"), Panel)
            If panel IsNot Nothing Then
                'change usercontrol
                Dim CustomerProfile As New CustomerProfile
                panel.Controls.Clear()
                panel.Controls.Add(CustomerProfile)
            End If

        Else
            MsgBox("Password does not match!", 0 + MsgBoxStyle.Information, "Change Password Status")

        End If



    End Sub

    Private Sub cboShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cboShowPassword.CheckedChanged
        If txtPassword.ForeColor = Color.FromName("InactiveCaption") Then
            txtPassword.UseSystemPasswordChar = False
            txtConfirmPassword.UseSystemPasswordChar = False
        Else
            'user can show or hide password
            If cboShowPassword.Checked = True Then
                txtPassword.UseSystemPasswordChar = False
                txtConfirmPassword.UseSystemPasswordChar = False
            Else
                txtPassword.UseSystemPasswordChar = True
                txtConfirmPassword.UseSystemPasswordChar = True
            End If

        End If
    End Sub
End Class
