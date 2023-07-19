Public Class AdminHomepage
    Sub Resett()
        btnData.BackColor = Color.FromArgb(30, 30, 30)
        btnTransactionHistory.BackColor = Color.FromArgb(30, 30, 30)
        btnFeedback.BackColor = Color.FromArgb(30, 30, 30)
        iconData.BackColor = Color.FromArgb(30, 30, 30)
        iconTransactionHistory.BackColor = Color.FromArgb(30, 30, 30)
        iconFeedback.BackColor = Color.FromArgb(30, 30, 30)
        If pnlContainer.Controls.Count > 0 Then
            'Remove the usercontrol in the panel
            pnlContainer.Controls.RemoveAt(0)
        End If
    End Sub

    Private Sub BtnData_Click(sender As Object, e As EventArgs) Handles iconData.Click, btnData.Click
        Resett()
        Dim UserData As New UserData With {
            .Parent = pnlContainer
        }
        btnData.BackColor = Color.FromArgb(50, 50, 50)
        iconData.BackColor = Color.FromArgb(50, 50, 50)
    End Sub

    Private Sub BtnTransactionHistory_Click(sender As Object, e As EventArgs) Handles iconTransactionHistory.Click, btnTransactionHistory.Click
        Resett()
        Dim AdminTransactionHistory As New AdminTransactionHistory With {
            .Parent = pnlContainer
        }
        btnTransactionHistory.BackColor = Color.FromArgb(50, 50, 50)
        iconTransactionHistory.BackColor = Color.FromArgb(50, 50, 50)
    End Sub

    Private Sub BtnFeedback_Click(sender As Object, e As EventArgs) Handles iconFeedback.Click, btnFeedback.Click
        Resett()
        Dim AdminViewFeedback As New AdminViewFeedback With {
            .Parent = pnlContainer
        }
        btnFeedback.BackColor = Color.FromArgb(50, 50, 50)
        iconFeedback.BackColor = Color.FromArgb(50, 50, 50)
    End Sub

    Private Sub MouseInForm_MouseEnter(sender As Object, e As EventArgs) Handles iconTransactionHistory.MouseEnter, iconFeedback.MouseEnter, iconData.MouseEnter, btnTransactionHistory.MouseEnter, btnFeedback.MouseEnter, btnData.MouseEnter
        Dim button As Button = DirectCast(sender, Button)
        If button.BackColor = Color.FromArgb(30, 30, 30) Then
            button.BackColor = Color.FromArgb(80, 80, 80)
            If button Is btnData Then
                iconData.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is btnTransactionHistory Then
                iconTransactionHistory.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is btnFeedback Then
                iconFeedback.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is icondata Then
                btnData.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is iconTransactionHistory Then
                btnTransactionHistory.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is iconFeedback Then
                btnFeedback.BackColor = Color.FromArgb(80, 80, 80)
            End If
        End If
    End Sub

    Private Sub MouseInForm_MouseLeave(sender As Object, e As EventArgs) Handles iconTransactionHistory.MouseLeave, iconFeedback.MouseLeave, iconData.MouseLeave, btnTransactionHistory.MouseLeave, btnFeedback.MouseLeave, btnData.MouseLeave
        Dim button As Button = DirectCast(sender, Button)
        If button.BackColor = Color.FromArgb(80, 80, 80) Then
            button.BackColor = Color.FromArgb(30, 30, 30)
            If button Is btnData Then
                iconData.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is btnTransactionHistory Then
                iconTransactionHistory.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is btnFeedback Then
                iconFeedback.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is iconData Then
                btnData.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is iconTransactionHistory Then
                btnTransactionHistory.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is iconFeedback Then
                btnFeedback.BackColor = Color.FromArgb(30, 30, 30)
            End If
        End If
    End Sub

    Private Sub AdminHomepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UserData As New UserData With {
            .Parent = pnlContainer
        }
        btnData.BackColor = Color.FromArgb(50, 50, 50)
        iconData.BackColor = Color.FromArgb(50, 50, 50)
    End Sub
End Class