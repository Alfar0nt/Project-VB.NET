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
        Dim col1 As System.Windows.Forms.ColumnHeader
        Dim col2 As System.Windows.Forms.ColumnHeader
        Dim col3 As System.Windows.Forms.ColumnHeader
        Dim col4 As System.Windows.Forms.ColumnHeader
        Dim col5 As System.Windows.Forms.ColumnHeader
        Dim col6 As System.Windows.Forms.ColumnHeader
        Dim col7 As System.Windows.Forms.ColumnHeader

        Me.kdBrg = New System.Windows.Forms.TextBox()
        Me.nmBrg = New System.Windows.Forms.TextBox()
        Me.jns = New System.Windows.Forms.TextBox()
        Me.satuan = New System.Windows.Forms.TextBox()
        Me.HB = New System.Windows.Forms.NumericUpDown()
        Me.HJ = New System.Windows.Forms.NumericUpDown()
        Me.stk = New System.Windows.Forms.NumericUpDown()
        Me.btnBr = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHps = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()

        col1 = New System.Windows.Forms.ColumnHeader()
        col2 = New System.Windows.Forms.ColumnHeader()
        col3 = New System.Windows.Forms.ColumnHeader()
        col4 = New System.Windows.Forms.ColumnHeader()
        col5 = New System.Windows.Forms.ColumnHeader()
        col6 = New System.Windows.Forms.ColumnHeader()
        col7 = New System.Windows.Forms.ColumnHeader()

        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()

        CType(Me.HB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HJ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListView1.SuspendLayout()
        Me.SuspendLayout()
        '
        ' kdBrg
        '
        Me.kdBrg.Location = New System.Drawing.Point(256, 30)
        Me.kdBrg.Name = "kdBrg"
        Me.kdBrg.Size = New System.Drawing.Size(268, 47)
        Me.kdBrg.TabIndex = 0
        ' 
        ' nmBrg
        '
        Me.nmBrg.Location = New System.Drawing.Point(256, 92)
        Me.nmBrg.Name = "nmBrg"
        Me.nmBrg.Size = New System.Drawing.Size(268, 47)
        Me.nmBrg.TabIndex = 1
        ' 
        ' jns
        '
        Me.jns.Location = New System.Drawing.Point(256, 150)
        Me.jns.Name = "jns"
        Me.jns.Size = New System.Drawing.Size(268, 47)
        Me.jns.TabIndex = 2
        ' 
        ' satuan
        '
        Me.satuan.Location = New System.Drawing.Point(256, 212)
        Me.satuan.Name = "satuan"
        Me.satuan.Size = New System.Drawing.Size(268, 47)
        Me.satuan.TabIndex = 3
        ' 
        ' HB
        '
        Me.HB.Location = New System.Drawing.Point(1237, 47)
        Me.HB.Name = "HB"
        Me.HB.Size = New System.Drawing.Size(251, 47)
        Me.HB.TabIndex = 4
        Me.HB.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        ' 
        ' HJ
        '
        Me.HJ.Location = New System.Drawing.Point(1237, 122)
        Me.HJ.Name = "HJ"
        Me.HJ.Size = New System.Drawing.Size(251, 47)
        Me.HJ.TabIndex = 5
        Me.HJ.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        ' 
        ' stk
        '
        Me.stk.Location = New System.Drawing.Point(1237, 200)
        Me.stk.Name = "stk"
        Me.stk.Size = New System.Drawing.Size(251, 47)
        Me.stk.TabIndex = 6
        Me.stk.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        ' 
        ' btnBr
        '
        Me.btnBr.Location = New System.Drawing.Point(851, 328)
        Me.btnBr.Name = "btnBr"
        Me.btnBr.Size = New System.Drawing.Size(164, 59)
        Me.btnBr.TabIndex = 7
        Me.btnBr.Text = "Baru"
        ' 
        ' btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(1060, 328)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(151, 59)
        Me.btnSimpan.TabIndex = 8
        Me.btnSimpan.Text = "Simpan"
        ' 
        ' btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(1258, 330)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(149, 61)
        Me.btnUbah.TabIndex = 9
        Me.btnUbah.Text = "Ubah"
        ' 
        ' btnHps
        '
        Me.btnHps.Location = New System.Drawing.Point(1449, 334)
        Me.btnHps.Name = "btnHps"
        Me.btnHps.Size = New System.Drawing.Size(177, 53)
        Me.btnHps.TabIndex = 10
        Me.btnHps.Text = "Hapus"
        ' 
        ' ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {col1, col2, col3, col4, col5, col6, col7})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(12, 414)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1645, 479)
        Me.ListView1.TabIndex = 11
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        ' 
        ' col1
        '
        col1.Text = "Kode Barang"
        col1.Width = 250
        ' 
        ' col2
        '
        col2.Text = "Nama Barang"
        col2.Width = 250
        ' 
        ' col3
        '
        col3.Text = "Jenis"
        col3.Width = 150
        ' 
        ' col4
        '
        col4.Text = "Satuan"
        col4.Width = 150
        ' 
        ' col5
        '
        col5.Text = "Beli"
        col5.Width = 150
        ' 
        ' col6
        '
        col6.Text = "Jual"
        col6.Width = 150
        ' 
        ' col7
        '
        col7.Text = "Stok"
        col7.Width = 150
        ' 
        ' Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 41)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Kode Barang"
        ' 
        ' Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 41)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nama Barang"
        ' 
        ' Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 41)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Jenis"
        ' 
        ' Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 41)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Satuan"
        ' 
        ' Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1004, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 41)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Harga Barang"
        ' 
        ' Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1004, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 41)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Harga Jual"
        ' 
        ' Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1004, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 41)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Stok Barang"
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0F, 41.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1669, 922)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnHps)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnBr)
        Me.Controls.Add(Me.stk)
        Me.Controls.Add(Me.HJ)
        Me.Controls.Add(Me.HB)
        Me.Controls.Add(Me.satuan)
        Me.Controls.Add(Me.jns)
        Me.Controls.Add(Me.nmBrg)
        Me.Controls.Add(Me.kdBrg)
        Me.Name = "Form1"
        CType(Me.HB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HJ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListView1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents kdBrg As TextBox
    Friend WithEvents nmBrg As TextBox
    Friend WithEvents jns As TextBox
    Friend WithEvents satuan As TextBox
    Friend WithEvents HB As NumericUpDown
    Friend WithEvents HJ As NumericUpDown
    Friend WithEvents stk As NumericUpDown
    Friend WithEvents btnBr As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHps As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class