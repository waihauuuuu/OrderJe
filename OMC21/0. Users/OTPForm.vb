Imports System.Data.OleDb
Imports Microsoft.VisualBasic.ApplicationServices

Public Class OTPForm
    Dim matchedID As String
    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If String.IsNullOrWhiteSpace(txtOTP.Text) Then
            MsgBox("Please Insert OTP!", 0 + MsgBoxStyle.Exclamation, "Incomplete information")
        Else
            'if user enter the correct OTP, login to customer homepage using the same id as matched in the database with the email
            matchedID = GetIDFromDatabase(ForgotPassword.emailcustomer)
            If txtOTP.Text = ForgotPassword.otp Then
                MsgBox("Correct OTP")
                ' Assign the matched ID to the global variable
                GlobalVariables.UserID = matchedID

                ' Open the homepage
                Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
                Dim strsql As String = "SELECT * FROM [UserDatabase]"

                Dim mycmd As New OleDbCommand(strsql, mycon)

                mycon.Open()
                Dim reader As OleDbDataReader = mycmd.ExecuteReader()
                Dim usertype As String

                While reader.Read()
                    usertype = reader("User Type")
                End While
                If usertype = "Customer" Then
                    Dim customerHomepage As New CustomerHomepage()
                    Me.Hide()
                    customerHomepage.Show()
                ElseIf usertype = "Rider" Then
                    Dim RiderHomepage As New RiderHomepage()
                    Me.Hide()
                    RiderHomepage.Show()
                End If
                mycon.Close()
            Else
                MessageBox.Show("Wrong OTP. Please try again.")
            End If
        End If
    End Sub

    Private Function GetIDFromDatabase(emailcustomer As String)
        ' Perform database query to retrieve the ID based on the email
        ' Replace the code below with your actual database query logic       
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Msi\source\repos\OMC21\OMC21\OrderJeDatabase.accdb"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim command As New OleDbCommand("SELECT [User ID] FROM UserDatabase WHERE Email = @Email", connection)
            command.Parameters.AddWithValue("@Email", emailcustomer)
            matchedID = command.ExecuteScalar()
        End Using

        Return matchedID
    End Function
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnClose_MouseEnter(sender As Object, e As EventArgs) Handles btnClose.MouseEnter
        btnClose.ForeColor = Color.White
    End Sub

    Private Sub BtnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        btnClose.ForeColor = Color.Black
    End Sub
End Class