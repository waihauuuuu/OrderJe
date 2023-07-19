Public Class FlappyBirdGame
    Dim pipeSpeed As Integer = 8
    Dim gravity As Integer = 2
    Dim score As Integer = 0
    Private Sub GameTimerEvent(sender As Object, e As EventArgs) Handles gameTimer.Tick
        FlappyBird.Top += gravity
        pipeBottom.Left -= pipeSpeed
        pipeTop.Left -= pipeSpeed
        lblScore.Text = "Score: " & score

        If pipeBottom.Left < -150 Then
            pipeBottom.Left = 800
            score += 1
        End If

        If pipeTop.Left < -180 Then
            pipeTop.Left = 850
            score += 1
        End If

        If Val(FlappyBird.Bounds.IntersectsWith(pipeBottom.Bounds)) Then
            EndGame()
        End If

        If Val(FlappyBird.Bounds.IntersectsWith(pipeTop.Bounds)) Then
            EndGame()
        End If

        If Val(FlappyBird.Bounds.IntersectsWith(ground.Bounds)) Then
            EndGame()
        End If

        If FlappyBird.Bottom <= -25 Then
            EndGame()
        End If

        If score > 5 Then
            pipeSpeed = 15
        End If

        If FlappyBird.Top < -25 Then
            EndGame()
        End If
    End Sub

    Private Sub Gamekeyisdown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Space) Then
            gravity = -2
        End If

    End Sub

    Private Sub Gamekeyisup(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If (e.KeyCode = Keys.Space) Then
            gravity = 2
        End If

    End Sub
    Private Sub BtnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click
        ' Reset game variables
        pipeSpeed = 8
        gravity = 2
        score = 0

        pipeBottom.Left = 293
        pipeTop.Left = 161
        FlappyBird.Top = 151
        lblGameOver.Text = ""
        btnPlayAgain.Visible = False
        btnPlayAgain.Enabled = False
        gameTimer.Start()
    End Sub

    Private Sub EndGame()
        gameTimer.Stop()
        lblScore.Text += ""
        lblGameOver.Text = "Game Over!!"
        btnPlayAgain.Visible = True
        btnPlayAgain.Enabled = True
    End Sub
End Class