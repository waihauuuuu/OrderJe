Imports System.IO
Public Class CustomerEditProfile
    Private Sub CustomerEditProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display username, userID, Profile pic
        lblUsername.Text = GlobalVariables.Username
        lblUserID.Text = GlobalVariables.UserID
        If Not String.IsNullOrEmpty(GlobalVariables.ProfilePicture) AndAlso File.Exists(GlobalVariables.ProfilePicture) Then
            picProfile.Image = Image.FromFile(GlobalVariables.ProfilePicture)
        Else
            picProfile.Image = Nothing
        End If
        'Default colour = orange red
        Dim CustomerProfile As New CustomerProfile()
        btnPersonal.BackColor = Color.OrangeRed
        Me.BackColor = Color.OrangeRed
        CustomerProfile.Parent = pnlContainer
    End Sub

    'when mouse point on button, colour change
    Private Sub ButtonInForm_MouseEnter(sender As Object, e As EventArgs) Handles btnTransaction.MouseEnter, btnPoints.MouseEnter, btnPersonal.MouseEnter, btnPayment.MouseEnter, btnLogout.MouseEnter, btnAboutUs.MouseEnter
        Dim button As Button = DirectCast(sender, Button)
        If button.BackColor = Color.FromArgb(30, 30, 30) Then
            button.BackColor = Color.FromArgb(80, 80, 80)
        End If
    End Sub

    'when mouse leave the button, colour change back to initial colour
    Private Sub ButtonInForm_MouseLeave(sender As Object, e As EventArgs) Handles btnTransaction.MouseLeave, btnPoints.MouseLeave, btnPersonal.MouseLeave, btnPayment.MouseLeave, btnLogout.MouseLeave, btnAboutUs.MouseLeave
        Dim button As Button = DirectCast(sender, Button)
        If button.BackColor = Color.FromArgb(80, 80, 80) Then
            button.BackColor = Color.FromArgb(30, 30, 30)
        End If
    End Sub

    'Concept:
    ' > Profile form
    ' > button clicked, clear user control in panel, add new usercontrol
    ' > for every usercontol change, colour changed
    ' > more fancyyyyy~ XD

    'Create function
    Sub Resett()
        'Set all buttons to colour 30, 30, 30
        btnPersonal.BackColor = Color.FromArgb(30, 30, 30)
        btnTransaction.BackColor = Color.FromArgb(30, 30, 30)
        btnPoints.BackColor = Color.FromArgb(30, 30, 30)
        btnPayment.BackColor = Color.FromArgb(30, 30, 30)
        btnAboutUs.BackColor = Color.FromArgb(30, 30, 30)
        If pnlContainer.Controls.Count > 0 Then
            'Remove the usercontrol in the panel
            pnlContainer.Controls.RemoveAt(0)
        End If
    End Sub
    Private Sub BtnPersonal_Click(sender As Object, e As EventArgs) Handles btnPersonal.Click
        'Call function
        Resett()

        'Add new usercontrol
        Dim CustomerProfile As New CustomerProfile()
        btnPersonal.BackColor = Color.OrangeRed
        Me.BackColor = Color.OrangeRed
        CustomerProfile.Parent = pnlContainer
    End Sub

    Private Sub BtnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        'Call function
        Resett()

        'Add new usercontrol
        Dim CustomerTransactionHistory As New CustomerTransactionHistory()
        btnTransaction.BackColor = Color.Green
        Me.BackColor = Color.Green
        CustomerTransactionHistory.Parent = pnlContainer
    End Sub

    Private Sub BtnPoints_Click(sender As Object, e As EventArgs) Handles btnPoints.Click
        'Call function
        Resett()

        'Add new usercontrol
        Dim MyPoints As New MyPoints()
        btnPoints.BackColor = Color.DarkGoldenrod
        Me.BackColor = Color.DarkGoldenrod
        MyPoints.Parent = pnlContainer
    End Sub

    Private Sub BtnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        'Call function
        Resett()

        'Add new usercontrol
        Dim AddPaymentMethods As New AddPaymentMethods()
        btnPayment.BackColor = Color.Purple
        Me.BackColor = Color.Purple
        AddPaymentMethods.Parent = pnlContainer
    End Sub

    Private Sub BtnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        'Call function
        Resett()

        'Add new usercontrol
        'IN PROGRESS...
        btnAboutUs.BackColor = Color.MediumBlue
        Me.BackColor = Color.MediumBlue
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim response = MsgBox("Are you sure you want log out?", 4 + MsgBoxStyle.Question, "Confirmation")
        If response = MsgBoxResult.Yes Then
            Me.Hide()
            CustomerLogin.Show()
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        CustomerHomepage.Show()
    End Sub
End Class