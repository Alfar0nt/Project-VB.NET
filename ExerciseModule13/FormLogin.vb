Imports MySql.Data.MySqlClient

Public Class FormLogin
    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPass.Checked
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' 1. Input validation
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter both Username and Password.", "Validation Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Return
        End If

        ' 2. Hash the entered password using SHA-256
        Dim hashedPassword As String = HashSHA256(txtPassword.Text.Trim())

        ' 3. Query 'users' table using a Parameterized Query
        Dim query As String = "SELECT id, full_name, role FROM users WHERE username = @user AND " &
                              "password = @pass LIMIT 1"

        Try
            Using conn As MySqlConnection = GetConnection()
                If conn.State <> ConnectionState.Open Then Return

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim())
                    cmd.Parameters.AddWithValue("@pass", hashedPassword)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' 4. Pass user id, full_name & role directly to FormDashboard
                            Dim dash As New FormDashboard()
                            dash.ActiveUserId = Convert.ToInt32(reader("id"))
                            dash.ActiveUser = reader("full_name").ToString()
                            dash.ActiveRole = reader("role").ToString()

                            txtPassword.Clear()
                            dash.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Invalid username or password.", "Authentication Failed",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtPassword.Clear()
                            txtPassword.Focus()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Login execution error: " & ex.Message, "System Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
