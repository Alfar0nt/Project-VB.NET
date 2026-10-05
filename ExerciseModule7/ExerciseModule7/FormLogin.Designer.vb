<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        txtUser = New TextBox()
        txtPass = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(995, 288)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(297, 47)
        txtUser.TabIndex = 0
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(995, 383)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(297, 47)
        txtPass.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(718, 281)
        Label1.Name = "Label1"
        Label1.Size = New Size(231, 54)
        Label1.TabIndex = 2
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold)
        Label2.Location = New Point(718, 376)
        Label2.Name = "Label2"
        Label2.Size = New Size(224, 54)
        Label2.TabIndex = 3
        Label2.Text = "Password:"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnLogin.Location = New Point(1104, 485)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(188, 58)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1957, 877)
        Controls.Add(btnLogin)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Name = "FormLogin"
        Text = "FormLogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Button
End Class
