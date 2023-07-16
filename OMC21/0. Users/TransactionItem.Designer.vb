<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionItem
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
        Me.lblOrderItem = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblOrderItem
        '
        Me.lblOrderItem.AutoSize = True
        Me.lblOrderItem.Location = New System.Drawing.Point(42, 37)
        Me.lblOrderItem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrderItem.Name = "lblOrderItem"
        Me.lblOrderItem.Size = New System.Drawing.Size(83, 17)
        Me.lblOrderItem.TabIndex = 0
        Me.lblOrderItem.Text = "lblOrderItem"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(209, 37)
        Me.lblQuantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(73, 17)
        Me.lblQuantity.TabIndex = 1
        Me.lblQuantity.Text = "lblQuantity"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(42, 81)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(49, 17)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "lblDate"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(356, 37)
        Me.lblCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(47, 17)
        Me.lblCost.TabIndex = 3
        Me.lblCost.Text = "lblCost"
        '
        'TransactionItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblOrderItem)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "TransactionItem"
        Me.Size = New System.Drawing.Size(470, 133)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOrderItem As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblCost As Label
End Class
