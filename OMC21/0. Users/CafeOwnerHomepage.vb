Imports System.Data.OleDb

Public Class CafeOwnerHomepage
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
                'Display username
                If reader("Username").ToString = "V2Cafe" Then
                    lblCafeName.Text = "V2 Gee & S Café"
                ElseIf reader("Username").ToString = "V3Cafe" Then
                    lblCafeName.Text = "V3 Island One Café"
                ElseIf reader("Username").ToString = "V4Cafe" Then
                    lblCafeName.Text = "V4 Razak zaitom Café"
                ElseIf reader("Username").ToString = "V5Cafe" Then
                    lblCafeName.Text = "V5 Afifah Beta Café"
                ElseIf reader("Username").ToString = "V5Dapur" Then
                    lblCafeName.Text = "V5 Dapur Ibrahim Café"
                ElseIf reader("Username").ToString = "Manje" Then
                    lblCafeName.Text = "V5 Manje Burger"
                ElseIf reader("Username").ToString = "V6Cafe" Then
                    lblCafeName.Text = "V6 Harraz Café"
                ElseIf reader("Username").ToString = "Sayang" Then
                    lblCafeName.Text = "Sayang Café"
                ElseIf reader("Username").ToString = "Mesra" Then
                    lblCafeName.Text = "Café Mesra"
                End If
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btnHome.BackColor = Color.FromArgb(180, 20, 20)
        iconHome.BackColor = Color.FromArgb(180, 20, 20)
    End Sub
    Sub Resett()
        'Set all buttons to colour 130, 0, 0
        btnHome.BackColor = Color.FromArgb(30, 30, 30)
        btnMenu.BackColor = Color.FromArgb(30, 30, 30)
        btnTransaction.BackColor = Color.FromArgb(30, 30, 30)
        btnFeedback.BackColor = Color.FromArgb(30, 30, 30)
        iconHome.BackColor = Color.FromArgb(30, 30, 30)
        iconMenu.BackColor = Color.FromArgb(30, 30, 30)
        iconTransaction.BackColor = Color.FromArgb(30, 30, 30)
        iconFeedback.BackColor = Color.FromArgb(30, 30, 30)

        If pnlContainer.Controls.Count > 0 Then
            'Remove the usercontrol in the panel
            pnlContainer.Controls.RemoveAt(0)
        End If
    End Sub
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

    Private Sub ButtonInForm_MouseEnter(sender As Object, e As EventArgs) Handles iconTransaction.MouseEnter, iconMenu.MouseEnter, iconHome.MouseEnter, iconFeedback.MouseEnter, btnTransaction.MouseEnter, btnMenu.MouseEnter, btnHome.MouseEnter, btnFeedback.MouseEnter
        Dim button As Button = DirectCast(sender, Button)
        If button.BackColor = Color.FromArgb(30, 30, 30) Then
            button.BackColor = Color.FromArgb(80, 80, 80)
            If button Is btnHome Then
                iconHome.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is btnMenu Then
                iconMenu.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is btnTransaction Then
                iconTransaction.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is btnFeedback Then
                iconFeedback.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is iconHome Then
                btnHome.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is iconMenu Then
                btnMenu.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is iconTransaction Then
                btnTransaction.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is iconFeedback Then
                btnFeedback.BackColor = Color.FromArgb(80, 80, 80)
            End If
        End If
    End Sub

    Private Sub ButtonInForm_MouseLeave(sender As Object, e As EventArgs) Handles iconTransaction.MouseLeave, iconMenu.MouseLeave, iconHome.MouseLeave, iconFeedback.MouseLeave, btnTransaction.MouseLeave, btnMenu.MouseLeave, btnHome.MouseLeave, btnFeedback.MouseLeave
        Dim button As Button = DirectCast(sender, Button)
        If button.BackColor = Color.FromArgb(80, 80, 80) Then
            button.BackColor = Color.FromArgb(30, 30, 30)
            If button Is btnHome Then
                iconHome.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is btnMenu Then
                iconMenu.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is btnTransaction Then
                iconTransaction.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is btnFeedback Then
                iconFeedback.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is iconHome Then
                btnHome.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is iconMenu Then
                btnMenu.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is iconTransaction Then
                btnTransaction.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is iconFeedback Then
                btnFeedback.BackColor = Color.FromArgb(30, 30, 30)
            End If
        End If
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles iconHome.Click, btnHome.Click
        Resett()
        btnHome.BackColor = Color.FromArgb(180, 20, 20)
        iconHome.BackColor = Color.FromArgb(180, 20, 20)
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles iconMenu.Click, btnMenu.Click
        Resett()
        Dim Menu As New Menu()
        btnMenu.BackColor = Color.FromArgb(180, 20, 20)
        iconMenu.BackColor = Color.FromArgb(180, 20, 20)
        Menu.Parent = pnlContainer
    End Sub

    Private Sub BtnTransaction_Click(sender As Object, e As EventArgs) Handles iconTransaction.Click, btnTransaction.Click
        Resett()
        Dim CafeOwnerTransactionHistory As New CafeOwnerTransactionHistory()
        btnTransaction.BackColor = Color.FromArgb(180, 20, 20)
        iconTransaction.BackColor = Color.FromArgb(180, 20, 20)
        CafeOwnerTransactionHistory.Parent = pnlContainer
    End Sub

    Private Sub BtnFeedback_Click(sender As Object, e As EventArgs) Handles iconFeedback.Click, btnFeedback.Click
        Resett()
        Dim CafeOwnerViewFeedback As New CafeOwnerViewFeedback()
        btnFeedback.BackColor = Color.FromArgb(180, 20, 20)
        iconFeedback.BackColor = Color.FromArgb(180, 20, 20)
        CafeOwnerViewFeedback.Parent = pnlContainer
    End Sub
End Class