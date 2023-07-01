Imports System.Security.Cryptography
Imports System.Text
Module ModuleEncrypt
    'This module is to encrypt password
    Sub Main()
        ' Retrieve password from textbox input
        Dim formInstance As New CustomerSignUp()
        Dim password As String = formInstance.TextBoxValue

        ' Encrypt the password
        Dim encryptedPassword As String = EncryptPassword(password)
    End Sub

    Function EncryptPassword(password As String) As String
        ' Create an instance of the MD5 cryptographic algorithm
        Using md5 As New MD5CryptoServiceProvider()

            ' Compute the hash value from the password
            Dim hashedBytes As Byte() = md5.ComputeHash(Encoding.UTF8.GetBytes(password))

            ' Convert the byte array to a hexadecimal string
            Dim sb As New StringBuilder()
            For Each b As Byte In hashedBytes
                sb.Append(b.ToString("X2"))
            Next

            Return sb.ToString()
        End Using
    End Function
End Module
