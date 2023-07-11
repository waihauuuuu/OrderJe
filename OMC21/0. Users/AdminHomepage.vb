Public Class AdminHomepage
    Sub Resett()
        If pnlContainer.Controls.Count > 0 Then
            'Remove the usercontrol in the panel
            pnlContainer.Controls.RemoveAt(0)
        End If
    End Sub

    Private Sub BtnData_Click(sender As Object, e As EventArgs) Handles iconData.Click, btnData.Click
        Resett()
        Dim UserData As New UserData()
        UserData.Parent = pnlContainer
    End Sub

    Private Sub BtnTransactionHistory_Click(sender As Object, e As EventArgs) Handles iconTransactionHistory.Click, btnTransactionHistory.Click
        Resett()
        Dim AdminTransactionHistory As New AdminTransactionHistory()
        AdminTransactionHistory.Parent = pnlContainer
    End Sub

    Private Sub BtnFeedback_Click(sender As Object, e As EventArgs) Handles iconFeedback.Click, btnFeedback.Click
        Resett()
        Dim AdminViewFeedback As New AdminViewFeedback()
        AdminViewFeedback.Parent = pnlContainer
    End Sub
End Class