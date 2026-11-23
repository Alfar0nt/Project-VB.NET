Imports MySql.Data.MySqlClient

Module ModuleKoneksi
    ' Connection string configured for the dbtrial schema
    ' ponytail: password kosong untuk MySQL lokal; isi dbPassword bila password ditambahkan
    Private dbPassword As String = ""
    Private connectionString As String = "server=localhost;user id=root;password=" & dbPassword & ";database=dbtrial;"

    ' Returns an open MySqlConnection instance
    Public Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connectionString)
        Try
            conn.Open()
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Database Connection Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return conn
    End Function
End Module
