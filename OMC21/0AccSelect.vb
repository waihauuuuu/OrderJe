Public Class AccSelect
    Private Sub BtnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Me.Hide()
        LoginCustomer.Show()
    End Sub
    Private Sub BtnCafeOwner_Click(sender As Object, e As EventArgs) Handles btnCafeOwner.Click
        Me.Hide()
        LoginCafeOwner.Show()
    End Sub
    Private Sub BtnRider_Click(sender As Object, e As EventArgs) Handles btnRider.Click
        Me.Hide()
        LoginRider.Show()
    End Sub
End Class
