'Account Selection
Public Class AccSelect
    'Switch form when button clicked
    Private Sub BtnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Me.Hide()
        CustomerLogin.Show()
    End Sub
    Private Sub BtnCafeOwner_Click(sender As Object, e As EventArgs) Handles btnCafeOwner.Click
        Me.Hide()
        CafeOwnerLogin.Show()
    End Sub
    Private Sub BtnRider_Click(sender As Object, e As EventArgs) Handles btnRider.Click
        Me.Hide()
        RiderLogin.Show()
    End Sub

    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Me.Hide()
        AdminLogin.Show()
    End Sub

End Class
