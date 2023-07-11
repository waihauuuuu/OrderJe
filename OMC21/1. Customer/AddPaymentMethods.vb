'Add Payment Methods
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

    ' > After btnAddCard clicked in "AddBankCard" usercontrol
    ' > retrieve data from database
    ' > display on lstMethod
End Class
