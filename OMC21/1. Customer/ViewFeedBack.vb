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
End Class
