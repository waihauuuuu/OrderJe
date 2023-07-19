Imports System.Data.OleDb

Public Class CustomerHome
    Private Sub BtnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        Dim CustomerHomepage As CustomerHomepage = TryCast(Me.ParentForm, CustomerHomepage)
        Dim panel As Panel = TryCast(ParentForm.Controls("pnlContainer"), Panel)
        If panel IsNot Nothing Then
            'change usercontrol
            Dim Cart As New Cart
            panel.Controls.Clear()
            panel.Controls.Add(Cart)
        End If
        CustomerHomepage.btnHome.BackColor = Color.FromArgb(30, 30, 30)
        CustomerHomepage.iconHome.BackColor = Color.FromArgb(30, 30, 30)
    End Sub

    Private Sub CustomerHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
