<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboard
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
        pnlSidebar = New Panel()
        btnLogout = New Button()
        btnNavReport = New Button()
        btnNavTransaction = New Button()
        btnNavMaster = New Button()
        btnNavDashboard = New Button()
        pnlHeader = New Panel()
        lblUserInfo = New Label()
        lblPageTitle = New Label()
        pnlWorkspace = New Panel()
        pnlChartBox = New Panel()
        lblChartTitle = New Label()
        tlpKpi = New TableLayoutPanel()
        pnlCardTrx = New Panel()
        lblTotalTrx = New Label()
        lblTrxCaption = New Label()
        pnlCardRev = New Panel()
        lblTotalRevenue = New Label()
        lblRevCaption = New Label()
        pnlSidebar.SuspendLayout()
        pnlHeader.SuspendLayout()
        pnlWorkspace.SuspendLayout()
        pnlChartBox.SuspendLayout()
        tlpKpi.SuspendLayout()
        pnlCardTrx.SuspendLayout()
        pnlCardRev.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(27), CByte(54), CByte(93))
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Controls.Add(btnNavReport)
        pnlSidebar.Controls.Add(btnNavTransaction)
        pnlSidebar.Controls.Add(btnNavMaster)
        pnlSidebar.Controls.Add(btnNavDashboard)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(230, 820)
        pnlSidebar.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(27), CByte(54), CByte(93))
        btnLogout.Dock = DockStyle.Bottom
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(0, 772)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(16, 0, 0, 0)
        btnLogout.Size = New Size(230, 48)
        btnLogout.TabIndex = 4
        btnLogout.Text = "Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnNavReport
        ' 
        btnNavReport.BackColor = Color.FromArgb(CByte(27), CByte(54), CByte(93))
        btnNavReport.Dock = DockStyle.Top
        btnNavReport.FlatAppearance.BorderSize = 0
        btnNavReport.FlatStyle = FlatStyle.Flat
        btnNavReport.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNavReport.ForeColor = Color.White
        btnNavReport.Location = New Point(0, 144)
        btnNavReport.Name = "btnNavReport"
        btnNavReport.Padding = New Padding(16, 0, 0, 0)
        btnNavReport.Size = New Size(230, 48)
        btnNavReport.TabIndex = 3
        btnNavReport.Text = "Report"
        btnNavReport.TextAlign = ContentAlignment.MiddleLeft
        btnNavReport.UseVisualStyleBackColor = False
        ' 
        ' btnNavTransaction
        ' 
        btnNavTransaction.BackColor = Color.FromArgb(CByte(27), CByte(54), CByte(93))
        btnNavTransaction.Dock = DockStyle.Top
        btnNavTransaction.FlatAppearance.BorderSize = 0
        btnNavTransaction.FlatStyle = FlatStyle.Flat
        btnNavTransaction.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNavTransaction.ForeColor = Color.White
        btnNavTransaction.Location = New Point(0, 96)
        btnNavTransaction.Name = "btnNavTransaction"
        btnNavTransaction.Padding = New Padding(16, 0, 0, 0)
        btnNavTransaction.Size = New Size(230, 48)
        btnNavTransaction.TabIndex = 2
        btnNavTransaction.Text = "Transaction"
        btnNavTransaction.TextAlign = ContentAlignment.MiddleLeft
        btnNavTransaction.UseVisualStyleBackColor = False
        ' 
        ' btnNavMaster
        ' 
        btnNavMaster.BackColor = Color.FromArgb(CByte(27), CByte(54), CByte(93))
        btnNavMaster.Dock = DockStyle.Top
        btnNavMaster.FlatAppearance.BorderSize = 0
        btnNavMaster.FlatStyle = FlatStyle.Flat
        btnNavMaster.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNavMaster.ForeColor = Color.White
        btnNavMaster.Location = New Point(0, 48)
        btnNavMaster.Name = "btnNavMaster"
        btnNavMaster.Padding = New Padding(16, 0, 0, 0)
        btnNavMaster.Size = New Size(230, 48)
        btnNavMaster.TabIndex = 1
        btnNavMaster.Text = "Master Barang"
        btnNavMaster.TextAlign = ContentAlignment.MiddleLeft
        btnNavMaster.UseVisualStyleBackColor = False
        ' 
        ' btnNavDashboard
        ' 
        btnNavDashboard.BackColor = Color.FromArgb(CByte(27), CByte(54), CByte(93))
        btnNavDashboard.Dock = DockStyle.Top
        btnNavDashboard.FlatAppearance.BorderSize = 0
        btnNavDashboard.FlatStyle = FlatStyle.Flat
        btnNavDashboard.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNavDashboard.ForeColor = Color.White
        btnNavDashboard.Location = New Point(0, 0)
        btnNavDashboard.Name = "btnNavDashboard"
        btnNavDashboard.Padding = New Padding(16, 0, 0, 0)
        btnNavDashboard.Size = New Size(230, 48)
        btnNavDashboard.TabIndex = 0
        btnNavDashboard.Text = "Dashboard"
        btnNavDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnNavDashboard.UseVisualStyleBackColor = False
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.White
        pnlHeader.Controls.Add(lblUserInfo)
        pnlHeader.Controls.Add(lblPageTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(230, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Padding = New Padding(24, 0, 24, 0)
        pnlHeader.Size = New Size(1678, 90)
        pnlHeader.TabIndex = 1
        ' 
        ' lblUserInfo
        ' 
        lblUserInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblUserInfo.AutoSize = True
        lblUserInfo.Font = New Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUserInfo.Location = New Point(1474, 22)
        lblUserInfo.Name = "lblUserInfo"
        lblUserInfo.Size = New Size(442, 47)
        lblUserInfo.TabIndex = 1
        lblUserInfo.Text = "User: Guest  |  Role: Cashier"
        lblUserInfo.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblPageTitle
        ' 
        lblPageTitle.AutoSize = True
        lblPageTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPageTitle.Location = New Point(24, 18)
        lblPageTitle.Name = "lblPageTitle"
        lblPageTitle.Size = New Size(499, 65)
        lblPageTitle.TabIndex = 0
        lblPageTitle.Text = "Dashboard Overview"
        ' 
        ' pnlWorkspace
        ' 
        pnlWorkspace.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        pnlWorkspace.Controls.Add(pnlChartBox)
        pnlWorkspace.Controls.Add(tlpKpi)
        pnlWorkspace.Dock = DockStyle.Fill
        pnlWorkspace.Location = New Point(230, 90)
        pnlWorkspace.Name = "pnlWorkspace"
        pnlWorkspace.Padding = New Padding(24)
        pnlWorkspace.Size = New Size(1678, 730)
        pnlWorkspace.TabIndex = 2
        ' 
        ' pnlChartBox
        ' 
        pnlChartBox.BackColor = Color.White
        pnlChartBox.Controls.Add(lblChartTitle)
        pnlChartBox.Dock = DockStyle.Fill
        pnlChartBox.Location = New Point(24, 164)
        pnlChartBox.Margin = New Padding(0, 16, 0, 0)
        pnlChartBox.Name = "pnlChartBox"
        pnlChartBox.Padding = New Padding(16)
        pnlChartBox.Size = New Size(1630, 542)
        pnlChartBox.TabIndex = 1
        ' 
        ' lblChartTitle
        ' 
        lblChartTitle.Dock = DockStyle.Top
        lblChartTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblChartTitle.Location = New Point(16, 16)
        lblChartTitle.Name = "lblChartTitle"
        lblChartTitle.Padding = New Padding(8, 0, 0, 0)
        lblChartTitle.Size = New Size(1598, 62)
        lblChartTitle.TabIndex = 0
        lblChartTitle.Text = "Top 5 Best-Selling Items"
        lblChartTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tlpKpi
        ' 
        tlpKpi.ColumnCount = 2
        tlpKpi.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpKpi.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpKpi.Controls.Add(pnlCardTrx, 0, 0)
        tlpKpi.Controls.Add(pnlCardRev, 1, 0)
        tlpKpi.Dock = DockStyle.Top
        tlpKpi.Location = New Point(24, 24)
        tlpKpi.Name = "tlpKpi"
        tlpKpi.RowCount = 1
        tlpKpi.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpKpi.Size = New Size(1630, 140)
        tlpKpi.TabIndex = 0
        ' 
        ' pnlCardTrx
        ' 
        pnlCardTrx.BackColor = Color.White
        pnlCardTrx.Controls.Add(lblTotalTrx)
        pnlCardTrx.Controls.Add(lblTrxCaption)
        pnlCardTrx.Dock = DockStyle.Fill
        pnlCardTrx.Location = New Point(0, 0)
        pnlCardTrx.Margin = New Padding(0, 0, 12, 0)
        pnlCardTrx.Name = "pnlCardTrx"
        pnlCardTrx.Size = New Size(803, 140)
        pnlCardTrx.TabIndex = 0
        ' 
        ' lblTotalTrx
        ' 
        lblTotalTrx.AutoSize = True
        lblTotalTrx.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalTrx.Location = New Point(20, 52)
        lblTotalTrx.Name = "lblTotalTrx"
        lblTotalTrx.Size = New Size(77, 89)
        lblTotalTrx.TabIndex = 0
        lblTotalTrx.Text = "0"
        ' 
        ' lblTrxCaption
        ' 
        lblTrxCaption.AutoSize = True
        lblTrxCaption.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTrxCaption.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblTrxCaption.Location = New Point(20, 18)
        lblTrxCaption.Name = "lblTrxCaption"
        lblTrxCaption.Size = New Size(266, 41)
        lblTrxCaption.TabIndex = 1
        lblTrxCaption.Text = "Total Orders Today"
        ' 
        ' pnlCardRev
        ' 
        pnlCardRev.BackColor = Color.White
        pnlCardRev.Controls.Add(lblTotalRevenue)
        pnlCardRev.Controls.Add(lblRevCaption)
        pnlCardRev.Dock = DockStyle.Fill
        pnlCardRev.Location = New Point(827, 0)
        pnlCardRev.Margin = New Padding(12, 0, 0, 0)
        pnlCardRev.Name = "pnlCardRev"
        pnlCardRev.Size = New Size(803, 140)
        pnlCardRev.TabIndex = 1
        ' 
        ' lblTotalRevenue
        ' 
        lblTotalRevenue.AutoSize = True
        lblTotalRevenue.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalRevenue.Location = New Point(20, 52)
        lblTotalRevenue.Name = "lblTotalRevenue"
        lblTotalRevenue.Size = New Size(181, 89)
        lblTotalRevenue.TabIndex = 0
        lblTotalRevenue.Text = "Rp 0"
        ' 
        ' lblRevCaption
        ' 
        lblRevCaption.AutoSize = True
        lblRevCaption.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRevCaption.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblRevCaption.Location = New Point(20, 18)
        lblRevCaption.Name = "lblRevCaption"
        lblRevCaption.Size = New Size(289, 41)
        lblRevCaption.TabIndex = 1
        lblRevCaption.Text = "Total Revenue Today"
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1908, 820)
        Controls.Add(pnlWorkspace)
        Controls.Add(pnlHeader)
        Controls.Add(pnlSidebar)
        Name = "FormDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        WindowState = FormWindowState.Maximized
        pnlSidebar.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlWorkspace.ResumeLayout(False)
        pnlChartBox.ResumeLayout(False)
        tlpKpi.ResumeLayout(False)
        pnlCardTrx.ResumeLayout(False)
        pnlCardTrx.PerformLayout()
        pnlCardRev.ResumeLayout(False)
        pnlCardRev.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents btnNavDashboard As System.Windows.Forms.Button
    Friend WithEvents btnNavMaster As System.Windows.Forms.Button
    Friend WithEvents btnNavTransaction As System.Windows.Forms.Button
    Friend WithEvents btnNavReport As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblPageTitle As System.Windows.Forms.Label
    Friend WithEvents lblUserInfo As System.Windows.Forms.Label
    Friend WithEvents pnlWorkspace As System.Windows.Forms.Panel
    Friend WithEvents tlpKpi As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlCardTrx As System.Windows.Forms.Panel
    Friend WithEvents lblTrxCaption As System.Windows.Forms.Label
    Friend WithEvents lblTotalTrx As System.Windows.Forms.Label
    Friend WithEvents pnlCardRev As System.Windows.Forms.Panel
    Friend WithEvents lblRevCaption As System.Windows.Forms.Label
    Friend WithEvents lblTotalRevenue As System.Windows.Forms.Label
    Friend WithEvents pnlChartBox As System.Windows.Forms.Panel
    Friend WithEvents lblChartTitle As System.Windows.Forms.Label
    Friend WithEvents chrSalesTrend As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
