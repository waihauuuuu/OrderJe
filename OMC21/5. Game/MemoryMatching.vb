Public Class MemoryMatching
    Dim _matchingGameEngine As MatchingGameEngine = Nothing

    Public ReadOnly Property WinnerLabel As Label
        Get
            Return Me.Label3
        End Get
    End Property

    Private Sub MemoryMatching_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _matchingGameEngine = New MatchingGameEngine(GameSize.Small, Me)
        _matchingGameEngine.StartNewGame()

    End Sub

    Private Function GetCard(pictureBox As PictureBox) As Image
        pictureBox.Image = _matchingGameEngine.CardClicked(pictureBox)
        Return pictureBox.Image
    End Function


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        GetCard(CType(sender, PictureBox))
        _matchingGameEngine.CheckForMatch()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        GetCard(CType(sender, PictureBox))
        _matchingGameEngine.CheckForMatch()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        GetCard(CType(sender, PictureBox))
        _matchingGameEngine.CheckForMatch()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        GetCard(CType(sender, PictureBox))
        _matchingGameEngine.CheckForMatch()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        GetCard(CType(sender, PictureBox))
        _matchingGameEngine.CheckForMatch()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        GetCard(CType(sender, PictureBox))
        _matchingGameEngine.CheckForMatch()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        GetCard(CType(sender, PictureBox))
        _matchingGameEngine.CheckForMatch()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        GetCard(CType(sender, PictureBox))
        _matchingGameEngine.CheckForMatch()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        GetCard(CType(sender, PictureBox))
        _matchingGameEngine.CheckForMatch()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        GetCard(CType(sender, PictureBox))
        _matchingGameEngine.CheckForMatch()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        GetCard(CType(sender, PictureBox))
        _matchingGameEngine.CheckForMatch()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        GetCard(CType(sender, PictureBox))
        _matchingGameEngine.CheckForMatch()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _matchingGameEngine.StartNewGame()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim answer As Integer
        answer = MsgBox("Are you done playing?", vbYesNo + vbDefaultButton2 + vbQuestion, "Memory Matching Game")
        If answer = vbYes Then
            Me.Close()
        End If
    End Sub
End Class