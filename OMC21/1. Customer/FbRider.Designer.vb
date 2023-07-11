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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FbRider))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblRiderName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBad = New System.Windows.Forms.Button()
        Me.btnMid = New System.Windows.Forms.Button()
        Me.btnGood = New System.Windows.Forms.Button()
        Me.txtCommentRider = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblRiderName
        '
        Me.lblRiderName.AutoSize = True
        Me.lblRiderName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblRiderName.Location = New System.Drawing.Point(128, 38)
        Me.lblRiderName.Name = "lblRiderName"
        Me.lblRiderName.Size = New System.Drawing.Size(24, 17)
        Me.lblRiderName.TabIndex = 1
        Me.lblRiderName.Text = "Ali"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(128, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User ID: "
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblUserID.Location = New System.Drawing.Point(197, 68)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(34, 17)
        Me.lblUserID.TabIndex = 3
        Me.lblUserID.Text = "R001"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(22, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "How was your experience with this rider?"
        '
        'btnBad
        '
        Me.btnBad.Location = New System.Drawing.Point(25, 172)
        Me.btnBad.Name = "btnBad"
        Me.btnBad.Size = New System.Drawing.Size(61, 62)
        Me.btnBad.TabIndex = 5
        Me.btnBad.Text = "Bad"
        Me.btnBad.UseVisualStyleBackColor = True
        '
        'btnMid
        '
        Me.btnMid.Location = New System.Drawing.Point(108, 172)
        Me.btnMid.Name = "btnMid"
        Me.btnMid.Size = New System.Drawing.Size(61, 62)
        Me.btnMid.TabIndex = 6
        Me.btnMid.Text = "Mid"
        Me.btnMid.UseVisualStyleBackColor = True
        '
        'btnGood
        '
        Me.btnGood.Location = New System.Drawing.Point(190, 172)
        Me.btnGood.Name = "btnGood"
        Me.btnGood.Size = New System.Drawing.Size(61, 62)
        Me.btnGood.TabIndex = 7
        Me.btnGood.Text = "Good"
        Me.btnGood.UseVisualStyleBackColor = True
        '
        'txtCommentRider
        '
        Me.txtCommentRider.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommentRider.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtCommentRider.Location = New System.Drawing.Point(15, 257)
        Me.txtCommentRider.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCommentRider.Name = "txtCommentRider"
        Me.txtCommentRider.Size = New System.Drawing.Size(275, 24)
        Me.txtCommentRider.TabIndex = 8
        Me.txtCommentRider.Text = "Comment"
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
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtCommentRider)
        Me.Controls.Add(Me.btnGood)
        Me.Controls.Add(Me.btnMid)
        Me.Controls.Add(Me.btnBad)
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
    Friend WithEvents btnBad As Button
    Friend WithEvents btnMid As Button
    Friend WithEvents btnGood As Button
    Friend WithEvents txtCommentRider As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSend As Button
End Class
