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

    'Controls declared by the Windows Form Designer
    Private kdBrg As System.Windows.Forms.TextBox
    Private nmBrg As System.Windows.Forms.TextBox
    Private jns As System.Windows.Forms.TextBox
    Private satuan As System.Windows.Forms.TextBox
    Private HB As System.Windows.Forms.NumericUpDown
    Private HJ As System.Windows.Forms.NumericUpDown
    Private stk As System.Windows.Forms.NumericUpDown
    Private btnBr As System.Windows.Forms.Button
    Private btnSimpan As System.Windows.Forms.Button
    Private btnUbah As System.Windows.Forms.Button
    Private btnHps As System.Windows.Forms.Button
    Private ListView1 As System.Windows.Forms.ListView

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        kdBrg = New TextBox()
        nmBrg = New TextBox()
        jns = New TextBox()
        satuan = New TextBox()
        HB = New NumericUpDown()
        HJ = New NumericUpDown()
        stk = New NumericUpDown()
        btnBr = New Button()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHps = New Button()
        ListView1 = New ListView()
        col1 = New ColumnHeader()
        col2 = New ColumnHeader()
        col3 = New ColumnHeader()
        col4 = New ColumnHeader()
        col5 = New ColumnHeader()
        col6 = New ColumnHeader()
        col7 = New ColumnHeader()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        CType(HB, ComponentModel.ISupportInitialize).BeginInit()
        CType(HJ, ComponentModel.ISupportInitialize).BeginInit()
        CType(stk, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' kdBrg
        ' 
        kdBrg.Location = New Point(256, 30)
        kdBrg.Name = "kdBrg"
        kdBrg.Size = New Size(150, 47)
        kdBrg.TabIndex = 11
        ' 
        ' nmBrg
        ' 
        nmBrg.Location = New Point(256, 92)
        nmBrg.Name = "nmBrg"
        nmBrg.Size = New Size(150, 47)
        nmBrg.TabIndex = 10
        ' 
        ' jns
        ' 
        jns.Location = New Point(256, 150)
        jns.Name = "jns"
        jns.Size = New Size(150, 47)
        jns.TabIndex = 9
        ' 
        ' satuan
        ' 
        satuan.Location = New Point(256, 212)
        satuan.Name = "satuan"
        satuan.Size = New Size(150, 47)
        satuan.TabIndex = 8
        ' 
        ' HB
        ' 
        HB.Location = New Point(1237, 47)
        HB.Name = "HB"
        HB.Size = New Size(150, 47)
        HB.TabIndex = 7
        ' 
        ' HJ
        ' 
        HJ.Location = New Point(1237, 122)
        HJ.Name = "HJ"
        HJ.Size = New Size(150, 47)
        HJ.TabIndex = 6
        ' 
        ' stk
        ' 
        stk.Location = New Point(1237, 200)
        stk.Name = "stk"
        stk.Size = New Size(150, 47)
        stk.TabIndex = 5
        ' 
        ' btnBr
        ' 
        btnBr.Location = New Point(851, 328)
        btnBr.Name = "btnBr"
        btnBr.Size = New Size(164, 59)
        btnBr.TabIndex = 4
        btnBr.Text = "Baru"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(1060, 328)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(151, 59)
        btnSimpan.TabIndex = 3
        btnSimpan.Text = "Simpan"
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(1258, 330)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(149, 61)
        btnUbah.TabIndex = 2
        btnUbah.Text = "Ubah"
        ' 
        ' btnHps
        ' 
        btnHps.Location = New Point(1449, 334)
        btnHps.Name = "btnHps"
        btnHps.Size = New Size(177, 53)
        btnHps.TabIndex = 1
        btnHps.Text = "Hapus"
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {col1, col2, col3, col4, col5, col6, col7})
        ListView1.FullRowSelect = True
        ListView1.Location = New Point(12, 414)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1645, 479)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
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
        Label1.AutoSize = True
        Label1.Location = New Point(26, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 41)
        Label1.TabIndex = 12
        Label1.Text = "Kode Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(196, 41)
        Label2.TabIndex = 13
        Label2.Text = "Nama Barang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 41)
        Label3.TabIndex = 14
        Label3.Text = "Jenis"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(26, 218)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 41)
        Label4.TabIndex = 15
        Label4.Text = "Satuan"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(1004, 47)
        Label5.Name = "Label5"
        Label5.Size = New Size(197, 41)
        Label5.TabIndex = 16
        Label5.Text = "Harga Barang"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(1004, 124)
        Label6.Name = "Label6"
        Label6.Size = New Size(155, 41)
        Label6.TabIndex = 17
        Label6.Text = "Harga Jual"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(1004, 202)
        Label7.Name = "Label7"
        Label7.Size = New Size(176, 41)
        Label7.TabIndex = 18
        Label7.Text = "Stok Barang"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(17.0F, 41.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1669, 922)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ListView1)
        Controls.Add(btnHps)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(btnBr)
        Controls.Add(stk)
        Controls.Add(HJ)
        Controls.Add(HB)
        Controls.Add(satuan)
        Controls.Add(jns)
        Controls.Add(nmBrg)
        Controls.Add(kdBrg)
        Name = "Form1"
        CType(HB, ComponentModel.ISupportInitialize).EndInit()
        CType(HJ, ComponentModel.ISupportInitialize).EndInit()
        CType(stk, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents col1 As ColumnHeader
    Friend WithEvents col2 As ColumnHeader
    Friend WithEvents col3 As ColumnHeader
    Friend WithEvents col4 As ColumnHeader
    Friend WithEvents col5 As ColumnHeader
    Friend WithEvents col6 As ColumnHeader
    Friend WithEvents col7 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class