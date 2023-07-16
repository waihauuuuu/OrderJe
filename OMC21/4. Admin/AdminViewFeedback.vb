Imports System.Data.OleDb
Imports System.IO

Public Class AdminViewFeedback
    Private Sub AdminViewFeedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
        Dim strsql As String = "SELECT * FROM [Feedback] WHERE [Feedback Target] = 'Application'"
        Dim mycmd As New OleDbCommand(strsql, mycon)

        Dim strUsersql As String = "SELECT * FROM [UserDatabase] WHERE [User Type] = 'Customer'"
        Dim Usercmd As New OleDbCommand(strUsersql, mycon)

        Dim Count As Integer = 0
        Dim sqlCount As String = "SELECT COUNT(*) FROM [Feedback] WHERE [Feedback Target] = 'Application'"

        Dim overall As Double
        Dim RoundOverall As String

        mycon.Open()

        Using commandCount As New OleDbCommand(sqlCount, mycon)
            Count = CInt(commandCount.ExecuteScalar())
        End Using

        Dim reader As OleDbDataReader = mycmd.ExecuteReader
        While reader.Read()
            Dim comment As New Comment
            PanelComment.Controls.Add(comment)

            comment.lblComment.Text = reader("Comment")

            overall += CDbl(reader("Rating")) / Count
            lblRating.Text = overall
            RoundOverall = CStr(Math.Round(overall))

            Select Case RoundOverall
                Case "1"
                    Star1.ForeColor = Color.Yellow
                Case "2"
                    Star1.ForeColor = Color.Yellow
                    Star2.ForeColor = Color.Yellow
                Case "3"
                    Star1.ForeColor = Color.Yellow
                    Star2.ForeColor = Color.Yellow
                    Star3.ForeColor = Color.Yellow
                Case "4"
                    Star1.ForeColor = Color.Yellow
                    Star2.ForeColor = Color.Yellow
                    Star3.ForeColor = Color.Yellow
                    Star4.ForeColor = Color.Yellow
                Case "5"
                    Star1.ForeColor = Color.Yellow
                    Star2.ForeColor = Color.Yellow
                    Star3.ForeColor = Color.Yellow
                    Star4.ForeColor = Color.Yellow
                    Star5.ForeColor = Color.Yellow
            End Select


            Dim feedbackUserID As String = reader("User ID").ToString()
            Dim Userreader As OleDbDataReader = Usercmd.ExecuteReader()

            While Userreader.Read()
                Dim userDBUserID As String = Userreader("User ID").ToString()
                If feedbackUserID = userDBUserID Then
                    comment.lblUsername.Text = Userreader("Username").ToString()
                    comment.lblUserID.Text = userDBUserID
                    If Not String.IsNullOrEmpty(Userreader("Picture")) AndAlso File.Exists(Userreader("Picture")) Then
                        comment.picProfile.Image = Image.FromFile(Userreader("Picture"))
                    Else
                        comment.picProfile.Image = My.Resources.profilePic
                    End If
                End If
            End While
            Userreader.Close()
        End While
        reader.Close()
        mycon.Close()
    End Sub
End Class
