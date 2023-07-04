Imports System.Data.OleDb
Imports System.IO

Public Class FbApplication
    Dim stars = {Star1, Star2, Star3, Star4, Star5}
    Dim rate As Integer = 0
    Public Sub New()
        InitializeComponent()
        stars = {Star1, Star2, Star3, Star4, Star5}
    End Sub
    Private Sub Star_Click(sender As Object, e As EventArgs) Handles Star1.Click, Star2.Click, Star3.Click, Star4.Click, Star5.Click
        Dim selectedStar As Button = DirectCast(sender, Button)
        Dim selectedRate As Integer = Array.IndexOf(stars, selectedStar) + 1

        For Each star As Button In stars
            If Array.IndexOf(stars, star) < selectedRate Then
                star.ForeColor = Color.Yellow
            Else
                star.ForeColor = Color.Black
            End If
        Next

        rate = selectedRate
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        For Each star In stars
            star.ForeColor = Color.Black
        Next
        rate = 0
        txtComment.Clear()
    End Sub

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If String.IsNullOrWhiteSpace(txtComment.Text) OrElse rate = 0 Then
            MsgBox("Please enter a comment and provide a rating before sending.", MsgBoxStyle.Exclamation, "Incomplete Information")
        Else
            Dim feedback As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Huawei\Desktop\OrderJeDatabase.accdb")
            'insert into is a statement of SQL, Feedback is datatable name
            Dim strsql As String = "INSERT INTO Feedback ([Comment], [Rating], [Feedback Target]) Values(@comment, @rating, @target)"
            Dim mycmd As New OleDbCommand(strsql, feedback)

            feedback.Open()

            mycmd.Parameters.AddWithValue("@comment", txtComment.Text)
            mycmd.Parameters.AddWithValue("@rating", rate)
            mycmd.Parameters.AddWithValue("@target", "Application")

            mycmd.ExecuteNonQuery()
            feedback.Close() 'database
            MsgBox("Your feedback has been successfully sent!", 0 + MsgBoxStyle.Information, "Feedback")
        End If


    End Sub
    Private Sub TxtComment_Enter(sender As Object, e As EventArgs) Handles txtComment.Enter
        If txtComment.ForeColor = Color.FromName("InactiveCaption") Then
            txtComment.Clear()
            txtComment.ForeColor = Color.FromName("ControlText")
        End If
    End Sub

    Private Sub TxtComment_Leave(sender As Object, e As EventArgs) Handles txtComment.Leave
        If String.IsNullOrWhiteSpace(txtComment.Text) Then
            txtComment.ForeColor = Color.FromName("InactiveCaption")
            txtComment.Text = "Comment"
        End If
    End Sub


End Class
