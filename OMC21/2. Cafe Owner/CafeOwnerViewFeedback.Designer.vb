<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CafeOwnerViewFeedback
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Star5 = New System.Windows.Forms.Button()
        Me.Star4 = New System.Windows.Forms.Button()
        Me.Star3 = New System.Windows.Forms.Button()
        Me.Star2 = New System.Windows.Forms.Button()
        Me.Star1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(45, 240)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(526, 209)
        Me.FlowLayoutPanel1.TabIndex = 98
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(42, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 23)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Cafe's Ratings and Reviews"
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
        Me.Label14.TabIndex = 87
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
        Me.PictureBox2.TabIndex = 88
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 17)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Feedback to improve your business"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(41, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 23)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Overall Rating"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"All ratings", "5 stars", "4 stars", "3 stars", "2 stars", "1 star"})
        Me.ComboBox1.Location = New System.Drawing.Point(375, 195)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(196, 25)
        Me.ComboBox1.TabIndex = 101
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(198, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 23)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "lblRating"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Image = Global.OMC21.My.Resources.Resources.icons8_notification_35
        Me.Button6.Location = New System.Drawing.Point(551, 33)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(45, 45)
        Me.Button6.TabIndex = 103
        Me.Button6.UseVisualStyleBackColor = False
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
        Me.Star5.Location = New System.Drawing.Point(235, 182)
        Me.Star5.Name = "Star5"
        Me.Star5.Size = New System.Drawing.Size(67, 66)
        Me.Star5.TabIndex = 108
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
        Me.Star4.Location = New System.Drawing.Point(184, 182)
        Me.Star4.Name = "Star4"
        Me.Star4.Size = New System.Drawing.Size(67, 66)
        Me.Star4.TabIndex = 107
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
        Me.Star3.Location = New System.Drawing.Point(134, 182)
        Me.Star3.Name = "Star3"
        Me.Star3.Size = New System.Drawing.Size(67, 66)
        Me.Star3.TabIndex = 106
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
        Me.Star2.Location = New System.Drawing.Point(84, 182)
        Me.Star2.Name = "Star2"
        Me.Star2.Size = New System.Drawing.Size(67, 66)
        Me.Star2.TabIndex = 105
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
        Me.Star1.Location = New System.Drawing.Point(35, 182)
        Me.Star1.Name = "Star1"
        Me.Star1.Size = New System.Drawing.Size(67, 66)
        Me.Star1.TabIndex = 104
        Me.Star1.Text = "★"
        Me.Star1.UseVisualStyleBackColor = False
        '
        'CafeOwnerViewFeedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Star5)
        Me.Controls.Add(Me.Star4)
        Me.Controls.Add(Me.Star3)
        Me.Controls.Add(Me.Star2)
        Me.Controls.Add(Me.Star1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CafeOwnerViewFeedback"
        Me.Size = New System.Drawing.Size(622, 470)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Star5 As Button
    Friend WithEvents Star4 As Button
    Friend WithEvents Star3 As Button
    Friend WithEvents Star2 As Button
    Friend WithEvents Star1 As Button
End Class
