'Customer 'Feedback'
Public Class ViewFeedBack
    Sub Resett()
        'Set all buttons to colour White
        btnCafe.BackColor = Color.White
        btnRider.BackColor = Color.White
        btnApplication.BackColor = Color.White
        If pnlContainerIn.Controls.Count > 0 Then
            'Remove the usercontrol in the panel
            pnlContainerIn.Controls.RemoveAt(0)
        End If
    End Sub
    Private Sub BtnCafe_Click(sender As Object, e As EventArgs) Handles btnCafe.Click
        Resett()
        Dim FbCafe As New FbCafe()
        btnCafe.BackColor = Color.Gray
        FbCafe.Parent = pnlContainerIn
    End Sub

    Private Sub BtnRider_Click(sender As Object, e As EventArgs) Handles btnRider.Click
        Resett()
        Dim FbRider As New FbRider()
        btnRider.BackColor = Color.Gray
        FbRider.Parent = pnlContainerIn
    End Sub

    Private Sub BtnApplication_Click(sender As Object, e As EventArgs) Handles btnApplication.Click
        Resett()
        Dim FbApplication As New FbApplication()
        btnApplication.BackColor = Color.Gray
        FbApplication.Parent = pnlContainerIn
    End Sub

    Private Sub ViewFeedBack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FbCafe As New FbCafe()
        btnCafe.BackColor = Color.Gray
        FbCafe.Parent = pnlContainerIn
    End Sub

    Private Sub BtnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        Dim CustomerHomepage As CustomerHomepage = TryCast(Me.ParentForm, CustomerHomepage)
        Dim panel As Panel = TryCast(ParentForm.Controls("pnlContainer"), Panel)
        If panel IsNot Nothing Then
            'change usercontrol
            Dim Cart As New Cart
            panel.Controls.Clear()
            panel.Controls.Add(Cart)
            CustomerHomepage.btnFeedback.BackColor = Color.FromArgb(30, 30, 30)
            CustomerHomepage.iconFeedback.BackColor = Color.FromArgb(30, 30, 30)
        End If
    End Sub
End Class
