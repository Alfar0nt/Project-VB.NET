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
        btPrint = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' tbName
        ' 
        tbName.Location = New Point(121, 26)
        tbName.Name = "tbName"
        tbName.Size = New Size(150, 31)
        tbName.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 25)
        Label2.TabIndex = 2
        Label2.Text = "NPM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 25)
        Label3.TabIndex = 3
        Label3.Text = "Prodi"
        ' 
        ' tbNPM
        ' 
        tbNPM.Location = New Point(121, 112)
        tbNPM.Name = "tbNPM"
        tbNPM.Size = New Size(150, 31)
        tbNPM.TabIndex = 4
        ' 
        ' tbProdi
        ' 
        tbProdi.Location = New Point(121, 174)
        tbProdi.Name = "tbProdi"
        tbProdi.Size = New Size(150, 31)
        tbProdi.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(306, 32)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 25)
        Label4.TabIndex = 6
        Label4.Text = "Jenis Kelamin"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(306, 110)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 25)
        Label5.TabIndex = 7
        Label5.Text = "Semester"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(306, 174)
        Label6.Name = "Label6"
        Label6.Size = New Size(102, 25)
        Label6.TabIndex = 8
        Label6.Text = "No Telepon"
        ' 
        ' RbLakilaki
        ' 
        RbLakilaki.AutoSize = True
        RbLakilaki.Location = New Point(460, 26)
        RbLakilaki.Name = "RbLakilaki"
        RbLakilaki.Size = New Size(114, 29)
        RbLakilaki.TabIndex = 9
        RbLakilaki.TabStop = True
        RbLakilaki.Text = "Laki - Laki"
        RbLakilaki.UseVisualStyleBackColor = True
        ' 
        ' RbPerempuan
        ' 
        RbPerempuan.AutoSize = True
        RbPerempuan.Location = New Point(460, 61)
        RbPerempuan.Name = "RbPerempuan"
        RbPerempuan.Size = New Size(126, 29)
        RbPerempuan.TabIndex = 10
        RbPerempuan.TabStop = True
        RbPerempuan.Text = "Perempuan"
        RbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' CbSemester
        ' 
        CbSemester.DropDownStyle = ComboBoxStyle.DropDownList
        CbSemester.FormattingEnabled = True
        CbSemester.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        CbSemester.Location = New Point(460, 110)
        CbSemester.Name = "CbSemester"
        CbSemester.Size = New Size(182, 33)
        CbSemester.TabIndex = 11
        ' 
        ' tbTelepon
        ' 
        tbTelepon.Location = New Point(460, 174)
        tbTelepon.Name = "tbTelepon"
        tbTelepon.Size = New Size(182, 31)
        tbTelepon.TabIndex = 12
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Location = New Point(682, 26)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(195, 200)
        CheckedListBox1.TabIndex = 13
        ' 
        ' btnOk
        ' 
        btnOk.Location = New Point(31, 248)
        btnOk.Name = "btnOk"
        btnOk.Size = New Size(846, 34)
        btnOk.TabIndex = 14
        btnOk.Text = "Save"
        btnOk.UseVisualStyleBackColor = True
        ' 
        ' lvDataMahasiswa
        ' 
        lvDataMahasiswa.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6})
        lvDataMahasiswa.Location = New Point(36, 306)
        lvDataMahasiswa.Name = "lvDataMahasiswa"
        lvDataMahasiswa.Size = New Size(841, 146)
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
        ColumnHeader2.Width = 110
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Prodi"
        ColumnHeader3.Width = 120
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Jenis Kelamin"
        ColumnHeader4.Width = 130
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Semester"
        ColumnHeader5.Width = 140
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "No Telepon"
        ColumnHeader6.Width = 160
        ' 
        ' btPrint
        ' 
        btPrint.Location = New Point(765, 482)
        btPrint.Name = "btPrint"
        btPrint.Size = New Size(112, 34)
        btPrint.TabIndex = 16
        btPrint.Text = "Tampilkan"
        btPrint.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(895, 540)
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

    Private Sub tbName_TextChanged(sender As Object, e As EventArgs) Handles tbName.TextChanged

    End Sub

    Private Sub CbSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbSemester.SelectedIndexChanged

    End Sub

    Private Sub tbTelepon_TextChanged(sender As Object, e As EventArgs) Handles tbTelepon.TextChanged

    End Sub
End Class
