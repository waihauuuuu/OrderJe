<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Payment
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
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rdbPickup = New System.Windows.Forms.RadioButton()
        Me.rdbStandard = New System.Windows.Forms.RadioButton()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.pnlOrderSummary = New System.Windows.Forms.Panel()
        Me.lblDatetime = New System.Windows.Forms.Label()
        Me.lstCost = New System.Windows.Forms.ListBox()
        Me.lstQuantity = New System.Windows.Forms.ListBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lstFood = New System.Windows.Forms.ListBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDelivery = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupDelivery = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboBank = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.GroupPoints = New System.Windows.Forms.GroupBox()
        Me.chkPoints = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlOrderSummary.SuspendLayout()
        Me.GroupDelivery.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupPoints.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(533, 651)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(116, 24)
        Me.TextBox5.TabIndex = 68
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(349, 651)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(116, 24)
        Me.TextBox4.TabIndex = 67
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(62, 651)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(205, 24)
        Me.TextBox3.TabIndex = 66
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(309, 513)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(181, 24)
        Me.TextBox2.TabIndex = 65
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(62, 513)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 24)
        Me.TextBox1.TabIndex = 64
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(57, 607)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 20)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Card Number  :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(304, 472)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 40)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "Last Name  :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(344, 607)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 20)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Expiry Date  :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(57, 476)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 20)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "First Name  :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(528, 607)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 20)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "CVV :"
        '
        'rdbPickup
        '
        Me.rdbPickup.AutoSize = True
        Me.rdbPickup.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbPickup.ForeColor = System.Drawing.Color.White
        Me.rdbPickup.Location = New System.Drawing.Point(16, 83)
        Me.rdbPickup.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbPickup.Name = "rdbPickup"
        Me.rdbPickup.Size = New System.Drawing.Size(168, 21)
        Me.rdbPickup.TabIndex = 55
        Me.rdbPickup.TabStop = True
        Me.rdbPickup.Text = "Pick Up                   Free"
        Me.rdbPickup.UseVisualStyleBackColor = True
        '
        'rdbStandard
        '
        Me.rdbStandard.AutoSize = True
        Me.rdbStandard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdbStandard.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbStandard.ForeColor = System.Drawing.Color.White
        Me.rdbStandard.Location = New System.Drawing.Point(16, 34)
        Me.rdbStandard.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbStandard.Name = "rdbStandard"
        Me.rdbStandard.Size = New System.Drawing.Size(167, 21)
        Me.rdbStandard.TabIndex = 54
        Me.rdbStandard.Text = "Standard Delivery    RM2"
        Me.rdbStandard.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(819, 647)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(127, 30)
        Me.Button6.TabIndex = 50
        Me.Button6.Text = "Place Order"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'pnlOrderSummary
        '
        Me.pnlOrderSummary.BackColor = System.Drawing.Color.White
        Me.pnlOrderSummary.Controls.Add(Me.lblDatetime)
        Me.pnlOrderSummary.Controls.Add(Me.lstCost)
        Me.pnlOrderSummary.Controls.Add(Me.lstQuantity)
        Me.pnlOrderSummary.Controls.Add(Me.lblSubtotal)
        Me.pnlOrderSummary.Controls.Add(Me.Label15)
        Me.pnlOrderSummary.Controls.Add(Me.lstFood)
        Me.pnlOrderSummary.Controls.Add(Me.lblTotal)
        Me.pnlOrderSummary.Controls.Add(Me.lblDelivery)
        Me.pnlOrderSummary.Controls.Add(Me.lblPoints)
        Me.pnlOrderSummary.Controls.Add(Me.Label5)
        Me.pnlOrderSummary.Controls.Add(Me.Label4)
        Me.pnlOrderSummary.Controls.Add(Me.Label3)
        Me.pnlOrderSummary.Controls.Add(Me.Label2)
        Me.pnlOrderSummary.Controls.Add(Me.Label1)
        Me.pnlOrderSummary.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlOrderSummary.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlOrderSummary.Location = New System.Drawing.Point(454, 102)
        Me.pnlOrderSummary.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlOrderSummary.Name = "pnlOrderSummary"
        Me.pnlOrderSummary.Size = New System.Drawing.Size(189, 322)
        Me.pnlOrderSummary.TabIndex = 49
        '
        'lblDatetime
        '
        Me.lblDatetime.AutoSize = True
        Me.lblDatetime.Font = New System.Drawing.Font("Comic Sans MS", 8.0!)
        Me.lblDatetime.Location = New System.Drawing.Point(58, 32)
        Me.lblDatetime.Name = "lblDatetime"
        Me.lblDatetime.Size = New System.Drawing.Size(65, 15)
        Me.lblDatetime.TabIndex = 15
        Me.lblDatetime.Text = "lblDatetime"
        Me.lblDatetime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstCost
        '
        Me.lstCost.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstCost.Font = New System.Drawing.Font("Comic Sans MS", 7.0!)
        Me.lstCost.FormattingEnabled = True
        Me.lstCost.Location = New System.Drawing.Point(120, 55)
        Me.lstCost.Name = "lstCost"
        Me.lstCost.Size = New System.Drawing.Size(48, 156)
        Me.lstCost.TabIndex = 14
        '
        'lstQuantity
        '
        Me.lstQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstQuantity.Font = New System.Drawing.Font("Comic Sans MS", 7.0!)
        Me.lstQuantity.FormattingEnabled = True
        Me.lstQuantity.Location = New System.Drawing.Point(84, 55)
        Me.lstQuantity.Name = "lstQuantity"
        Me.lstQuantity.Size = New System.Drawing.Size(32, 156)
        Me.lstQuantity.TabIndex = 13
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(132, 235)
        Me.lblSubtotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(32, 17)
        Me.lblSubtotal.TabIndex = 12
        Me.lblSubtotal.Text = "0.00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 257)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 17)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Points  : "
        '
        'lstFood
        '
        Me.lstFood.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstFood.Font = New System.Drawing.Font("Comic Sans MS", 7.0!)
        Me.lstFood.FormattingEnabled = True
        Me.lstFood.Location = New System.Drawing.Point(6, 55)
        Me.lstFood.Name = "lstFood"
        Me.lstFood.Size = New System.Drawing.Size(74, 156)
        Me.lstFood.TabIndex = 10
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(132, 301)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(32, 17)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.Text = "0.00"
        '
        'lblDelivery
        '
        Me.lblDelivery.AutoSize = True
        Me.lblDelivery.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelivery.Location = New System.Drawing.Point(132, 279)
        Me.lblDelivery.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDelivery.Name = "lblDelivery"
        Me.lblDelivery.Size = New System.Drawing.Size(32, 17)
        Me.lblDelivery.TabIndex = 8
        Me.lblDelivery.Text = "0.00"
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.Location = New System.Drawing.Point(132, 257)
        Me.lblPoints.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(32, 17)
        Me.lblPoints.TabIndex = 7
        Me.lblPoints.Text = "0.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 301)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Total  :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 279)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Delivery / Pickup  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 235)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Subtotal  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 211)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "___________________________"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order Summary"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(208, 42)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 23)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Check Out"
        '
        'GroupDelivery
        '
        Me.GroupDelivery.Controls.Add(Me.Label6)
        Me.GroupDelivery.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupDelivery.Controls.Add(Me.rdbStandard)
        Me.GroupDelivery.Controls.Add(Me.rdbPickup)
        Me.GroupDelivery.ForeColor = System.Drawing.Color.White
        Me.GroupDelivery.Location = New System.Drawing.Point(22, 129)
        Me.GroupDelivery.Name = "GroupDelivery"
        Me.GroupDelivery.Size = New System.Drawing.Size(200, 121)
        Me.GroupDelivery.TabIndex = 72
        Me.GroupDelivery.TabStop = False
        Me.GroupDelivery.Text = "Delivery Service"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(237, 15)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(149, 186)
        Me.FlowLayoutPanel1.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboBank)
        Me.GroupBox3.Controls.Add(Me.btnAdd)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(22, 276)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(410, 109)
        Me.GroupBox3.TabIndex = 73
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment Methods"
        '
        'cboBank
        '
        Me.cboBank.FormattingEnabled = True
        Me.cboBank.Location = New System.Drawing.Point(23, 30)
        Me.cboBank.Name = "cboBank"
        Me.cboBank.Size = New System.Drawing.Size(363, 25)
        Me.cboBank.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(23, 68)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(149, 25)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Bank Card"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnPurchase
        '
        Me.btnPurchase.ForeColor = System.Drawing.Color.Black
        Me.btnPurchase.Location = New System.Drawing.Point(174, 403)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(97, 28)
        Me.btnPurchase.TabIndex = 74
        Me.btnPurchase.Text = "Purchase"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'GroupPoints
        '
        Me.GroupPoints.Controls.Add(Me.chkPoints)
        Me.GroupPoints.Controls.Add(Me.FlowLayoutPanel2)
        Me.GroupPoints.ForeColor = System.Drawing.Color.White
        Me.GroupPoints.Location = New System.Drawing.Point(232, 129)
        Me.GroupPoints.Name = "GroupPoints"
        Me.GroupPoints.Size = New System.Drawing.Size(200, 121)
        Me.GroupPoints.TabIndex = 75
        Me.GroupPoints.TabStop = False
        Me.GroupPoints.Text = "My Points"
        '
        'chkPoints
        '
        Me.chkPoints.AutoSize = True
        Me.chkPoints.Location = New System.Drawing.Point(66, 52)
        Me.chkPoints.Name = "chkPoints"
        Me.chkPoints.Size = New System.Drawing.Size(61, 21)
        Me.chkPoints.TabIndex = 55
        Me.chkPoints.Text = "Points"
        Me.chkPoints.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(237, 15)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(149, 186)
        Me.FlowLayoutPanel2.TabIndex = 10
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Image = Global.OMC21.My.Resources.Resources.Refresh
        Me.btnRefresh.Location = New System.Drawing.Point(542, 20)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(52, 52)
        Me.btnRefresh.TabIndex = 76
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OMC21.My.Resources.Resources.OrderJeLogo
        Me.PictureBox1.Location = New System.Drawing.Point(45, -5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 70
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 7.0!)
        Me.Label6.Location = New System.Drawing.Point(30, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 14)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "(For each Food)"
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.GroupPoints)
        Me.Controls.Add(Me.btnPurchase)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupDelivery)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.pnlOrderSummary)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Payment"
        Me.Size = New System.Drawing.Size(622, 470)
        Me.pnlOrderSummary.ResumeLayout(False)
        Me.pnlOrderSummary.PerformLayout()
        Me.GroupDelivery.ResumeLayout(False)
        Me.GroupDelivery.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupPoints.ResumeLayout(False)
        Me.GroupPoints.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents rdbPickup As RadioButton
    Friend WithEvents rdbStandard As RadioButton
    Friend WithEvents Button6 As Button
    Friend WithEvents pnlOrderSummary As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupDelivery As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnPurchase As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDelivery As Label
    Friend WithEvents lblPoints As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lstFood As ListBox
    Friend WithEvents GroupPoints As GroupBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents cboBank As ComboBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lstCost As ListBox
    Friend WithEvents lstQuantity As ListBox
    Friend WithEvents lblDatetime As Label
    Friend WithEvents chkPoints As CheckBox
    Friend WithEvents Label6 As Label
End Class
