Option Strict On
Option Explicit On

Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class Form1

    '--- Variabel koneksi ---
    Private conn As MySqlConnection
    Private cmd As MySqlCommand
    Private reader As MySqlDataReader

    '--- Event handlers (without Handles clause) ---
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Wire up button events
            AddHandler btnBr.Click, AddressOf BtnBr_Click
            AddHandler btnSimpan.Click, AddressOf BtnSimpan_Click
            AddHandler btnUbah.Click, AddressOf BtnUbah_Click
            AddHandler btnHps.Click, AddressOf BtnHps_Click

            'Load data
            Call Koneksi()
            Call TampilData()

            'Set fokus
            kdBrg.Focus()
        Catch ex As Exception
            MessageBox.Show("Error saat load form: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub BtnBr_Click(sender As Object, e As EventArgs)
        Try
            'Iterasi For Each untuk mengosongkan TextBox dan NumericUpDown
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is TextBox Then
                    DirectCast(ctrl, TextBox).Clear()
                End If
                If TypeOf ctrl Is NumericUpDown Then
                    DirectCast(ctrl, NumericUpDown).Value = 0
                End If
            Next

            kdBrg.Focus()
        Catch ex As Exception
            MessageBox.Show("Error form baru: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs)
        Try
            If kdBrg.Text = "" Or nmBrg.Text = "" Or jns.Text = "" Or satuan.Text = "" Then
                MessageBox.Show("Semua field wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Call Koneksi()
            Dim query As String = "INSERT INTO tblbarang (Kode_Barang, Nama_Barang, Jenis, Satuan, Harga_Beli, Harga_Jual, Stock) VALUES (@kode, @nama, @jenis, @satuan, @beli, @jual, @stock)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@kode", kdBrg.Text)
            cmd.Parameters.AddWithValue("@nama", nmBrg.Text)
            cmd.Parameters.AddWithValue("@jenis", jns.Text)
            cmd.Parameters.AddWithValue("@satuan", satuan.Text)
            cmd.Parameters.AddWithValue("@beli", HB.Value)
            cmd.Parameters.AddWithValue("@jual", HJ.Value)
            cmd.Parameters.AddWithValue("@stock", stk.Value)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Refresh data di ListView
            Call TampilData()
        Catch ex As Exception
            MessageBox.Show("Error simpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs)
        Try
            If kdBrg.Text = "" Then
                MessageBox.Show("Kode Barang harus diisi untuk mengubah data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Call Koneksi()
            Dim query As String = "UPDATE tblbarang SET Nama_Barang=@nama, Jenis=@jenis, Satuan=@satuan, Harga_Beli=@beli, Harga_Jual=@jual, Stock=@stock WHERE Kode_Barang=@kode"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@kode", kdBrg.Text)
            cmd.Parameters.AddWithValue("@nama", nmBrg.Text)
            cmd.Parameters.AddWithValue("@jenis", jns.Text)
            cmd.Parameters.AddWithValue("@satuan", satuan.Text)
            cmd.Parameters.AddWithValue("@beli", HB.Value)
            cmd.Parameters.AddWithValue("@jual", HJ.Value)
            cmd.Parameters.AddWithValue("@stock", stk.Value)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Refresh data di ListView
            Call TampilData()
        Catch ex As Exception
            MessageBox.Show("Error ubah data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub BtnHps_Click(sender As Object, e As EventArgs)
        Try
            If kdBrg.Text = "" Then
                MessageBox.Show("Kode Barang harus diisi untuk menghapus data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Call Koneksi()
            Dim query As String = "DELETE FROM tblbarang WHERE Kode_Barang=@kode"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@kode", kdBrg.Text)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Reload data di ListView
            Call TampilData()
        Catch ex As Exception
            MessageBox.Show("Error hapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    '--- Fungsi Koneksi ---
    Private Sub Koneksi()
        Try
            Dim connString As String = "Server=localhost;Port=3306;Username=root;Database=pemdesk;"
            conn = New MySqlConnection(connString)
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Koneksi Gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '--- Fungsi Tampil Data (Read) ---
    Private Sub TampilData()
        Try
            Dim query As String = "SELECT * FROM tblbarang"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader

            ListView1.Items.Clear()

            While reader.Read
                Dim item As New ListViewItem(reader("Kode_Barang").ToString())
                item.SubItems.Add(reader("Nama_Barang").ToString())
                item.SubItems.Add(reader("Jenis").ToString())
                item.SubItems.Add(reader("Satuan").ToString())
                item.SubItems.Add(reader("Harga_Beli").ToString())
                item.SubItems.Add(reader("Harga_Jual").ToString())
                item.SubItems.Add(reader("Stock").ToString())
                ListView1.Items.Add(item)
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error tampil data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class