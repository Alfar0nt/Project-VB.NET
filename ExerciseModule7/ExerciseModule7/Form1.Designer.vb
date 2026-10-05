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
        txtStudentID = New TextBox()
        txtStudentName = New TextBox()
        txtPhone = New TextBox()
        txtSearch = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        cboMajor = New ComboBox()
        btnSave = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        dgvStudents = New DataGridView()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(655, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(591, 67)
        Label1.TabIndex = 0
        Label1.Text = "Manajemen Mahasigma"
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Location = New Point(340, 189)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(303, 47)
        txtStudentID.TabIndex = 1
        ' 
        ' txtStudentName
        ' 
        txtStudentName.Location = New Point(340, 269)
        txtStudentName.Name = "txtStudentName"
        txtStudentName.Size = New Size(303, 47)
        txtStudentName.TabIndex = 2
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(340, 433)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(303, 47)
        txtPhone.TabIndex = 4
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(1224, 189)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(303, 47)
        txtSearch.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(47, 189)
        Label2.Name = "Label2"
        Label2.Size = New Size(196, 50)
        Label2.TabIndex = 6
        Label2.Text = "Student ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.Location = New Point(47, 269)
        Label3.Name = "Label3"
        Label3.Size = New Size(258, 50)
        Label3.TabIndex = 7
        Label3.Text = "Student Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F)
        Label4.Location = New Point(47, 347)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 50)
        Label4.TabIndex = 8
        Label4.Text = "Major"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F)
        Label5.Location = New Point(47, 429)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 50)
        Label5.TabIndex = 9
        Label5.Text = "Phone"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11F)
        Label6.Location = New Point(1032, 189)
        Label6.Name = "Label6"
        Label6.Size = New Size(131, 50)
        Label6.TabIndex = 10
        Label6.Text = "Search"
        ' 
        ' cboMajor
        ' 
        cboMajor.FormattingEnabled = True
        cboMajor.Location = New Point(340, 351)
        cboMajor.Name = "cboMajor"
        cboMajor.Size = New Size(303, 49)
        cboMajor.TabIndex = 3
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnSave.Location = New Point(1040, 404)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(188, 58)
        btnSave.TabIndex = 6
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        btnUpdate.Location = New Point(1288, 404)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(188, 58)
        btnUpdate.TabIndex = 7
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnDelete.Location = New Point(1532, 404)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(188, 58)
        btnDelete.TabIndex = 8
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(1781, 404)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(188, 58)
        btnClear.TabIndex = 9
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' dgvStudents
        ' 
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudents.Location = New Point(59, 509)
        dgvStudents.Name = "dgvStudents"
        dgvStudents.RowHeadersWidth = 102
        dgvStudents.Size = New Size(1910, 375)
        dgvStudents.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2015, 936)
        Controls.Add(dgvStudents)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnSave)
        Controls.Add(cboMajor)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtSearch)
        Controls.Add(txtPhone)
        Controls.Add(txtStudentName)
        Controls.Add(txtStudentID)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboMajor As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvStudents As DataGridView

End Class
