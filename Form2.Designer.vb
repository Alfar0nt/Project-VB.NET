<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        lvRekapGaji = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader9 = New ColumnHeader()
        ButtonBack = New Button()
        Label2 = New Label()
        TextBoxTotalGaji = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(598, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(700, 89)
        Label1.TabIndex = 0
        Label1.Text = "Rekap Gaji Karyawan"
        ' 
        ' lvRekapGaji
        ' 
        lvRekapGaji.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader7, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader8, ColumnHeader9})
        lvRekapGaji.Location = New Point(93, 168)
        lvRekapGaji.Name = "lvRekapGaji"
        lvRekapGaji.Size = New Size(1911, 695)
        lvRekapGaji.TabIndex = 1
        lvRekapGaji.UseCompatibleStateImageBehavior = False
        lvRekapGaji.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Kode Karyawan"
        ColumnHeader1.Width = 220
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Nama Karyawan"
        ColumnHeader2.TextAlign = HorizontalAlignment.Center
        ColumnHeader2.Width = 290
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Jenis Kelamin"
        ColumnHeader7.TextAlign = HorizontalAlignment.Center
        ColumnHeader7.Width = 220
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Gaji Pokok"
        ColumnHeader3.TextAlign = HorizontalAlignment.Center
        ColumnHeader3.Width = 200
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Jam Lembur"
        ColumnHeader4.TextAlign = HorizontalAlignment.Center
        ColumnHeader4.Width = 200
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Insentif"
        ColumnHeader5.TextAlign = HorizontalAlignment.Center
        ColumnHeader5.Width = 180
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Total Gaji"
        ColumnHeader6.TextAlign = HorizontalAlignment.Center
        ColumnHeader6.Width = 200
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Golongan"
        ColumnHeader8.TextAlign = HorizontalAlignment.Center
        ColumnHeader8.Width = 180
        ' 
        ' ColumnHeader9
        ' 
        ColumnHeader9.Text = "Tunjangan"
        ColumnHeader9.TextAlign = HorizontalAlignment.Center
        ColumnHeader9.Width = 180
        ' 
        ' ButtonBack
        ' 
        ButtonBack.BackColor = SystemColors.ControlLight
        ButtonBack.Location = New Point(93, 915)
        ButtonBack.Name = "ButtonBack"
        ButtonBack.Size = New Size(188, 58)
        ButtonBack.TabIndex = 2
        ButtonBack.Text = "Back"
        ButtonBack.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(1396, 915)
        Label2.Name = "Label2"
        Label2.Size = New Size(332, 41)
        Label2.TabIndex = 3
        Label2.Text = "Total Gaji Keseluruhan"
        ' 
        ' TextBoxTotalGaji
        ' 
        TextBoxTotalGaji.Location = New Point(1754, 909)
        TextBoxTotalGaji.Name = "TextBoxTotalGaji"
        TextBoxTotalGaji.ReadOnly = True
        TextBoxTotalGaji.Size = New Size(250, 47)
        TextBoxTotalGaji.TabIndex = 4
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(2106, 1025)
        Controls.Add(TextBoxTotalGaji)
        Controls.Add(Label2)
        Controls.Add(ButtonBack)
        Controls.Add(lvRekapGaji)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lvRekapGaji As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ButtonBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxTotalGaji As TextBox
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
End Class
