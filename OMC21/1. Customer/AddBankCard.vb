Public Class AddBankCard
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'parent form named "CustomerEditProfile"
        Dim CustomerEditProfile As CustomerEditProfile = TryCast(Me.ParentForm, CustomerEditProfile)
        Dim panel As Panel = TryCast(ParentForm.Controls("pnlContainer"), Panel)
        If panel IsNot Nothing Then
            'change usercontrol
            Dim AddPaymentMethods As New AddPaymentMethods
            panel.Controls.Clear()
            panel.Controls.Add(AddPaymentMethods)
        End If
    End Sub

    'need to connect another datatable

    'TO DO LIST
    ' > when leave the textbox, label.text change to what is insert in textbox
    ' > msgbox "successful" --> elaborate
    ' when "back button" on left down corner clicked back to "AddPaymentMethods"
    ' when "X" on left up corner clicked back to "AddPaymentMethods"
End Class
