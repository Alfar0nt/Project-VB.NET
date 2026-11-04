Option Strict On
Option Explicit On

Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class Form1

    ' =========================================================================
    ' KONFIGURASI DATABASE (LARAGON)
    ' =========================================================================
    Private Const DB_HOST As String = "localhost"
    Private Const DB_PORT As String = "3306"
    Private Const DB_NAME As String = "dbweek10"
    Private Const DB_USER As String = "root"
    Private Const DB_PASSWORD As String = ""

    Private Const CONNECTION_STRING As String =
        "Server=" & DB_HOST & ";Port=" & DB_PORT & ";Database=" & DB_NAME &
        ";Uid=" & DB_USER & ";Pwd=" & DB_PASSWORD & ";CharSet=utf8mb4;"

    Private Const TABLE_SATUAN As String = "tblsatuan"

    Private kodeBarangTerpilih As String = String.Empty
    Private noSatuanTerpilih As Integer = -1
    Private satuanLama As String = String.Empty

    Private Function BukaKoneksi() As MySqlConnection
        Dim koneksi As New MySqlConnection(CONNECTION_STRING)
        koneksi.Open()
        Return koneksi
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            KonfigurasiTampilan()
            MuatSatuan()
            MuatBarang()
            MuatGridSatuan()
            BersihkanBarang()
            BersihkanSatuan()
        Catch ex As Exception
            TampilkanError("Gagal menyiapkan form", ex)
        End Try
    End Sub

    Private Sub KonfigurasiTampilan()
        txtKodeBarang.ReadOnly = True
        txtNoSatuan.ReadOnly = True
        txtNamaBarang.MaxLength = 50
        txtJenis.MaxLength = 50
        txtSatuan.MaxLength = 50
        cmbSatuan.DropDownStyle = ComboBoxStyle.DropDownList

        For Each angka As NumericUpDown In New NumericUpDown() {numHargaBeli, numHargaJual, numStock}
            angka.Minimum = 0D
            angka.Maximum = CDec(Integer.MaxValue)
            angka.DecimalPlaces = 0
            angka.ThousandsSeparator = True
        Next

        For Each grid As DataGridView In New DataGridView() {dgvBarang, dgvSatuan}
            grid.ReadOnly = True
            grid.AllowUserToAddRows = False
            grid.AllowUserToDeleteRows = False
            grid.MultiSelect = False
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            grid.RowHeadersVisible = False
        Next
    End Sub

    ' =========================================================================
    ' DATA BARANG
    ' =========================================================================

    Private Function AmbilKodeBarangBerikutnya(koneksi As MySqlConnection) As String
        Const sql As String =
            "SELECT COALESCE(MAX(CAST(SUBSTRING(Kode_Barang, 4) AS UNSIGNED)), 0) " &
            "FROM tblbarang WHERE Kode_Barang REGEXP '^BRG[0-9]+$'"
        Using cmd As New MySqlCommand(sql, koneksi)
            Dim nomor As Long = Convert.ToInt64(cmd.ExecuteScalar()) + 1L
            Return "BRG" & nomor.ToString("D3")
        End Using
    End Function

    Private Function BuatKodeBarang() As String
        Using koneksi As MySqlConnection = BukaKoneksi()
            Return AmbilKodeBarangBerikutnya(koneksi)
        End Using
    End Function

    Private Sub MuatSatuan(Optional pilihan As String = "")
        Dim tabel As New DataTable()
        Using koneksi As MySqlConnection = BukaKoneksi()
            Dim sql As String = "SELECT `no`, satuan FROM `" & TABLE_SATUAN & "` ORDER BY satuan"
            Using adapter As New MySqlDataAdapter(sql, koneksi)
                adapter.Fill(tabel)
            End Using
        End Using

        cmbSatuan.DataSource = Nothing
        cmbSatuan.DisplayMember = "satuan"
        cmbSatuan.ValueMember = "satuan"
        cmbSatuan.DataSource = tabel
        cmbSatuan.SelectedIndex = -1

        If pilihan <> String.Empty Then
            cmbSatuan.SelectedValue = pilihan
        End If
    End Sub

    Private Sub MuatBarang()
        Dim tabel As New DataTable()
        Const sql As String =
            "SELECT Kode_Barang, Nama_Barang, Jenis, Satuan, Harga_Beli, Harga_Jual, Stock " &
            "FROM tblbarang ORDER BY Kode_Barang"

        Using koneksi As MySqlConnection = BukaKoneksi()
            Using adapter As New MySqlDataAdapter(sql, koneksi)
                adapter.Fill(tabel)
            End Using
        End Using

        dgvBarang.DataSource = tabel
        AturJudulKolom(dgvBarang, "Kode_Barang", "Kode Barang")
        AturJudulKolom(dgvBarang, "Nama_Barang", "Nama Barang")
        AturJudulKolom(dgvBarang, "Jenis", "Jenis")
        AturJudulKolom(dgvBarang, "Satuan", "Satuan")
        AturJudulKolom(dgvBarang, "Harga_Beli", "Harga Beli")
        AturJudulKolom(dgvBarang, "Harga_Jual", "Harga Jual")
        AturJudulKolom(dgvBarang, "Stock", "Stok")
        dgvBarang.ClearSelection()
    End Sub

    Private Sub AturJudulKolom(grid As DataGridView, kolom As String, judul As String)
        If grid.Columns.Contains(kolom) Then
            grid.Columns(kolom).HeaderText = judul
        End If
    End Sub

    Private Sub BersihkanBarang()
        kodeBarangTerpilih = String.Empty
        txtKodeBarang.Text = BuatKodeBarang()
        txtNamaBarang.Clear()
        txtJenis.Clear()
        cmbSatuan.SelectedIndex = -1
        numHargaBeli.Value = 0D
        numHargaJual.Value = 0D
        numStock.Value = 0D
        btnSimpanBarang.Enabled = True
        btnUbahBarang.Enabled = False
        btnHapusBarang.Enabled = False
        dgvBarang.ClearSelection()
    End Sub

    Private Function ValidasiBarang() As Boolean
        If txtNamaBarang.Text.Trim() = "" Then
            MessageBox.Show("Nama barang wajib diisi.", "Validasi")
            txtNamaBarang.Focus()
            Return False
        End If

        If txtJenis.Text.Trim() = "" Then
            MessageBox.Show("Jenis barang wajib diisi.", "Validasi")
            txtJenis.Focus()
            Return False
        End If

        If cmbSatuan.SelectedIndex < 0 Then
            MessageBox.Show("Pilih satuan barang.", "Validasi")
            cmbSatuan.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub TambahkanParameterBarang(cmd As MySqlCommand)
        cmd.Parameters.Add("@nama", MySqlDbType.VarChar, 50).Value = txtNamaBarang.Text.Trim()
        cmd.Parameters.Add("@jenis", MySqlDbType.VarChar, 50).Value = txtJenis.Text.Trim()
        cmd.Parameters.Add("@satuan", MySqlDbType.VarChar, 50).Value = CStr(cmbSatuan.SelectedValue)
        cmd.Parameters.Add("@beli", MySqlDbType.Int32).Value = Decimal.ToInt32(numHargaBeli.Value)
        cmd.Parameters.Add("@jual", MySqlDbType.Int32).Value = Decimal.ToInt32(numHargaJual.Value)
        cmd.Parameters.Add("@stock", MySqlDbType.Int32).Value = Decimal.ToInt32(numStock.Value)
    End Sub

    Private Sub btnSimpanBarang_Click(sender As Object, e As EventArgs) Handles btnSimpanBarang.Click
        If kodeBarangTerpilih <> String.Empty Then
            MessageBox.Show("Anda sedang mengedit barang. Klik Ubah untuk langsung menyimpan perubahan.", "Informasi")
            Return
        End If

        If Not ValidasiBarang() Then Return

        Const sql As String =
            "INSERT INTO tblbarang (Kode_Barang, Nama_Barang, Jenis, Satuan, Harga_Beli, Harga_Jual, Stock) " &
            "VALUES (@kode, @nama, @jenis, @satuan, @beli, @jual, @stock)"

        Try
            ' Coba ulang jika ada user lain yang lebih dulu menyimpan kode yang sama.
            Using koneksi As MySqlConnection = BukaKoneksi()
                Dim berhasil As Boolean = False
                For percobaan As Integer = 1 To 5
                    Dim kodeBaru As String = AmbilKodeBarangBerikutnya(koneksi)
                    Try
                        Using cmd As New MySqlCommand(sql, koneksi)
                            cmd.Parameters.Add("@kode", MySqlDbType.VarChar, 50).Value = kodeBaru
                            TambahkanParameterBarang(cmd)
                            cmd.ExecuteNonQuery()
                        End Using
                        txtKodeBarang.Text = kodeBaru
                        berhasil = True
                        Exit For
                    Catch ex As MySqlException When ex.Number = 1062 AndAlso percobaan < 5
                        ' Duplicate primary key: ambil kode terbaru dan coba kembali.
                    End Try
                Next

                If Not berhasil Then
                    Throw New InvalidOperationException("Kode barang bentrok. Silakan coba Simpan kembali.")
                End If
            End Using

            MessageBox.Show("Barang berhasil disimpan.", "Informasi")
            MuatBarang()
            BersihkanBarang()
        Catch ex As Exception
            TampilkanError("Gagal menyimpan barang", ex)
        End Try
    End Sub

    Private Sub btnUbahBarang_Click(sender As Object, e As EventArgs) Handles btnUbahBarang.Click
        If kodeBarangTerpilih = "" Then
            MessageBox.Show("Pilih barang di tabel terlebih dahulu.", "Informasi")
            Return
        End If

        If Not ValidasiBarang() Then Return

        Const sql As String =
            "UPDATE tblbarang SET Nama_Barang=@nama, Jenis=@jenis, Satuan=@satuan, " &
            "Harga_Beli=@beli, Harga_Jual=@jual, Stock=@stock WHERE Kode_Barang=@kode"

        Try
            Using koneksi As MySqlConnection = BukaKoneksi()
                Using cmd As New MySqlCommand(sql, koneksi)
                    cmd.Parameters.Add("@kode", MySqlDbType.VarChar, 50).Value = kodeBarangTerpilih
                    TambahkanParameterBarang(cmd)
                    If cmd.ExecuteNonQuery() = 0 Then
                        MessageBox.Show("Tidak ada data yang berubah atau barang tidak ditemukan.", "Informasi")
                    Else
                        MessageBox.Show("Barang berhasil diubah.", "Informasi")
                    End If
                End Using
            End Using

            MuatBarang()
            BersihkanBarang()
        Catch ex As Exception
            TampilkanError("Gagal mengubah barang", ex)
        End Try
    End Sub

    Private Sub btnHapusBarang_Click(sender As Object, e As EventArgs) Handles btnHapusBarang.Click
        If kodeBarangTerpilih = "" Then
            MessageBox.Show("Pilih barang di tabel terlebih dahulu.", "Informasi")
            Return
        End If

        If MessageBox.Show("Hapus barang " & kodeBarangTerpilih & "?", "Konfirmasi",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

        Try
            Using koneksi As MySqlConnection = BukaKoneksi()
                Using cmd As New MySqlCommand("DELETE FROM tblbarang WHERE Kode_Barang=@kode", koneksi)
                    cmd.Parameters.Add("@kode", MySqlDbType.VarChar, 50).Value = kodeBarangTerpilih
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MuatBarang()
            BersihkanBarang()
            MessageBox.Show("Barang berhasil dihapus.", "Informasi")
        Catch ex As Exception
            TampilkanError("Gagal menghapus barang", ex)
        End Try
    End Sub

    Private Sub btnBersihBarang_Click(sender As Object, e As EventArgs) Handles btnBersihBarang.Click
        Try
            BersihkanBarang()
        Catch ex As Exception
            TampilkanError("Gagal mengosongkan isian", ex)
        End Try
    End Sub

    Private Sub dgvBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBarang.CellClick
        If e.RowIndex < 0 Then Return
        Dim baris As DataGridViewRow = dgvBarang.Rows(e.RowIndex)
        If baris.IsNewRow Then Return

        Try
            kodeBarangTerpilih = Convert.ToString(baris.Cells("Kode_Barang").Value)
            txtKodeBarang.Text = kodeBarangTerpilih
            txtNamaBarang.Text = Convert.ToString(baris.Cells("Nama_Barang").Value)
            txtJenis.Text = Convert.ToString(baris.Cells("Jenis").Value)
            cmbSatuan.SelectedValue = Convert.ToString(baris.Cells("Satuan").Value)
            numHargaBeli.Value = Convert.ToDecimal(baris.Cells("Harga_Beli").Value)
            numHargaJual.Value = Convert.ToDecimal(baris.Cells("Harga_Jual").Value)
            numStock.Value = Convert.ToDecimal(baris.Cells("Stock").Value)

            ' Pilihan baris masuk mode edit: tombol Ubah langsung menyimpan UPDATE.
            btnSimpanBarang.Enabled = False
            btnUbahBarang.Enabled = True
            btnHapusBarang.Enabled = True
        Catch ex As Exception
            TampilkanError("Gagal membaca baris barang", ex)
        End Try
    End Sub

    ' =========================================================================
    ' DATA SATUAN
    ' =========================================================================

    Private Function AmbilNomorSatuanBerikutnya(koneksi As MySqlConnection) As Integer
        Dim sql As String = "SELECT COALESCE(MAX(`no`), 0) + 1 FROM `" & TABLE_SATUAN & "`"
        Using cmd As New MySqlCommand(sql, koneksi)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    Private Sub MuatGridSatuan()
        Dim tabel As New DataTable()
        Using koneksi As MySqlConnection = BukaKoneksi()
            Dim sql As String = "SELECT `no`, satuan FROM `" & TABLE_SATUAN & "` ORDER BY `no`"
            Using adapter As New MySqlDataAdapter(sql, koneksi)
                adapter.Fill(tabel)
            End Using
        End Using

        dgvSatuan.DataSource = tabel
        AturJudulKolom(dgvSatuan, "no", "No")
        AturJudulKolom(dgvSatuan, "satuan", "Satuan")
        dgvSatuan.ClearSelection()
    End Sub

    Private Sub BersihkanSatuan()
        noSatuanTerpilih = -1
        satuanLama = String.Empty
        txtSatuan.Clear()
        btnSimpanSatuan.Enabled = True
        btnUbahSatuan.Enabled = False
        btnHapusSatuan.Enabled = False

        Using koneksi As MySqlConnection = BukaKoneksi()
            txtNoSatuan.Text = AmbilNomorSatuanBerikutnya(koneksi).ToString()
        End Using

        dgvSatuan.ClearSelection()
    End Sub

    Private Function ValidasiSatuan() As Boolean
        If txtSatuan.Text.Trim() = "" Then
            MessageBox.Show("Nama satuan wajib diisi.", "Validasi")
            txtSatuan.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function SatuanSudahAda(koneksi As MySqlConnection,
                                    nama As String,
                                    Optional kecualiNo As Integer = -1,
                                    Optional transaksi As MySqlTransaction = Nothing) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM `" & TABLE_SATUAN & "` " &
                            "WHERE LOWER(satuan)=LOWER(@nama) AND `no`<>@kecuali"
        Using cmd As New MySqlCommand(sql, koneksi, transaksi)
            cmd.Parameters.Add("@nama", MySqlDbType.VarChar, 50).Value = nama
            cmd.Parameters.Add("@kecuali", MySqlDbType.Int32).Value = kecualiNo
            Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
        End Using
    End Function

    Private Sub btnSimpanSatuan_Click(sender As Object, e As EventArgs) Handles btnSimpanSatuan.Click
        If noSatuanTerpilih >= 0 Then
            MessageBox.Show("Anda sedang mengedit satuan. Klik Ubah untuk langsung menyimpan perubahan.", "Informasi")
            Return
        End If

        If Not ValidasiSatuan() Then Return

        Try
            Using koneksi As MySqlConnection = BukaKoneksi()
                If SatuanSudahAda(koneksi, txtSatuan.Text.Trim()) Then
                    MessageBox.Show("Satuan tersebut sudah terdaftar.", "Validasi")
                    Return
                End If

                Dim sql As String = "INSERT INTO `" & TABLE_SATUAN & "` (`no`, satuan) VALUES (@no, @nama)"
                Using cmd As New MySqlCommand(sql, koneksi)
                    cmd.Parameters.Add("@no", MySqlDbType.Int32).Value = AmbilNomorSatuanBerikutnya(koneksi)
                    cmd.Parameters.Add("@nama", MySqlDbType.VarChar, 50).Value = txtSatuan.Text.Trim()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Dim dipilih As String = txtSatuan.Text.Trim()
            MuatGridSatuan()
            MuatSatuan(dipilih)
            BersihkanSatuan()
            MessageBox.Show("Satuan berhasil disimpan.", "Informasi")
        Catch ex As Exception
            TampilkanError("Gagal menyimpan satuan", ex)
        End Try
    End Sub

    Private Sub btnUbahSatuan_Click(sender As Object, e As EventArgs) Handles btnUbahSatuan.Click
        If noSatuanTerpilih < 0 Then
            MessageBox.Show("Pilih satuan di tabel terlebih dahulu.", "Informasi")
            Return
        End If

        If Not ValidasiSatuan() Then Return

        Dim namaBaru As String = txtSatuan.Text.Trim()

        Try
            Using koneksi As MySqlConnection = BukaKoneksi()
                Using transaksi As MySqlTransaction = koneksi.BeginTransaction()
                    Try
                        If SatuanSudahAda(koneksi, namaBaru, noSatuanTerpilih, transaksi) Then
                            MessageBox.Show("Nama satuan sudah digunakan.", "Validasi")
                            transaksi.Rollback()
                            Return
                        End If

                        Dim sql As String = "UPDATE `" & TABLE_SATUAN & "` SET satuan=@baru WHERE `no`=@no"
                        Using cmd As New MySqlCommand(sql, koneksi, transaksi)
                            cmd.Parameters.Add("@baru", MySqlDbType.VarChar, 50).Value = namaBaru
                            cmd.Parameters.Add("@no", MySqlDbType.Int32).Value = noSatuanTerpilih
                            cmd.ExecuteNonQuery()
                        End Using

                        ' Kolom tblbarang.Satuan berupa teks, jadi perbarui juga referensinya.
                        Using cmd As New MySqlCommand(
                            "UPDATE tblbarang SET Satuan=@baru WHERE Satuan=@lama", koneksi, transaksi)
                            cmd.Parameters.Add("@baru", MySqlDbType.VarChar, 50).Value = namaBaru
                            cmd.Parameters.Add("@lama", MySqlDbType.VarChar, 50).Value = satuanLama
                            cmd.ExecuteNonQuery()
                        End Using

                        transaksi.Commit()
                    Catch
                        transaksi.Rollback()
                        Throw
                    End Try
                End Using
            End Using

            MuatGridSatuan()
            MuatSatuan(namaBaru)
            MuatBarang()
            BersihkanBarang()
            BersihkanSatuan()
            MessageBox.Show("Satuan dan referensi barang berhasil diubah.", "Informasi")
        Catch ex As Exception
            TampilkanError("Gagal mengubah satuan", ex)
        End Try
    End Sub

    Private Sub btnHapusSatuan_Click(sender As Object, e As EventArgs) Handles btnHapusSatuan.Click
        If noSatuanTerpilih < 0 Then
            MessageBox.Show("Pilih satuan di tabel terlebih dahulu.", "Informasi")
            Return
        End If

        If MessageBox.Show("Hapus satuan '" & satuanLama & "'?", "Konfirmasi",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

        Try
            Using koneksi As MySqlConnection = BukaKoneksi()
                Using cmdCek As New MySqlCommand(
                    "SELECT COUNT(*) FROM tblbarang WHERE Satuan=@satuan", koneksi)
                    cmdCek.Parameters.Add("@satuan", MySqlDbType.VarChar, 50).Value = satuanLama
                    If Convert.ToInt32(cmdCek.ExecuteScalar()) > 0 Then
                        MessageBox.Show("Satuan masih digunakan pada data barang dan tidak dapat dihapus.", "Validasi")
                        Return
                    End If
                End Using

                Dim sql As String = "DELETE FROM `" & TABLE_SATUAN & "` WHERE `no`=@no"
                Using cmd As New MySqlCommand(sql, koneksi)
                    cmd.Parameters.Add("@no", MySqlDbType.Int32).Value = noSatuanTerpilih
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MuatGridSatuan()
            MuatSatuan()
            BersihkanBarang()
            BersihkanSatuan()
            MessageBox.Show("Satuan berhasil dihapus.", "Informasi")
        Catch ex As Exception
            TampilkanError("Gagal menghapus satuan", ex)
        End Try
    End Sub

    Private Sub btnBersihSatuan_Click(sender As Object, e As EventArgs) Handles btnBersihSatuan.Click
        Try
            BersihkanSatuan()
        Catch ex As Exception
            TampilkanError("Gagal mengosongkan satuan", ex)
        End Try
    End Sub

    Private Sub dgvSatuan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSatuan.CellClick
        If e.RowIndex < 0 Then Return
        Dim baris As DataGridViewRow = dgvSatuan.Rows(e.RowIndex)
        If baris.IsNewRow Then Return

        noSatuanTerpilih = Convert.ToInt32(baris.Cells("no").Value)
        satuanLama = Convert.ToString(baris.Cells("satuan").Value)
        txtNoSatuan.Text = noSatuanTerpilih.ToString()
        txtSatuan.Text = satuanLama

        btnSimpanSatuan.Enabled = False
        btnUbahSatuan.Enabled = True
        btnHapusSatuan.Enabled = True
    End Sub

    Private Sub TampilkanError(kegiatan As String, ex As Exception)
        MessageBox.Show(kegiatan & ": " & ex.Message, "Kesalahan",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

End Class