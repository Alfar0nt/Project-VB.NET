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
        ComboBoxJamLembur.Location = New Point(1461, 101)
        ComboBoxJamLembur.Name = "ComboBoxJamLembur"
        ComboBoxJamLembur.Size = New Size(361, 49)
        ComboBoxJamLembur.TabIndex = 3
        ' 
        ' TextBoxInsentif
        ' 
        TextBoxInsentif.Location = New Point(1461, 194)
        TextBoxInsentif.Name = "TextBoxInsentif"
        TextBoxInsentif.ReadOnly = True
        TextBoxInsentif.Size = New Size(361, 47)
        TextBoxInsentif.TabIndex = 4
        ' 
        ' ButtonClear
        ' 
        ButtonClear.BackColor = Color.Tomato
        ButtonClear.Location = New Point(1281, 300)
        ButtonClear.Name = "ButtonClear"
        ButtonClear.Size = New Size(541, 58)
        ButtonClear.TabIndex = 5
        ButtonClear.Text = "Clear"
        ButtonClear.UseVisualStyleBackColor = False
        ' 
        ' ButtonTambahData
        ' 
        ButtonTambahData.BackColor = Color.Chartreuse
        ButtonTambahData.Location = New Point(262, 406)
        ButtonTambahData.Name = "ButtonTambahData"
        ButtonTambahData.Size = New Size(1560, 58)
        ButtonTambahData.TabIndex = 6
        ButtonTambahData.Text = "Tambah Data Karyawan"
        ButtonTambahData.UseVisualStyleBackColor = False
        ' 
        ' lvDataKaryawan
        ' 
        lvDataKaryawan.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5})
        lvDataKaryawan.Location = New Point(262, 500)
        lvDataKaryawan.Name = "lvDataKaryawan"
        lvDataKaryawan.Size = New Size(1560, 334)
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
        ButtonRekap.Location = New Point(1461, 876)
        ButtonRekap.Name = "ButtonRekap"
        ButtonRekap.Size = New Size(361, 58)
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
        Label4.Location = New Point(1255, 109)
        Label4.Name = "Label4"
        Label4.Size = New Size(179, 41)
        Label4.TabIndex = 12
        Label4.Text = "Jam Lembur"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(1255, 200)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 41)
        Label5.TabIndex = 13
        Label5.Text = "Insensif"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2075, 1016)
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

End Class
