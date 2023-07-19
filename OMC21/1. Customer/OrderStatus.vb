'Customer 'Delivery'
Imports System.IO
Imports System.Data.OleDb


Public Class OrderStatus
    Private countdownTime As Integer ' Total countdown time in seconds

    Private Sub OrderStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        countdownTime = 30 * 60 ' Set the countdown time to 30 minutes
        UpdateCountdownLabel()
        Timer1.Interval = 1000
        Timer1.Start()

        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
        Dim strsql As String = "SELECT * FROM [Transaction History] WHERE [Status] = '3rd Stage'"
        Dim mycmd As New OleDbCommand(strsql, mycon)

        Dim usersql As String = "SELECT * FROM [UserDatabase]"
        Dim usercmd As New OleDbCommand(usersql, mycon)

        mycon.Open()
        Dim reader As OleDbDataReader = mycmd.ExecuteReader
        Dim userreader As OleDbDataReader = usercmd.ExecuteReader

        reader.Read()
        While userreader.Read()
            If userreader("User ID") = reader("Rider ID") Then
                lblUsername.Text = userreader("Username")
                lblUserID.Text = userreader("User ID")
                lblPhone.Text = userreader("Phone Number")
                If Not String.IsNullOrEmpty(userreader("Picture").ToString) AndAlso File.Exists(userreader("Picture").ToString) Then
                    picProfile.Image = Image.FromFile(userreader("Picture").ToString)
                Else
                    picProfile.Image = My.Resources.profilePic
                End If
            End If
        End While
        reader.Close()
        mycon.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If countdownTime > 0 Then
            countdownTime -= 1
            UpdateCountdownLabel()
        Else
            Timer1.Stop()
            ' Countdown has reached 0, perform any required actions here
            MessageBox.Show("Countdown reached 0. Your time has expired.")
        End If
    End Sub

    Private Sub UpdateCountdownLabel()
        Dim minutes As Integer = countdownTime \ 60 ' Get the remaining minutes
        Dim seconds As Integer = countdownTime Mod 60 ' Get the remaining seconds

        ' Update the label to display the remaining time in the format "MM:SS"
        lblTimer.Text = minutes.ToString("00") & ":" & seconds.ToString("00")
    End Sub

    Private Sub BtnReceive_Click(sender As Object, e As EventArgs) Handles btnReceive.Click
        Dim response As String = MsgBox("Are you sure you have received your order?", 4 + MsgBoxStyle.Question, "Order")
        If response = vbYes Then
            Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
            Dim strsql As String = "UPDATE [Transaction History] SET [Status] = @status, [Rider ID] = @id WHERE [Status] = '3rd Stage'"
            Dim mycmd As New OleDbCommand(strsql, mycon)
            mycon.Open()

            mycmd.Parameters.AddWithValue("@status", "Done")
            mycmd.Parameters.AddWithValue("@id", GlobalVariables.UserID)

            mycmd.ExecuteNonQuery()
            mycon.Close()

            MsgBox("Order Received!", 0 + MsgBoxStyle.Information, "Order")

            Dim CustomerHomepage As CustomerHomepage = TryCast(Me.ParentForm, CustomerHomepage)
            Dim panel As Panel = TryCast(ParentForm.Controls("pnlContainer"), Panel)
            If panel IsNot Nothing Then
                'change usercontrol
                Dim CustomerHome As New CustomerHome
                panel.Controls.Clear()
                panel.Controls.Add(CustomerHome)
            End If
            CustomerHomepage.btnHome.BackColor = Color.FromArgb(180, 20, 20)
            CustomerHomepage.iconHome.BackColor = Color.FromArgb(180, 20, 20)
        End If
    End Sub
End Class