<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        pnlTopBanner = New Panel()
        lblTitle = New Label()
        lblUsername = New Label()
        txtUsername = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        chkShowPass = New CheckBox()
        btnLogin = New Button()
        btnExit = New Button()
        pnlTopBanner.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlTopBanner
        ' 
        pnlTopBanner.BackColor = Color.FromArgb(CByte(27), CByte(54), CByte(93))
        pnlTopBanner.Controls.Add(lblTitle)
        pnlTopBanner.Dock = DockStyle.Top
        pnlTopBanner.Location = New Point(0, 0)
        pnlTopBanner.Name = "pnlTopBanner"
        pnlTopBanner.Size = New Size(1625, 74)
        pnlTopBanner.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(624, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(371, 65)
        lblTitle.TabIndex = 0
        lblTitle.Text = "SYSTEM LOGIN"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(516, 185)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(170, 46)
        lblUsername.TabIndex = 6
        lblUsername.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(711, 181)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(286, 54)
        txtUsername.TabIndex = 1
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(516, 256)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(160, 46)
        lblPassword.TabIndex = 7
        lblPassword.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(711, 252)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(286, 54)
        txtPassword.TabIndex = 2
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' chkShowPass
        ' 
        chkShowPass.AutoSize = True
        chkShowPass.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkShowPass.Location = New Point(711, 414)
        chkShowPass.Name = "chkShowPass"
        chkShowPass.Size = New Size(262, 45)
        chkShowPass.TabIndex = 3
        chkShowPass.Text = "Show Password"
        chkShowPass.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(27), CByte(54), CByte(93))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(711, 325)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(155, 61)
        btnLogin.TabIndex = 4
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(226), CByte(232), CByte(240))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(872, 325)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(125, 61)
        btnExit.TabIndex = 5
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' FormLogin
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(17.0F, 41.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1625, 718)
        Controls.Add(btnExit)
        Controls.Add(btnLogin)
        Controls.Add(chkShowPass)
        Controls.Add(txtPassword)
        Controls.Add(lblPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblUsername)
        Controls.Add(pnlTopBanner)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        pnlTopBanner.ResumeLayout(False)
        pnlTopBanner.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlTopBanner As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents chkShowPass As System.Windows.Forms.CheckBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
