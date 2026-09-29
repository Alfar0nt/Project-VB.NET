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
        DataGridView1 = New DataGridView()
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
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' kdBrg
        ' 
        kdBrg.Location = New Point(105, 11)
        kdBrg.Margin = New Padding(1, 1, 1, 1)
        kdBrg.Name = "kdBrg"
        kdBrg.Size = New Size(113, 23)
        kdBrg.TabIndex = 0
        ' 
        ' nmBrg
        ' 
        nmBrg.Location = New Point(105, 34)
        nmBrg.Margin = New Padding(1, 1, 1, 1)
        nmBrg.Name = "nmBrg"
        nmBrg.Size = New Size(113, 23)
        nmBrg.TabIndex = 1
        ' 
        ' jns
        ' 
        jns.Location = New Point(105, 55)
        jns.Margin = New Padding(1, 1, 1, 1)
        jns.Name = "jns"
        jns.Size = New Size(113, 23)
        jns.TabIndex = 2
        ' 
        ' satuan
        ' 
        satuan.Location = New Point(105, 78)
        satuan.Margin = New Padding(1, 1, 1, 1)
        satuan.Name = "satuan"
        satuan.Size = New Size(113, 23)
        satuan.TabIndex = 3
        ' 
        ' HB
        ' 
        HB.Location = New Point(509, 17)
        HB.Margin = New Padding(1, 1, 1, 1)
        HB.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        HB.Name = "HB"
        HB.Size = New Size(103, 23)
        HB.TabIndex = 4
        ' 
        ' HJ
        ' 
        HJ.Location = New Point(509, 45)
        HJ.Margin = New Padding(1, 1, 1, 1)
        HJ.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        HJ.Name = "HJ"
        HJ.Size = New Size(103, 23)
        HJ.TabIndex = 5
        ' 
        ' stk
        ' 
        stk.Location = New Point(509, 73)
        stk.Margin = New Padding(1, 1, 1, 1)
        stk.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        stk.Name = "stk"
        stk.Size = New Size(103, 23)
        stk.TabIndex = 6
        ' 
        ' btnBr
        ' 
        btnBr.Location = New Point(366, 118)
        btnBr.Margin = New Padding(1, 1, 1, 1)
        btnBr.Name = "btnBr"
        btnBr.Size = New Size(70, 27)
        btnBr.TabIndex = 7
        btnBr.Text = "Baru"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(451, 118)
        btnSimpan.Margin = New Padding(1, 1, 1, 1)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(64, 27)
        btnSimpan.TabIndex = 8
        btnSimpan.Text = "Simpan"
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(526, 118)
        btnUbah.Margin = New Padding(1, 1, 1, 1)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(67, 27)
        btnUbah.TabIndex = 9
        btnUbah.Text = "Ubah"
        ' 
        ' btnHps
        ' 
        btnHps.Location = New Point(604, 118)
        btnHps.Margin = New Padding(1, 1, 1, 1)
        btnHps.Name = "btnHps"
        btnHps.Size = New Size(73, 27)
        btnHps.TabIndex = 10
        btnHps.Text = "Hapus"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.Location = New Point(5, 151)
        DataGridView1.Margin = New Padding(1, 1, 1, 1)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(677, 175)
        DataGridView1.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 13)
        Label1.Margin = New Padding(1, 0, 1, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 12
        Label1.Text = "Kode Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 36)
        Label2.Margin = New Padding(1, 0, 1, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 15)
        Label2.TabIndex = 13
        Label2.Text = "Nama Barang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 56)
        Label3.Margin = New Padding(1, 0, 1, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(32, 15)
        Label3.TabIndex = 14
        Label3.Text = "Jenis"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(11, 80)
        Label4.Margin = New Padding(1, 0, 1, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 15)
        Label4.TabIndex = 15
        Label4.Text = "Satuan"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(413, 17)
        Label5.Margin = New Padding(1, 0, 1, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 15)
        Label5.TabIndex = 16
        Label5.Text = "Harga Barang"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(413, 45)
        Label6.Margin = New Padding(1, 0, 1, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 15)
        Label6.TabIndex = 17
        Label6.Text = "Harga Jual"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(413, 74)
        Label7.Margin = New Padding(1, 0, 1, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 15)
        Label7.TabIndex = 18
        Label7.Text = "Stok Barang"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(687, 337)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
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
        Margin = New Padding(1, 1, 1, 1)
        Name = "Form1"
        Text = "Form1"
        CType(HB, ComponentModel.ISupportInitialize).EndInit()
        CType(HJ, ComponentModel.ISupportInitialize).EndInit()
        CType(stk, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class