'Add Bank Card
Imports System.Runtime.CompilerServices

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

    Private Sub TxtBank_TextChanged(sender As Object, e As EventArgs) Handles txtBank.TextChanged
        lblBank.Text = txtBank.Text
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        lblName.Text = UCase(txtName.Text)
    End Sub

    Private Sub TxtCardNum_Click(sender As Object, e As EventArgs) Handles txtCardNum.Click
        lblCardNumber.Text = ""
        lblCardNumber.Text = txtCardNum.Text
    End Sub

    Private Sub TxtExpired_Click(sender As Object, e As EventArgs) Handles txtExpired.Click
        lblExpiredDate.Text = ""
        lblExpiredDate.Text = txtExpired.Text
    End Sub

End Class
