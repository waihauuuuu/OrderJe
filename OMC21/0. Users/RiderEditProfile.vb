Imports System.Data.OleDb
Imports System.IO
Public Class RiderEditProfile
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb"
    Public Sub RefreshParentForm()
        Using mycon As New OleDbConnection(connectionString)
            Dim strsql As String = "SELECT * FROM UserDatabase WHERE [User ID] = @id"
            Dim mycmd As New OleDbCommand(strsql, mycon)
            mycmd.Parameters.AddWithValue("@id", GlobalVariables.UserID)

            Try
                mycon.Open()
                Dim reader As OleDbDataReader = mycmd.ExecuteReader()
                'Display username, userID, Profile pic
                If reader.Read() Then
                    lblUsername.Text = reader("Username").ToString
                    lblUserID.Text = GlobalVariables.UserID
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
    Private Sub RiderEditProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshParentForm()

        'Default colour = orange red
        Dim RiderProfile As New RiderProfile()
        btnPersonal.BackColor = Color.OrangeRed
        iconPersonal.BackColor = Color.OrangeRed
        Me.BackColor = Color.OrangeRed
        RiderProfile.Parent = pnlContainer
    End Sub

    'when mouse point on button, colour change
    Private Sub ButtonInForm_MouseEnter(sender As Object, e As EventArgs) Handles btnTransaction.MouseEnter, btnPersonal.MouseEnter, btnLogout.MouseEnter, btnAboutUs.MouseEnter, iconTransaction.MouseEnter, iconPersonal.MouseEnter, iconAboutUs.MouseEnter
        Dim button As Button = DirectCast(sender, Button)
        If button.BackColor = Color.FromArgb(30, 30, 30) Then
            button.BackColor = Color.FromArgb(80, 80, 80)
            If button Is btnPersonal Then
                iconPersonal.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is btnTransaction Then
                iconTransaction.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is btnAboutUs Then
                iconAboutUs.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is iconPersonal Then
                btnPersonal.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is iconTransaction Then
                btnTransaction.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is iconAboutUs Then
                btnAboutUs.BackColor = Color.FromArgb(80, 80, 80)
            End If
        End If
    End Sub
    'when mouse leave the button, colour change back to initial colour
    Private Sub ButtonInForm_MouseLeave(sender As Object, e As EventArgs) Handles btnTransaction.MouseLeave, btnPersonal.MouseLeave, btnLogout.MouseLeave, btnAboutUs.MouseLeave, iconTransaction.MouseLeave, iconPersonal.MouseLeave, iconAboutUs.MouseLeave
        Dim button As Button = DirectCast(sender, Button)
        If button.BackColor = Color.FromArgb(80, 80, 80) Then
            button.BackColor = Color.FromArgb(30, 30, 30)
            If button Is btnPersonal Then
                iconPersonal.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is btnTransaction Then
                iconTransaction.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is btnAboutUs Then
                iconAboutUs.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is iconPersonal Then
                btnPersonal.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is iconTransaction Then
                btnTransaction.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is iconAboutUs Then
                btnAboutUs.BackColor = Color.FromArgb(30, 30, 30)
            End If
        End If
    End Sub
    'Create function
    Sub Resett()
        'Set all buttons to colour 30, 30, 30
        btnPersonal.BackColor = Color.FromArgb(30, 30, 30)
        btnTransaction.BackColor = Color.FromArgb(30, 30, 30)
        btnAboutUs.BackColor = Color.FromArgb(30, 30, 30)
        iconPersonal.BackColor = Color.FromArgb(30, 30, 30)
        iconTransaction.BackColor = Color.FromArgb(30, 30, 30)
        iconAboutUs.BackColor = Color.FromArgb(30, 30, 30)

        If pnlContainer.Controls.Count > 0 Then
            'Remove the usercontrol in the panel
            pnlContainer.Controls.RemoveAt(0)
        End If
    End Sub

    Private Sub BtnPersonal_Click(sender As Object, e As EventArgs) Handles btnPersonal.Click, iconPersonal.Click
        'Call function
        Resett()

        'Add new usercontrol
        Dim RiderProfile As New RiderProfile()
        btnPersonal.BackColor = Color.OrangeRed
        iconPersonal.BackColor = Color.OrangeRed
        Me.BackColor = Color.OrangeRed
        RiderProfile.Parent = pnlContainer
    End Sub
    Private Sub BtnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click, iconTransaction.Click
        'Call function
        Resett()

        'Add new usercontrol
        Dim RiderTransactionHistory As New RiderTransactionHistory()
        btnTransaction.BackColor = Color.Green
        iconTransaction.BackColor = Color.Green
        Me.BackColor = Color.Green
        RiderTransactionHistory.Parent = pnlContainer
    End Sub

    Private Sub BtnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click, iconAboutUs.Click
        'Call function
        Resett()

        'Add new usercontrol
        Dim AboutUs As New AboutUs()
        btnAboutUs.BackColor = Color.MediumBlue
        iconAboutUs.BackColor = Color.MediumBlue
        Me.BackColor = Color.MediumBlue
        AboutUs.Parent = pnlContainer
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim response = MsgBox("Are you sure you want log out?", 4 + MsgBoxStyle.Question, "Confirmation")
        If response = MsgBoxResult.Yes Then
            Me.Hide()
            RiderLogin.Show()
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        RiderHomepage.Show()
    End Sub
End Class