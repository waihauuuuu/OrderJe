Public Class RiderLogin
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'change form
        Me.Hide()
        AccSelect.Show()
    End Sub

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        'change form
        Me.Hide()
        RiderSignUp.Show()
    End Sub

    'LIST TO DO
    ' > Exact same to CustomerLogin
    ' > Connect database

End Class