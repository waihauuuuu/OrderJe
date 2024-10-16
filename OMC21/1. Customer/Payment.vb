﻿Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class Payment
    Public Shared orderID As Integer
    Dim dblSubtotal As Double
    Dim dblDelivery As Double
    Dim dblPoint As Double
    Dim dblTotal As Double
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddBankCard2.Show()
    End Sub
    Sub RefreshForm()
        Dim strsql As String = "SELECT * FROM [Payment Methods] WHERE [User ID] = '" & GlobalVariables.UserID & "'"
        Dim mycmd As New OleDbCommand(strsql, mycon)
        mycon.Open()

        Dim reader As OleDbDataReader = mycmd.ExecuteReader
        While reader.Read()
            If (reader("Bank Name").Length > 7) Then
                cboBank.Items.Add(reader("Bank Name") & vbTab & reader("Bank Number"))
            Else
                cboBank.Items.Add(reader("Bank Name") & vbTab & vbTab & reader("Bank Number"))
            End If
        End While
        mycon.Close()
    End Sub
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshForm()
        Dim strsql1 As String = "SELECT * FROM [Cart] WHERE [User ID] = '" & GlobalVariables.UserID & "' AND [Status] = 'Cart'"
        Dim mycmd1 As New OleDbCommand(strsql1, mycon)
        mycon.Open()
        Dim reader1 As OleDbDataReader = mycmd1.ExecuteReader
        While reader1.Read()
            lstFood.Items.Add(reader1("Food Name"))
            lstQuantity.Items.Add("x" & reader1("Quantity"))
            lstCost.Items.Add(reader1("Cost"))
            dblSubtotal += CDbl(reader1("Cost"))
        End While
        lblSubtotal.Text = Format(dblSubtotal, "0.00")
        mycon.Close()
        lblDatetime.Text = Date.Now.ToString("dd/MM/yyyy")
        dblTotal = dblSubtotal
        lblTotal.Text = Format(dblTotal, "0.00")
    End Sub
    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        cboBank.Items.Clear()
        RefreshForm()
    End Sub

    Private Sub BtnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        If (cboBank.Text = "") OrElse ((rdbStandard.Checked Or rdbPickup.Checked) = False) Then
            MsgBox("Please select all the requirement fields", 0 + MsgBoxStyle.Exclamation, "Incomplete Information")
        Else
            Dim response = MsgBox("Are you sure to purchase?", 4 + MsgBoxStyle.Question, "Purchase")
            If response = vbYes Then
                Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
                Dim strsql As String = "INSERT INTO [Transaction History] ([User ID], [Card Number], [Subtotal], [Points], [Delivery/Pickup], [Total], [Datetime], [Status]) Values(@id, @cardnumber, @subtotal, @points, @dp, @total, @datetime, @status)"
                Dim mycmd As New OleDbCommand(strsql, mycon)
                mycon.Open()

                mycmd.Parameters.AddWithValue("@id", GlobalVariables.UserID)
                Dim cardNumber As String = cboBank.SelectedItem.ToString()
                Dim numericPart As String = Regex.Replace(cardNumber, "[^\d]", "")
                mycmd.Parameters.AddWithValue("@cardnumber", numericPart)
                mycmd.Parameters.AddWithValue("@subtotal", lblSubtotal.Text)
                mycmd.Parameters.AddWithValue("@points", lblPoints.Text)
                mycmd.Parameters.AddWithValue("@dp", lblDelivery.Text)
                mycmd.Parameters.AddWithValue("@total", lblTotal.Text)
                mycmd.Parameters.AddWithValue("@datetime", lblDatetime.Text)
                mycmd.Parameters.AddWithValue("@status", "1st Stage")

                mycmd.ExecuteNonQuery()
                mycon.Close()

                Dim ordersql As String = "SELECT [Order ID] FROM [Transaction History]"
                Dim ordercmd As New OleDbCommand(ordersql, mycon)
                mycon.Open()

                Dim reader As OleDbDataReader = ordercmd.ExecuteReader
                While reader.Read()
                    orderID = reader("Order ID")
                End While

                Dim idsql As String = "UPDATE [CART] SET [Order ID] = @orderid, [Status] = @status WHERE [User ID] = '" & GlobalVariables.UserID & "' AND [Status] = 'Cart'"
                Dim idcmd As New OleDbCommand(idsql, mycon)

                idcmd.Parameters.AddWithValue("@orderid", orderID)
                idcmd.Parameters.AddWithValue("@status", "Purchased")

                idcmd.ExecuteNonQuery()
                mycon.Close()

                MsgBox("Purchase sucessfully!", 0 + MsgBoxStyle.Information, "Purchase")
                Dim CustomerHomepage As CustomerHomepage = TryCast(Me.ParentForm, CustomerHomepage)
                Dim panel As Panel = TryCast(ParentForm.Controls("pnlContainer"), Panel)
                If panel IsNot Nothing Then
                    'change usercontrol
                    Dim CustomerReceipt As New CustomerReceipt
                    panel.Controls.Clear()
                    panel.Controls.Add(CustomerReceipt)
                End If
            Else
                MsgBox("Failed to purchase!", 0 + MsgBoxStyle.Critical, "Purchase")
            End If
        End If
    End Sub

    Private Sub Rdb_CheckedChanged(sender As Object, e As EventArgs) Handles rdbStandard.CheckedChanged, rdbPickup.CheckedChanged
        Dim Count As Integer = 0
        Dim Countsql As String = "SELECT COUNT(*) FROM [Cart] WHERE [User ID] = '" & GlobalVariables.UserID & "' AND [Status] = 'Cart'"
        mycon.Open()

        Using Countcommand As New OleDbCommand(Countsql, mycon)
            Count = CInt(Countcommand.ExecuteScalar())
        End Using
        If rdbStandard.Checked = True Then
            dblDelivery = 2 * Count
        ElseIf rdbPickup.Checked = True Then
            dblDelivery = 0
        End If
        lblDelivery.Text = Format(dblDelivery, "0.00")
        dblTotal += dblDelivery
        lblTotal.Text = Format(dblTotal, "0.00")
        mycon.Close()
    End Sub

    Private Sub ChkPoints_CheckedChanged(sender As Object, e As EventArgs) Handles chkPoints.CheckedChanged
        Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
        Dim Count As Integer = 0
        Dim sqlCount As String = "SELECT COUNT(*) FROM [CART] WHERE [User ID] = '" & GlobalVariables.UserID & "' AND [Status] = 'History'"

        Dim strsql As String = "SELECT * FROM [CART]"
        Dim mycmd As New OleDbCommand(strsql, mycon)

        mycon.Open()
        Dim reader As OleDbDataReader = mycmd.ExecuteReader

        Using commandCount As New OleDbCommand(sqlCount, mycon)
            Count = CInt(commandCount.ExecuteScalar())
        End Using

        While reader.Read()
            If reader("Quantity") > 1 Then
                Count += reader("Quantity")
                Count -= 1
            End If
        End While

        mycon.Close()

        If chkPoints.Checked = True Then
            dblPoint = Count / 10
            lblPoints.Text = Format(dblPoint, "0.00")
        ElseIf chkPoints.Checked = False Then
            dblPoint = 0
            lblPoints.Text = Format(dblPoint, "0.00")
        End If
        dblTotal -= dblPoint
        lblTotal.Text = Format(dblTotal, "0.00")
    End Sub
End Class
