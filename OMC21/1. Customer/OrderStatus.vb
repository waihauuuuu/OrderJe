'Customer 'Delivery'
Public Class OrderStatus
    Private countdownTime As Integer ' Total countdown time in seconds

    Private Sub OrderStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        countdownTime = 30 * 60 ' Set the countdown time to 30 minutes
        UpdateCountdownLabel()
        Timer1.Interval = 1000
        Timer1.Start()
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

    Private Sub BtnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        Dim CustomerHomepage As CustomerHomepage = TryCast(Me.ParentForm, CustomerHomepage)
        Dim panel As Panel = TryCast(ParentForm.Controls("pnlContainer"), Panel)
        If panel IsNot Nothing Then
            'change usercontrol
            Dim Cart As New Cart
            panel.Controls.Clear()
            panel.Controls.Add(Cart)
        End If
        CustomerHomepage.btnDelivery.BackColor = Color.FromArgb(30, 30, 30)
        CustomerHomepage.iconDelivery.BackColor = Color.FromArgb(30, 30, 30)
    End Sub

    'If cafe owner and rider accept the order
    'Show this usercontrol
    'Elseif cafe owner accept the order, rider not accept the order
    'Show 'Delivery service not accepted'
    'Elseif cafe owner not accept the order, rider not accept the order
    'Show 'Order not accepted'
    'Else (no order)
    'Show 'You have no order'
End Class