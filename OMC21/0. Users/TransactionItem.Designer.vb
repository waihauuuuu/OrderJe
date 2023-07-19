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
        Me.lblCorner = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCorner
        '
        Me.lblCorner.Location = New System.Drawing.Point(186, 37)
        Me.lblCorner.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCorner.Name = "lblCorner"
        Me.lblCorner.Size = New System.Drawing.Size(231, 17)
        Me.lblCorner.TabIndex = 0
        Me.lblCorner.Text = "lblCorner"
        Me.lblCorner.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(42, 83)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(49, 17)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "lblDate"
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(183, 83)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(234, 17)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "lblTotal"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Location = New System.Drawing.Point(42, 37)
        Me.lblOrder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(56, 17)
        Me.lblOrder.TabIndex = 4
        Me.lblOrder.Text = "lblOrder"
        '
        'TransactionItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblCorner)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "TransactionItem"
        Me.Size = New System.Drawing.Size(470, 133)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCorner As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblOrder As Label
End Class
