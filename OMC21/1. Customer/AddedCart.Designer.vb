<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddedCart
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
        Me.lblFoodName = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.picFood = New System.Windows.Forms.PictureBox()
        Me.lblCafeName = New System.Windows.Forms.Label()
        CType(Me.picFood, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFoodName
        '
        Me.lblFoodName.AutoSize = True
        Me.lblFoodName.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.lblFoodName.ForeColor = System.Drawing.Color.Black
        Me.lblFoodName.Location = New System.Drawing.Point(210, 39)
        Me.lblFoodName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFoodName.Name = "lblFoodName"
        Me.lblFoodName.Size = New System.Drawing.Size(105, 23)
        Me.lblFoodName.TabIndex = 1
        Me.lblFoodName.Text = "lblFoodName"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.lblCost.ForeColor = System.Drawing.Color.Black
        Me.lblCost.Location = New System.Drawing.Point(210, 85)
        Me.lblCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(62, 23)
        Me.lblCost.TabIndex = 2
        Me.lblCost.Text = "lblCost"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.lblQuantity.ForeColor = System.Drawing.Color.Black
        Me.lblQuantity.Location = New System.Drawing.Point(483, 24)
        Me.lblQuantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(76, 23)
        Me.lblQuantity.TabIndex = 3
        Me.lblQuantity.Text = "Quantity"
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnDelete
        '
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Image = Global.OMC21.My.Resources.Resources.delete
        Me.btnDelete.Location = New System.Drawing.Point(514, 120)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(45, 45)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'picFood
        '
        Me.picFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFood.Location = New System.Drawing.Point(22, 24)
        Me.picFood.Margin = New System.Windows.Forms.Padding(4)
        Me.picFood.Name = "picFood"
        Me.picFood.Size = New System.Drawing.Size(148, 141)
        Me.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFood.TabIndex = 0
        Me.picFood.TabStop = False
        '
        'lblCafeName
        '
        Me.lblCafeName.AutoSize = True
        Me.lblCafeName.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.lblCafeName.ForeColor = System.Drawing.Color.Black
        Me.lblCafeName.Location = New System.Drawing.Point(212, 129)
        Me.lblCafeName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCafeName.Name = "lblCafeName"
        Me.lblCafeName.Size = New System.Drawing.Size(104, 23)
        Me.lblCafeName.TabIndex = 6
        Me.lblCafeName.Text = "lblCafeName"
        '
        'AddedCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblCafeName)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblFoodName)
        Me.Controls.Add(Me.picFood)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddedCart"
        Me.Size = New System.Drawing.Size(578, 188)
        CType(Me.picFood, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picFood As PictureBox
    Friend WithEvents lblFoodName As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblCafeName As Label
End Class
