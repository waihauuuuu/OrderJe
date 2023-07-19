Imports System.Data.OleDb
Public Class ChangePassword
    'when form loads, the textboxes will show the passwords as asterisks
    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
        txtConfirmPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'check if both password is the same for both textboxes

        If txtPassword.Text = txtConfirmPassword.Text Then

            'store the password in the database CustomerDatabase
            Dim mycon As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Msi\source\repos\OMC21\OMC21\OrderJeDatabase.accdb")
            Dim usersql As String = "UPDATE CustomerDatabase SET [Password (encrypted)] = @password WHERE [User ID] = @id"
            Dim usercmd As New OleDb.OleDbCommand(usersql, mycon)

            'sets the value of the parameter to the text entered in the "txtUsername" control
            usercmd.Parameters.AddWithValue("@password", EncryptPassword(txtPassword.Text))
            usercmd.Parameters.AddWithValue("@id", GlobalVariables.UserID)

            mycon.Open()
            usercmd.ExecuteNonQuery()
            mycon.Close()

            MsgBox("Password changed!", 0 + MsgBoxStyle.Information, "Change Password Status")

            'change form to CustomerProfile
            Dim strsql As String = "SELECT * FROM UserDatabase WHERE [User ID] = '" & GlobalVariables.UserID & "'"
            Dim mycmd As New OleDbCommand(strsql, mycon)
            mycon.Open()
            Dim reader As OleDbDataReader = mycmd.ExecuteScalar
            Dim panel As Panel = TryCast(ParentForm.Controls("pnlContainer"), Panel)
            If reader.Read() Then
                If reader("User Type") = "Customer" Then
                    Dim CustomerEditProfile As CustomerEditProfile = TryCast(Me.ParentForm, CustomerEditProfile)
                    Dim CustomerProfile As New CustomerProfile
                    panel.Controls.Clear()
                    panel.Controls.Add(CustomerProfile)
                ElseIf reader("User Type") = "Rider" Then
                    Dim RiderEditProfile As RiderEditProfile = TryCast(Me.ParentForm, RiderEditProfile)
                    Dim RiderProfile As New RiderProfile
                    panel.Controls.Clear()
                    panel.Controls.Add(RiderProfile)
                End If
            End If
            mycon.Close()

        Else
            MsgBox("Password does not match!", 0 + MsgBoxStyle.Information, "Change Password Status")

        End If
    End Sub

    Private Sub CboShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cboShowPassword.CheckedChanged
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

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
        Dim strsql As String = "SELECT * FROM UserDatabase WHERE [User ID] = '" & GlobalVariables.UserID & "'"
        Dim mycmd As New OleDbCommand(strsql, mycon)
        mycon.Open()
        Dim reader As OleDbDataReader = mycmd.ExecuteScalar
        Dim panel As Panel = TryCast(ParentForm.Controls("pnlContainer"), Panel)
        If reader.Read() Then
            If reader("User Type") = "Customer" Then
                Dim CustomerEditProfile As CustomerEditProfile = TryCast(Me.ParentForm, CustomerEditProfile)
                Dim CustomerProfile As New CustomerProfile
                panel.Controls.Clear()
                panel.Controls.Add(CustomerProfile)
            ElseIf reader("User Type") = "Rider" Then
                Dim RiderEditProfile As RiderEditProfile = TryCast(Me.ParentForm, RiderEditProfile)
                Dim RiderProfile As New RiderProfile
                panel.Controls.Clear()
                panel.Controls.Add(RiderProfile)
            End If
        End If
        mycon.Close()
    End Sub
End Class
