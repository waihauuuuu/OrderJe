'Add Payment Methods
Imports System.Data.OleDb

Public Class AddPaymentMethods
    Private Sub BtnAddMethod_Click(sender As Object, e As EventArgs) Handles btnAddMethod.Click
        'parent form named "CustomerEditProfile"
        Dim CustomerEditProfile As CustomerEditProfile = TryCast(Me.ParentForm, CustomerEditProfile)
        Dim panel As Panel = TryCast(ParentForm.Controls("pnlContainer"), Panel)
        If panel IsNot Nothing Then
            'change usercontrol
            Dim AddBankCard As New AddBankCard
            panel.Controls.Clear()
            panel.Controls.Add(AddBankCard)
        End If
    End Sub

    Private Sub AddPaymentMethods_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
        Dim strsql As String = "SELECT * FROM [Payment Methods] WHERE [User ID] = '" & GlobalVariables.UserID & "'"
        Dim mycmd As New OleDbCommand(strsql, mycon)
        Try
            mycon.Open()
            Dim reader As OleDbDataReader = mycmd.ExecuteReader()
            While reader.Read()
                If (reader("Bank Name").Length > 7) Then
                    lstMethod.Items.Add(reader("Bank Name") & vbTab & vbTab & vbTab & reader("Bank Number"))
                Else
                    lstMethod.Items.Add(reader("Bank Name") & vbTab & vbTab & vbTab & vbTab & reader("Bank Number"))
                End If
            End While
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
