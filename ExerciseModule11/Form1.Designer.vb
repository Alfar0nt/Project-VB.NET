<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        grpOrderHeader = New GroupBox()
        cboUser = New ComboBox()
        lblUserText = New Label()
        dtpOrderDate = New DateTimePicker()
        lblOrderDateText = New Label()
        txtOrderNo = New TextBox()
        lblOrderNumberText = New Label()
        grpOrderDetails = New GroupBox()
        btnAddItem = New Button()
        txtSubtotal = New TextBox()
        lblSubtotalText = New Label()
        nudQty = New NumericUpDown()
        lblQuantityText = New Label()
        txtUnitPrice = New TextBox()
        lblUnitPriceText = New Label()
        cboProduct = New ComboBox()
        lblProductText = New Label()
        dgvDetail = New DataGridView()
        btnNewOrder = New Button()
        btnSaveOrder = New Button()
        btnClearItem = New Button()
        lblGrandTotalText = New Label()
        lblGrandTotal = New Label()
        grpOrderHeader.SuspendLayout()
        grpOrderDetails.SuspendLayout()
        CType(nudQty, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvDetail, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grpOrderHeader
        ' 
        grpOrderHeader.Controls.Add(cboUser)
        grpOrderHeader.Controls.Add(lblUserText)
        grpOrderHeader.Controls.Add(dtpOrderDate)
        grpOrderHeader.Controls.Add(lblOrderDateText)
        grpOrderHeader.Controls.Add(txtOrderNo)
        grpOrderHeader.Controls.Add(lblOrderNumberText)
        grpOrderHeader.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        grpOrderHeader.Location = New Point(12, 12)
        grpOrderHeader.Name = "grpOrderHeader"
        grpOrderHeader.Size = New Size(340, 150)
        grpOrderHeader.TabIndex = 0
        grpOrderHeader.TabStop = False
        grpOrderHeader.Text = "Order Header"
        ' 
        ' cboUser
        ' 
        cboUser.DropDownStyle = ComboBoxStyle.DropDownList
        cboUser.FormattingEnabled = True
        cboUser.Location = New Point(110, 102)
        cboUser.Name = "cboUser"
        cboUser.Size = New Size(215, 28)
        cboUser.TabIndex = 5
        ' 
        ' lblUserText
        ' 
        lblUserText.AutoSize = True
        lblUserText.Location = New Point(12, 105)
        lblUserText.Name = "lblUserText"
        lblUserText.Size = New Size(38, 20)
        lblUserText.TabIndex = 4
        lblUserText.Text = "User"
        ' 
        ' dtpOrderDate
        ' 
        dtpOrderDate.Format = DateTimePickerFormat.Short
        dtpOrderDate.Location = New Point(110, 65)
        dtpOrderDate.Name = "dtpOrderDate"
        dtpOrderDate.Size = New Size(215, 27)
        dtpOrderDate.TabIndex = 3
        ' 
        ' lblOrderDateText
        ' 
        lblOrderDateText.AutoSize = True
        lblOrderDateText.Location = New Point(12, 68)
        lblOrderDateText.Name = "lblOrderDateText"
        lblOrderDateText.Size = New Size(82, 20)
        lblOrderDateText.TabIndex = 2
        lblOrderDateText.Text = "Order Date"
        ' 
        ' txtOrderNo
        ' 
        txtOrderNo.Location = New Point(110, 28)
        txtOrderNo.Name = "txtOrderNo"
        txtOrderNo.ReadOnly = True
        txtOrderNo.Size = New Size(215, 27)
        txtOrderNo.TabIndex = 1
        ' 
        ' lblOrderNumberText
        ' 
        lblOrderNumberText.AutoSize = True
        lblOrderNumberText.Location = New Point(12, 31)
        lblOrderNumberText.Name = "lblOrderNumberText"
        lblOrderNumberText.Size = New Size(95, 20)
        lblOrderNumberText.TabIndex = 0
        lblOrderNumberText.Text = "Order Number"
        ' 
        ' grpOrderDetails
        ' 
        grpOrderDetails.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        grpOrderDetails.Controls.Add(btnAddItem)
        grpOrderDetails.Controls.Add(txtSubtotal)
        grpOrderDetails.Controls.Add(lblSubtotalText)
        grpOrderDetails.Controls.Add(nudQty)
        grpOrderDetails.Controls.Add(lblQuantityText)
        grpOrderDetails.Controls.Add(txtUnitPrice)
        grpOrderDetails.Controls.Add(lblUnitPriceText)
        grpOrderDetails.Controls.Add(cboProduct)
        grpOrderDetails.Controls.Add(lblProductText)
        grpOrderDetails.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        grpOrderDetails.Location = New Point(360, 12)
        grpOrderDetails.Name = "grpOrderDetails"
        grpOrderDetails.Size = New Size(422, 150)
        grpOrderDetails.TabIndex = 1
        grpOrderDetails.TabStop = False
        grpOrderDetails.Text = "Order Details"
        ' 
        ' btnAddItem
        ' 
        btnAddItem.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddItem.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddItem.ForeColor = Color.DarkGreen
        btnAddItem.Location = New Point(310, 24)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New Size(100, 32)
        btnAddItem.TabIndex = 8
        btnAddItem.Text = "+ Add Item"
        btnAddItem.UseVisualStyleBackColor = True
        ' 
        ' txtSubtotal
        ' 
        txtSubtotal.Location = New Point(85, 114)
        txtSubtotal.Name = "txtSubtotal"
        txtSubtotal.ReadOnly = True
        txtSubtotal.Size = New Size(205, 27)
        txtSubtotal.TabIndex = 7
        ' 
        ' lblSubtotalText
        ' 
        lblSubtotalText.AutoSize = True
        lblSubtotalText.Location = New Point(12, 117)
        lblSubtotalText.Name = "lblSubtotalText"
        lblSubtotalText.Size = New Size(65, 20)
        lblSubtotalText.TabIndex = 6
        lblSubtotalText.Text = "Subtotal"
        ' 
        ' nudQty
        ' 
        nudQty.Location = New Point(85, 84)
        nudQty.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        nudQty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudQty.Name = "nudQty"
        nudQty.Size = New Size(205, 27)
        nudQty.TabIndex = 5
        nudQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' lblQuantityText
        ' 
        lblQuantityText.AutoSize = True
        lblQuantityText.Location = New Point(12, 86)
        lblQuantityText.Name = "lblQuantityText"
        lblQuantityText.Size = New Size(65, 20)
        lblQuantityText.TabIndex = 4
        lblQuantityText.Text = "Quantity"
        ' 
        ' txtUnitPrice
        ' 
        txtUnitPrice.Location = New Point(85, 54)
        txtUnitPrice.Name = "txtUnitPrice"
        txtUnitPrice.ReadOnly = True
        txtUnitPrice.Size = New Size(205, 27)
        txtUnitPrice.TabIndex = 3
        ' 
        ' lblUnitPriceText
        ' 
        lblUnitPriceText.AutoSize = True
        lblUnitPriceText.Location = New Point(12, 57)
        lblUnitPriceText.Name = "lblUnitPriceText"
        lblUnitPriceText.Size = New Size(72, 20)
        lblUnitPriceText.TabIndex = 2
        lblUnitPriceText.Text = "Unit Price"
        ' 
        ' cboProduct
        ' 
        cboProduct.DropDownStyle = ComboBoxStyle.DropDownList
        cboProduct.FormattingEnabled = True
        cboProduct.Location = New Point(85, 24)
        cboProduct.Name = "cboProduct"
        cboProduct.Size = New Size(205, 28)
        cboProduct.TabIndex = 1
        ' 
        ' lblProductText
        ' 
        lblProductText.AutoSize = True
        lblProductText.Location = New Point(12, 27)
        lblProductText.Name = "lblProductText"
        lblProductText.Size = New Size(60, 20)
        lblProductText.TabIndex = 0
        lblProductText.Text = "Product"
        ' 
        ' dgvDetail
        ' 
        dgvDetail.AllowUserToAddRows = False
        dgvDetail.AllowUserToDeleteRows = False
        dgvDetail.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDetail.BackgroundColor = Color.White
        dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDetail.Location = New Point(12, 172)
        dgvDetail.Name = "dgvDetail"
        dgvDetail.ReadOnly = True
        dgvDetail.RowHeadersVisible = False
        dgvDetail.RowHeadersWidth = 51
        dgvDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDetail.Size = New Size(770, 270)
        dgvDetail.TabIndex = 2
        ' 
        ' btnNewOrder
        ' 
        btnNewOrder.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnNewOrder.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnNewOrder.ForeColor = Color.DarkGreen
        btnNewOrder.Location = New Point(12, 455)
        btnNewOrder.Name = "btnNewOrder"
        btnNewOrder.Size = New Size(110, 35)
        btnNewOrder.TabIndex = 3
        btnNewOrder.Text = "+ New Order"
        btnNewOrder.UseVisualStyleBackColor = True
        ' 
        ' btnSaveOrder
        ' 
        btnSaveOrder.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnSaveOrder.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnSaveOrder.ForeColor = Color.DarkBlue
        btnSaveOrder.Location = New Point(128, 455)
        btnSaveOrder.Name = "btnSaveOrder"
        btnSaveOrder.Size = New Size(110, 35)
        btnSaveOrder.TabIndex = 4
        btnSaveOrder.Text = "💾 Save Order"
        btnSaveOrder.UseVisualStyleBackColor = True
        ' 
        ' btnClearItem
        ' 
        btnClearItem.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnClearItem.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnClearItem.ForeColor = Color.DarkRed
        btnClearItem.Location = New Point(244, 455)
        btnClearItem.Name = "btnClearItem"
        btnClearItem.Size = New Size(110, 35)
        btnClearItem.TabIndex = 5
        btnClearItem.Text = "Clear Item"
        btnClearItem.UseVisualStyleBackColor = True
        ' 
        ' lblGrandTotalText
        ' 
        lblGrandTotalText.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblGrandTotalText.AutoSize = True
        lblGrandTotalText.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblGrandTotalText.Location = New Point(530, 461)
        lblGrandTotalText.Name = "lblGrandTotalText"
        lblGrandTotalText.Size = New Size(103, 23)
        lblGrandTotalText.TabIndex = 6
        lblGrandTotalText.Text = "Grand Total"
        ' 
        ' lblGrandTotal
        ' 
        lblGrandTotal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblGrandTotal.AutoSize = True
        lblGrandTotal.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblGrandTotal.Location = New Point(640, 457)
        lblGrandTotal.Name = "lblGrandTotal"
        lblGrandTotal.Size = New Size(81, 28)
        lblGrandTotal.TabIndex = 7
        lblGrandTotal.Text = "Rp 0,00"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(204, 232, 238)
        ClientSize = New Size(794, 502)
        Controls.Add(lblGrandTotal)
        Controls.Add(lblGrandTotalText)
        Controls.Add(btnClearItem)
        Controls.Add(btnSaveOrder)
        Controls.Add(btnNewOrder)
        Controls.Add(dgvDetail)
        Controls.Add(grpOrderDetails)
        Controls.Add(grpOrderHeader)
        MinimumSize = New Size(810, 540)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        grpOrderHeader.ResumeLayout(False)
        grpOrderHeader.PerformLayout()
        grpOrderDetails.ResumeLayout(False)
        grpOrderDetails.PerformLayout()
        CType(nudQty, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvDetail, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grpOrderHeader As GroupBox
    Friend WithEvents lblOrderNumberText As Label
    Friend WithEvents txtOrderNo As TextBox
    Friend WithEvents lblOrderDateText As Label
    Friend WithEvents dtpOrderDate As DateTimePicker
    Friend WithEvents lblUserText As Label
    Friend WithEvents cboUser As ComboBox
    Friend WithEvents grpOrderDetails As GroupBox
    Friend WithEvents lblProductText As Label
    Friend WithEvents cboProduct As ComboBox
    Friend WithEvents lblUnitPriceText As Label
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents lblQuantityText As Label
    Friend WithEvents nudQty As NumericUpDown
    Friend WithEvents lblSubtotalText As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents dgvDetail As DataGridView
    Friend WithEvents btnNewOrder As Button
    Friend WithEvents btnSaveOrder As Button
    Friend WithEvents btnClearItem As Button
    Friend WithEvents lblGrandTotalText As Label
    Friend WithEvents lblGrandTotal As Label

End Class
