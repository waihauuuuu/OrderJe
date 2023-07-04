Public Class OrderStatus
    Private countdownTime As Integer 'Total countdown time in seconds
    Private Sub OrderStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        countdownTime = 30 * 3600 'Set the countdown time
        UpdateCountdownLabel()
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If countdownTime > 0 Then
            countdownTime -= 1
            UpdateCountdownLabel()
        Else
            Timer1.Stop()
        End If
    End Sub

    Private Sub UpdateCountdownLabel()
        Dim minutes As Integer = countdownTime \ 60

        'Update the label to display in min
        lblTimer.Text = minutes.ToString("00")
    End Sub
End Class
