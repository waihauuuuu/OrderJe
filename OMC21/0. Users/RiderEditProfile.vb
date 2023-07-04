Imports System.IO
Public Class RiderEditProfile
    Private Sub RiderEditProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display username, userID, Profile pic
        lblUsername.Text = GlobalVariables.Username
        lblUserID.Text = "U" & (100 + GlobalVariables.UserID)
        If Not String.IsNullOrEmpty(GlobalVariables.ProfilePicture) AndAlso File.Exists(GlobalVariables.ProfilePicture) Then
            picProfile.Image = Image.FromFile(GlobalVariables.ProfilePicture)
        Else
            picProfile.Image = My.Resources.profilePic
        End If
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
        'IN PROGRESS...
        btnAboutUs.BackColor = Color.MediumBlue
        iconAboutUs.BackColor = Color.MediumBlue
        Me.BackColor = Color.MediumBlue
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