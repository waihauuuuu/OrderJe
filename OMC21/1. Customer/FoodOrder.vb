'Customer 'Cafe'
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class FoodOrder
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
    Public Shared strCafe As String
    Public Shared strFood As String
    Public Shared strCost As String
    Public Shared imgFood As Image
    'Function to display usercontrol in table layout panel
    Private Sub DisplayMenu(readerC As OleDbDataReader, readerU As OleDbDataReader, ByRef column As Integer, ByRef row As Integer, tlpMenu As TableLayoutPanel)
        Dim MenuPicture As New MenuPicture With {
            .Dock = DockStyle.Fill
        }
        MenuPicture.lblCafe.Text = readerU("Full Name").ToString()
        MenuPicture.lblFood.Text = readerC("Menu Name").ToString()
        MenuPicture.lblCost.Text = "RM" & readerC("Cost").ToString()
        MenuPicture.picFood.Image = Image.FromFile(readerC("Menu Picture").ToString)
        tlpMenu.Controls.Add(MenuPicture, column, row)
        If column >= 3 Then
            column = 0
            row += 1
        End If
    End Sub

    'When FoodOrder page load..
    Private Sub FoodOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'count the row of the database table
        Dim rowCount As Integer = 0
        Dim sqlCount As String = "SELECT COUNT(*) FROM [Cafe Menu]"
        mycon.Open()
        Using commandCount As New OleDbCommand(sqlCount, mycon)
            rowCount = CInt(commandCount.ExecuteScalar())
        End Using
        Try
            'open 2 reader to relate user id in both database table
            Dim strsqlC As String = "SELECT * FROM [Cafe Menu]"
            Dim mycmdC As New OleDbCommand(strsqlC, mycon)
            Dim readerC As OleDbDataReader = mycmdC.ExecuteReader()

            Dim strsqlU As String = "SELECT * FROM [UserDatabase] INNER JOIN [Cafe Menu] ON [UserDatabase].[User ID] = [Cafe Menu].[User ID]"
            Dim mycmdU As New OleDbCommand(strsqlU, mycon)
            Dim readerU As OleDbDataReader = mycmdU.ExecuteReader()

            Dim row As Integer = 0
            Dim column As Integer = 0

            'for loop based on how many row database table have
            For i = 0 To rowCount - 1
                If readerC.Read() AndAlso readerU.Read() Then
                    'call function
                    DisplayMenu(readerC, readerU, column, row, TLPMenu)
                End If
            Next

            readerU.Close()
            readerC.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        mycon.Close()

        btnFood.BackColor = Color.White
        btnFood.ForeColor = Color.Black
    End Sub

    'when cbo changed
    Private Sub CboCafe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCafe.SelectedIndexChanged
        'count the row in database table
        Dim rowCount As Integer = 0
        Dim sqlCount As String = "SELECT COUNT(*) FROM [Cafe Menu]"
        mycon.Open()
        Using commandCount As New OleDbCommand(sqlCount, mycon)
            rowCount = CInt(commandCount.ExecuteScalar())
        End Using
        Try
            Dim row As Integer = 0
            Dim column As Integer = 0

            'when index not = "-1" selected, which mean it selected on something else
            If cboCafe.SelectedIndex <> -1 Then
                Dim selectedCafeName As String = cboCafe.SelectedItem.ToString()
                Dim strsql As String = "SELECT * FROM UserDatabase WHERE [Full Name] = @cafename"
                Dim mycmd As New OleDbCommand(strsql, mycon)
                mycmd.Parameters.AddWithValue("@cafename", selectedCafeName)

                Dim readerU As OleDbDataReader = mycmd.ExecuteReader()

                If readerU.Read() Then
                    Dim userID As String = readerU("User ID")

                    Dim strsqlC As String = "SELECT * FROM [Cafe Menu] WHERE [User ID] = @id"
                    Dim mycmdC As New OleDbCommand(strsqlC, mycon)
                    mycmdC.Parameters.AddWithValue("@id", userID)

                    TLPMenu.Controls.Clear()

                    Dim readerC As OleDbDataReader = mycmdC.ExecuteReader()

                    'for loop based on how many row database table have
                    For i = 0 To rowCount - 1
                        If readerC.Read() Then
                            DisplayMenu(readerC, readerU, column, row, TLPMenu)
                        End If
                    Next
                    readerU.Close()
                    readerC.Close()
                End If
            End If

            'when index "0" sleected or "all cafe" selected
            If cboCafe.SelectedIndex = 0 Then
                Dim strsqlC As String = "SELECT * FROM [Cafe Menu]"
                Dim mycmdC As New OleDbCommand(strsqlC, mycon)
                Dim readerC As OleDbDataReader = mycmdC.ExecuteReader()

                Dim strsqlU As String = "SELECT * FROM [UserDatabase] INNER JOIN [Cafe Menu] ON [UserDatabase].[User ID] = [Cafe Menu].[User ID]"
                Dim mycmdU As New OleDbCommand(strsqlU, mycon)
                Dim readerU As OleDbDataReader = mycmdU.ExecuteReader()

                TLPMenu.Controls.Clear()

                'for loop based on how many row database table have
                For i = 0 To rowCount - 1
                    If readerC.Read() AndAlso readerU.Read() Then
                        'call function
                        DisplayMenu(readerC, readerU, column, row, TLPMenu)
                    End If
                Next
                readerU.Close()
                readerC.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        mycon.Close()
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
        CustomerHomepage.btnCafe.BackColor = Color.FromArgb(30, 30, 30)
        CustomerHomepage.iconCafe.BackColor = Color.FromArgb(30, 30, 30)
    End Sub
End Class
