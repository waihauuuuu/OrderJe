'Feedback on Rider
Imports System.Data.OleDb
Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class FbRider
    Dim Rate As Integer = 0
    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        If String.IsNullOrWhiteSpace(txtComment.Text) OrElse Rate = 0 Then
            MsgBox("Please enter a comment and provide a rating before sending.", MsgBoxStyle.Exclamation, "Incomplete Information")
        Else
            Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
            Dim strsql As String = "INSERT INTO [Feedback] ([Comment],[Rating],[Feedback Target], [User ID]) Values(@comment,@rating, @target, @id)"
            Dim mycmd As New OleDbCommand(strsql, mycon)

            mycon.Open()

            mycmd.Parameters.AddWithValue("@comment", txtComment.Text)
            mycmd.Parameters.AddWithValue("@rating", Rate)
            mycmd.Parameters.AddWithValue("@target", ViewFeedBack.riderid)
            mycmd.Parameters.AddWithValue("@id", GlobalVariables.UserID)

            mycmd.ExecuteNonQuery()
            mycon.Close() 'database
            MsgBox("Thank you!", 0 + MsgBoxStyle.Information, "Feedback")

        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Rate = 0
        txtComment.Text = " "
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
    Sub Resett()
        btnBad.BackColor = Color.White
        btnMid.BackColor = Color.White
        btnGood.BackColor = Color.White
    End Sub
    Private Sub BtnBad_Click(sender As Object, e As EventArgs) Handles btnBad.Click
        Resett()
        btnBad.BackColor = Color.Gray
        Rate = 1
    End Sub

    Private Sub BtnMid_Click(sender As Object, e As EventArgs) Handles btnMid.Click
        Resett()
        btnMid.BackColor = Color.Gray
        Rate = 3
    End Sub

    Private Sub BtnGood_Click(sender As Object, e As EventArgs) Handles btnGood.Click
        Resett()
        btnGood.BackColor = Color.Gray
        Rate = 5
    End Sub
End Class

