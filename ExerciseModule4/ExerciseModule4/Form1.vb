Public Class Form1
    Dim arr(,) As String
    Dim i As Integer
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim arr(20, 5)
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        arr(i, 0) = tbNPM.Text
        arr(i, 1) = tbName.Text
        arr(i, 2) = tbProdi.Text

        If RbLakilaki.Checked Then
            arr(i, 3) = "Laki-Laki"
        ElseIf RbPerempuan.Checked Then
            arr(i, 3) = "Perempuan"
        End If

        arr(i, 4) = CbSemester.Text
        arr(i, 5) = tbTelepon.Text
        i += 1
        MsgBox("data sukses ditambah")

        lvDataMahasiswa.Items.Clear()

        For K As Integer = 0 To arr.GetUpperBound(0)
            lvDataMahasiswa.Items.Add(arr(K, 0))
            lvDataMahasiswa.Items(lvDataMahasiswa.Items.Count - 1).SubItems.Add(arr(K, 1))
            lvDataMahasiswa.Items(lvDataMahasiswa.Items.Count - 1).SubItems.Add(arr(K, 2))
            lvDataMahasiswa.Items(lvDataMahasiswa.Items.Count - 1).SubItems.Add(arr(K, 3))
            lvDataMahasiswa.Items(lvDataMahasiswa.Items.Count - 1).SubItems.Add(arr(K, 4))
            lvDataMahasiswa.Items(lvDataMahasiswa.Items.Count - 1).SubItems.Add(arr(K, 5))
        Next

        Dim ctr As Control
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            ElseIf TypeOf ctr Is ComboBox Then
                DirectCast(ctr, ComboBox).SelectedItem = Nothing
            ElseIf TypeOf ctr Is RadioButton Then
                DirectCast(ctr, RadioButton).Checked = False
            End If
        Next
    End Sub

    Private Sub btPrint_Click(sender As Object, e As EventArgs) Handles btPrint.Click
        Dim Str As String = ""
        For k As Integer = 0 To arr.GetUpperBound(0)
            Str &= arr(k, 0) & " " & arr(k, 1) & " " & arr(k, 2) & arr(k, 3) & " " & arr(k, 4) & " " & arr(k, 5) & vbCrLf
        Next

        MsgBox(Str)
    End Sub

    Private Sub lvDataMahasiswa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDataMahasiswa.SelectedIndexChanged

    End Sub
End Class