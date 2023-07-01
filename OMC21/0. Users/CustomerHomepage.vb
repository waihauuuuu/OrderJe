Imports System.IO
Public Class CustomerHomepage
    Private Sub BtnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        Me.Hide()
        CustomerEditProfile.Show()
    End Sub

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display username, Profile pic
        lblUsername.Text = GlobalVariables.Username
        If Not String.IsNullOrEmpty(GlobalVariables.ProfilePicture) AndAlso File.Exists(GlobalVariables.ProfilePicture) Then
            picProfile.Image = Image.FromFile(GlobalVariables.ProfilePicture)
        Else
            picProfile.Image = Nothing
        End If
    End Sub

    'Logout
    Private Sub LblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        Dim response = MsgBox("Are you sure you want log out?", 4 + MsgBoxStyle.Question, "Confirmation")
        If response = MsgBoxResult.Yes Then
            Me.Hide()
            CustomerLogin.Show()
        End If
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim response = MsgBox("Are you sure you want log out?", 4 + MsgBoxStyle.Question, "Confirmation")
        If response = MsgBoxResult.Yes Then
            Me.Hide()
            CustomerLogin.Show()
        End If
    End Sub

    Sub Resett()
        'Set all buttons to colour 130, 0, 0
        btnHome.BackColor = Color.FromArgb(130, 0, 0)
        btnCafe.BackColor = Color.FromArgb(130, 0, 0)
        btnGames.BackColor = Color.FromArgb(130, 0, 0)
        btnDelivery.BackColor = Color.FromArgb(130, 0, 0)
        btnFeedback.BackColor = Color.FromArgb(130, 0, 0)
        If pnlContainer.Controls.Count > 0 Then
            'Remove the usercontrol in the panel
            pnlContainer.Controls.RemoveAt(0)
        End If
    End Sub

    Private Sub BtnCafe_Click(sender As Object, e As EventArgs) Handles btnCafe.Click
        Resett()
        Dim FoodOrder As New FoodOrder()
        btnCafe.BackColor = Color.FromArgb(255, 132, 132)
        FoodOrder.Parent = pnlContainer
    End Sub

    Private Sub BtnGames_Click(sender As Object, e As EventArgs) Handles btnGames.Click
        Resett()
        'Usercontrol in progress...
        btnGames.BackColor = Color.FromArgb(255, 132, 132)
    End Sub

    Private Sub BtnDelivery_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click
        Resett()
        'check delivery
        If GlobalVariables.hasOrder = True Then
            Dim OrderStatus As New OrderStatus()
            btnDelivery.BackColor = Color.FromArgb(255, 132, 132)
            OrderStatus.Parent = pnlContainer
        Else
            MessageBox.Show("You have no order to deliver.")
        End If
    End Sub

    Private Sub BtnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click
        Resett()
        Dim ViewFeedback As New ViewFeedBack()
        btnFeedback.BackColor = Color.FromArgb(255, 132, 132)
        ViewFeedback.Parent = pnlContainer
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Resett()
    End Sub
End Class