Public Class TicTacToe
    Dim checkForXorO As Boolean = False
    Dim addOneToScore As Integer = 0

    Sub ButtonEnabledFalse()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
    End Sub

    Sub CheckForWin()
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            Button1.BackColor = Color.Black
            Button2.BackColor = Color.Black
            Button3.BackColor = Color.Black
            MsgBox("Winner is Player X", vbOKCancel + vbInformation)
            addOneToScore = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
        End If
        If Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            Button4.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button6.BackColor = Color.Black
            MsgBox("Winner is Player X", vbOKCancel + vbInformation)
            addOneToScore = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
        End If
        If Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            Button7.BackColor = Color.Black
            Button8.BackColor = Color.Black
            Button9.BackColor = Color.Black
            MsgBox("Winner is Player X", vbOKCancel + vbInformation)
            addOneToScore = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
        End If
        If Button1.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            Button1.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button7.BackColor = Color.Black
            MsgBox("Winner is Player X", vbOKCancel + vbInformation)
            addOneToScore = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
        End If
        If Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            Button2.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button8.BackColor = Color.Black
            MsgBox("Winner is Player X", vbOKCancel + vbInformation)
            addOneToScore = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
        End If
        If Button3.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            Button3.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button9.BackColor = Color.Black
            MsgBox("Winner is Player X", vbOKCancel + vbInformation)
            addOneToScore = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
        End If
        If Button1.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            Button1.BackColor = Color.Black
            Button6.BackColor = Color.Black
            Button9.BackColor = Color.Black
            MsgBox("Winner is Player X", vbOKCancel + vbInformation)
            addOneToScore = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
        End If
        If Button3.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            Button3.BackColor = Color.Black
            Button4.BackColor = Color.Black
            Button7.BackColor = Color.Black
            MsgBox("Winner is Player X", vbOKCancel + vbInformation)
            addOneToScore = Convert.ToInt64(lblPlayerX.Text)
            lblPlayerX.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
        End If

        'O combination
        If Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then
            Button1.BackColor = Color.Black
            Button2.BackColor = Color.Black
            Button3.BackColor = Color.Black
            MsgBox("Winner is Player O", vbOKCancel + vbInformation)
            addOneToScore = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
        End If
        If Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then
            Button4.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button6.BackColor = Color.Black
            MsgBox("Winner is Player O", vbOKCancel + vbInformation)
            addOneToScore = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
        End If
        If Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then
            Button7.BackColor = Color.Black
            Button8.BackColor = Color.Black
            Button9.BackColor = Color.Black
            MsgBox("Winner is Player O", vbOKCancel + vbInformation)
            addOneToScore = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
        End If
        If Button1.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then
            Button1.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button7.BackColor = Color.Black
            MsgBox("Winner is Player O", vbOKCancel + vbInformation)
            addOneToScore = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
        End If
        If Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then
            Button2.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button8.BackColor = Color.Black
            MsgBox("Winner is Player O", vbOKCancel + vbInformation)
            addOneToScore = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
        End If
        If Button3.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then
            Button3.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button9.BackColor = Color.Black
            MsgBox("Winner is Player O", vbOKCancel + vbInformation)
            addOneToScore = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
        End If
        If Button1.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then
            Button1.BackColor = Color.Black
            Button6.BackColor = Color.Black
            Button9.BackColor = Color.Black
            MsgBox("Winner is Player O", , vbOKCancel + vbInformation)
            addOneToScore = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
        End If
        If Button3.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then
            Button3.BackColor = Color.Black
            Button4.BackColor = Color.Black
            Button7.BackColor = Color.Black
            MsgBox("Winner is Player O", vbOKCancel + vbInformation)
            addOneToScore = Convert.ToInt64(lblPlayerO.Text)
            lblPlayerO.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
        End If

    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click
        Dim b As Button = sender
        If checkForXorO = False Then
            b.Text = "X"
            checkForXorO = True
        Else
            b.Text = "O"
            checkForXorO = False

        End If
        CheckForWin()
        b.Enabled = False
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True

        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""

        Button1.BackColor = Color.White
        Button2.BackColor = Color.White
        Button3.BackColor = Color.White
        Button4.BackColor = Color.White
        Button5.BackColor = Color.White
        Button6.BackColor = Color.White
        Button7.BackColor = Color.White
        Button8.BackColor = Color.White
        Button9.BackColor = Color.White
    End Sub

    Private Sub BtnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True

        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""

        Button1.BackColor = Color.White
        Button2.BackColor = Color.White
        Button3.BackColor = Color.White
        Button4.BackColor = Color.White
        Button5.BackColor = Color.White
        Button6.BackColor = Color.White
        Button7.BackColor = Color.White
        Button8.BackColor = Color.White
        Button9.BackColor = Color.White

        lblPlayerX.Text = "0"
        lblPlayerO.Text = "0"


    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim checkForExit As DialogResult = MsgBox("Confirm if you want to exit", +vbYesNo + vbQuestion)
        If checkForExit = vbYes Then
            Me.Close()
        End If
    End Sub
End Class