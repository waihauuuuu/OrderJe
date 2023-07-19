Imports System.Data.OleDb

Public Class RiderHome
    Private Sub BtnNotification_Click(sender As Object, e As EventArgs) Handles btnNotification.Click
        Dim RiderHomepage As RiderHomepage = TryCast(Me.ParentForm, RiderHomepage)
        Dim panel As Panel = TryCast(ParentForm.Controls("pnlContainer"), Panel)
        If panel IsNot Nothing Then
            'change usercontrol
            Dim RiderNotification As New RiderNotification
            panel.Controls.Clear()
            panel.Controls.Add(RiderNotification)
        End If
        RiderHomepage.btnHome.BackColor = Color.FromArgb(30, 30, 30)
        RiderHomepage.iconHome.BackColor = Color.FromArgb(30, 30, 30)
    End Sub

    Private Sub RiderHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
        Dim strsql As String = "SELECT * FROM [UserDatabase] WHERE [User ID] = '" & GlobalVariables.UserID & "'"
        Dim mycmd As New OleDbCommand(strsql, mycon)
        mycon.Open()
        Dim reader As OleDbDataReader = mycmd.ExecuteReader
        If reader.Read Then
            lblHi.Text = "Hi, " & reader("Username")
        End If
        mycon.Close()
    End Sub
End Class
