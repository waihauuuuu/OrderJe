'Add Bank Card
Imports System.Data.OleDb
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.ApplicationServices

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

    Private Sub TxtCardNum_TextChanged(sender As Object, e As EventArgs) Handles txtCardNum.TextChanged
        lblCardNumber.Text = txtCardNum.Text
    End Sub

    Private Sub TxtCardNum_Enter(sender As Object, e As EventArgs) Handles txtCardNum.Enter
        If txtCardNum.ForeColor = SystemColors.InactiveCaption Then
            txtCardNum.Clear()
            txtCardNum.ForeColor = SystemColors.ControlText
        End If
    End Sub

    Private Sub TxtCardNum_Leave(sender As Object, e As EventArgs) Handles txtCardNum.Leave
        If Not txtCardNum.MaskCompleted Then
            txtCardNum.ForeColor = Color.FromName("InactiveCaption")
            txtCardNum.Text = "0000000000000000"
        End If
    End Sub

    Private Sub TxtCVV_Enter(sender As Object, e As EventArgs) Handles txtCVV.Enter
        If txtCVV.ForeColor = SystemColors.InactiveCaption Then
            txtCVV.Clear()
            txtCVV.ForeColor = Color.FromName("ControlText")
        End If
    End Sub

    Private Sub TxtCVV_Leave(sender As Object, e As EventArgs) Handles txtCVV.Leave
        If Not txtCVV.MaskCompleted Then
            txtCVV.ForeColor = Color.FromName("InactiveCaption")
            txtCVV.Text = "000"
        End If
    End Sub

    Private Sub TxtExpired_TextChanged(sender As Object, e As EventArgs) Handles txtExpired.TextChanged
        txtDate.Text = txtExpired.Text
    End Sub

    Private Sub TxtExpired_Enter(sender As Object, e As EventArgs) Handles txtExpired.Enter
        If txtExpired.ForeColor = SystemColors.InactiveCaption Then
            txtExpired.Clear()
            txtExpired.ForeColor = Color.FromName("ControlText")
        End If
    End Sub

    Private Sub TxtExpired_Leave(sender As Object, e As EventArgs) Handles txtExpired.Leave
        If Not txtExpired.MaskCompleted Then
            txtExpired.ForeColor = Color.FromName("InactiveCaption")
            txtExpired.Text = "0000"
        End If
    End Sub

    Private Sub BtnAddCard_Click(sender As Object, e As EventArgs) Handles btnAddCard.Click
        Dim requiredTextboxes() As MaskedTextBox = {txtCardNum, txtExpired, txtCVV}

        For Each maskedtextBox As MaskedTextBox In requiredTextboxes
            If maskedtextBox.ForeColor = Color.Gray OrElse Not (maskedtextBox.MaskFull) Then
                MessageBox.Show("Please fill in all required fields before saving.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Next
        If String.IsNullOrWhiteSpace(txtBank.Text) OrElse
            String.IsNullOrWhiteSpace(txtName.Text) Then
            MsgBox("Please fill all the required field!", 0 + MsgBoxStyle.Exclamation, "Incomplete Information")
        Else
            Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
            Dim strsql As String = "INSERT INTO [Payment Methods] ([Bank Name], [Cardholder], [Bank Number], [Expired Date], [cvv], [User ID]) Values(@bankname, @cardholder, @banknum, @date, @cvv, @id)"
            Dim mycmd As New OleDbCommand(strsql, mycon)
            mycon.Open()
            mycmd.Parameters.AddWithValue("@bankname", txtBank.Text)
            mycmd.Parameters.AddWithValue("@cardholder", lblName.Text)
            mycmd.Parameters.AddWithValue("@banknum", txtCardNum.Text)
            mycmd.Parameters.AddWithValue("@date", txtExpired.Text)
            mycmd.Parameters.AddWithValue("@cvv", txtCVV.Text)
            mycmd.Parameters.AddWithValue("@id", GlobalVariables.UserID)
            mycmd.ExecuteNonQuery()
            mycon.Close()
            MsgBox("Bank card has been successfully added!", 0 + MsgBoxStyle.Information, "Bank Card")
            Dim CustomerEditProfile As CustomerEditProfile = TryCast(Me.ParentForm, CustomerEditProfile)
            Dim panel As Panel = TryCast(ParentForm.Controls("pnlContainer"), Panel)
            If panel IsNot Nothing Then
                'change usercontrol
                Dim AddPaymentMethods As New AddPaymentMethods
                panel.Controls.Clear()
                panel.Controls.Add(AddPaymentMethods)
            End If
        End If
    End Sub
End Class
