'Personal Details
Imports System.Data.OleDb
Imports System.IO

Public Class CustomerProfile
    Private CustomerEditProfile As CustomerEditProfile
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb"

    Private Sub CustomerProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using mycon As New OleDbConnection(connectionString)
            Dim strsql As String = "SELECT * FROM UserDatabase WHERE [User ID] = @id"
            Dim mycmd As New OleDbCommand(strsql, mycon)
            mycmd.Parameters.AddWithValue("@id", GlobalVariables.UserID)

            Try
                mycon.Open()
                Dim reader As OleDbDataReader = mycmd.ExecuteReader()
                If reader.Read() Then
                    txtFullName.Text = reader("Full Name").ToString()
                    txtUsername.Text = reader("Username").ToString()
                    txtEmail.Text = reader("Email").ToString()
                    txtPhone.Text = reader("Phone Number").ToString()
                    txtVillage.Text = reader("Village").ToString()


                    If Not String.IsNullOrEmpty(reader("Picture")) AndAlso File.Exists(reader("Picture")) Then
                        picProfile.Image = Image.FromFile(reader("Picture"))
                    Else
                        picProfile.Image = My.Resources.profilePic
                    End If
                End If
                reader.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using mycon As New OleDbConnection(connectionString)
            Dim strsql As String = "UPDATE UserDatabase SET [Full Name] = IIf(@fullname='', [Full Name], @fullname), " &
                                   "[Username] = IIf(@username='', [Username], @username), " &
                                   "[Email] = IIf(@email='', [Email], @email), " &
                                   "[Phone Number] = IIf(@phone='', [Phone Number], @phone), " &
                                   "[Village] = IIf(@village='', [Village], @village), " &
                                   "[Picture] = IIf(@picture IS NULL, [Picture], @picture) WHERE [User ID] = @id"

            Using mycmd As New OleDbCommand(strsql, mycon)
                Dim reader As OleDbDataReader = mycmd.ExecuteReader()
                If reader.Read() Then
                    mycmd.Parameters.AddWithValue("@fullname", If(txtFullName.Text.Trim() = "", DBNull.Value, txtFullName.Text))
                    mycmd.Parameters.AddWithValue("@username", If(txtUsername.Text.Trim() = "", DBNull.Value, txtUsername.Text))
                    mycmd.Parameters.AddWithValue("@email", If(txtEmail.Text.Trim() = "", DBNull.Value, txtEmail.Text))
                    mycmd.Parameters.AddWithValue("@phone", If(txtPhone.Text.Trim() = "", DBNull.Value, txtPhone.Text))
                    mycmd.Parameters.AddWithValue("@village", If(txtVillage.Text.Trim() = "", DBNull.Value, txtVillage.Text))
                    mycmd.Parameters.AddWithValue("@picture", If("@picture", If(picProfile.Image, DBNull.Value)))
                    mycmd.Parameters.AddWithValue("@id", GlobalVariables.UserID)
                End If
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to save the changes?", "Save Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Try
                        mycon.Open()
                        mycmd.ExecuteNonQuery()
                        MessageBox.Show("Your information has been updated successfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim CustomerEditProfile As CustomerEditProfile = TryCast(Me.ParentForm, CustomerEditProfile)
                        If ParentForm IsNot Nothing Then
                            CustomerEditProfile.RefreshParentForm()
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            End Using
        End Using
    End Sub

    Private Sub BtnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Using mycon As New OleDbConnection(connectionString)
            Dim strsql As String = "SELECT * FROM UserDatabase WHERE [User ID] = @id"
            Dim mycmd As New OleDbCommand(strsql, mycon)
            mycmd.Parameters.AddWithValue("@id", GlobalVariables.UserID)
            Dim reader As OleDbDataReader = mycmd.ExecuteReader()
            If reader.Read() Then
                OpenFileDialog1.Title = "Open Picture"
                OpenFileDialog1.FileName = ""
                OpenFileDialog1.Filter = "Images|*.jpg;*.png;*.bmp;*.gif"
                If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                    Try
                        picProfile.Image = Image.FromFile(reader("Picture").ToString)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            End If
        End Using
    End Sub

    Private Sub BtnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Dim CustomerEditProfile As CustomerEditProfile = TryCast(Me.ParentForm, CustomerEditProfile)
        Dim panel As Panel = TryCast(ParentForm.Controls("pnlContainer"), Panel)
        If panel IsNot Nothing Then
            Dim ChangePassword As New ChangePassword
            panel.Controls.Clear()
            panel.Controls.Add(ChangePassword)
        End If
    End Sub
End Class
