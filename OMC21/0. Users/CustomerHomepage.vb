'Customer Homepage
Imports System.Data.OleDb
Imports System.IO
Public Class CustomerHomepage
    Private Sub BtnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        Me.Hide()
        CustomerEditProfile.Show()
    End Sub

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Resett()
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")

        Dim strsql As String = "SELECT * FROM UserDatabase WHERE [User ID] = @id"
        Dim mycmd As New OleDbCommand(strsql, mycon)
        mycon.Open()
        mycmd.Parameters.AddWithValue("@id", GlobalVariables.UserID)
        Try
            Dim reader As OleDbDataReader = mycmd.ExecuteReader()
            'Display username, userID, Profile pic
            If reader.Read() Then
                'Display username, Profile pic
                lblUsername.Text = reader("Username").ToString
                If Not String.IsNullOrEmpty(reader("Picture").ToString) AndAlso File.Exists(reader("Picture").ToString) Then
                    picProfile.Image = Image.FromFile(reader("Picture").ToString)
                Else
                    picProfile.Image = My.Resources.profilePic
                End If
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        mycon.Close()
        Dim CustomerHome As New CustomerHome()
        btnHome.BackColor = Color.FromArgb(180, 20, 20)
        iconHome.BackColor = Color.FromArgb(180, 20, 20)
        CustomerHome.Parent = pnlContainer
    End Sub

    'Logout
    Private Sub LblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        Dim response = MsgBox("Are you sure you want log out?", 4 + MsgBoxStyle.Question, "Confirmation")
        If response = MsgBoxResult.Yes Then
            Me.Hide()
            CustomerLogin.Show()
        End If
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim response = MsgBox("Are you sure you want log out?", 4 + MsgBoxStyle.Question, "Confirmation")
        If response = MsgBoxResult.Yes Then
            Me.Hide()
            CustomerLogin.Show()
        End If
    End Sub

    Sub Resett()
        'Set all buttons to colour 130, 0, 0
        btnHome.BackColor = Color.FromArgb(30, 30, 30)
        btnCafe.BackColor = Color.FromArgb(30, 30, 30)
        btnGames.BackColor = Color.FromArgb(30, 30, 30)
        btnDelivery.BackColor = Color.FromArgb(30, 30, 30)
        btnFeedback.BackColor = Color.FromArgb(30, 30, 30)
        iconHome.BackColor = Color.FromArgb(30, 30, 30)
        iconCafe.BackColor = Color.FromArgb(30, 30, 30)
        iconGames.BackColor = Color.FromArgb(30, 30, 30)
        iconDelivery.BackColor = Color.FromArgb(30, 30, 30)
        iconFeedback.BackColor = Color.FromArgb(30, 30, 30)

        If pnlContainer.Controls.Count > 0 Then
            'Remove the usercontrol in the panel
            pnlContainer.Controls.RemoveAt(0)
        End If
    End Sub

    Private Sub BtnCafe_Click(sender As Object, e As EventArgs) Handles btnCafe.Click, iconCafe.Click
        Resett()
        Dim FoodOrder As New FoodOrder()
        btnCafe.BackColor = Color.FromArgb(180, 20, 20)
        iconCafe.BackColor = Color.FromArgb(180, 20, 20)
        FoodOrder.Parent = pnlContainer
    End Sub

    Private Sub BtnGames_Click(sender As Object, e As EventArgs) Handles btnGames.Click, iconGames.Click
        Resett()
        Dim MiniGames As New MiniGames()
        btnGames.BackColor = Color.FromArgb(180, 20, 20)
        iconGames.BackColor = Color.FromArgb(180, 20, 20)
        MiniGames.Parent = pnlContainer
    End Sub

    Private Sub BtnDelivery_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click, iconDelivery.Click
        Resett()
        'check delivery
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
        Dim strsql As String = "SELECT * FROM [Transaction History] WHERE [User ID] = '" & GlobalVariables.UserID & "'"
        Dim mycmd As New OleDbCommand(strsql, mycon)

        mycon.Open()
        Dim reader As OleDbDataReader = mycmd.ExecuteReader
        Dim status As String
        While reader.Read()
            status = reader("Status")
        End While
        If status = "3rd Stage" Then
            Dim OrderStatus As New OrderStatus()
            btnDelivery.BackColor = Color.FromArgb(180, 20, 20)
            iconDelivery.BackColor = Color.FromArgb(180, 20, 20)
            OrderStatus.Parent = pnlContainer
        ElseIf (status = "1st Stage") Or (status = "2nd Stage") Then
            MsgBox("Your order haven't accepted!", 0 + MsgBoxStyle.Information, "Order")
            Dim CustomerHome As New CustomerHome()
            btnHome.BackColor = Color.FromArgb(180, 20, 20)
            iconHome.BackColor = Color.FromArgb(180, 20, 20)
            CustomerHome.Parent = pnlContainer
        Else
            MsgBox("You have no order!", 0 + MsgBoxStyle.Information, "Order")
            Dim CustomerHome As New CustomerHome()
            btnHome.BackColor = Color.FromArgb(180, 20, 20)
            iconHome.BackColor = Color.FromArgb(180, 20, 20)
            CustomerHome.Parent = pnlContainer
        End If
        mycon.Close()
    End Sub

    Private Sub BtnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click, iconFeedback.Click
        Resett()
        Dim ViewFeedback As New ViewFeedBack()
        btnFeedback.BackColor = Color.FromArgb(180, 20, 20)
        iconFeedback.BackColor = Color.FromArgb(180, 20, 20)
        ViewFeedback.Parent = pnlContainer
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click, iconHome.Click
        Resett()
        Dim CustomerHome As New CustomerHome()
        btnHome.BackColor = Color.FromArgb(180, 20, 20)
        iconHome.BackColor = Color.FromArgb(180, 20, 20)
        CustomerHome.Parent = pnlContainer
    End Sub

    Private Sub ButtonInForm_MouseEnter(sender As Object, e As EventArgs) Handles iconHome.MouseEnter, iconGames.MouseEnter, iconFeedback.MouseEnter, iconDelivery.MouseEnter, iconCafe.MouseEnter, btnHome.MouseEnter, btnGames.MouseEnter, btnFeedback.MouseEnter, btnDelivery.MouseEnter, btnCafe.MouseEnter
        Dim button As Button = DirectCast(sender, Button)
        If button.BackColor = Color.FromArgb(30, 30, 30) Then
            button.BackColor = Color.FromArgb(80, 80, 80)
            If button Is btnHome Then
                iconHome.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is btnCafe Then
                iconCafe.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is btnGames Then
                iconGames.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is btnDelivery Then
                iconDelivery.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is btnFeedback Then
                iconFeedback.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is iconHome Then
                btnHome.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is iconCafe Then
                btnCafe.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is iconGames Then
                btnGames.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is iconDelivery Then
                btnDelivery.BackColor = Color.FromArgb(80, 80, 80)
            ElseIf button Is iconFeedback Then
                btnFeedback.BackColor = Color.FromArgb(80, 80, 80)
            End If
        End If
    End Sub
    Private Sub ButtonInForm_MouseLeave(sender As Object, e As EventArgs) Handles iconHome.MouseLeave, iconGames.MouseLeave, iconFeedback.MouseLeave, iconDelivery.MouseLeave, iconCafe.MouseLeave, btnHome.MouseLeave, btnGames.MouseLeave, btnFeedback.MouseLeave, btnDelivery.MouseLeave, btnCafe.MouseLeave
        Dim button As Button = DirectCast(sender, Button)
        If button.BackColor = Color.FromArgb(80, 80, 80) Then
            button.BackColor = Color.FromArgb(30, 30, 30)
            If button Is btnHome Then
                iconHome.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is btnCafe Then
                iconCafe.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is btnGames Then
                iconGames.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is btnDelivery Then
                iconDelivery.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is btnFeedback Then
                iconFeedback.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is iconHome Then
                btnHome.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is iconCafe Then
                btnCafe.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is iconGames Then
                btnGames.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is iconDelivery Then
                btnDelivery.BackColor = Color.FromArgb(30, 30, 30)
            ElseIf button Is iconFeedback Then
                btnFeedback.BackColor = Color.FromArgb(30, 30, 30)
            End If
        End If
    End Sub
End Class