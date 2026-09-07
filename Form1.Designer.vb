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
        TextBoxKode = New TextBox()
        TextBoxNama = New TextBox()
        TextBoxGajiPokok = New TextBox()
        ComboBoxJamLembur = New ComboBox()
        TextBoxInsentif = New TextBox()
        ButtonClear = New Button()
        ButtonTambahData = New Button()
        lvDataKaryawan = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ButtonRekap = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        RadioButtonPerempuan = New RadioButton()
        RadioButtonLaki = New RadioButton()
        Label6 = New Label()
        Label7 = New Label()
        ComboBoxGolonganTunjangan = New ComboBox()
        TextBoxTunjangan = New TextBox()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' TextBoxKode
        ' 
        TextBoxKode.Location = New Point(262, 103)
        TextBoxKode.Name = "TextBoxKode"
        TextBoxKode.Size = New Size(361, 47)
        TextBoxKode.TabIndex = 0
        ' 
        ' TextBoxNama
        ' 
        TextBoxNama.Location = New Point(262, 205)
        TextBoxNama.Name = "TextBoxNama"
        TextBoxNama.Size = New Size(361, 47)
        TextBoxNama.TabIndex = 1
        ' 
        ' TextBoxGajiPokok
        ' 
        TextBoxGajiPokok.Location = New Point(262, 311)
        TextBoxGajiPokok.Name = "TextBoxGajiPokok"
        TextBoxGajiPokok.Size = New Size(361, 47)
        TextBoxGajiPokok.TabIndex = 2
        ' 
        ' ComboBoxJamLembur
        ' 
        ComboBoxJamLembur.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxJamLembur.FormattingEnabled = True
        ComboBoxJamLembur.Items.AddRange(New Object() {">24hours", ">36hours", ">72hours"})
        ComboBoxJamLembur.Location = New Point(986, 292)
        ComboBoxJamLembur.Name = "ComboBoxJamLembur"
        ComboBoxJamLembur.Size = New Size(206, 49)
        ComboBoxJamLembur.TabIndex = 3
        ' 
        ' TextBoxInsentif
        ' 
        TextBoxInsentif.Location = New Point(1580, 109)
        TextBoxInsentif.Name = "TextBoxInsentif"
        TextBoxInsentif.ReadOnly = True
        TextBoxInsentif.Size = New Size(527, 47)
        TextBoxInsentif.TabIndex = 4
        ' 
        ' ButtonClear
        ' 
        ButtonClear.BackColor = Color.Tomato
        ButtonClear.Location = New Point(262, 862)
        ButtonClear.Name = "ButtonClear"
        ButtonClear.Size = New Size(330, 58)
        ButtonClear.TabIndex = 5
        ButtonClear.Text = "Clear"
        ButtonClear.UseVisualStyleBackColor = False
        ' 
        ' ButtonTambahData
        ' 
        ButtonTambahData.BackColor = Color.Chartreuse
        ButtonTambahData.Location = New Point(262, 406)
        ButtonTambahData.Name = "ButtonTambahData"
        ButtonTambahData.Size = New Size(1810, 58)
        ButtonTambahData.TabIndex = 6
        ButtonTambahData.Text = "Tambah Data Karyawan"
        ButtonTambahData.UseVisualStyleBackColor = False
        ' 
        ' lvDataKaryawan
        ' 
        lvDataKaryawan.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5})
        lvDataKaryawan.Location = New Point(262, 500)
        lvDataKaryawan.Name = "lvDataKaryawan"
        lvDataKaryawan.Size = New Size(1810, 334)
        lvDataKaryawan.TabIndex = 7
        lvDataKaryawan.UseCompatibleStateImageBehavior = False
        lvDataKaryawan.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Kode Karyawan"
        ColumnHeader1.Width = 250
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Nama Karyawan"
        ColumnHeader2.Width = 250
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Gaji Pokok"
        ColumnHeader3.Width = 200
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Jam Lembur"
        ColumnHeader4.Width = 200
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Insentif"
        ColumnHeader5.Width = 200
        ' 
        ' ButtonRekap
        ' 
        ButtonRekap.BackColor = Color.Yellow
        ButtonRekap.Location = New Point(1756, 862)
        ButtonRekap.Name = "ButtonRekap"
        ButtonRekap.Size = New Size(316, 58)
        ButtonRekap.TabIndex = 8
        ButtonRekap.Text = "Rekap Total Gaji"
        ButtonRekap.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 106)
        Label1.Name = "Label1"
        Label1.Size = New Size(220, 41)
        Label1.TabIndex = 9
        Label1.Text = "Kode Karyawan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 205)
        Label2.Name = "Label2"
        Label2.Size = New Size(230, 41)
        Label2.TabIndex = 10
        Label2.Text = "Nama Karyawan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 309)
        Label3.Name = "Label3"
        Label3.Size = New Size(158, 41)
        Label3.TabIndex = 11
        Label3.Text = "Gaji Pokok"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(767, 292)
        Label4.Name = "Label4"
        Label4.Size = New Size(179, 41)
        Label4.TabIndex = 12
        Label4.Text = "Jam Lembur"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(1388, 109)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 41)
        Label5.TabIndex = 13
        Label5.Text = "Insensif"
        ' 
        ' RadioButtonPerempuan
        ' 
        RadioButtonPerempuan.AutoSize = True
        RadioButtonPerempuan.Location = New Point(986, 103)
        RadioButtonPerempuan.Name = "RadioButtonPerempuan"
        RadioButtonPerempuan.Size = New Size(206, 45)
        RadioButtonPerempuan.TabIndex = 14
        RadioButtonPerempuan.TabStop = True
        RadioButtonPerempuan.Text = "Perempuan"
        RadioButtonPerempuan.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonLaki
        ' 
        RadioButtonLaki.AutoSize = True
        RadioButtonLaki.Location = New Point(986, 167)
        RadioButtonLaki.Name = "RadioButtonLaki"
        RadioButtonLaki.Size = New Size(169, 45)
        RadioButtonLaki.TabIndex = 15
        RadioButtonLaki.TabStop = True
        RadioButtonLaki.Text = "Laki-Laki"
        RadioButtonLaki.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(767, 105)
        Label6.Name = "Label6"
        Label6.Size = New Size(195, 41)
        Label6.TabIndex = 16
        Label6.Text = "Jenis Kelamin"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(1388, 193)
        Label7.Name = "Label7"
        Label7.Size = New Size(157, 82)
        Label7.TabIndex = 17
        Label7.Text = "Golongan " & vbCrLf & "Tunjangan"
        ' 
        ' ComboBoxGolonganTunjangan
        ' 
        ComboBoxGolonganTunjangan.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxGolonganTunjangan.FormattingEnabled = True
        ComboBoxGolonganTunjangan.Items.AddRange(New Object() {"Golongan 1", "Golongan 2", "Golongan 3", "Golongan 4", "Golongan 5"})
        ComboBoxGolonganTunjangan.Location = New Point(1580, 226)
        ComboBoxGolonganTunjangan.Name = "ComboBoxGolonganTunjangan"
        ComboBoxGolonganTunjangan.Size = New Size(527, 49)
        ComboBoxGolonganTunjangan.TabIndex = 18
        ' 
        ' TextBoxTunjangan
        ' 
        TextBoxTunjangan.Location = New Point(1580, 325)
        TextBoxTunjangan.Name = "TextBoxTunjangan"
        TextBoxTunjangan.ReadOnly = True
        TextBoxTunjangan.Size = New Size(527, 47)
        TextBoxTunjangan.TabIndex = 19
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(1388, 325)
        Label8.Name = "Label8"
        Label8.Size = New Size(118, 41)
        Label8.TabIndex = 20
        Label8.Text = "Insensif"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(17.0F, 41.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2155, 1000)
        Controls.Add(Label8)
        Controls.Add(TextBoxTunjangan)
        Controls.Add(ComboBoxGolonganTunjangan)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(RadioButtonLaki)
        Controls.Add(RadioButtonPerempuan)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ButtonRekap)
        Controls.Add(lvDataKaryawan)
        Controls.Add(ButtonTambahData)
        Controls.Add(ButtonClear)
        Controls.Add(TextBoxInsentif)
        Controls.Add(ComboBoxJamLembur)
        Controls.Add(TextBoxGajiPokok)
        Controls.Add(TextBoxNama)
        Controls.Add(TextBoxKode)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxKode As TextBox
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents TextBoxGajiPokok As TextBox
    Friend WithEvents ComboBoxJamLembur As ComboBox
    Friend WithEvents TextBoxInsentif As TextBox
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonTambahData As Button
    Friend WithEvents lvDataKaryawan As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ButtonRekap As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RadioButtonPerempuan As RadioButton
    Friend WithEvents RadioButtonLaki As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxGolonganTunjangan As ComboBox
    Friend WithEvents TextBoxTunjangan As TextBox
    Friend WithEvents Label8 As Label

End Class
