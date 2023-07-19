<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RiderDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.lstFood = New System.Windows.Forms.ListBox()
        Me.lstCafeName = New System.Windows.Forms.ListBox()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstFood
        '
        Me.lstFood.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstFood.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFood.FormattingEnabled = True
        Me.lstFood.ItemHeight = 17
        Me.lstFood.Location = New System.Drawing.Point(26, 50)
        Me.lstFood.Name = "lstFood"
        Me.lstFood.Size = New System.Drawing.Size(132, 153)
        Me.lstFood.TabIndex = 16
        '
        'lstCafeName
        '
        Me.lstCafeName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstCafeName.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCafeName.FormattingEnabled = True
        Me.lstCafeName.ItemHeight = 17
        Me.lstCafeName.Location = New System.Drawing.Point(157, 50)
        Me.lstCafeName.Name = "lstCafeName"
        Me.lstCafeName.Size = New System.Drawing.Size(181, 153)
        Me.lstCafeName.TabIndex = 17
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.lblDetails.Location = New System.Drawing.Point(22, 12)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(62, 23)
        Me.lblDetails.TabIndex = 18
        Me.lblDetails.Text = "Details"
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(316, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(22, 23)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "X"
        '
        'RiderDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(362, 224)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.lstCafeName)
        Me.Controls.Add(Me.lstFood)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RiderDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RiderDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstFood As ListBox
    Friend WithEvents lstCafeName As ListBox
    Friend WithEvents lblDetails As Label
    Friend WithEvents btnClose As Label
End Class
