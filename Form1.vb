Public Class Form1
    Private Sub lvDataKaryawan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDataKaryawan.SelectedIndexChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub ComboBoxJamLembur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxJamLembur.SelectedIndexChanged
        If ComboBoxJamLembur.Text = ">24hours" Then
            TextBoxInsentif.Text = "1000000"
        ElseIf ComboBoxJamLembur.Text = ">36hours" Then
            TextBoxInsentif.Text = "1500000"
        ElseIf ComboBoxJamLembur.Text = ">72hours" Then
            TextBoxInsentif.Text = "2000000"
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Dim ctr As Control
        For Each ctr In Me.Controls
            If TypeOf (ctr) Is TextBox Then
                ctr.Text = ""
            ElseIf TypeOf (ctr) Is ComboBox Then
                DirectCast(ctr, ComboBox).SelectedItem = Nothing
            End If
        Next
    End Sub

    Private Sub ButtonTambahData_Click(sender As Object, e As EventArgs) Handles ButtonTambahData.Click
        lvDataKaryawan.Items.Add(TextBoxKode.Text)
        lvDataKaryawan.Items(lvDataKaryawan.Items.Count - 1).SubItems.Add(TextBoxNama.Text)
        lvDataKaryawan.Items(lvDataKaryawan.Items.Count - 1).SubItems.Add(TextBoxGajiPokok.Text)
        lvDataKaryawan.Items(lvDataKaryawan.Items.Count - 1).SubItems.Add(ComboBoxJamLembur.Text)
        lvDataKaryawan.Items(lvDataKaryawan.Items.Count - 1).SubItems.Add(TextBoxInsentif.Text)
    End Sub

    Private Sub ButtonRekap_Click(sender As Object, e As EventArgs) Handles ButtonRekap.Click
        Dim totalGaji As Integer = 0

        Form2.lvRekapGaji.Items().Clear()

        For i As Integer = 0 To lvDataKaryawan.Items.Count - 1
            Form2.lvRekapGaji.Items.Add(lvDataKaryawan.Items(i).SubItems(1).Text)
            Form2.lvRekapGaji.Items(i).SubItems.Add(lvDataKaryawan.Items(i).SubItems(1).Text)
            Form2.lvRekapGaji.Items(i).SubItems.Add(lvDataKaryawan.Items(i).SubItems(2).Text)
            Form2.lvRekapGaji.Items(i).SubItems.Add(lvDataKaryawan.Items(i).SubItems(3).Text)
            Form2.lvRekapGaji.Items(i).SubItems.Add(lvDataKaryawan.Items(i).SubItems(4).Text)
            Form2.lvRekapGaji.Items(i).SubItems.Add(CInt(lvDataKaryawan.Items(i).SubItems(2).Text) + CInt(lvDataKaryawan.Items(i).SubItems(2).Text))

        Next

        For i As Integer = 0 To Form2.lvRekapGaji.Items.Count - 1
            totalGaji += CInt(Form2.lvRekapGaji.Items(i).SubItems(5).Text)
        Next

        Form2.TextBoxTotalGaji.Text = totalGaji

        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub TextBoxInsentif_TextChanged(sender As Object, e As EventArgs) Handles TextBoxInsentif.TextChanged

    End Sub
End Class
