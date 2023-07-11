'Cafe Owner "Menu"
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
    'Retrieve data from database
    'Display on datagri
End Class
