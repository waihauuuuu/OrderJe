<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CafeOwnerTransactionHistory
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelTransactionHistory = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNotification = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OMC21.My.Resources.Resources.OrderJeLogo
        Me.PictureBox1.Location = New System.Drawing.Point(45, -5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        '
        'PanelTransactionHistory
        '
        Me.PanelTransactionHistory.Location = New System.Drawing.Point(74, 121)
        Me.PanelTransactionHistory.Name = "PanelTransactionHistory"
        Me.PanelTransactionHistory.Size = New System.Drawing.Size(480, 349)
        Me.PanelTransactionHistory.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(208, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 23)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Transaction History"
        '
        'btnNotification
        '
        Me.btnNotification.BackColor = System.Drawing.Color.White
        Me.btnNotification.Image = Global.OMC21.My.Resources.Resources.icons8_notification_35
        Me.btnNotification.Location = New System.Drawing.Point(551, 33)
        Me.btnNotification.Name = "btnNotification"
        Me.btnNotification.Size = New System.Drawing.Size(45, 45)
        Me.btnNotification.TabIndex = 84
        Me.btnNotification.UseVisualStyleBackColor = False
        '
        'CafeOwnerTransactionHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Controls.Add(Me.btnNotification)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PanelTransactionHistory)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CafeOwnerTransactionHistory"
        Me.Size = New System.Drawing.Size(622, 470)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelTransactionHistory As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNotification As Button
End Class
