' =====================================================================
' FormOrder.vb  -  Week 9: Auto Generate Number & Error Handling
' (code-behind; tampilan ada di FormOrder.Designer.vb)
' =====================================================================
Imports System.Data
Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class FormOrder

    Private Const ConnStr As String =
        "Server=localhost;Port=3306;Database=db_module9;Uid=root;Pwd=;"

    ' Format angka Indonesia: 3.000,00
    Private ReadOnly idCulture As New CultureInfo("id-ID")

    ' =================== Load ===================
    Private Sub FormOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadUser()
            LoadProduct()
            ClearForm()
        Catch ex As MySqlException
            MessageBox.Show("Tidak dapat terhubung ke database." & vbCrLf & ex.Message,
                            "Kesalahan Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat memuat form: " & ex.Message,
                            "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadUser()
        Using conn As New MySqlConnection(ConnStr)
            Dim dt As New DataTable()
            Using da As New MySqlDataAdapter("SELECT user_id, username FROM `user` ORDER BY username", conn)
                da.Fill(dt)
            End Using
            cmbUser.DataSource = dt
            cmbUser.DisplayMember = "username"
            cmbUser.ValueMember = "user_id"
            cmbUser.SelectedIndex = -1
        End Using
    End Sub

    Private Sub LoadProduct()
        Using conn As New MySqlConnection(ConnStr)
            Dim dt As New DataTable()
            Using da As New MySqlDataAdapter(
                "SELECT kode_barang, nama_barang, harga FROM tblbarang ORDER BY nama_barang", conn)
                da.Fill(dt)
            End Using
            cmbProduct.DataSource = dt
            cmbProduct.DisplayMember = "nama_barang"
            cmbProduct.ValueMember = "kode_barang"
            cmbProduct.SelectedIndex = -1
        End Using
    End Sub

    ' =================== Nomor order (preview) ===================
    ' Hanya MENAMPILKAN perkiraan nomor berikutnya. Nomor final diambil
    ' secara atomik di dalam transaksi saat tombol Save ditekan.
    Private Sub RefreshOrderNumberPreview()
        Try
            Dim tgl As Date = dtpOrderDate.Value.Date
            Using conn As New MySqlConnection(ConnStr)
                conn.Open()
                Using cmd As New MySqlCommand("SELECT last_seq FROM order_counter WHERE order_date=@d", conn)
                    cmd.Parameters.AddWithValue("@d", tgl.ToString("yyyy-MM-dd"))
                    Dim o As Object = cmd.ExecuteScalar()
                    Dim nextSeq As Integer = If(o Is Nothing OrElse IsDBNull(o), 1, Convert.ToInt32(o) + 1)
                    txtOrderNumber.Text = "ORD-" & tgl.ToString("yyyyMMdd") & "-" & nextSeq.ToString("0000")
                End Using
            End Using
        Catch ex As MySqlException
            txtOrderNumber.Text = ""
            MessageBox.Show("Gagal membaca nomor order: " & ex.Message, "Kesalahan Database",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            txtOrderNumber.Text = ""
        End Try
    End Sub

    Private Sub dtpOrderDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpOrderDate.ValueChanged
        If Not btnSave.Enabled Then Return ' order baru saja tersimpan, tunggu Clear
        RefreshOrderNumberPreview()
    End Sub

    ' =================== Produk & Qty ===================
    Private Sub cmbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles cmbProduct.SelectedIndexChanged
        ErrorProvider1.SetError(cmbProduct, "")
        Dim row As DataRowView = TryCast(cmbProduct.SelectedItem, DataRowView)
        If cmbProduct.SelectedIndex < 0 OrElse row Is Nothing Then
            txtUnitPrice.Clear()
        Else
            txtUnitPrice.Text = Convert.ToDecimal(row("harga")).ToString("N2", idCulture)
        End If
        HitungTotal()
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        HitungTotal()
    End Sub

    Private Sub txtQuantity_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) _
        Handles txtQuantity.Validating
        Dim q As Integer
        ErrorProvider1.SetError(txtQuantity, ValidateQty(q))
    End Sub

    Private Function ValidateQty(ByRef qty As Integer) As String
        Dim s As String = txtQuantity.Text.Trim()
        If s = "" Then Return "Quantity tidak boleh kosong."
        If Not Integer.TryParse(s, qty) Then Return "Quantity harus berupa angka bulat."
        If qty <= 0 Then Return "Quantity harus lebih besar dari 0."
        Return ""
    End Function

    Private Sub HitungTotal()
        Dim row As DataRowView = TryCast(cmbProduct.SelectedItem, DataRowView)
        Dim qty As Integer
        If row IsNot Nothing AndAlso Integer.TryParse(txtQuantity.Text.Trim(), qty) AndAlso qty > 0 Then
            Dim sub_ As Decimal = Convert.ToDecimal(row("harga")) * qty
            txtSubtotal.Text = sub_.ToString("N2", idCulture)
            lblGrandTotal.Text = "Rp " & sub_.ToString("N2", idCulture)
        Else
            txtSubtotal.Clear()
            lblGrandTotal.Text = "Rp 0,00"
        End If
    End Sub

    ' =================== Clear ===================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        ErrorProvider1.Clear()
        btnSave.Enabled = True
        cmbUser.SelectedIndex = -1
        cmbProduct.SelectedIndex = -1
        txtQuantity.Clear()
        txtUnitPrice.Clear()
        txtSubtotal.Clear()
        lblGrandTotal.Text = "Rp 0,00"
        dtpOrderDate.Value = Date.Today
        RefreshOrderNumberPreview()
        cmbUser.Focus()
    End Sub

    ' =================== Save ===================
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ErrorProvider1.Clear()

        ' ---- Validasi input ----
        Dim valid As Boolean = True
        If cmbUser.SelectedIndex < 0 OrElse cmbUser.SelectedValue Is Nothing Then
            ErrorProvider1.SetError(cmbUser, "User harus dipilih.")
            valid = False
        End If
        If cmbProduct.SelectedIndex < 0 OrElse cmbProduct.SelectedValue Is Nothing Then
            ErrorProvider1.SetError(cmbProduct, "Product harus dipilih.")
            valid = False
        End If
        Dim qty As Integer
        Dim msg As String = ValidateQty(qty)
        If msg <> "" Then
            ErrorProvider1.SetError(txtQuantity, msg)
            valid = False
        End If
        If Not valid Then
            MessageBox.Show("Data belum lengkap atau tidak valid. Periksa tanda seru merah pada form.",
                            "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim userId As Integer = Convert.ToInt32(cmbUser.SelectedValue)
        Dim kode As String = cmbProduct.SelectedValue.ToString()
        Dim tgl As Date = dtpOrderDate.Value.Date
        Dim tglStr As String = tgl.ToString("yyyy-MM-dd")
        Dim orderDateTime As Date = tgl.Add(DateTime.Now.TimeOfDay)

        Using conn As New MySqlConnection(ConnStr)
            Dim trx As MySqlTransaction = Nothing
            Try
                conn.Open()
                trx = conn.BeginTransaction()

                ' 1. Pastikan user ada
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM `user` WHERE user_id=@u", conn, trx)
                    cmd.Parameters.AddWithValue("@u", userId)
                    If Convert.ToInt32(cmd.ExecuteScalar()) = 0 Then
                        Throw New ApplicationException("User tidak ditemukan di database.")
                    End If
                End Using

                ' 2. Nomor order unik berbasis database (counter per tanggal).
                '    Baris counter terkunci sampai COMMIT -> aman untuk 2 kasir bersamaan.
                Using cmd As New MySqlCommand(
                    "INSERT INTO order_counter (order_date, last_seq) VALUES (@d, 1) " &
                    "ON DUPLICATE KEY UPDATE last_seq = last_seq + 1", conn, trx)
                    cmd.Parameters.AddWithValue("@d", tglStr)
                    cmd.ExecuteNonQuery()
                End Using
                Dim seq As Integer
                Using cmd As New MySqlCommand("SELECT last_seq FROM order_counter WHERE order_date=@d", conn, trx)
                    cmd.Parameters.AddWithValue("@d", tglStr)
                    seq = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
                Dim orderNo As String = "ORD-" & tgl.ToString("yyyyMMdd") & "-" & seq.ToString("0000")

                ' 3. Cek produk, harga & stok terbaru (row lock)
                Dim harga As Decimal
                Dim stok As Integer
                Using cmd As New MySqlCommand(
                    "SELECT harga, stok FROM tblbarang WHERE kode_barang=@k FOR UPDATE", conn, trx)
                    cmd.Parameters.AddWithValue("@k", kode)
                    Using rd As MySqlDataReader = cmd.ExecuteReader()
                        If Not rd.Read() Then
                            Throw New ApplicationException("Product " & kode & " tidak ditemukan.")
                        End If
                        harga = rd.GetDecimal("harga")
                        stok = rd.GetInt32("stok")
                    End Using
                End Using
                If qty > stok Then
                    Throw New ApplicationException("Stok tidak cukup. Tersedia: " & stok & ", diminta: " & qty & ".")
                End If
                Dim subtotal As Decimal = harga * qty

                ' 4. Header order
                Dim orderId As Long
                Using cmd As New MySqlCommand(
                    "INSERT INTO orders (order_no, user_id, order_date, total) VALUES (@no, @u, @tgl, @t)", conn, trx)
                    cmd.Parameters.AddWithValue("@no", orderNo)
                    cmd.Parameters.AddWithValue("@u", userId)
                    cmd.Parameters.AddWithValue("@tgl", orderDateTime)
                    cmd.Parameters.AddWithValue("@t", subtotal)
                    cmd.ExecuteNonQuery()
                    orderId = cmd.LastInsertedId
                End Using

                ' 5. Detail order
                Using cmd As New MySqlCommand(
                    "INSERT INTO orders_detail (order_id, kode_barang, qty, unit_price, subtotal) " &
                    "VALUES (@o, @k, @q, @p, @s)", conn, trx)
                    cmd.Parameters.AddWithValue("@o", orderId)
                    cmd.Parameters.AddWithValue("@k", kode)
                    cmd.Parameters.AddWithValue("@q", qty)
                    cmd.Parameters.AddWithValue("@p", harga)
                    cmd.Parameters.AddWithValue("@s", subtotal)
                    cmd.ExecuteNonQuery()
                End Using

                ' 6. Kurangi stok
                Using cmd As New MySqlCommand(
                    "UPDATE tblbarang SET stok = stok - @q WHERE kode_barang=@k", conn, trx)
                    cmd.Parameters.AddWithValue("@q", qty)
                    cmd.Parameters.AddWithValue("@k", kode)
                    cmd.ExecuteNonQuery()
                End Using

                ' 7. Semua berhasil
                trx.Commit()

                txtOrderNumber.Text = orderNo   ' read-only, nomor final
                btnSave.Enabled = False         ' cegah simpan ganda; tekan Clear untuk order baru
                MessageBox.Show("Order berhasil disimpan." & vbCrLf & "No. Order: " & orderNo &
                                vbCrLf & "Total: Rp " & subtotal.ToString("N2", idCulture),
                                "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As ApplicationException
                SafeRollback(trx)
                MessageBox.Show(ex.Message & vbCrLf & "Order dibatalkan, tidak ada data yang tersimpan.",
                                "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Catch ex As MySqlException
                SafeRollback(trx)
                Dim pesan As String
                Select Case ex.Number
                    Case 1062 : pesan = "Nomor order duplikat. Silakan coba simpan lagi."
                    Case 1452 : pesan = "Data user atau product tidak valid (relasi tidak ditemukan)."
                    Case 1213 : pesan = "Terjadi konflik dengan pengguna lain. Silakan coba lagi."
                    Case 1042, 2002, 2003 : pesan = "Tidak dapat terhubung ke server database."
                    Case Else : pesan = "Kesalahan database (" & ex.Number & "): " & ex.Message
                End Select
                MessageBox.Show(pesan & vbCrLf & "Semua perubahan dibatalkan (rollback).",
                                "Kesalahan Database", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Catch ex As InvalidCastException
                SafeRollback(trx)
                MessageBox.Show("Tipe data tidak sesuai: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Catch ex As NullReferenceException
                SafeRollback(trx)
                MessageBox.Show("Ada data yang belum terisi: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Catch ex As Exception
                SafeRollback(trx)
                MessageBox.Show("Terjadi kesalahan tak terduga: " & ex.Message & vbCrLf &
                                "Semua perubahan dibatalkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End Using
    End Sub

    Private Sub SafeRollback(trx As MySqlTransaction)
        Try
            If trx IsNot Nothing Then trx.Rollback()
        Catch
            ' koneksi mungkin sudah terputus; transaksi otomatis dibatalkan server
        End Try
    End Sub
End Class