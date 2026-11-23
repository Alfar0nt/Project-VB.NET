Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Imports System.Windows.Forms.DataVisualization.Charting

Public Class FormDashboard
    ' Public properties populated directly by FormLogin
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property ActiveUserId As Integer = 1
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property ActiveUser As String = "Guest"
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property ActiveRole As String = "Cashier"

    Private isLoggingOut As Boolean = False

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lblUserInfo.Text = $"User: {ActiveUser}  |  Role: {ActiveRole}"
            ApplyRoleAccess()
            LoadDashboardMetrics()
        Catch ex As Exception
            MessageBox.Show("Dashboard load error: " & ex.Message & vbCrLf & ex.StackTrace,
                            "Dashboard Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 1. Role-Based Access Control (RBAC) Enforcement
    Private Sub ApplyRoleAccess()
        If ActiveRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then
            btnNavDashboard.Visible = True
            btnNavMaster.Visible = True
            btnNavTransaction.Visible = True
            btnNavReport.Visible = True
        ElseIf ActiveRole.Equals("Cashier", StringComparison.OrdinalIgnoreCase) Then
            ' Cashiers can process transactions and view the dashboard, but cannot access Master or Reports
            btnNavDashboard.Visible = True
            btnNavMaster.Visible = False
            btnNavTransaction.Visible = True
            btnNavReport.Visible = False
        Else
            btnNavDashboard.Visible = True
            btnNavMaster.Visible = False
            btnNavTransaction.Visible = False
            btnNavReport.Visible = False
        End If
    End Sub

    ' Chart may be dropped from InitializeComponent when the designer saves.
    Private Sub EnsureChart()
        If chrSalesTrend Is Nothing Then
            chrSalesTrend = New Chart()
            chrSalesTrend.Name = "chrSalesTrend"
            chrSalesTrend.Dock = DockStyle.Fill

            ' title must be added last so it docks Top before the chart fills
            If lblChartTitle IsNot Nothing Then
                pnlChartBox.Controls.Remove(lblChartTitle)
            End If
            pnlChartBox.Controls.Add(chrSalesTrend)
            If lblChartTitle IsNot Nothing Then
                pnlChartBox.Controls.Add(lblChartTitle)
            End If
        End If

        If chrSalesTrend.ChartAreas.Count = 0 Then
            chrSalesTrend.ChartAreas.Add(New ChartArea("ChartArea1"))
        End If
        If chrSalesTrend.Legends.Count = 0 Then
            chrSalesTrend.Legends.Add(New Legend("Legend1"))
        End If
        Dim hasSeries1 As Boolean = False
        For Each existing As Series In chrSalesTrend.Series
            If existing.Name = "Series1" Then
                hasSeries1 = True
                Exit For
            End If
        Next
        If Not hasSeries1 Then
            chrSalesTrend.Series.Add(New Series("Series1"))
        End If
    End Sub

    ' 2. Load KPI Summary Cards & Analytical Chart
    Private Sub LoadDashboardMetrics()
        Try
            EnsureChart()
            Using conn As MySqlConnection = GetConnection()
                If conn.State <> ConnectionState.Open Then Return

                ' KPI 1: Total Orders Today
                Dim sqlCount As String = "SELECT COUNT(*) FROM orders WHERE order_date = CURDATE()"
                Using cmdCount As New MySqlCommand(sqlCount, conn)
                    Dim totalTrx As Object = cmdCount.ExecuteScalar()
                    lblTotalTrx.Text = If(totalTrx IsNot Nothing AndAlso Not IsDBNull(totalTrx),
                                          totalTrx.ToString(), "0")
                End Using

                ' KPI 2: Total Revenue Today
                Dim sqlRev As String = "SELECT IFNULL(SUM(total), 0) FROM orders WHERE order_date = CURDATE()"
                Using cmdRev As New MySqlCommand(sqlRev, conn)
                    Dim revenue As Decimal = Convert.ToDecimal(cmdRev.ExecuteScalar())
                    lblTotalRevenue.Text = "Rp " & revenue.ToString("N0")
                End Using

                ' Chart: Top 5 Best-Selling Items
                Dim sqlChart As String = "SELECT b.Nama_Barang, SUM(d.qty) AS total_sold " &
                                         "FROM orders_detail d " &
                                         "JOIN tblbarang b ON d.kode_barang = b.Kode_Barang " &
                                         "GROUP BY b.Kode_Barang, b.Nama_Barang " &
                                         "ORDER BY total_sold DESC LIMIT 5"
                Using da As New MySqlDataAdapter(sqlChart, conn)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    If chrSalesTrend IsNot Nothing Then
                        Dim series As Series = chrSalesTrend.Series("Series1")
                        series.XValueMember = "Nama_Barang"
                        series.YValueMembers = "total_sold"
                        series.ChartType = SeriesChartType.Column
                        series.IsValueShownAsLabel = True
                        chrSalesTrend.Legends(0).Enabled = False
                        chrSalesTrend.DataSource = dt
                        chrSalesTrend.DataBind()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load dashboard metrics: " & ex.Message, "Dashboard Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ' 3. Module Navigation Handlers
    Private Sub btnNavDashboard_Click(sender As Object, e As EventArgs) Handles btnNavDashboard.Click
        lblPageTitle.Text = "Dashboard Overview"
        LoadDashboardMetrics()
    End Sub

    Private Sub btnNavMaster_Click(sender As Object, e As EventArgs) Handles btnNavMaster.Click
        MessageBox.Show("Master Barang module is not part of this week's scope.", "Coming Soon",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnNavTransaction_Click(sender As Object, e As EventArgs) Handles btnNavTransaction.Click
        MessageBox.Show("Transaction module is not part of this week's scope.", "Coming Soon",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnNavReport_Click(sender As Object, e As EventArgs) Handles btnNavReport.Click
        MessageBox.Show("Report module is not part of this week's scope.", "Coming Soon",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' 4. Secure Logout Handler
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim confirm = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            isLoggingOut = True
            FormLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub FormDashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isLoggingOut Then Return

        Dim loginForm As Form = Nothing
        For Each f As Form In Application.OpenForms
            If TypeOf f Is FormLogin Then
                loginForm = f
                Exit For
            End If
        Next

        If loginForm IsNot Nothing AndAlso Not loginForm.IsDisposed Then
            ' jangan matikan proses hanya karena dashboard ditutup
            e.Cancel = True
            Me.Hide()
            loginForm.Show()
        Else
            Application.Exit()
        End If
    End Sub
End Class
