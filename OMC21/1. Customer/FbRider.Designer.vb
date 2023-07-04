<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FbRider
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
        Me.lblRiderName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(15, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 92)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblRiderName
        '
        Me.lblRiderName.AutoSize = True
        Me.lblRiderName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRiderName.Location = New System.Drawing.Point(128, 38)
        Me.lblRiderName.Name = "lblRiderName"
        Me.lblRiderName.Size = New System.Drawing.Size(67, 17)
        Me.lblRiderName.TabIndex = 1
        Me.lblRiderName.Text = "RiderName"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(128, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User ID: "
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUserID.Location = New System.Drawing.Point(197, 68)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(44, 17)
        Me.lblUserID.TabIndex = 3
        Me.lblUserID.Text = "XXXX"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(22, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "How was your experience with this rider?"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 62)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Bad"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(108, 172)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 62)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Mid"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(190, 172)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(61, 62)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Good"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox1.Location = New System.Drawing.Point(15, 257)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(275, 24)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "Comment"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(369, 256)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(45, 24)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(308, 256)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(45, 24)
        Me.btnSend.TabIndex = 9
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'FbRider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblRiderName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FbRider"
        Me.Size = New System.Drawing.Size(431, 298)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblRiderName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUserID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSend As Button
End Class
