Imports System.Net.Mail
Imports System.Text.RegularExpressions

Public Class ForgotPassword
    Public Shared otp As Integer
    Public Shared emailcustomer As String


    Private Function GenerateOTP() As Integer
        Dim rnd As New Random()
        Return rnd.Next(100000, 999999)
    End Function

    Private Function ValidateEmailFormat(email As String) As Boolean
        'Function for email format
        Dim pattern As String = "^([\w\d_]+@([a-zA-Z0-9_]+\.(com))|([\w\d_]+@utp\.edu\.my))$"
        Return Regex.IsMatch(email, pattern)
    End Function

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MsgBox("Please Insert email!", 0 + MsgBoxStyle.Exclamation, "Incomplete information")
        ElseIf Not ValidateEmailFormat(txtEmail.Text) Then
            MsgBox("Please enter a valid email address.", 0 + MsgBoxStyle.Exclamation, "Invalid Email")
        Else
            emailcustomer = txtEmail.Text
            otp = GenerateOTP()

            ' Create the email message
            Dim email As New MailMessage With {
                .From = New MailAddress("waihaufong@gmail.com") ' Your email address
                }
            email.[To].Add(txtEmail.Text) ' User's email address
            email.Subject = "Password Reset OTP"
            email.Body = "Your OTP is: " & otp

            ' Configure the SMTP client
            Dim smtp As New SmtpClient With {
                .Host = "smtp.gmail.com", ' Your SMTP server address
                .Port = 587, ' Your SMTP server port
                .EnableSsl = True,
                .Credentials = New System.Net.NetworkCredential("waihaufong@gmail.com", "ypiuyvnoswnacyoj") ' Your email credentials
                }

            ' Send the email
            Try
                smtp.Send(email)
                MessageBox.Show("OTP sent successfully.")
                'when customer click ok, open OTP customer form
                Me.Hide()
                OTPForm.Show()

            Catch ex As Exception
                MessageBox.Show("Failed to send OTP. Error: " & ex.Message)
            End Try
        End If
    End Sub

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