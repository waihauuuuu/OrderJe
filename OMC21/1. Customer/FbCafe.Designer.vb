<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FbCafe
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
        Me.cboCafe = New System.Windows.Forms.ComboBox()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.Star5 = New System.Windows.Forms.Button()
        Me.Star4 = New System.Windows.Forms.Button()
        Me.Star3 = New System.Windows.Forms.Button()
        Me.Star2 = New System.Windows.Forms.Button()
        Me.Star1 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboCafe
        '
        Me.cboCafe.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.cboCafe.FormattingEnabled = True
        Me.cboCafe.Items.AddRange(New Object() {"Café Mesra", "V2 Gee & S Café", "V3 Island One Café", "V4 Razak zaitom Café", "V5 Afifah Beta Café", "V6 Harraz Café", "V5 Dapur Ibrahim Café", "V5 Manje Burger", "Sayang Café"})
        Me.cboCafe.Location = New System.Drawing.Point(29, 15)
        Me.cboCafe.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboCafe.Name = "cboCafe"
        Me.cboCafe.Size = New System.Drawing.Size(170, 23)
        Me.cboCafe.TabIndex = 0
        '
        'txtComment
        '
        Me.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComment.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComment.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtComment.Location = New System.Drawing.Point(29, 97)
        Me.txtComment.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(500, 94)
        Me.txtComment.TabIndex = 1
        Me.txtComment.Text = "Comment"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(536, 136)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(59, 23)
        Me.btnSend.TabIndex = 2
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'Star5
        '
        Me.Star5.AutoSize = True
        Me.Star5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Star5.FlatAppearance.BorderSize = 0
        Me.Star5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Star5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Star5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Star5.Font = New System.Drawing.Font("Comic Sans MS", 30.0!)
        Me.Star5.Location = New System.Drawing.Point(221, 34)
        Me.Star5.Name = "Star5"
        Me.Star5.Size = New System.Drawing.Size(69, 68)
        Me.Star5.TabIndex = 12
        Me.Star5.Text = "★"
        Me.Star5.UseVisualStyleBackColor = False
        '
        'Star4
        '
        Me.Star4.AutoSize = True
        Me.Star4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Star4.FlatAppearance.BorderSize = 0
        Me.Star4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Star4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Star4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Star4.Font = New System.Drawing.Font("Comic Sans MS", 30.0!)
        Me.Star4.Location = New System.Drawing.Point(170, 34)
        Me.Star4.Name = "Star4"
        Me.Star4.Size = New System.Drawing.Size(69, 68)
        Me.Star4.TabIndex = 11
        Me.Star4.Text = "★"
        Me.Star4.UseVisualStyleBackColor = False
        '
        'Star3
        '
        Me.Star3.AutoSize = True
        Me.Star3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Star3.FlatAppearance.BorderSize = 0
        Me.Star3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Star3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Star3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Star3.Font = New System.Drawing.Font("Comic Sans MS", 30.0!)
        Me.Star3.Location = New System.Drawing.Point(120, 34)
        Me.Star3.Name = "Star3"
        Me.Star3.Size = New System.Drawing.Size(69, 68)
        Me.Star3.TabIndex = 10
        Me.Star3.Text = "★"
        Me.Star3.UseVisualStyleBackColor = False
        '
        'Star2
        '
        Me.Star2.AutoSize = True
        Me.Star2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Star2.FlatAppearance.BorderSize = 0
        Me.Star2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Star2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Star2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Star2.Font = New System.Drawing.Font("Comic Sans MS", 30.0!)
        Me.Star2.Location = New System.Drawing.Point(70, 34)
        Me.Star2.Name = "Star2"
        Me.Star2.Size = New System.Drawing.Size(69, 68)
        Me.Star2.TabIndex = 9
        Me.Star2.Text = "★"
        Me.Star2.UseVisualStyleBackColor = False
        '
        'Star1
        '
        Me.Star1.AutoSize = True
        Me.Star1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Star1.FlatAppearance.BorderSize = 0
        Me.Star1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Star1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Star1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Star1.Font = New System.Drawing.Font("Comic Sans MS", 30.0!)
        Me.Star1.Location = New System.Drawing.Point(21, 34)
        Me.Star1.Name = "Star1"
        Me.Star1.Size = New System.Drawing.Size(69, 68)
        Me.Star1.TabIndex = 8
        Me.Star1.Text = "★"
        Me.Star1.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(536, 168)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(59, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'FbCafe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.cboCafe)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.Star5)
        Me.Controls.Add(Me.Star4)
        Me.Controls.Add(Me.Star3)
        Me.Controls.Add(Me.Star2)
        Me.Controls.Add(Me.Star1)
        Me.Controls.Add(Me.btnSend)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FbCafe"
        Me.Size = New System.Drawing.Size(622, 324)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboCafe As ComboBox
    Friend WithEvents txtComment As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents Star5 As Button
    Friend WithEvents Star4 As Button
    Friend WithEvents Star3 As Button
    Friend WithEvents Star2 As Button
    Friend WithEvents Star1 As Button
    Friend WithEvents btnClear As Button
End Class
