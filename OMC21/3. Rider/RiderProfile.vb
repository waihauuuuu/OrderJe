Imports System.Data.OleDb
Imports System.IO

Public Class RiderProfile
    Private RiderEditProfile As RiderEditProfile
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb"

    Private Sub RiderProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    If reader("Gender").ToString() = "Male" Then
                        rbMale.Checked = True
                    ElseIf reader("Gender").ToString() = "Female" Then
                        rbFemale.Checked = True
                    Else
                        rbMale.Checked = False
                        rbFemale.Checked = False
                    End If
                    cboVehicleType.SelectedItem = reader("Vehicle Type").ToString()
                    txtNumberPlate.Text = reader("Number Plate").ToString()

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
            mycon.Close()
        End Using
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim gender As String
        If rbMale.Checked Then
            gender = "Male"
        ElseIf rbFemale.Checked Then
            gender = "Female"
        Else
            gender = Nothing
        End If
        Using mycon As New OleDbConnection(connectionString)
            Dim strsql As String = "UPDATE UserDatabase SET [Full Name] = IIf(@fullname='', [Full Name], @fullname), " &
                                   "[Username] = IIf(@username='', [Username], @username), " &
                                   "[Email] = IIf(@email='', [Email], @email), " &
                                   "[Phone Number] = IIf(@phone='', [Phone Number], @phone), " &
                                   "[Gender] = IIf(@gender='', [Gender], @gender), " &
                                   "[Vehicle Type] = IIf(@vehicle='', [Vehicle Type], @vehicle), " &
                                   "[Number Plate] = IIf(@numberplate='', [Number Plate], @numberplate), " &
                                   "[Picture] = IIf(@picture IS NULL, [Picture], @picture) WHERE [User ID] = @id"

            Using mycmd As New OleDbCommand(strsql, mycon)
                Dim imageName As String = Guid.NewGuid().ToString() + ".png" 'create unique name for doc or image 
                Dim imagePath As String = Path.Combine(Path.GetTempPath(), imageName) 'combine guid and image name = image path
                picProfile.Image?.Save(imagePath, System.Drawing.Imaging.ImageFormat.Png) 'if picturebox contain image, then save image as png
                mycon.Open()
                mycmd.Parameters.AddWithValue("@fullname", If(txtFullName.Text.Trim() = "", DBNull.Value, txtFullName.Text))
                mycmd.Parameters.AddWithValue("@username", If(txtUsername.Text.Trim() = "", DBNull.Value, txtUsername.Text))
                mycmd.Parameters.AddWithValue("@email", If(txtEmail.Text.Trim() = "", DBNull.Value, txtEmail.Text))
                mycmd.Parameters.AddWithValue("@phone", If(txtPhone.Text.Trim() = "", DBNull.Value, txtPhone.Text))
                mycmd.Parameters.AddWithValue("@gender", If(String.IsNullOrWhiteSpace(gender), DBNull.Value, gender))
                mycmd.Parameters.AddWithValue("@vehicle", If(cboVehicleType.Text.Trim() = "", DBNull.Value, cboVehicleType.Text))
                mycmd.Parameters.AddWithValue("@numberplate", If(txtNumberPlate.Text.Trim() = "", DBNull.Value, txtNumberPlate.Text))
                mycmd.Parameters.AddWithValue("@picture", If(picProfile.Image IsNot Nothing, imagePath, DBNull.Value))
                mycmd.Parameters.AddWithValue("@id", GlobalVariables.UserID)
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to save the changes?", "Save Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Try
                        mycmd.ExecuteNonQuery()
                        MessageBox.Show("Your information has been updated successfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim RiderEditProfile As RiderEditProfile = TryCast(Me.ParentForm, RiderEditProfile)
                        If ParentForm IsNot Nothing Then
                            RiderEditProfile.RefreshParentForm()
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
                mycon.Close()
            End Using
        End Using
    End Sub

    Private Sub BtnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Using mycon As New OleDbConnection(connectionString)
            Dim strsql As String = "SELECT * FROM UserDatabase WHERE [User ID] = @id"
            Dim mycmd As New OleDbCommand(strsql, mycon)
            mycmd.Parameters.AddWithValue("@id", GlobalVariables.UserID)
            mycon.Open()
            Dim reader As OleDbDataReader = mycmd.ExecuteReader()
            If reader.Read() Then
                OpenFileDialog1.Title = "Open Picture"
                OpenFileDialog1.FileName = ""
                OpenFileDialog1.Filter = "Images|*.jpg;*.png;*.bmp;*.gif"
                If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                    picProfile.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
                End If
            End If
            mycon.Close()
        End Using
    End Sub

    Private Sub BtnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Dim RiderEditProfile As RiderEditProfile = TryCast(Me.ParentForm, RiderEditProfile)
        Dim panel As Panel = TryCast(ParentForm.Controls("pnlContainer"), Panel)
        If panel IsNot Nothing Then
            Dim ChangePassword As New ChangePassword
            panel.Controls.Clear()
            panel.Controls.Add(ChangePassword)
        End If
    End Sub
    Private Sub TxtNumberPlate_Enter(sender As Object, e As EventArgs)
        If cboVehicleType.Text = "Bicycle" OrElse cboVehicleType.Text = "Scooter" Then
            MsgBox("This field is not required for this vehicle.", 0 + MsgBoxStyle.Information, "Not required")
        End If
    End Sub

    Private Sub CboVehicleType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVehicleType.SelectedIndexChanged
        If cboVehicleType.SelectedItem = "Bicycle" OrElse cboVehicleType.SelectedItem = "Scooter" Then
            txtNumberPlate.Text = "Not Required"
            txtNumberPlate.BackColor = Color.Gray
        Else
            txtNumberPlate.Clear()
            txtNumberPlate.BackColor = Color.White
        End If
    End Sub
End Class
