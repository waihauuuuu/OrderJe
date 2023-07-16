﻿Public Class MiniGames
    Private Sub BtnCarRacing_Click(sender As Object, e As EventArgs) Handles btnCarRacing.Click
        CarRacing.Show()
    End Sub

    Private Sub BtnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        Dim CustomerHomepage As CustomerHomepage = TryCast(Me.ParentForm, CustomerHomepage)
        Dim panel As Panel = TryCast(ParentForm.Controls("pnlContainer"), Panel)
        If panel IsNot Nothing Then
            'change usercontrol
            Dim Cart As New Cart
            panel.Controls.Clear()
            panel.Controls.Add(Cart)
        End If
        CustomerHomepage.btnGames.BackColor = Color.FromArgb(30, 30, 30)
        CustomerHomepage.iconGames.BackColor = Color.FromArgb(30, 30, 30)
    End Sub
End Class
