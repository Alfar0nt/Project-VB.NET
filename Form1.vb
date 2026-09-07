Public Class Form1

    Private Sub ComboBoxJamLembur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxJamLembur.SelectedIndexChanged
        If ComboBoxJamLembur.Text = ">24hours" Then
            TextBoxInsentif.Text = "1000000"
        ElseIf ComboBoxJamLembur.Text = ">36hours" Then
            TextBoxInsentif.Text = "1500000"
        ElseIf ComboBoxJamLembur.Text = ">72hours" Then
            TextBoxInsentif.Text = "2000000"
        End If
    End Sub

    Private Sub ComboBoxGolonganTunjangan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxGolonganTunjangan.SelectedIndexChanged
        Select Case ComboBoxGolonganTunjangan.Text
            Case "Golongan 1"
                TextBoxTunjangan.Text = "500000"
            Case "Golongan 2"
                TextBoxTunjangan.Text = "1000000"
            Case "Golongan 3"
                TextBoxTunjangan.Text = "1500000"
            Case "Golongan 4"
                TextBoxTunjangan.Text = "2000000"
            Case "Golongan 5"
                TextBoxTunjangan.Text = "2500000"
        End Select
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        lvDataKaryawan.Items.Clear()
        Dim ctr As Control
        For Each ctr In Me.Controls
            If TypeOf (ctr) Is TextBox Then
                ctr.Text = ""
            ElseIf TypeOf (ctr) Is ComboBox Then
                DirectCast(ctr, ComboBox).SelectedItem = Nothing
            ElseIf TypeOf (ctr) Is RadioButton Then
                DirectCast(ctr, RadioButton).Checked = False
            End If
        Next
    End Sub

    Private Sub ButtonTambahData_Click(sender As Object, e As EventArgs) Handles ButtonTambahData.Click
        Dim gender As String = ""
        If RadioButtonLaki.Checked Then
            gender = "Laki-Laki"
        ElseIf RadioButtonPerempuan.Checked Then
            gender = "Perempuan"
        End If

        lvDataKaryawan.Items.Add(TextBoxKode.Text)
        With lvDataKaryawan.Items(lvDataKaryawan.Items.Count - 1)
            .SubItems.Add(TextBoxNama.Text)
            .SubItems.Add(TextBoxGajiPokok.Text)
            .SubItems.Add(ComboBoxJamLembur.Text)
            .SubItems.Add(TextBoxInsentif.Text)
            .SubItems.Add(gender)
            .SubItems.Add(ComboBoxGolonganTunjangan.Text)
            .SubItems.Add(TextBoxTunjangan.Text)
        End With

        For Each ctr As Control In Me.Controls
            If TypeOf (ctr) Is TextBox Then
                ctr.Text = ""
            ElseIf TypeOf (ctr) Is ComboBox Then
                DirectCast(ctr, ComboBox).SelectedItem = Nothing
            ElseIf TypeOf (ctr) Is RadioButton Then
                DirectCast(ctr, RadioButton).Checked = False
            End If
        Next
    End Sub

    Private Sub ButtonRekap_Click(sender As Object, e As EventArgs) Handles ButtonRekap.Click
        Dim totalGaji As Integer = 0

        Form2.lvRekapGaji.Items.Clear()

        For i As Integer = 0 To lvDataKaryawan.Items.Count - 1
            Dim gajiPokok As Integer = CInt(lvDataKaryawan.Items(i).SubItems(2).Text)
            Dim insentif As Integer = CInt(lvDataKaryawan.Items(i).SubItems(4).Text)
            Dim tunjangan As Integer = CInt(lvDataKaryawan.Items(i).SubItems(7).Text)
            Dim total As Integer = gajiPokok + insentif + tunjangan

            Form2.lvRekapGaji.Items.Add(lvDataKaryawan.Items(i).SubItems(0).Text)
            With Form2.lvRekapGaji.Items(i)
                .SubItems.Add(lvDataKaryawan.Items(i).SubItems(1).Text)
                .SubItems.Add(lvDataKaryawan.Items(i).SubItems(5).Text)
                .SubItems.Add(lvDataKaryawan.Items(i).SubItems(2).Text)
                .SubItems.Add(lvDataKaryawan.Items(i).SubItems(3).Text)
                .SubItems.Add(lvDataKaryawan.Items(i).SubItems(4).Text)
                .SubItems.Add(total.ToString())
                .SubItems.Add(lvDataKaryawan.Items(i).SubItems(6).Text)
                .SubItems.Add(lvDataKaryawan.Items(i).SubItems(7).Text)
            End With
            totalGaji += total
        Next

        Form2.TextBoxTotalGaji.Text = totalGaji

        Me.Hide()
        Form2.Show()
    End Sub

End Class
