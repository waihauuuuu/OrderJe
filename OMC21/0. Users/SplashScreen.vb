Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SplashScreen
    Private Sub TimerLoading_Tick(sender As Object, e As EventArgs) Handles TimerLoading.Tick
        Dim newSize As New Size(picLoading.Width + 80, picLoading.Height + 80)
        Dim newLocation As New Point(picLoading.Location.X - 40, picLoading.Location.Y - 40)

        'Set the new size and location
        picLoading.Size = newSize
        picLoading.Location = newLocation
        If picLoading.Width > 1500 AndAlso picLoading.Height > 1500 Then
            Bar.Visible = True
            lblVersion.Visible = True
            Value.Width += 66
            If Value.Width >= 700 Then
                TimerLoading.Stop() 'Stop the timer
                Me.Hide()
                AccSelect.Show()
            End If
        End If
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerLoading.Start()
    End Sub
End Class