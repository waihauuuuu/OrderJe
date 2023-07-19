<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AcceptOrder
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
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnDecline = New System.Windows.Forms.Button()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFoodName
        '
        Me.lblFoodName.AutoSize = True
        Me.lblFoodName.Location = New System.Drawing.Point(54, 44)
        Me.lblFoodName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFoodName.Name = "lblFoodName"
        Me.lblFoodName.Size = New System.Drawing.Size(77, 17)
        Me.lblFoodName.TabIndex = 0
        Me.lblFoodName.Text = "lblFoodName"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Location = New System.Drawing.Point(54, 100)
        Me.lblUserID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(51, 17)
        Me.lblUserID.TabIndex = 1
        Me.lblUserID.Text = "UserID"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(233, 44)
        Me.lblQuantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(73, 17)
        Me.lblQuantity.TabIndex = 2
        Me.lblQuantity.Text = "lblQuantity"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(397, 44)
        Me.lblCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(47, 17)
        Me.lblCost.TabIndex = 3
        Me.lblCost.Text = "lblCost"
        '
        'btnAccept
        '
        Me.btnAccept.BackColor = System.Drawing.Color.Lime
        Me.btnAccept.Location = New System.Drawing.Point(429, 95)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(59, 51)
        Me.btnAccept.TabIndex = 4
        Me.btnAccept.Text = "Done"
        Me.btnAccept.UseVisualStyleBackColor = False
        '
        'btnDecline
        '
        Me.btnDecline.BackColor = System.Drawing.Color.Red
        Me.btnDecline.Location = New System.Drawing.Point(354, 95)
        Me.btnDecline.Name = "btnDecline"
        Me.btnDecline.Size = New System.Drawing.Size(59, 51)
        Me.btnDecline.TabIndex = 5
        Me.btnDecline.Text = "Decline"
        Me.btnDecline.UseVisualStyleBackColor = False
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Location = New System.Drawing.Point(19, 11)
        Me.lblOrderID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(58, 17)
        Me.lblOrderID.TabIndex = 6
        Me.lblOrderID.Text = "OrderID"
        '
        'AcceptOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblOrderID)
        Me.Controls.Add(Me.btnDecline)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.lblFoodName)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AcceptOrder"
        Me.Size = New System.Drawing.Size(504, 161)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFoodName As Label
    Friend WithEvents lblUserID As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnDecline As Button
    Friend WithEvents lblOrderID As Label
End Class
