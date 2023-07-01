Public Class Payment
    Dim hasOrder As Boolean = False
    Private Sub BtnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        hasOrder = True
    End Sub
End Class
