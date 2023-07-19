<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RiderOrder
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
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.btnDecline = New System.Windows.Forms.Button()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblVillage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Location = New System.Drawing.Point(18, 13)
        Me.lblOrderID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(58, 17)
        Me.lblOrderID.TabIndex = 13
        Me.lblOrderID.Text = "OrderID"
        '
        'btnDecline
        '
        Me.btnDecline.BackColor = System.Drawing.Color.Red
        Me.btnDecline.Location = New System.Drawing.Point(353, 97)
        Me.btnDecline.Name = "btnDecline"
        Me.btnDecline.Size = New System.Drawing.Size(59, 51)
        Me.btnDecline.TabIndex = 12
        Me.btnDecline.Text = "Decline"
        Me.btnDecline.UseVisualStyleBackColor = False
        '
        'btnAccept
        '
        Me.btnAccept.BackColor = System.Drawing.Color.Lime
        Me.btnAccept.Location = New System.Drawing.Point(428, 97)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(59, 51)
        Me.btnAccept.TabIndex = 11
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(396, 46)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(52, 17)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "lblTotal"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Location = New System.Drawing.Point(52, 46)
        Me.lblUserID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(51, 17)
        Me.lblUserID.TabIndex = 8
        Me.lblUserID.Text = "UserID"
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetails.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblDetails.Location = New System.Drawing.Point(54, 114)
        Me.lblDetails.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(49, 17)
        Me.lblDetails.TabIndex = 7
        Me.lblDetails.Text = "Details"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Location = New System.Drawing.Point(214, 46)
        Me.lblContact.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(65, 17)
        Me.lblContact.TabIndex = 14
        Me.lblContact.Text = "lblContact"
        '
        'lblVillage
        '
        Me.lblVillage.AutoSize = True
        Me.lblVillage.Location = New System.Drawing.Point(214, 114)
        Me.lblVillage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVillage.Name = "lblVillage"
        Me.lblVillage.Size = New System.Drawing.Size(60, 17)
        Me.lblVillage.TabIndex = 15
        Me.lblVillage.Text = "lblVillage"
        '
        'RiderOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblVillage)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.lblOrderID)
        Me.Controls.Add(Me.btnDecline)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.lblDetails)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RiderOrder"
        Me.Size = New System.Drawing.Size(504, 161)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOrderID As Label
    Friend WithEvents btnDecline As Button
    Friend WithEvents btnAccept As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblUserID As Label
    Friend WithEvents lblDetails As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblVillage As Label
End Class
