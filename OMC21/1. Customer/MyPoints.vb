Public Class MyPoints
    Private Sub BtnOrderNow_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        Me.ParentForm.Hide()
        Dim CustomerHomepage As New CustomerHomepage
        CustomerHomepage.Show()
    End Sub
End Class
