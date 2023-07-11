'Feedback on Rider
Imports System.Data.OleDb
Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class FbRider
    Dim buttons = {btnBad, btnMid, btnGood}
    Dim rating As Integer

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btnBad.Click, btnMid.Click, btnGood.Click
        Dim selectedButton As System.Windows.Forms.Button = DirectCast(sender, System.Windows.Forms.Button)
        Dim selectedRate As Integer = Array.IndexOf(buttons, selectedButton) + 1

        For Each button As Button In buttons
            If Array.IndexOf(buttons, button) < selectedRate Then
                rating += 3
            End If
        Next

        rating = selectedRate
    End Sub


    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click


        If String.IsNullOrWhiteSpace(txtCommentRider.Text) OrElse rating = 0 Then
            MsgBox("Please enter a comment and provide a rating before sending.", MsgBoxStyle.Exclamation, "Incomplete Information")
        Else
            Dim feedback As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
            'insert into is a statement of SQL, Feedback is datatable name
            Dim strsql As String = "INSERT INTO Feedback ([Comment],[Rating],[Feedback Target]) Values(@comment,@rating, @target)"
            Dim mycmd As New OleDbCommand(strsql, feedback)

            feedback.Open()

            mycmd.Parameters.AddWithValue("@comment", txtCommentRider.Text)
            mycmd.Parameters.AddWithValue("@rating", rating)
            mycmd.Parameters.AddWithValue("@target", "Rider")

            mycmd.ExecuteNonQuery()
            feedback.Close() 'database
            MsgBox("Thank you!", 0 + MsgBoxStyle.Information, "Feedback")

        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rating = 1
        txtCommentRider.Text = " "
    End Sub


End Class

