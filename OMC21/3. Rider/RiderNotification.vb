Imports System.Data.OleDb

Public Class RiderNotification
    Public Shared id As String
    Private Sub RiderNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")

        Dim ridersql As String = "SELECT * FROM [Transaction History] WHERE [Status] = '2nd Stage'"
        Dim ridercmd As New OleDbCommand(ridersql, mycon)

        Dim usersql As String = "SELECT * FROM [UserDatabase]"
        Dim usercmd As New OleDbCommand(usersql, mycon)

        Dim RiderOrder As New RiderOrder
        mycon.Open()

        Dim riderreader As OleDbDataReader = ridercmd.ExecuteReader

        While riderreader.Read()
            id = riderreader("Order ID")
            RiderOrder.lblOrderID.Text = riderreader("Order ID")
            RiderOrder.lblUserID.Text = riderreader("User ID")
            RiderOrder.lblTotal.Text = "RM" & riderreader("Total")

            Dim userreader As OleDbDataReader = usercmd.ExecuteReader
            While userreader.Read()
                If userreader("User ID") = riderreader("User ID") Then
                    RiderOrder.lblContact.Text = userreader("Phone Number")
                    RiderOrder.lblVillage.Text = userreader("Village")
                End If
            End While
            userreader.Close()

            RiderOrder.Anchor = AnchorStyles.Left Or AnchorStyles.Right
            PanelNotification.Controls.Add(RiderOrder)
        End While

        mycon.Close()
    End Sub
End Class
