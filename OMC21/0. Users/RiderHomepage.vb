Imports System.Data.OleDb
Imports System.IO
Public Class RiderHomepage
    Private Sub BtnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        Me.Hide()
        RiderEditProfile.Show()
    End Sub

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
        Dim strsql As String = "SELECT * FROM UserDatabase WHERE [User ID] = @id"
        Dim mycmd As New OleDbCommand(strsql, mycon)
        mycmd.Parameters.AddWithValue("@id", GlobalVariables.UserID)
        Try
            mycon.Open()
            Dim reader As OleDbDataReader = mycmd.ExecuteReader()
            'Display username, userID, Profile pic
            If reader.Read() Then
                'Display username, Profile pic
                lblUsername.Text = reader("Username").ToString
                If Not String.IsNullOrEmpty(reader("Picture").ToString) AndAlso File.Exists(reader("Picture").ToString) Then
                    picProfile.Image = Image.FromFile(reader("Picture").ToString)
                Else
                    picProfile.Image = My.Resources.profilePic
                End If
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Dim RiderHome As New RiderHome()
        btnHome.BackColor = Color.FromArgb(180, 20, 20)
        iconHome.BackColor = Color.FromArgb(180, 20, 20)
        RiderHome.Parent = pnlContainer
    End Sub

    'Logout
    Private Sub LblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        Dim response = MsgBox("Are you sure you want log out?", 4 + MsgBoxStyle.Question, "Confirmation")
        If response = MsgBoxResult.Yes Then
            Me.Hide()
            RiderLogin.Show()
        End If
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim response = MsgBox("Are you sure you want log out?", 4 + MsgBoxStyle.Question, "Confirmation")
        If response = MsgBoxResult.Yes Then
            Me.Hide()
            RiderLogin.Show()
        End If
    End Sub

    Sub Resett()
        'Set all buttons to colour 130, 0, 0
        btnHome.BackColor = Color.FromArgb(30, 30, 30)
        btnFeedback.BackColor = Color.FromArgb(30, 30, 30)
        iconHome.BackColor = Color.FromArgb(30, 30, 30)
        iconFeedback.BackColor = Color.FromArgb(30, 30, 30)

        If pnlContainer.Controls.Count > 0 Then
            'Remove the usercontrol in the panel
            pnlContainer.Controls.RemoveAt(0)
        End If
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click, iconHome.Click
        Resett()
        Dim RiderHome As New RiderHome()
        btnHome.BackColor = Color.FromArgb(180, 20, 20)
        iconHome.BackColor = Color.FromArgb(180, 20, 20)
        RiderHome.Parent = pnlContainer
    End Sub

    Private Sub BtnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click, iconFeedback.Click
        Resett()
        Dim RiderViewFeedback As New RiderViewFeedback()
        btnFeedback.BackColor = Color.FromArgb(180, 20, 20)
        iconFeedback.BackColor = Color.FromArgb(180, 20, 20)
        RiderViewFeedback.Parent = pnlContainer
    End Sub

    Private Sub ButtonInForm_MouseEnter(sender As Object, e As EventArgs) Handles iconHome.MouseEnter, iconFeedback.MouseEnter, btnHome.MouseEnter, btnFeedback.MouseEnter
        Dim button As Button = DirectCast(sender, Button)
        If button.BackColor = Color.FromArgb(30, 30, 30) Then
            button.BackColor = Color.FromArgb(80, 80, 80)
            If button Is btnHome Then
                iconHome.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is btnFeedback Then
                iconFeedback.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is iconHome Then
                btnHome.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is iconFeedback Then
                btnFeedback.BackColor = Color.FromArgb(80, 80, 80)
            End If
        End If
    End Sub

    Private Sub ButtonInForm_MouseLeave(sender As Object, e As EventArgs) Handles iconHome.MouseLeave, iconFeedback.MouseLeave, btnHome.MouseLeave, btnFeedback.MouseLeave
        Dim button As Button = DirectCast(sender, Button)
        If button.BackColor = Color.FromArgb(80, 80, 80) Then
            button.BackColor = Color.FromArgb(30, 30, 30)
            If button Is btnHome Then
                iconHome.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is btnFeedback Then
                iconFeedback.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is iconHome Then
                btnHome.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is iconFeedback Then
                btnFeedback.BackColor = Color.FromArgb(30, 30, 30)
            End If
        End If
    End Sub
End Class