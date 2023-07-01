<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewFeedBack
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
        Me.btnCafe = New System.Windows.Forms.Button()
        Me.btnRider = New System.Windows.Forms.Button()
        Me.btnApplication = New System.Windows.Forms.Button()
        Me.pnlContainerIn = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(208, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Feedback"
        '
        'btnCafe
        '
        Me.btnCafe.BackColor = System.Drawing.Color.White
        Me.btnCafe.ForeColor = System.Drawing.Color.Black
        Me.btnCafe.Location = New System.Drawing.Point(-1, 105)
        Me.btnCafe.Name = "btnCafe"
        Me.btnCafe.Size = New System.Drawing.Size(103, 45)
        Me.btnCafe.TabIndex = 2
        Me.btnCafe.Text = "Cafe"
        Me.btnCafe.UseVisualStyleBackColor = False
        '
        'btnRider
        '
        Me.btnRider.BackColor = System.Drawing.Color.White
        Me.btnRider.ForeColor = System.Drawing.Color.Black
        Me.btnRider.Location = New System.Drawing.Point(99, 105)
        Me.btnRider.Name = "btnRider"
        Me.btnRider.Size = New System.Drawing.Size(103, 45)
        Me.btnRider.TabIndex = 3
        Me.btnRider.Text = "Rider"
        Me.btnRider.UseVisualStyleBackColor = False
        '
        'btnApplication
        '
        Me.btnApplication.BackColor = System.Drawing.Color.White
        Me.btnApplication.ForeColor = System.Drawing.Color.Black
        Me.btnApplication.Location = New System.Drawing.Point(198, 105)
        Me.btnApplication.Name = "btnApplication"
        Me.btnApplication.Size = New System.Drawing.Size(103, 45)
        Me.btnApplication.TabIndex = 4
        Me.btnApplication.Text = "Application"
        Me.btnApplication.UseVisualStyleBackColor = False
        '
        'pnlContainerIn
        '
        Me.pnlContainerIn.BackColor = System.Drawing.SystemColors.Control
        Me.pnlContainerIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlContainerIn.Location = New System.Drawing.Point(0, 149)
        Me.pnlContainerIn.Name = "pnlContainerIn"
        Me.pnlContainerIn.Size = New System.Drawing.Size(622, 328)
        Me.pnlContainerIn.TabIndex = 5
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Image = Global.OMC21.My.Resources.Resources.icons8_notification_35
        Me.Button5.Location = New System.Drawing.Point(491, 33)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(45, 45)
        Me.Button5.TabIndex = 7
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Image = Global.OMC21.My.Resources.Resources.icons8_cart_35
        Me.Button6.Location = New System.Drawing.Point(551, 33)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(45, 45)
        Me.Button6.TabIndex = 8
        Me.Button6.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OMC21.My.Resources.Resources.OrderJeLogo
        Me.PictureBox1.Location = New System.Drawing.Point(45, -5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ViewFeedBack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Controls.Add(Me.pnlContainerIn)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnApplication)
        Me.Controls.Add(Me.btnRider)
        Me.Controls.Add(Me.btnCafe)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ViewFeedBack"
        Me.Size = New System.Drawing.Size(622, 470)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCafe As Button
    Friend WithEvents btnRider As Button
    Friend WithEvents btnApplication As Button
    Friend WithEvents pnlContainerIn As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
