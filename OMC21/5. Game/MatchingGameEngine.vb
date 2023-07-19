Imports System.Windows

Public Class MatchingGameEngine

    Private ReadOnly _gameSize As GameSize
    Private ReadOnly _cardList As New List(Of Card)
    'Private _locations As New List(Of Location)
    Private _pictureBoxes As List(Of PictureBox)
    Private _flippedOverCount As Integer = 0
    Private _firstFlippedCard As Card
    Private _secondFlippedCard As Card
    Private _score As Integer = 0
    Private _scoreForWin As Integer = 0
    Private ReadOnly _form As MemoryMatching



    Public Sub New(gameSize As GameSize, form As MemoryMatching)
        Me._gameSize = gameSize
        Me._form = form
        Me._pictureBoxes = form.Controls.OfType(Of PictureBox).ToList()

    End Sub

    Public Sub StartNewGame()

        Reset()

        If (_gameSize = GameSize.Small) Then
            CreateSmallGameBoard()
        End If

    End Sub


    Public Function CardClicked(pictureBox As PictureBox) As Image

        _flippedOverCount += 1

        Dim cardImage As Image = My.Resources.bluecardback

        For Each card In _cardList
            If card.PictureBox.Equals(pictureBox) Then
                cardImage = card.CardImage
                If (_flippedOverCount = 1 And Not card.IsMatched) Then
                    _firstFlippedCard = card
                ElseIf (_flippedOverCount = 2 And Not card.IsMatched) Then
                    _secondFlippedCard = card
                Else
                    _flippedOverCount -= 1
                End If

            End If
        Next


        'flip unmatched one back over.. 
        If (_flippedOverCount > 2) Then
            HideCards()
            _flippedOverCount = 0
            'Return My.Resources.bluecardback
        End If


        Return cardImage

    End Function


    Public Sub HideCards()
        For Each card In _cardList
            If (card.IsMatched = False) Then
                card.PictureBox.Image = My.Resources.bluecardback
            End If
        Next
    End Sub

    Public Sub Reset()
        _form.WinnerLabel.Visible = False
        _score = 0
        _flippedOverCount = 0
        _firstFlippedCard = Nothing
        _secondFlippedCard = Nothing
        For Each card In _cardList
            card.IsMatched = False
        Next
        HideCards()
    End Sub

    Public Sub CheckForMatch()



        If _flippedOverCount < 2 Then
            Return
        End If

        If _firstFlippedCard Is Nothing Or _secondFlippedCard Is Nothing Then
            _flippedOverCount = 0
            Return
        ElseIf _flippedOverCount = 2 Then
            Task.Delay(1000).Wait() 'wait a second before flipping back over
            If (_firstFlippedCard.ImageNumber.Equals(_secondFlippedCard.ImageNumber)) Then
                _firstFlippedCard.IsMatched = True
                _secondFlippedCard.IsMatched = True
                _score += 1
                If (_score = _scoreForWin) Then
                    _form.WinnerLabel.Visible = True
                End If
            Else
                HideCards()
            End If
            _flippedOverCount = 0
        End If

    End Sub



    Private Sub CreateSmallGameBoard()
        _scoreForWin = 6

        _cardList.Clear()

        _pictureBoxes = Shuffle(_pictureBoxes)

        _cardList.Add(New Card(1, My.Resources.Simp1, _pictureBoxes.Item(0)))
        _cardList.Add(New Card(2, My.Resources.Simp2, _pictureBoxes.Item(1)))
        _cardList.Add(New Card(3, My.Resources.Simp3, _pictureBoxes.Item(2)))
        _cardList.Add(New Card(4, My.Resources.Simp4, _pictureBoxes.Item(3)))
        _cardList.Add(New Card(5, My.Resources.Simp5, _pictureBoxes.Item(4)))
        _cardList.Add(New Card(6, My.Resources.Simp6, _pictureBoxes.Item(5)))
        _cardList.Add(New Card(1, My.Resources.Simp1, _pictureBoxes.Item(6)))
        _cardList.Add(New Card(2, My.Resources.Simp2, _pictureBoxes.Item(7)))
        _cardList.Add(New Card(3, My.Resources.Simp3, _pictureBoxes.Item(8)))
        _cardList.Add(New Card(4, My.Resources.Simp4, _pictureBoxes.Item(9)))
        _cardList.Add(New Card(5, My.Resources.Simp5, _pictureBoxes.Item(10)))
        _cardList.Add(New Card(6, My.Resources.Simp6, _pictureBoxes.Item(11)))

    End Sub


    Private Function Shuffle(Of T)(collection As IEnumerable(Of T)) As List(Of T)
        Dim r As New Random()
        Shuffle = collection.OrderBy(Function(a) r.Next()).ToList()
    End Function
End Class


Public Enum GameSize
    Small = 1
    Medium = 2
    Large = 3
End Enum
