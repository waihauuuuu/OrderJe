Public Class LoginRider
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        AccSelect.Show()
    End Sub

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Me.Hide()
        RiderSignUp.Show()
    End Sub
End Class