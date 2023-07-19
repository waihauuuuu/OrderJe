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
            While reader.Read()
                lblCafeName.Text = reader("Full Name")
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Dim CafeOwnerHome As New CafeOwnerHome()
        btnHome.BackColor = Color.FromArgb(180, 20, 20)
        iconHome.BackColor = Color.FromArgb(180, 20, 20)
        CafeOwnerHome.Parent = pnlContainer
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
            CafeOwnerLogin.Show()
        End If
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim response = MsgBox("Are you sure you want log out?", 4 + MsgBoxStyle.Question, "Confirmation")
        If response = MsgBoxResult.Yes Then
            Me.Hide()
            CafeOwnerLogin.Show()
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
        Dim CafeOwnerHome As New CafeOwnerHome()
        btnHome.BackColor = Color.FromArgb(180, 20, 20)
        iconHome.BackColor = Color.FromArgb(180, 20, 20)
        CafeOwnerHome.Parent = pnlContainer
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