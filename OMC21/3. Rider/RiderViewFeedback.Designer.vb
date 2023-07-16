<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RiderViewFeedback
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
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelComment = New System.Windows.Forms.FlowLayoutPanel()
        Me.Star5 = New System.Windows.Forms.Button()
        Me.Star4 = New System.Windows.Forms.Button()
        Me.Star3 = New System.Windows.Forms.Button()
        Me.Star2 = New System.Windows.Forms.Button()
        Me.Star1 = New System.Windows.Forms.Button()
        Me.lblRating = New System.Windows.Forms.Label()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picProfile
        '
        Me.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProfile.Image = Global.OMC21.My.Resources.Resources.profilePic
        Me.picProfile.Location = New System.Drawing.Point(45, 114)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(90, 98)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfile.TabIndex = 0
        Me.picProfile.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(208, 42)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 23)
        Me.Label14.TabIndex = 74
        Me.Label14.Text = "Feedback"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.OMC21.My.Resources.Resources.OrderJeLogo
        Me.PictureBox2.Location = New System.Drawing.Point(45, -5)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 75
        Me.PictureBox2.TabStop = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(146, 129)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(80, 23)
        Me.lblUsername.TabIndex = 76
        Me.lblUsername.Text = "Username"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.ForeColor = System.Drawing.Color.White
        Me.lblUserID.Location = New System.Drawing.Point(230, 167)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(58, 23)
        Me.lblUserID.TabIndex = 77
        Me.lblUserID.Text = "XXXX"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(148, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 23)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "User ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(326, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 23)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Rating"
        '
        'PanelComment
        '
        Me.PanelComment.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelComment.Location = New System.Drawing.Point(0, 231)
        Me.PanelComment.Name = "PanelComment"
        Me.PanelComment.Size = New System.Drawing.Size(622, 239)
        Me.PanelComment.TabIndex = 85
        '
        'Star5
        '
        Me.Star5.AutoSize = True
        Me.Star5.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Star5.FlatAppearance.BorderSize = 0
        Me.Star5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Star5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Star5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Star5.Font = New System.Drawing.Font("Comic Sans MS", 30.0!)
        Me.Star5.Location = New System.Drawing.Point(514, 144)
        Me.Star5.Name = "Star5"
        Me.Star5.Size = New System.Drawing.Size(69, 68)
        Me.Star5.TabIndex = 90
        Me.Star5.Text = "★"
        Me.Star5.UseVisualStyleBackColor = False
        '
        'Star4
        '
        Me.Star4.AutoSize = True
        Me.Star4.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Star4.FlatAppearance.BorderSize = 0
        Me.Star4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Star4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Star4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Star4.Font = New System.Drawing.Font("Comic Sans MS", 30.0!)
        Me.Star4.Location = New System.Drawing.Point(463, 144)
        Me.Star4.Name = "Star4"
        Me.Star4.Size = New System.Drawing.Size(69, 68)
        Me.Star4.TabIndex = 89
        Me.Star4.Text = "★"
        Me.Star4.UseVisualStyleBackColor = False
        '
        'Star3
        '
        Me.Star3.AutoSize = True
        Me.Star3.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Star3.FlatAppearance.BorderSize = 0
        Me.Star3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Star3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Star3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Star3.Font = New System.Drawing.Font("Comic Sans MS", 30.0!)
        Me.Star3.Location = New System.Drawing.Point(413, 144)
        Me.Star3.Name = "Star3"
        Me.Star3.Size = New System.Drawing.Size(69, 68)
        Me.Star3.TabIndex = 88
        Me.Star3.Text = "★"
        Me.Star3.UseVisualStyleBackColor = False
        '
        'Star2
        '
        Me.Star2.AutoSize = True
        Me.Star2.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Star2.FlatAppearance.BorderSize = 0
        Me.Star2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Star2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Star2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Star2.Font = New System.Drawing.Font("Comic Sans MS", 30.0!)
        Me.Star2.Location = New System.Drawing.Point(363, 144)
        Me.Star2.Name = "Star2"
        Me.Star2.Size = New System.Drawing.Size(69, 68)
        Me.Star2.TabIndex = 87
        Me.Star2.Text = "★"
        Me.Star2.UseVisualStyleBackColor = False
        '
        'Star1
        '
        Me.Star1.AutoSize = True
        Me.Star1.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Star1.FlatAppearance.BorderSize = 0
        Me.Star1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Star1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Star1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Star1.Font = New System.Drawing.Font("Comic Sans MS", 30.0!)
        Me.Star1.Location = New System.Drawing.Point(314, 144)
        Me.Star1.Name = "Star1"
        Me.Star1.Size = New System.Drawing.Size(69, 68)
        Me.Star1.TabIndex = 86
        Me.Star1.Text = "★"
        Me.Star1.UseVisualStyleBackColor = False
        '
        'lblRating
        '
        Me.lblRating.AutoSize = True
        Me.lblRating.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.lblRating.ForeColor = System.Drawing.Color.White
        Me.lblRating.Location = New System.Drawing.Point(488, 129)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(77, 23)
        Me.lblRating.TabIndex = 103
        Me.lblRating.Text = "lblRating"
        '
        'RiderViewFeedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Controls.Add(Me.lblRating)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Star5)
        Me.Controls.Add(Me.Star4)
        Me.Controls.Add(Me.Star3)
        Me.Controls.Add(Me.Star2)
        Me.Controls.Add(Me.Star1)
        Me.Controls.Add(Me.PanelComment)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.picProfile)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RiderViewFeedback"
        Me.Size = New System.Drawing.Size(622, 470)
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picProfile As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblUserID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelComment As FlowLayoutPanel
    Friend WithEvents Star5 As Button
    Friend WithEvents Star4 As Button
    Friend WithEvents Star3 As Button
    Friend WithEvents Star2 As Button
    Friend WithEvents Star1 As Button
    Friend WithEvents lblRating As Label
End Class
