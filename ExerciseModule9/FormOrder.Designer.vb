<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormOrder
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblOrderNumber = New System.Windows.Forms.Label()
        Me.txtOrderNumber = New System.Windows.Forms.TextBox()
        Me.lblOrderDate = New System.Windows.Forms.Label()
        Me.dtpOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.cmbUser = New System.Windows.Forms.ComboBox()
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.cmbProduct = New System.Windows.Forms.ComboBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblUnitPrice = New System.Windows.Forms.Label()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.lblGrandTotalCaption = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpDetails.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(0, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(620, 35)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Order Transaction Form"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOrderNumber
        '
        Me.lblOrderNumber.AutoSize = True
        Me.lblOrderNumber.Location = New System.Drawing.Point(25, 73)
        Me.lblOrderNumber.Name = "lblOrderNumber"
        Me.lblOrderNumber.Size = New System.Drawing.Size(76, 13)
        Me.lblOrderNumber.TabIndex = 1
        Me.lblOrderNumber.Text = "Order Number"
        '
        'txtOrderNumber
        '
        Me.txtOrderNumber.BackColor = System.Drawing.SystemColors.Control
        Me.txtOrderNumber.Location = New System.Drawing.Point(125, 70)
        Me.txtOrderNumber.Name = "txtOrderNumber"
        Me.txtOrderNumber.ReadOnly = True
        Me.txtOrderNumber.Size = New System.Drawing.Size(170, 20)
        Me.txtOrderNumber.TabIndex = 2
        Me.txtOrderNumber.TabStop = False
        '
        'lblOrderDate
        '
        Me.lblOrderDate.AutoSize = True
        Me.lblOrderDate.Location = New System.Drawing.Point(330, 73)
        Me.lblOrderDate.Name = "lblOrderDate"
        Me.lblOrderDate.Size = New System.Drawing.Size(61, 13)
        Me.lblOrderDate.TabIndex = 3
        Me.lblOrderDate.Text = "Order Date"
        '
        'dtpOrderDate
        '
        Me.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOrderDate.Location = New System.Drawing.Point(410, 69)
        Me.dtpOrderDate.Name = "dtpOrderDate"
        Me.dtpOrderDate.Size = New System.Drawing.Size(175, 20)
        Me.dtpOrderDate.TabIndex = 0
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(25, 108)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(29, 13)
        Me.lblUser.TabIndex = 4
        Me.lblUser.Text = "User"
        '
        'cmbUser
        '
        Me.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUser.FormattingEnabled = True
        Me.cmbUser.Location = New System.Drawing.Point(125, 105)
        Me.cmbUser.Name = "cmbUser"
        Me.cmbUser.Size = New System.Drawing.Size(170, 21)
        Me.cmbUser.TabIndex = 1
        '
        'grpDetails
        '
        Me.grpDetails.Controls.Add(Me.lblProduct)
        Me.grpDetails.Controls.Add(Me.cmbProduct)
        Me.grpDetails.Controls.Add(Me.lblQuantity)
        Me.grpDetails.Controls.Add(Me.txtQuantity)
        Me.grpDetails.Controls.Add(Me.lblUnitPrice)
        Me.grpDetails.Controls.Add(Me.txtUnitPrice)
        Me.grpDetails.Controls.Add(Me.lblSubtotal)
        Me.grpDetails.Controls.Add(Me.txtSubtotal)
        Me.grpDetails.Location = New System.Drawing.Point(25, 150)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(570, 130)
        Me.grpDetails.TabIndex = 2
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Order Details"
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.Location = New System.Drawing.Point(15, 35)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(44, 13)
        Me.lblProduct.TabIndex = 0
        Me.lblProduct.Text = "Product"
        '
        'cmbProduct
        '
        Me.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProduct.FormattingEnabled = True
        Me.cmbProduct.Location = New System.Drawing.Point(100, 32)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(170, 21)
        Me.cmbProduct.TabIndex = 0
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(305, 35)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.TabIndex = 1
        Me.lblQuantity.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(390, 32)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(150, 20)
        Me.txtQuantity.TabIndex = 1
        '
        'lblUnitPrice
        '
        Me.lblUnitPrice.AutoSize = True
        Me.lblUnitPrice.Location = New System.Drawing.Point(15, 80)
        Me.lblUnitPrice.Name = "lblUnitPrice"
        Me.lblUnitPrice.Size = New System.Drawing.Size(55, 13)
        Me.lblUnitPrice.TabIndex = 2
        Me.lblUnitPrice.Text = "Unit Price"
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.BackColor = System.Drawing.SystemColors.Control
        Me.txtUnitPrice.Location = New System.Drawing.Point(100, 77)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.ReadOnly = True
        Me.txtUnitPrice.Size = New System.Drawing.Size(170, 20)
        Me.txtUnitPrice.TabIndex = 3
        Me.txtUnitPrice.TabStop = False
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(305, 80)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(46, 13)
        Me.lblSubtotal.TabIndex = 4
        Me.lblSubtotal.Text = "Subtotal"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.BackColor = System.Drawing.SystemColors.Control
        Me.txtSubtotal.Location = New System.Drawing.Point(390, 77)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(150, 20)
        Me.txtSubtotal.TabIndex = 5
        Me.txtSubtotal.TabStop = False
        '
        'lblGrandTotalCaption
        '
        Me.lblGrandTotalCaption.AutoSize = True
        Me.lblGrandTotalCaption.Location = New System.Drawing.Point(330, 305)
        Me.lblGrandTotalCaption.Name = "lblGrandTotalCaption"
        Me.lblGrandTotalCaption.Size = New System.Drawing.Size(63, 13)
        Me.lblGrandTotalCaption.TabIndex = 5
        Me.lblGrandTotalCaption.Text = "Grand Total"
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGrandTotal.Location = New System.Drawing.Point(410, 301)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(185, 22)
        Me.lblGrandTotal.TabIndex = 6
        Me.lblGrandTotal.Text = "Rp 0,00"
        Me.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(410, 345)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 32)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(510, 345)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 32)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FormOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 400)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblOrderNumber)
        Me.Controls.Add(Me.txtOrderNumber)
        Me.Controls.Add(Me.lblOrderDate)
        Me.Controls.Add(Me.dtpOrderDate)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.cmbUser)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.lblGrandTotalCaption)
        Me.Controls.Add(Me.lblGrandTotal)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.MaximizeBox = False
        Me.Name = "FormOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Transaction Form"
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblOrderNumber As System.Windows.Forms.Label
    Friend WithEvents txtOrderNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblOrderDate As System.Windows.Forms.Label
    Friend WithEvents dtpOrderDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents cmbUser As System.Windows.Forms.ComboBox
    Friend WithEvents grpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblProduct As System.Windows.Forms.Label
    Friend WithEvents cmbProduct As System.Windows.Forms.ComboBox
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents lblUnitPrice As System.Windows.Forms.Label
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents lblGrandTotalCaption As System.Windows.Forms.Label
    Friend WithEvents lblGrandTotal As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class