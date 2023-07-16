<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerTransactionHistory
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.PanelTransactionHistory = New System.Windows.Forms.FlowLayoutPanel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cboCafe = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(37, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 23)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Transaction History"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(320, 59)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(82, 24)
        Me.btnSearch.TabIndex = 56
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'PanelTransactionHistory
        '
        Me.PanelTransactionHistory.AutoScroll = True
        Me.PanelTransactionHistory.Location = New System.Drawing.Point(17, 108)
        Me.PanelTransactionHistory.Name = "PanelTransactionHistory"
        Me.PanelTransactionHistory.Size = New System.Drawing.Size(484, 402)
        Me.PanelTransactionHistory.TabIndex = 58
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(41, 61)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(127, 24)
        Me.DateTimePicker1.TabIndex = 59
        Me.DateTimePicker1.Value = New Date(2023, 7, 7, 0, 0, 0, 0)
        '
        'cboCafe
        '
        Me.cboCafe.FormattingEnabled = True
        Me.cboCafe.Items.AddRange(New Object() {"All Café", "Café Mesra", "V2 Gee & S Café", "V3 Island One Café", "V4 Razak zaitom Café", "V5 Afifah Beta Café", "V6 Harraz Café", "V5 Dapur Ibrahim Café", "V5 Manje Burger", "Sayang Café"})
        Me.cboCafe.Location = New System.Drawing.Point(183, 60)
        Me.cboCafe.Name = "cboCafe"
        Me.cboCafe.Size = New System.Drawing.Size(121, 25)
        Me.cboCafe.TabIndex = 60
        '
        'CustomerTransactionHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Controls.Add(Me.cboCafe)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PanelTransactionHistory)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CustomerTransactionHistory"
        Me.Size = New System.Drawing.Size(517, 510)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents PanelTransactionHistory As FlowLayoutPanel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cboCafe As ComboBox
End Class
