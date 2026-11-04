<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.grpBarang = New System.Windows.Forms.GroupBox()
        Me.lblKodeBarang = New System.Windows.Forms.Label()
        Me.lblNamaBarang = New System.Windows.Forms.Label()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.lblSatuanBarang = New System.Windows.Forms.Label()
        Me.lblHargaBeli = New System.Windows.Forms.Label()
        Me.lblHargaJual = New System.Windows.Forms.Label()
        Me.lblStok = New System.Windows.Forms.Label()
        Me.txtKodeBarang = New System.Windows.Forms.TextBox()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.txtJenis = New System.Windows.Forms.TextBox()
        Me.cmbSatuan = New System.Windows.Forms.ComboBox()
        Me.numHargaBeli = New System.Windows.Forms.NumericUpDown()
        Me.numHargaJual = New System.Windows.Forms.NumericUpDown()
        Me.numStock = New System.Windows.Forms.NumericUpDown()
        Me.btnSimpanBarang = New System.Windows.Forms.Button()
        Me.btnUbahBarang = New System.Windows.Forms.Button()
        Me.btnHapusBarang = New System.Windows.Forms.Button()
        Me.btnBersihBarang = New System.Windows.Forms.Button()
        Me.dgvBarang = New System.Windows.Forms.DataGridView()
        Me.grpSatuan = New System.Windows.Forms.GroupBox()
        Me.lblNoSatuan = New System.Windows.Forms.Label()
        Me.lblNamaSatuan = New System.Windows.Forms.Label()
        Me.txtNoSatuan = New System.Windows.Forms.TextBox()
        Me.txtSatuan = New System.Windows.Forms.TextBox()
        Me.btnSimpanSatuan = New System.Windows.Forms.Button()
        Me.btnUbahSatuan = New System.Windows.Forms.Button()
        Me.btnHapusSatuan = New System.Windows.Forms.Button()
        Me.btnBersihSatuan = New System.Windows.Forms.Button()
        Me.dgvSatuan = New System.Windows.Forms.DataGridView()
        Me.grpBarang.SuspendLayout()
        CType(Me.numHargaBeli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHargaJual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSatuan.SuspendLayout()
        CType(Me.dgvSatuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBarang
        '
        Me.grpBarang.BackColor = System.Drawing.Color.AliceBlue
        Me.grpBarang.Controls.Add(Me.lblKodeBarang)
        Me.grpBarang.Controls.Add(Me.lblNamaBarang)
        Me.grpBarang.Controls.Add(Me.lblJenis)
        Me.grpBarang.Controls.Add(Me.lblSatuanBarang)
        Me.grpBarang.Controls.Add(Me.lblHargaBeli)
        Me.grpBarang.Controls.Add(Me.lblHargaJual)
        Me.grpBarang.Controls.Add(Me.lblStok)
        Me.grpBarang.Controls.Add(Me.txtKodeBarang)
        Me.grpBarang.Controls.Add(Me.txtNamaBarang)
        Me.grpBarang.Controls.Add(Me.txtJenis)
        Me.grpBarang.Controls.Add(Me.cmbSatuan)
        Me.grpBarang.Controls.Add(Me.numHargaBeli)
        Me.grpBarang.Controls.Add(Me.numHargaJual)
        Me.grpBarang.Controls.Add(Me.numStock)
        Me.grpBarang.Controls.Add(Me.btnSimpanBarang)
        Me.grpBarang.Controls.Add(Me.btnUbahBarang)
        Me.grpBarang.Controls.Add(Me.btnHapusBarang)
        Me.grpBarang.Controls.Add(Me.btnBersihBarang)
        Me.grpBarang.Controls.Add(Me.dgvBarang)
        Me.grpBarang.Location = New System.Drawing.Point(12, 12)
        Me.grpBarang.Name = "grpBarang"
        Me.grpBarang.Size = New System.Drawing.Size(560, 480)
        Me.grpBarang.TabIndex = 0
        Me.grpBarang.TabStop = False
        Me.grpBarang.Text = "Master Barang"
        '
        'lblKodeBarang
        '
        Me.lblKodeBarang.AutoSize = True
        Me.lblKodeBarang.Location = New System.Drawing.Point(15, 30)
        Me.lblKodeBarang.Name = "lblKodeBarang"
        Me.lblKodeBarang.Size = New System.Drawing.Size(75, 15)
        Me.lblKodeBarang.TabIndex = 0
        Me.lblKodeBarang.Text = "Kode Barang"
        '
        'lblNamaBarang
        '
        Me.lblNamaBarang.AutoSize = True
        Me.lblNamaBarang.Location = New System.Drawing.Point(15, 60)
        Me.lblNamaBarang.Name = "lblNamaBarang"
        Me.lblNamaBarang.Size = New System.Drawing.Size(79, 15)
        Me.lblNamaBarang.TabIndex = 1
        Me.lblNamaBarang.Text = "Nama Barang"
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Location = New System.Drawing.Point(15, 90)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(32, 15)
        Me.lblJenis.TabIndex = 2
        Me.lblJenis.Text = "Jenis"
        '
        'lblSatuanBarang
        '
        Me.lblSatuanBarang.AutoSize = True
        Me.lblSatuanBarang.Location = New System.Drawing.Point(15, 120)
        Me.lblSatuanBarang.Name = "lblSatuanBarang"
        Me.lblSatuanBarang.Size = New System.Drawing.Size(43, 15)
        Me.lblSatuanBarang.TabIndex = 3
        Me.lblSatuanBarang.Text = "Satuan"
        '
        'lblHargaBeli
        '
        Me.lblHargaBeli.AutoSize = True
        Me.lblHargaBeli.Location = New System.Drawing.Point(15, 150)
        Me.lblHargaBeli.Name = "lblHargaBeli"
        Me.lblHargaBeli.Size = New System.Drawing.Size(61, 15)
        Me.lblHargaBeli.TabIndex = 4
        Me.lblHargaBeli.Text = "Harga Beli"
        '
        'lblHargaJual
        '
        Me.lblHargaJual.AutoSize = True
        Me.lblHargaJual.Location = New System.Drawing.Point(15, 180)
        Me.lblHargaJual.Name = "lblHargaJual"
        Me.lblHargaJual.Size = New System.Drawing.Size(62, 15)
        Me.lblHargaJual.TabIndex = 5
        Me.lblHargaJual.Text = "Harga Jual"
        '
        'lblStok
        '
        Me.lblStok.AutoSize = True
        Me.lblStok.Location = New System.Drawing.Point(15, 210)
        Me.lblStok.Name = "lblStok"
        Me.lblStok.Size = New System.Drawing.Size(30, 15)
        Me.lblStok.TabIndex = 6
        Me.lblStok.Text = "Stok"
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.Location = New System.Drawing.Point(135, 27)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.ReadOnly = True
        Me.txtKodeBarang.Size = New System.Drawing.Size(215, 23)
        Me.txtKodeBarang.TabIndex = 7
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Location = New System.Drawing.Point(135, 57)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(215, 23)
        Me.txtNamaBarang.TabIndex = 8
        '
        'txtJenis
        '
        Me.txtJenis.Location = New System.Drawing.Point(135, 87)
        Me.txtJenis.Name = "txtJenis"
        Me.txtJenis.Size = New System.Drawing.Size(215, 23)
        Me.txtJenis.TabIndex = 9
        '
        'cmbSatuan
        '
        Me.cmbSatuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSatuan.FormattingEnabled = True
        Me.cmbSatuan.Location = New System.Drawing.Point(135, 117)
        Me.cmbSatuan.Name = "cmbSatuan"
        Me.cmbSatuan.Size = New System.Drawing.Size(215, 23)
        Me.cmbSatuan.TabIndex = 10
        '
        'numHargaBeli
        '
        Me.numHargaBeli.Location = New System.Drawing.Point(135, 147)
        Me.numHargaBeli.Name = "numHargaBeli"
        Me.numHargaBeli.Size = New System.Drawing.Size(215, 23)
        Me.numHargaBeli.TabIndex = 11
        '
        'numHargaJual
        '
        Me.numHargaJual.Location = New System.Drawing.Point(135, 177)
        Me.numHargaJual.Name = "numHargaJual"
        Me.numHargaJual.Size = New System.Drawing.Size(215, 23)
        Me.numHargaJual.TabIndex = 12
        '
        'numStock
        '
        Me.numStock.Location = New System.Drawing.Point(135, 207)
        Me.numStock.Name = "numStock"
        Me.numStock.Size = New System.Drawing.Size(100, 23)
        Me.numStock.TabIndex = 13
        '
        'btnSimpanBarang
        '
        Me.btnSimpanBarang.Location = New System.Drawing.Point(385, 26)
        Me.btnSimpanBarang.Name = "btnSimpanBarang"
        Me.btnSimpanBarang.Size = New System.Drawing.Size(120, 32)
        Me.btnSimpanBarang.TabIndex = 14
        Me.btnSimpanBarang.Text = "➕ Insert"
        Me.btnSimpanBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSimpanBarang.UseVisualStyleBackColor = True
        '
        'btnUbahBarang
        '
        Me.btnUbahBarang.Location = New System.Drawing.Point(385, 64)
        Me.btnUbahBarang.Name = "btnUbahBarang"
        Me.btnUbahBarang.Size = New System.Drawing.Size(120, 32)
        Me.btnUbahBarang.TabIndex = 15
        Me.btnUbahBarang.Text = "✏️ Update"
        Me.btnUbahBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnUbahBarang.UseVisualStyleBackColor = True
        '
        'btnHapusBarang
        '
        Me.btnHapusBarang.Location = New System.Drawing.Point(385, 102)
        Me.btnHapusBarang.Name = "btnHapusBarang"
        Me.btnHapusBarang.Size = New System.Drawing.Size(120, 32)
        Me.btnHapusBarang.TabIndex = 16
        Me.btnHapusBarang.Text = "🗑️ Delete"
        Me.btnHapusBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnHapusBarang.UseVisualStyleBackColor = True
        '
        'btnBersihBarang
        '
        Me.btnBersihBarang.Location = New System.Drawing.Point(385, 140)
        Me.btnBersihBarang.Name = "btnBersihBarang"
        Me.btnBersihBarang.Size = New System.Drawing.Size(120, 32)
        Me.btnBersihBarang.TabIndex = 17
        Me.btnBersihBarang.Text = "✨ Clear"
        Me.btnBersihBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnBersihBarang.UseVisualStyleBackColor = True
        '
        'dgvBarang
        '
        Me.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBarang.Location = New System.Drawing.Point(15, 245)
        Me.dgvBarang.Name = "dgvBarang"
        Me.dgvBarang.Size = New System.Drawing.Size(530, 220)
        Me.dgvBarang.TabIndex = 18
        '
        'grpSatuan
        '
        Me.grpSatuan.BackColor = System.Drawing.Color.AliceBlue
        Me.grpSatuan.Controls.Add(Me.lblNoSatuan)
        Me.grpSatuan.Controls.Add(Me.lblNamaSatuan)
        Me.grpSatuan.Controls.Add(Me.txtNoSatuan)
        Me.grpSatuan.Controls.Add(Me.txtSatuan)
        Me.grpSatuan.Controls.Add(Me.btnSimpanSatuan)
        Me.grpSatuan.Controls.Add(Me.btnUbahSatuan)
        Me.grpSatuan.Controls.Add(Me.btnHapusSatuan)
        Me.grpSatuan.Controls.Add(Me.btnBersihSatuan)
        Me.grpSatuan.Controls.Add(Me.dgvSatuan)
        Me.grpSatuan.Location = New System.Drawing.Point(585, 12)
        Me.grpSatuan.Name = "grpSatuan"
        Me.grpSatuan.Size = New System.Drawing.Size(375, 480)
        Me.grpSatuan.TabIndex = 1
        Me.grpSatuan.TabStop = False
        Me.grpSatuan.Text = "Master Satuan"
        '
        'lblNoSatuan
        '
        Me.lblNoSatuan.AutoSize = True
        Me.lblNoSatuan.Location = New System.Drawing.Point(15, 30)
        Me.lblNoSatuan.Name = "lblNoSatuan"
        Me.lblNoSatuan.Size = New System.Drawing.Size(23, 15)
        Me.lblNoSatuan.TabIndex = 0
        Me.lblNoSatuan.Text = "No"
        '
        'lblNamaSatuan
        '
        Me.lblNamaSatuan.AutoSize = True
        Me.lblNamaSatuan.Location = New System.Drawing.Point(15, 65)
        Me.lblNamaSatuan.Name = "lblNamaSatuan"
        Me.lblNamaSatuan.Size = New System.Drawing.Size(43, 15)
        Me.lblNamaSatuan.TabIndex = 1
        Me.lblNamaSatuan.Text = "Satuan"
        '
        'txtNoSatuan
        '
        Me.txtNoSatuan.Location = New System.Drawing.Point(85, 27)
        Me.txtNoSatuan.Name = "txtNoSatuan"
        Me.txtNoSatuan.ReadOnly = True
        Me.txtNoSatuan.Size = New System.Drawing.Size(130, 23)
        Me.txtNoSatuan.TabIndex = 2
        '
        'txtSatuan
        '
        Me.txtSatuan.Location = New System.Drawing.Point(85, 62)
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.Size = New System.Drawing.Size(130, 23)
        Me.txtSatuan.TabIndex = 3
        '
        'btnSimpanSatuan
        '
        Me.btnSimpanSatuan.Location = New System.Drawing.Point(235, 26)
        Me.btnSimpanSatuan.Name = "btnSimpanSatuan"
        Me.btnSimpanSatuan.Size = New System.Drawing.Size(120, 32)
        Me.btnSimpanSatuan.TabIndex = 4
        Me.btnSimpanSatuan.Text = "➕ Insert"
        Me.btnSimpanSatuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSimpanSatuan.UseVisualStyleBackColor = True
        '
        'btnUbahSatuan
        '
        Me.btnUbahSatuan.Location = New System.Drawing.Point(235, 64)
        Me.btnUbahSatuan.Name = "btnUbahSatuan"
        Me.btnUbahSatuan.Size = New System.Drawing.Size(120, 32)
        Me.btnUbahSatuan.TabIndex = 5
        Me.btnUbahSatuan.Text = "✏️ Update"
        Me.btnUbahSatuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnUbahSatuan.UseVisualStyleBackColor = True
        '
        'btnHapusSatuan
        '
        Me.btnHapusSatuan.Location = New System.Drawing.Point(235, 102)
        Me.btnHapusSatuan.Name = "btnHapusSatuan"
        Me.btnHapusSatuan.Size = New System.Drawing.Size(120, 32)
        Me.btnHapusSatuan.TabIndex = 6
        Me.btnHapusSatuan.Text = "🗑️ Delete"
        Me.btnHapusSatuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnHapusSatuan.UseVisualStyleBackColor = True
        '
        'btnBersihSatuan
        '
        Me.btnBersihSatuan.Location = New System.Drawing.Point(235, 140)
        Me.btnBersihSatuan.Name = "btnBersihSatuan"
        Me.btnBersihSatuan.Size = New System.Drawing.Size(120, 32)
        Me.btnBersihSatuan.TabIndex = 7
        Me.btnBersihSatuan.Text = "✨ Clear"
        Me.btnBersihSatuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnBersihSatuan.UseVisualStyleBackColor = True
        '
        'dgvSatuan
        '
        Me.dgvSatuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSatuan.Location = New System.Drawing.Point(15, 245)
        Me.dgvSatuan.Name = "dgvSatuan"
        Me.dgvSatuan.Size = New System.Drawing.Size(345, 220)
        Me.dgvSatuan.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(975, 505)
        Me.Controls.Add(Me.grpSatuan)
        Me.Controls.Add(Me.grpBarang)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.grpBarang.ResumeLayout(False)
        Me.grpBarang.PerformLayout()
        CType(Me.numHargaBeli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHargaJual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSatuan.ResumeLayout(False)
        Me.grpSatuan.PerformLayout()
        CType(Me.dgvSatuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpBarang As GroupBox
    Friend WithEvents lblKodeBarang As Label
    Friend WithEvents lblNamaBarang As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents lblSatuanBarang As Label
    Friend WithEvents lblHargaBeli As Label
    Friend WithEvents lblHargaJual As Label
    Friend WithEvents lblStok As Label
    Friend WithEvents txtKodeBarang As TextBox
    Friend WithEvents txtNamaBarang As TextBox
    Friend WithEvents txtJenis As TextBox
    Friend WithEvents cmbSatuan As ComboBox
    Friend WithEvents numHargaBeli As NumericUpDown
    Friend WithEvents numHargaJual As NumericUpDown
    Friend WithEvents numStock As NumericUpDown
    Friend WithEvents btnSimpanBarang As Button
    Friend WithEvents btnUbahBarang As Button
    Friend WithEvents btnHapusBarang As Button
    Friend WithEvents btnBersihBarang As Button
    Friend WithEvents dgvBarang As DataGridView
    Friend WithEvents grpSatuan As GroupBox
    Friend WithEvents lblNoSatuan As Label
    Friend WithEvents lblNamaSatuan As Label
    Friend WithEvents txtNoSatuan As TextBox
    Friend WithEvents txtSatuan As TextBox
    Friend WithEvents btnSimpanSatuan As Button
    Friend WithEvents btnUbahSatuan As Button
    Friend WithEvents btnHapusSatuan As Button
    Friend WithEvents btnBersihSatuan As Button
    Friend WithEvents dgvSatuan As DataGridView

End Class