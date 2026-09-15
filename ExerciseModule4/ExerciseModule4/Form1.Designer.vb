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
        Label1 = New Label()
        tbName = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        tbNPM = New TextBox()
        tbProdi = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        RbLakilaki = New RadioButton()
        RbPerempuan = New RadioButton()
        CbSemester = New ComboBox()
        tbTelepon = New TextBox()
        CheckedListBox1 = New CheckedListBox()
        btnOk = New Button()
        lvDataMahasiswa = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        btPrint = New Button()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(46, 52)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 41)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' tbName
        ' 
        tbName.Location = New Point(206, 43)
        tbName.Margin = New Padding(5)
        tbName.Name = "tbName"
        tbName.Size = New Size(252, 47)
        tbName.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(46, 180)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 41)
        Label2.TabIndex = 2
        Label2.Text = "NPM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(41, 285)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 41)
        Label3.TabIndex = 3
        Label3.Text = "Prodi"
        ' 
        ' tbNPM
        ' 
        tbNPM.Location = New Point(206, 184)
        tbNPM.Margin = New Padding(5)
        tbNPM.Name = "tbNPM"
        tbNPM.Size = New Size(252, 47)
        tbNPM.TabIndex = 4
        ' 
        ' tbProdi
        ' 
        tbProdi.Location = New Point(206, 285)
        tbProdi.Margin = New Padding(5)
        tbProdi.Name = "tbProdi"
        tbProdi.Size = New Size(252, 47)
        tbProdi.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(520, 52)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(195, 41)
        Label4.TabIndex = 6
        Label4.Text = "Jenis Kelamin"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(520, 180)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(141, 41)
        Label5.TabIndex = 7
        Label5.Text = "Semester"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(520, 285)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(171, 41)
        Label6.TabIndex = 8
        Label6.Text = "No Telepon"
        ' 
        ' RbLakilaki
        ' 
        RbLakilaki.AutoSize = True
        RbLakilaki.Location = New Point(782, 43)
        RbLakilaki.Margin = New Padding(5)
        RbLakilaki.Name = "RbLakilaki"
        RbLakilaki.Size = New Size(185, 45)
        RbLakilaki.TabIndex = 9
        RbLakilaki.TabStop = True
        RbLakilaki.Text = "Laki - Laki"
        RbLakilaki.UseVisualStyleBackColor = True
        ' 
        ' RbPerempuan
        ' 
        RbPerempuan.AutoSize = True
        RbPerempuan.Location = New Point(782, 100)
        RbPerempuan.Margin = New Padding(5)
        RbPerempuan.Name = "RbPerempuan"
        RbPerempuan.Size = New Size(206, 45)
        RbPerempuan.TabIndex = 10
        RbPerempuan.TabStop = True
        RbPerempuan.Text = "Perempuan"
        RbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' CbSemester
        ' 
        CbSemester.DropDownStyle = ComboBoxStyle.DropDownList
        CbSemester.FormattingEnabled = True
        CbSemester.Location = New Point(782, 180)
        CbSemester.Margin = New Padding(5)
        CbSemester.Name = "CbSemester"
        CbSemester.Size = New Size(307, 49)
        CbSemester.TabIndex = 11
        ' 
        ' tbTelepon
        ' 
        tbTelepon.Location = New Point(782, 285)
        tbTelepon.Margin = New Padding(5)
        tbTelepon.Name = "tbTelepon"
        tbTelepon.Size = New Size(307, 47)
        tbTelepon.TabIndex = 12
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Items.AddRange(New Object() {"e-sport", "renang", "basket", "volly", "UKKI"})
        CheckedListBox1.Location = New Point(1159, 43)
        CheckedListBox1.Margin = New Padding(5)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(329, 312)
        CheckedListBox1.TabIndex = 13
        ' 
        ' btnOk
        ' 
        btnOk.Location = New Point(53, 407)
        btnOk.Margin = New Padding(5)
        btnOk.Name = "btnOk"
        btnOk.Size = New Size(1438, 56)
        btnOk.TabIndex = 14
        btnOk.Text = "Save"
        btnOk.UseVisualStyleBackColor = True
        ' 
        ' lvDataMahasiswa
        ' 
        lvDataMahasiswa.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7})
        lvDataMahasiswa.Location = New Point(61, 502)
        lvDataMahasiswa.Margin = New Padding(5)
        lvDataMahasiswa.Name = "lvDataMahasiswa"
        lvDataMahasiswa.Size = New Size(1427, 237)
        lvDataMahasiswa.TabIndex = 15
        lvDataMahasiswa.UseCompatibleStateImageBehavior = False
        lvDataMahasiswa.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "NPM"
        ColumnHeader1.Width = 90
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Nama"
        ColumnHeader2.Width = 250
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Prodi"
        ColumnHeader3.Width = 250
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Jenis Kelamin"
        ColumnHeader4.Width = 200
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Semester"
        ColumnHeader5.Width = 140
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "No Telepon"
        ColumnHeader6.Width = 250
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "UKM"
        ColumnHeader7.Width = 230
        ' 
        ' btPrint
        ' 
        btPrint.Location = New Point(1300, 790)
        btPrint.Margin = New Padding(5)
        btPrint.Name = "btPrint"
        btPrint.Size = New Size(190, 56)
        btPrint.TabIndex = 16
        btPrint.Text = "Tampilkan"
        btPrint.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(1159, 8)
        Label7.Margin = New Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(83, 41)
        Label7.TabIndex = 17
        Label7.Text = "UKM"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1522, 886)
        Controls.Add(Label7)
        Controls.Add(btPrint)
        Controls.Add(lvDataMahasiswa)
        Controls.Add(btnOk)
        Controls.Add(CheckedListBox1)
        Controls.Add(tbTelepon)
        Controls.Add(CbSemester)
        Controls.Add(RbPerempuan)
        Controls.Add(RbLakilaki)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(tbProdi)
        Controls.Add(tbNPM)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(tbName)
        Controls.Add(Label1)
        Margin = New Padding(5)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbNPM As TextBox
    Friend WithEvents tbProdi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RbLakilaki As RadioButton
    Friend WithEvents RbPerempuan As RadioButton
    Friend WithEvents CbSemester As ComboBox
    Friend WithEvents tbTelepon As TextBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents btnOk As Button
    Friend WithEvents lvDataMahasiswa As ListView
    Friend WithEvents btPrint As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Label7 As Label
    Friend WithEvents ColumnHeader7 As ColumnHeader

    Private Sub tbName_TextChanged(sender As Object, e As EventArgs) Handles tbName.TextChanged

    End Sub

    Private Sub CbSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbSemester.SelectedIndexChanged

    End Sub

    Private Sub tbTelepon_TextChanged(sender As Object, e As EventArgs) Handles tbTelepon.TextChanged

    End Sub
End Class
