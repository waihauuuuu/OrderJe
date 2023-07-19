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
        Me.lblRiderName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnGood = New System.Windows.Forms.Button()
        Me.btnMid = New System.Windows.Forms.Button()
        Me.btnBad = New System.Windows.Forms.Button()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRiderName
        '
        Me.lblRiderName.AutoSize = True
        Me.lblRiderName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblRiderName.Location = New System.Drawing.Point(117, 38)
        Me.lblRiderName.Name = "lblRiderName"
        Me.lblRiderName.Size = New System.Drawing.Size(81, 17)
        Me.lblRiderName.TabIndex = 1
        Me.lblRiderName.Text = "lblRiderName"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(117, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User ID: "
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblUserID.Location = New System.Drawing.Point(186, 68)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(44, 17)
        Me.lblUserID.TabIndex = 3
        Me.lblUserID.Text = "XXXX"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(13, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "How was your experience with this rider?"
        '
        'txtComment
        '
        Me.txtComment.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComment.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtComment.Location = New System.Drawing.Point(16, 206)
        Me.txtComment.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(275, 24)
        Me.txtComment.TabIndex = 8
        Me.txtComment.Text = "Comment"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(349, 206)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(45, 24)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(298, 205)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(45, 24)
        Me.btnSend.TabIndex = 9
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'btnGood
        '
        Me.btnGood.BackColor = System.Drawing.Color.White
        Me.btnGood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGood.Image = Global.OMC21.My.Resources.Resources.smiley
        Me.btnGood.Location = New System.Drawing.Point(124, 150)
        Me.btnGood.Name = "btnGood"
        Me.btnGood.Size = New System.Drawing.Size(40, 40)
        Me.btnGood.TabIndex = 7
        Me.btnGood.UseVisualStyleBackColor = False
        '
        'btnMid
        '
        Me.btnMid.BackColor = System.Drawing.Color.White
        Me.btnMid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMid.Image = Global.OMC21.My.Resources.Resources.moderate
        Me.btnMid.Location = New System.Drawing.Point(70, 150)
        Me.btnMid.Name = "btnMid"
        Me.btnMid.Size = New System.Drawing.Size(40, 40)
        Me.btnMid.TabIndex = 6
        Me.btnMid.UseVisualStyleBackColor = False
        '
        'btnBad
        '
        Me.btnBad.BackColor = System.Drawing.Color.White
        Me.btnBad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBad.Image = Global.OMC21.My.Resources.Resources.bad
        Me.btnBad.Location = New System.Drawing.Point(15, 150)
        Me.btnBad.Name = "btnBad"
        Me.btnBad.Size = New System.Drawing.Size(40, 40)
        Me.btnBad.TabIndex = 5
        Me.btnBad.UseVisualStyleBackColor = False
        '
        'picProfile
        '
        Me.picProfile.BackColor = System.Drawing.Color.White
        Me.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProfile.Image = Global.OMC21.My.Resources.Resources.profilePic
        Me.picProfile.Location = New System.Drawing.Point(15, 14)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(84, 92)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfile.TabIndex = 0
        Me.picProfile.TabStop = False
        '
        'FbRider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.btnGood)
        Me.Controls.Add(Me.btnMid)
        Me.Controls.Add(Me.btnBad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblRiderName)
        Me.Controls.Add(Me.picProfile)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FbRider"
        Me.Size = New System.Drawing.Size(404, 240)
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picProfile As PictureBox
    Friend WithEvents lblRiderName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUserID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBad As Button
    Friend WithEvents btnMid As Button
    Friend WithEvents btnGood As Button
    Friend WithEvents txtComment As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSend As Button
End Class
