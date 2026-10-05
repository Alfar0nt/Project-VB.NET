Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub LoadMajor()
        cboMajor.Items.Clear()
        cboMajor.Items.Add("Information Systems")
        cboMajor.Items.Add("Informatics")
        cboMajor.Items.Add("Accounting")
        cboMajor.Items.Add("Management")
    End Sub
    Private Sub LoadData()
        Dim dt As New DataTable()
        Using conn As New MySqlConnection(ConnectionString)
            Dim query As String =
                "SELECT student_id,
                 student_name,
                 major,
                 phone
            FROM students
            ORDER BY student_id"
            Dim adapter As New MySqlDataAdapter(query, conn)

            adapter.Fill(dt)

        End Using

        dgvStudents.DataSource = dt
    End Sub
    Private Sub Form1_Load(sender As Object,
        e As EventArgs) Handles MyBase.Load
        LoadMajor()
        LoadData()
    End Sub
    Private Sub Form1_FormClosed(sender As Object,
        e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
    Private Sub ClearForm()
        txtStudentID.Clear()
        txtStudentName.Clear()
        cboMajor.SelectedIndex = -1
        txtPhone.Clear()
        txtStudentID.Focus()
    End Sub
    Private Sub btnClear_Click(sender As Object,
     e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub
    Private Function ValidateInput() As Boolean
        If txtStudentID.Text.Trim() = "" Then
            MessageBox.Show("Student ID must be filled.")
            txtStudentID.Focus()
            Return False
        End If
        If txtStudentName.Text.Trim() = "" Then
            MessageBox.Show("Student Name must be filled.")
            txtStudentName.Focus()
            Return False
        End If
        If cboMajor.SelectedIndex = -1 Then
            MessageBox.Show("Please select a major.")
            cboMajor.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub dgvStudents_CellClick(
     sender As Object,
     e As DataGridViewCellEventArgs
    ) Handles dgvStudents.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow =
     dgvStudents.Rows(e.RowIndex)
            txtStudentID.Text =
     row.Cells("student_id").Value.ToString()
            txtStudentName.Text =
     row.Cells("student_name").Value.ToString()
            cboMajor.Text =
     row.Cells("major").Value.ToString()
            txtPhone.Text =
     row.Cells("phone").Value.ToString()
        End If
    End Sub
    Private Sub txtSearch_TextChanged(
     sender As Object,
     e As EventArgs
    ) Handles txtSearch.TextChanged
        Dim dt As New DataTable()
        Using conn As New MySqlConnection(ConnectionString)
            Dim query As String =
     "SELECT student_id,
     student_name,
     major,
     phone
     FROM students
     WHERE student_id LIKE @search
     OR student_name LIKE @search
     OR major LIKE @search"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue(
     "@search",
     "%" & txtSearch.Text.Trim() & "%"
     )
                Dim adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using
        dgvStudents.DataSource = dt
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateInput() Then Exit Sub
        Using conn As New MySqlConnection(ConnectionString)
            Dim query As String =
                "INSERT INTO students (student_id, student_name, major, phone) VALUES (@id, @name, @major, @phone)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", txtStudentID.Text.Trim())
                cmd.Parameters.AddWithValue("@name", txtStudentName.Text.Trim())
                cmd.Parameters.AddWithValue("@major", cboMajor.Text)
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim())
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
        LoadData()
        ClearForm()
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Not ValidateInput() Then Exit Sub
        Using conn As New MySqlConnection(ConnectionString)
            Dim query As String =
                "UPDATE students SET student_name=@name, major=@major, phone=@phone WHERE student_id=@id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", txtStudentName.Text.Trim())
                cmd.Parameters.AddWithValue("@major", cboMajor.Text)
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim())
                cmd.Parameters.AddWithValue("@id", txtStudentID.Text.Trim())
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
        LoadData()
        ClearForm()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to delete this data?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub
        Using conn As New MySqlConnection(ConnectionString)
            Dim query As String = "DELETE FROM students WHERE student_id=@id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", txtStudentID.Text.Trim())
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
        LoadData()
        ClearForm()
    End Sub

End Class