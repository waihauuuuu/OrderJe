Imports System.Data.OleDb

Public Class CafeOwnerHome
    Private Sub BtnNotification_Click(sender As Object, e As EventArgs) Handles btnNotification.Click
        Dim CafeOwnerHomepage As CafeOwnerHomepage = TryCast(Me.ParentForm, CafeOwnerHomepage)
        Dim panel As Panel = TryCast(ParentForm.Controls("pnlContainer"), Panel)
        If panel IsNot Nothing Then
            'change usercontrol
            Dim CafeOwnerNotification As New CafeOwnerNotification
            panel.Controls.Clear()
            panel.Controls.Add(CafeOwnerNotification)
        End If
        CafeOwnerHomepage.btnHome.BackColor = Color.FromArgb(30, 30, 30)
        CafeOwnerHomepage.iconHome.BackColor = Color.FromArgb(30, 30, 30)
    End Sub

    Private Sub LblHi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
        Dim strsql As String = "SELECT * FROM [UserDatabase] WHERE [User ID] = '" & GlobalVariables.UserID & "'"
        Dim mycmd As New OleDbCommand(strsql, mycon)
        mycon.Open()
        Dim reader As OleDbDataReader = mycmd.ExecuteReader
        If reader.Read Then
            lblHi.Text = reader("Username")
        End If
        mycon.Close()
    End Sub
End Class
