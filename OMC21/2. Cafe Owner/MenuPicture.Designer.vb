<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPicture
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
        Me.picFood = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCafe = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblFood = New System.Windows.Forms.Label()
        CType(Me.picFood, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picFood
        '
        Me.picFood.BackColor = System.Drawing.Color.Silver
        Me.picFood.Location = New System.Drawing.Point(0, 0)
        Me.picFood.Name = "picFood"
        Me.picFood.Size = New System.Drawing.Size(109, 93)
        Me.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFood.TabIndex = 0
        Me.picFood.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblCafe)
        Me.Panel1.Controls.Add(Me.lblCost)
        Me.Panel1.Controls.Add(Me.lblFood)
        Me.Panel1.Location = New System.Drawing.Point(106, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(61, 93)
        Me.Panel1.TabIndex = 1
        '
        'lblCafe
        '
        Me.lblCafe.Font = New System.Drawing.Font("Comic Sans MS", 8.0!)
        Me.lblCafe.ForeColor = System.Drawing.Color.Black
        Me.lblCafe.Location = New System.Drawing.Point(-1, 4)
        Me.lblCafe.Name = "lblCafe"
        Me.lblCafe.Size = New System.Drawing.Size(59, 35)
        Me.lblCafe.TabIndex = 2
        Me.lblCafe.Text = "Cafe Name"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.lblCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.lblCost.Location = New System.Drawing.Point(-2, 67)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(42, 23)
        Me.lblCost.TabIndex = 1
        Me.lblCost.Text = "Cost"
        '
        'lblFood
        '
        Me.lblFood.Font = New System.Drawing.Font("Comic Sans MS", 8.0!)
        Me.lblFood.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.lblFood.Location = New System.Drawing.Point(0, 39)
        Me.lblFood.Name = "lblFood"
        Me.lblFood.Size = New System.Drawing.Size(58, 28)
        Me.lblFood.TabIndex = 0
        Me.lblFood.Text = "Food"
        Me.lblFood.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'MenuPicture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picFood)
        Me.Name = "MenuPicture"
        Me.Size = New System.Drawing.Size(167, 93)
        CType(Me.picFood, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picFood As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCafe As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblFood As Label
End Class
