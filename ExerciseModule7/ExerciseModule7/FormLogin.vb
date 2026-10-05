Imports MySql.Data.MySqlClient

Public Class FormLogin

    Private Function AuthenticateUser(username As String, password As String) As Boolean

        Dim query As String =
            "SELECT COUNT(*) FROM users " &
            "WHERE username=@username AND password=@password"

        Using conn As New MySqlConnection(ConnectionString)
            Using command As New MySqlCommand(query, conn)

                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)

                Try
                    conn.Open()

                    Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return result > 0

                Catch ex As MySqlException
                    MessageBox.Show("Error saat login: " & ex.Message)
                    Return False
                End Try

            End Using
        End Using

    End Function

    Private Sub btnLogin_Click(sender As Object,
                               e As EventArgs) Handles btnLogin.Click

        Dim username As String = txtUser.Text
        Dim password As String = txtPass.Text

        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Username and password cannot be empty.")
            Exit Sub
        End If

        If AuthenticateUser(username, password) Then
            MessageBox.Show("Login successful!")
            Me.Hide()
            Form1.Show()
        Else
            MessageBox.Show("Invalid username or password.")
        End If

    End Sub

End Class