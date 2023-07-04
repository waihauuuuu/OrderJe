Imports System.Data.OleDb
Imports System.IO

Public Class CustomerProfile
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Msi\source\repos\OMC21\OMC21\OrderJeDatabase.accdb"

    Private Function GetCustomerIdFromDatabase() As Integer
        Dim customerId As Integer = 0

        Using mycon As New OleDbConnection(connectionString)
            Dim strsql As String = "SELECT ID FROM CustomerDatabase WHERE [ID] = @id"
            Dim mycmd As New OleDbCommand(strsql, mycon)
            mycmd.Parameters.AddWithValue("@id", GlobalVariables.UserID)

            Try
                mycon.Open()
                Dim reader As OleDbDataReader = mycmd.ExecuteReader()
                If reader.Read() Then
                    customerId = CInt(reader("ID"))
                End If
                reader.Close()
                Console.WriteLine("Retrieved customer ID: " & customerId) ' Add this line to display the retrieved customer ID in the console
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
            End Try
        End Using

        Return customerId
    End Function

    Private Function ImageToString(image As Image) As String
        Using ms As New MemoryStream()
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim imageBytes() As Byte = ms.ToArray()
            Return Convert.ToBase64String(imageBytes)
        End Using
    End Function

    Private Function StringToImage(imageString As String) As Image
        Dim imageBytes() As Byte = Convert.FromBase64String(imageString)
        Using ms As New MemoryStream(imageBytes)
            Return Image.FromStream(ms)
        End Using
    End Function

    Private Sub CustomerProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using mycon As New OleDbConnection(connectionString)
            Dim strsql As String = "SELECT * FROM CustomerDatabase WHERE [ID] = @id"
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
                    picProfile.Image = StringToImage(reader("Picture").ToString())
                End If
                reader.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
            End Try
        End Using
    End Sub

    Private Function DecryptPassword(encryptedPassword As String) As String
        Dim decryptedPassword As String = ""

        For Each c As Char In encryptedPassword
            decryptedPassword += Chr(Asc(c) - 1)
        Next

        Return decryptedPassword
    End Function



    Private Function ByteArrayToImage(byteArrayIn As Byte()) As Image
        Dim ms As New MemoryStream(byteArrayIn)
        Dim returnImage As Image = Image.FromStream(ms)
        Return returnImage
    End Function

    Private Function ImageToByteArray(image As Image) As Byte()
        Dim ms As New MemoryStream()
        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using mycon As New OleDbConnection(connectionString)
            Dim strsql As String = "UPDATE CustomerDatabase SET [Full Name] = IIf(@fullname='', [Full Name], @fullname), " &
                                   "[Username] = IIf(@username='', [Username], @username), " &
                                   "[Email] = IIf(@email='', [Email], @email), " &
                                   "[Phone Number] = IIf(@phone='', [Phone Number], @phone), " &
                                   "[Village] = IIf(@village='', [Village], @village), " &
                                   "[Password (encrypted)] = IIf(@password='', [Password (encrypted)], @password), " &
                                   "[Picture] = IIf(@picture IS NULL, [Picture], @picture) WHERE ID = @id"

            Using mycmd As New OleDbCommand(strsql, mycon)
                mycmd.Parameters.AddWithValue("@fullname", If(txtFullName.Text.Trim() = "", DBNull.Value, txtFullName.Text))
                mycmd.Parameters.AddWithValue("@username", If(txtUsername.Text.Trim() = "", DBNull.Value, txtUsername.Text))
                mycmd.Parameters.AddWithValue("@email", If(txtEmail.Text.Trim() = "", DBNull.Value, txtEmail.Text))
                mycmd.Parameters.AddWithValue("@phone", If(txtPhone.Text.Trim() = "", DBNull.Value, txtPhone.Text))
                mycmd.Parameters.AddWithValue("@village", If(txtVillage.Text.Trim() = "", DBNull.Value, txtVillage.Text))
                mycmd.Parameters.AddWithValue("@picture", If(picProfile.Image Is Nothing, DBNull.Value, ImageToString(picProfile.Image)))

                Dim customerId As Integer = GetCustomerIdFromDatabase()
                mycmd.Parameters.AddWithValue("@id", customerId)

                'msgbox asks user if they want to confirm the changes
                Dim result As Integer = MsgBox("Are you sure you want to save the changes?", MsgBoxStyle.YesNo, "Save Changes")
                If result = DialogResult.Yes Then
                    Try
                        mycon.Open()
                        mycmd.ExecuteNonQuery()
                        MsgBox("Your information has been updated successfully!", MsgBoxStyle.Information, "Update Successful")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
                    End Try
                End If
            End Using
        End Using
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        'User can upload image from their file
        OpenFileDialog1.Title = "Open Picture"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Images|*.jpg;*.png;*.bmp;*.gif"

        'Check either user click on OK button in fileDialog
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            picProfile.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CustomerEditProfile As CustomerEditProfile = TryCast(Me.ParentForm, CustomerEditProfile)
        Dim panel As Panel = TryCast(ParentForm.Controls("pnlContainer"), Panel)
        If panel IsNot Nothing Then
            'change usercontrol
            Dim ChangePassword As New ChangePassword
            panel.Controls.Clear()
            panel.Controls.Add(ChangePassword)
        End If
    End Sub

    ' ...
End Class
