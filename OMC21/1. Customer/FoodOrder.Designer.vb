<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FoodOrder
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cboCafe = New System.Windows.Forms.ComboBox()
        Me.btnSideDish = New System.Windows.Forms.Button()
        Me.btnBeverages = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.pnlCart = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFood = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TLPMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCart = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pnlCart.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboCafe
        '
        Me.cboCafe.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboCafe.FormattingEnabled = True
        Me.cboCafe.Items.AddRange(New Object() {"All Café", "Café Mesra", "V2 Gee & S Café", "V3 Island One Café", "V4 Razak zaitom Café", "V5 Afifah Beta Café", "V6 Harraz Café", "V5 Dapur Ibrahim Café", "V5 Manje Burger", "Sayang Café"})
        Me.cboCafe.Location = New System.Drawing.Point(23, 127)
        Me.cboCafe.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboCafe.Name = "cboCafe"
        Me.cboCafe.Size = New System.Drawing.Size(183, 25)
        Me.cboCafe.TabIndex = 46
        Me.cboCafe.Text = "All Cafe"
        '
        'btnSideDish
        '
        Me.btnSideDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSideDish.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSideDish.ForeColor = System.Drawing.Color.White
        Me.btnSideDish.Location = New System.Drawing.Point(272, 174)
        Me.btnSideDish.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSideDish.Name = "btnSideDish"
        Me.btnSideDish.Size = New System.Drawing.Size(88, 36)
        Me.btnSideDish.TabIndex = 45
        Me.btnSideDish.Text = "Side Dish"
        Me.btnSideDish.UseVisualStyleBackColor = True
        '
        'btnBeverages
        '
        Me.btnBeverages.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBeverages.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBeverages.ForeColor = System.Drawing.Color.White
        Me.btnBeverages.Location = New System.Drawing.Point(155, 174)
        Me.btnBeverages.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnBeverages.Name = "btnBeverages"
        Me.btnBeverages.Size = New System.Drawing.Size(88, 36)
        Me.btnBeverages.TabIndex = 44
        Me.btnBeverages.Text = "Beverages"
        Me.btnBeverages.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtSearch.Location = New System.Drawing.Point(232, 128)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(283, 24)
        Me.txtSearch.TabIndex = 41
        Me.txtSearch.Text = "Search"
        '
        'pnlCart
        '
        Me.pnlCart.BackColor = System.Drawing.SystemColors.MenuBar
        Me.pnlCart.Controls.Add(Me.Button8)
        Me.pnlCart.Controls.Add(Me.Button7)
        Me.pnlCart.Controls.Add(Me.Button6)
        Me.pnlCart.Controls.Add(Me.RadioButton2)
        Me.pnlCart.Controls.Add(Me.RadioButton1)
        Me.pnlCart.Controls.Add(Me.Label1)
        Me.pnlCart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlCart.Location = New System.Drawing.Point(778, 164)
        Me.pnlCart.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlCart.Name = "pnlCart"
        Me.pnlCart.Size = New System.Drawing.Size(212, 354)
        Me.pnlCart.TabIndex = 47
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(63, 305)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(88, 31)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "Check Out"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(113, 247)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(88, 31)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "Delivery"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(19, 247)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(88, 31)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Pick Up"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(19, 112)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(19, 60)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "My Cart"
        '
        'btnFood
        '
        Me.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFood.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFood.ForeColor = System.Drawing.Color.White
        Me.btnFood.Location = New System.Drawing.Point(35, 174)
        Me.btnFood.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnFood.Name = "btnFood"
        Me.btnFood.Size = New System.Drawing.Size(88, 36)
        Me.btnFood.TabIndex = 43
        Me.btnFood.Text = "Food"
        Me.btnFood.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(208, 42)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 23)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "Cafe"
        '
        'TLPMenu
        '
        Me.TLPMenu.AutoScroll = True
        Me.TLPMenu.ColumnCount = 3
        Me.TLPMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLPMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLPMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TLPMenu.Location = New System.Drawing.Point(14, 224)
        Me.TLPMenu.Name = "TLPMenu"
        Me.TLPMenu.RowCount = 2
        Me.TLPMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPMenu.Size = New System.Drawing.Size(593, 246)
        Me.TLPMenu.TabIndex = 71
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OMC21.My.Resources.Resources.OrderJeLogo
        Me.PictureBox1.Location = New System.Drawing.Point(45, -5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'btnCart
        '
        Me.btnCart.BackColor = System.Drawing.Color.White
        Me.btnCart.Image = Global.OMC21.My.Resources.Resources.icons8_cart_35
        Me.btnCart.Location = New System.Drawing.Point(551, 33)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(45, 45)
        Me.btnCart.TabIndex = 73
        Me.btnCart.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Image = Global.OMC21.My.Resources.Resources.icons8_notification_35
        Me.Button5.Location = New System.Drawing.Point(491, 33)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(45, 45)
        Me.Button5.TabIndex = 72
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(532, 129)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 23)
        Me.Button2.TabIndex = 74
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FoodOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCart)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TLPMenu)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.pnlCart)
        Me.Controls.Add(Me.cboCafe)
        Me.Controls.Add(Me.btnSideDish)
        Me.Controls.Add(Me.btnBeverages)
        Me.Controls.Add(Me.btnFood)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FoodOrder"
        Me.Size = New System.Drawing.Size(622, 470)
        Me.pnlCart.ResumeLayout(False)
        Me.pnlCart.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboCafe As ComboBox
    Friend WithEvents btnSideDish As Button
    Friend WithEvents btnBeverages As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlCart As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFood As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents TLPMenu As TableLayoutPanel
    Friend WithEvents btnCart As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
End Class
