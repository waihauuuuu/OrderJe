'Customer 'Feedback'
Imports System.Data.OleDb
Imports System.IO

Public Class ViewFeedBack
    Public Shared riderid As String
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
        btnRider.BackColor = Color.Gray
        Dim FbRider As New FbRider()
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
        Dim strsql As String = "SELECT * FROM [UserDatabase] WHERE [User Type] = 'Rider'"
        Dim mycmd As New OleDbCommand(strsql, mycon)
        mycon.Open()
        Dim reader As OleDbDataReader = mycmd.ExecuteReader
        While reader.Read()
            riderid = reader("User ID")
            FbRider.lblRiderName.Text = reader("Username")
            FbRider.lblUserID.Text = reader("User ID")
            If Not String.IsNullOrEmpty(reader("Picture").ToString) AndAlso File.Exists(reader("Picture").ToString) Then
                FbRider.picProfile.Image = Image.FromFile(reader("Picture").ToString)
            Else
                FbRider.picProfile.Image = My.Resources.profilePic
            End If
            FbRider.Parent = pnlContainerIn
        End While
        mycon.Close()
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
