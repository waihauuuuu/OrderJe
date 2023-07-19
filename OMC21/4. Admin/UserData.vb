Imports System.Data.OleDb
Imports System.Runtime.Remoting.Messaging

Public Class UserData
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Documents\OrderJeDatabase.accdb")
    Private Sub UserData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strsql As String = "SELECT * FROM [Userdatabase] WHERE [User Type] = 'Customer'"
        Dim mycmd As New OleDbCommand(strsql, mycon)
        Dim dt As New DataTable()
        mycon.Open()
        dt.Load(mycmd.ExecuteReader())
        mycon.Close()
        UserDataGrid.DataSource = dt
        btnCustomer.BackColor = Color.Gray
    End Sub

    Sub Resett()
        btnCustomer.BackColor = Color.Gainsboro
        btnRider.BackColor = Color.Gainsboro
        btnCafeOwner.BackColor = Color.Gainsboro
    End Sub
    Private Sub BtnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Dim strsql As String = "SELECT * FROM [Userdatabase] WHERE [User Type] = 'Customer'"
        Dim mycmd As New OleDbCommand(strsql, mycon)
        Dim dt As New DataTable()
        mycon.Open()
        dt.Load(mycmd.ExecuteReader())
        mycon.Close()
        UserDataGrid.DataSource = dt
        Resett()
        btnCustomer.BackColor = Color.Gray
    End Sub

    Private Sub BtnRider_Click(sender As Object, e As EventArgs) Handles btnRider.Click
        Dim strsql As String = "SELECT * FROM [Userdatabase] WHERE [User Type] = 'Rider'"
        Dim mycmd As New OleDbCommand(strsql, mycon)
        Dim dt As New DataTable()
        mycon.Open()
        dt.Load(mycmd.ExecuteReader())
        mycon.Close()
        UserDataGrid.DataSource = dt
        Resett()
        btnRider.BackColor = Color.Gray
    End Sub

    Private Sub BtnCafeOwner_Click(sender As Object, e As EventArgs) Handles btnCafeOwner.Click
        Dim strsql As String = "SELECT * FROM [Userdatabase] WHERE [User Type] = 'Café Owner'"
        Dim mycmd As New OleDbCommand(strsql, mycon)
        Dim dt As New DataTable()
        mycon.Open()
        dt.Load(mycmd.ExecuteReader())
        mycon.Close()
        UserDataGrid.DataSource = dt
        Resett()
        btnCafeOwner.BackColor = Color.Gray
    End Sub
    Private Sub UserDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserDataGrid.CellClick
        ' Check if the click is on a valid cell and not the header row
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Manually select the entire row containing the clicked cell
            UserDataGrid.Rows(e.RowIndex).Selected = True
        End If
    End Sub
    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If UserDataGrid.SelectedRows.Count > 0 Then
            Dim response As DialogResult = MessageBox.Show("Are you sure to remove this user?", "Remove User", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = DialogResult.Yes Then
                Dim selectedRowIndex As Integer = UserDataGrid.SelectedRows(0).Index
                Dim selectedRow As DataGridViewRow = UserDataGrid.SelectedRows(0)

                Dim id As String = selectedRow.Cells("User ID").Value.ToString()

                Try
                    mycon.Open()
                    Dim strsql As String = "DELETE FROM [UserDatabase] WHERE [User ID] = @userId"
                    Using mycmd As New OleDbCommand(strsql, mycon)
                        mycmd.Parameters.AddWithValue("@userId", id)
                        mycmd.ExecuteNonQuery()
                    End Using

                    UserDataGrid.Rows.RemoveAt(selectedRowIndex)
                Catch ex As Exception
                    MessageBox.Show("Error occurred while deleting the row: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Please select a row to remove.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        mycon.Close()
    End Sub
End Class