'Cafe Owner "Menu"
Imports System.Data.OleDb

Public Class Menu
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim CafeOwnerHomepage As CafeOwnerHomepage = TryCast(Me.ParentForm, CafeOwnerHomepage)
        Dim panel As Panel = TryCast(ParentForm.Controls("pnlContainer"), Panel)
        If panel IsNot Nothing Then
            'change usercontrol
            Dim NewMenu As New NewMenu
            panel.Controls.Clear()
            panel.Controls.Add(NewMenu)
        End If
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
        Dim strsql As String = "SELECT * FROM [Cafe Menu] WHERE [User ID] = '" & GlobalVariables.UserID & "'"
        Dim mycmd As New OleDbCommand(strsql, mycon)
        Dim dt As New DataTable()
        mycon.Open()
        dt.Load(mycmd.ExecuteReader())
        mycon.Close()
        CafeDataGrid.DataSource = dt
    End Sub

    Private Sub BtnNotification_Click(sender As Object, e As EventArgs) Handles btnNotification.Click
        Dim CafeOwnerHomepage As CafeOwnerHomepage = TryCast(Me.ParentForm, CafeOwnerHomepage)
        Dim panel As Panel = TryCast(ParentForm.Controls("pnlContainer"), Panel)
        If panel IsNot Nothing Then
            'change usercontrol
            Dim CafeOwnerNotification As New CafeOwnerNotification
            panel.Controls.Clear()
            panel.Controls.Add(CafeOwnerNotification)
        End If
        CafeOwnerHomepage.btnMenu.BackColor = Color.FromArgb(30, 30, 30)
        CafeOwnerHomepage.iconMenu.BackColor = Color.FromArgb(30, 30, 30)
    End Sub
End Class
