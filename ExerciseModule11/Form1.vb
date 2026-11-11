Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Globalization

Public Class Form1

    ' =====================================================================
    ' KONFIGURASI DATABASE MYSQL
    ' =====================================================================
    ' Database disesuaikan dengan database dari pertemuan sebelumnya (dbweek10).
    ' Password dikosongkan (default Laragon / XAMPP).
    ' Jika Anda mengganti password MySQL nanti, isi pada bagian Pwd=password_baru;
    Private Const CONN_STR As String = "Server=localhost;Port=3306;Database=dbweek10;Uid=root;Pwd=;"

    Private ReadOnly budaya As CultureInfo = CultureInfo.GetCultureInfo("id-ID")
    Private detailTable As DataTable
    Private sedangMemuat As Boolean = False

    ' =====================================================================
    ' FORM LOAD
    ' =====================================================================
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            sedangMemuat = True
            InisialisasiDetail()
            MuatUser()
            MuatBarang()
            sedangMemuat = False
            ResetOrder()
        Catch ex As Exception
            sedangMemuat = False
            MessageBox.Show("Gagal membuka form: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InisialisasiDetail()
        detailTable = New DataTable()
        detailTable.Columns.Add("No", GetType(Integer))
        detailTable.Columns.Add("KodeBarang", GetType(String))
        detailTable.Columns.Add("NamaBarang", GetType(String))
        detailTable.Columns.Add("Satuan", GetType(String))
        detailTable.Columns.Add("Qty", GetType(Integer))
        detailTable.Columns.Add("UnitPrice", GetType(Decimal))
        detailTable.Columns.Add("Subtotal", GetType(Decimal))

        dgvDetail.AutoGenerateColumns = True
        dgvDetail.DataSource = detailTable

        ' Format angka harga & subtotal
        If dgvDetail.Columns.Contains("UnitPrice") Then
            dgvDetail.Columns("UnitPrice").DefaultCellStyle.Format = "N2"
            dgvDetail.Columns("UnitPrice").DefaultCellStyle.FormatProvider = budaya
        End If
        If dgvDetail.Columns.Contains("Subtotal") Then
            dgvDetail.Columns("Subtotal").DefaultCellStyle.Format = "N2"
            dgvDetail.Columns("Subtotal").DefaultCellStyle.FormatProvider = budaya
        End If

        ' Tambahkan kolom tombol hapus agar fitur dgvDetail_CellContentClick berfungsi
        If Not dgvDetail.Columns.Contains("colHapus") Then
            Dim btnHapusCol As New DataGridViewButtonColumn()
            btnHapusCol.Name = "colHapus"
            btnHapusCol.HeaderText = "Aksi"
            btnHapusCol.Text = "Hapus"
            btnHapusCol.UseColumnTextForButtonValue = True
            btnHapusCol.Width = 70
            dgvDetail.Columns.Add(btnHapusCol)
        End If
    End Sub

    ' =====================================================================
    ' MASTER DATA
    ' =====================================================================
    Private Sub MuatUser()
        Dim dt As New DataTable()
        Using cn As New MySqlConnection(CONN_STR)
            Using cmd As New MySqlCommand("SELECT id, username FROM users ORDER BY username", cn)
                cn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using
        cboUser.DisplayMember = "username"
        cboUser.ValueMember = "id"
        cboUser.DataSource = dt
        cboUser.SelectedIndex = -1
    End Sub

    Private Sub MuatBarang()
        Dim dt As New DataTable()
        Dim sql As String =
            "SELECT Kode_Barang AS KodeBarang, Nama_Barang AS NamaBarang, " &
            "Satuan, Harga_Jual AS HargaJual, Stock " &
            "FROM tblbarang ORDER BY Nama_Barang"
        Using cn As New MySqlConnection(CONN_STR)
            Using cmd As New MySqlCommand(sql, cn)
                cn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using
        cboProduct.DisplayMember = "NamaBarang"
        cboProduct.ValueMember = "KodeBarang"
        cboProduct.DataSource = dt
        cboProduct.SelectedIndex = -1
    End Sub

    ' Pembacaan stok terbaru setiap kali Add Item diklik.
    ' Stok yang dibaca di sini hanya untuk validasi awal (belum dikurangi).
    Private Function AmbilStokTerbaru(kodeBarang As String) As Integer
        Using cn As New MySqlConnection(CONN_STR)
            Using cmd As New MySqlCommand(
                "SELECT Stock FROM tblbarang WHERE Kode_Barang = @kode LIMIT 1", cn)
                cmd.Parameters.AddWithValue("@kode", kodeBarang)
                cn.Open()
                Dim nilai As Object = cmd.ExecuteScalar()
                If nilai Is Nothing Then
                    Throw New Exception("Produk tidak ditemukan di tblbarang: " & kodeBarang)
                End If
                If IsDBNull(nilai) Then
                    Throw New Exception("Stok produk belum diisi: " & kodeBarang)
                End If
                Return Convert.ToInt32(nilai)
            End Using
        End Using
    End Function

    ' =====================================================================
    ' INPUT ITEM DAN SUBTOTAL
    ' =====================================================================
    Private Sub cboProduct_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles cboProduct.SelectedIndexChanged
        If Not sedangMemuat Then HitungSubtotalInput()
    End Sub

    Private Sub nudQty_ValueChanged(sender As Object, e As EventArgs) _
        Handles nudQty.ValueChanged
        If Not sedangMemuat Then HitungSubtotalInput()
    End Sub

    Private Sub HitungSubtotalInput()
        Dim barang As DataRowView = TryCast(cboProduct.SelectedItem, DataRowView)
        If barang Is Nothing OrElse IsDBNull(barang("HargaJual")) Then
            txtUnitPrice.Clear()
            txtSubtotal.Clear()
            Return
        End If
        Dim harga As Decimal = Convert.ToDecimal(barang("HargaJual"))
        txtUnitPrice.Text = harga.ToString("N2", budaya)
        txtSubtotal.Text = (harga * nudQty.Value).ToString("N2", budaya)
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim barang As DataRowView = TryCast(cboProduct.SelectedItem, DataRowView)
        If barang Is Nothing Then
            MessageBox.Show("Pilih produk terlebih dahulu.")
            cboProduct.Focus()
            Return
        End If
        If nudQty.Value < 1D OrElse nudQty.Value > Integer.MaxValue Then
            MessageBox.Show("Quantity harus minimal 1 dan tidak boleh terlalu besar.")
            nudQty.Focus()
            Return
        End If
        If IsDBNull(barang("HargaJual")) Then
            MessageBox.Show("Harga jual produk belum diisi.")
            Return
        End If
        Dim harga As Decimal = Convert.ToDecimal(barang("HargaJual"))
        If harga <= 0D Then
            MessageBox.Show("Harga jual harus lebih besar dari nol.")
            Return
        End If
        Dim kode As String = Convert.ToString(barang("KodeBarang"))
        Dim nama As String = Convert.ToString(barang("NamaBarang"))
        Dim satuan As String = If(IsDBNull(barang("Satuan")), "", Convert.ToString(barang("Satuan")))
        Dim qtyDitambahkan As Integer = Decimal.ToInt32(nudQty.Value)

        Dim barisLama As DataRow = Nothing
        For Each r As DataRow In detailTable.Rows
            If String.Equals(Convert.ToString(r("KodeBarang")), kode, StringComparison.OrdinalIgnoreCase) Then
                barisLama = r
                Exit For
            End If
        Next

        Dim qtyDiGrid As Integer = If(barisLama Is Nothing, 0, Convert.ToInt32(barisLama("Qty")))
        Dim totalDiminta As Long = CLng(qtyDiGrid) + CLng(qtyDitambahkan)
        If totalDiminta > Integer.MaxValue Then
            MessageBox.Show("Quantity gabungan terlalu besar.")
            Return
        End If

        ' VALIDASI STOK ketika Add Item, termasuk barang yang sama di grid.
        Try
            Dim stokTersedia As Integer = AmbilStokTerbaru(kode)
            If stokTersedia < totalDiminta Then
                MessageBox.Show(
                    "Stok " & nama & " tidak mencukupi." & vbCrLf &
                    "Stok tersedia: " & stokTersedia & vbCrLf &
                    "Sudah di daftar: " & qtyDiGrid & vbCrLf &
                    "Ingin ditambahkan: " & qtyDitambahkan,
                    "Stok Tidak Cukup", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)
                Return
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal mengecek stok: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        If barisLama Is Nothing Then
            detailTable.Rows.Add(detailTable.Rows.Count + 1,
                                 kode, nama, satuan, qtyDitambahkan,
                                 harga, harga * qtyDitambahkan)
        Else
            barisLama("Qty") = CInt(totalDiminta)
            barisLama("Subtotal") = Convert.ToDecimal(barisLama("UnitPrice")) * CInt(totalDiminta)
        End If

        HitungGrandTotal()
        BersihkanInputBarang()
    End Sub

    Private Sub dgvDetail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvDetail.CellContentClick
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Return
        If dgvDetail.Columns(e.ColumnIndex).Name <> "colHapus" Then Return

        Dim item As DataRowView = TryCast(dgvDetail.Rows(e.RowIndex).DataBoundItem, DataRowView)
        If item Is Nothing Then Return

        detailTable.Rows.Remove(item.Row)
        For i As Integer = 0 To detailTable.Rows.Count - 1
            detailTable.Rows(i)("No") = i + 1
        Next

        HitungGrandTotal()
    End Sub

    Private Function AmbilTotal() As Decimal
        Dim total As Decimal = 0D
        For Each r As DataRow In detailTable.Rows
            total += Convert.ToDecimal(r("Subtotal"))
        Next
        Return total
    End Function

    Private Sub HitungGrandTotal()
        lblGrandTotal.Text = "Rp " & AmbilTotal().ToString("N2", budaya)
    End Sub

    Private Sub BersihkanInputBarang()
        cboProduct.SelectedIndex = -1
        nudQty.Value = 1D
        txtUnitPrice.Clear()
        txtSubtotal.Clear()
    End Sub

    Private Sub btnClearItem_Click(sender As Object, e As EventArgs) Handles btnClearItem.Click
        BersihkanInputBarang()
    End Sub

    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        If detailTable.Rows.Count > 0 Then
            If MessageBox.Show("Batalkan order yang belum disimpan?",
                               "Konfirmasi", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        End If
        ResetOrder()
    End Sub

    Private Sub ResetOrder()
        detailTable.Clear()
        cboUser.SelectedIndex = -1
        dtpOrderDate.Value = Date.Today
        BersihkanInputBarang()
        HitungGrandTotal()
        TampilkanNomorSementara()
    End Sub

    Private Sub dtpOrderDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpOrderDate.ValueChanged
        If Not sedangMemuat AndAlso detailTable IsNot Nothing Then
            TampilkanNomorSementara()
        End If
    End Sub

    Private Sub TampilkanNomorSementara()
        ' Angka di layar hanyalah pratinjau; saat Save memakai order_id final.
        Try
            Using cn As New MySqlConnection(CONN_STR)
                Using cmd As New MySqlCommand("SELECT COALESCE(MAX(order_id), 0) + 1 FROM orders", cn)
                    cn.Open()
                    Dim estimasiId As Long = Convert.ToInt64(cmd.ExecuteScalar())
                    txtOrderNo.Text = "ORD-" &
                        dtpOrderDate.Value.ToString("yyyyMMdd") & "-" &
                        estimasiId.ToString("D6")
                End Using
            End Using
        Catch
            txtOrderNo.Text = "Otomatis saat Save"
        End Try
    End Sub

    ' =====================================================================
    ' SAVE ORDER + PENGURANGAN STOK (ATOMIC TRANSACTION)
    ' =====================================================================
    Private Sub btnSaveOrder_Click(sender As Object, e As EventArgs) Handles btnSaveOrder.Click
        If cboUser.SelectedIndex < 0 OrElse cboUser.SelectedValue Is Nothing Then
            MessageBox.Show("User wajib dipilih.")
            cboUser.Focus()
            Return
        End If

        If detailTable.Rows.Count = 0 Then
            MessageBox.Show("Tambahkan minimal satu barang.")
            cboProduct.Focus()
            Return
        End If

        Dim userId As Integer
        If Not Integer.TryParse(Convert.ToString(cboUser.SelectedValue), userId) Then
            MessageBox.Show("User tidak valid.")
            Return
        End If

        Dim total As Decimal = AmbilTotal()
        If total <= 0D OrElse total > 9999999999999999.99D Then
            MessageBox.Show("Grand Total tidak valid.")
            Return
        End If

        Dim nomorFinal As String = ""
        btnSaveOrder.Enabled = False

        Try
            Using cn As New MySqlConnection(CONN_STR)
                cn.Open()
                Using tr As MySqlTransaction = cn.BeginTransaction()
                    Try
                        ' Insert header dengan nomor sementara yang unik.
                        Dim nomorSementara As String = "TMP-" & Guid.NewGuid().ToString("N").Substring(0, 24)
                        Dim orderId As Long

                        Using cmd As New MySqlCommand(
                            "INSERT INTO orders (order_no, user_id, order_date, total) " &
                            "VALUES (@no, @user, @tanggal, @total)", cn, tr)
                            cmd.Parameters.AddWithValue("@no", nomorSementara)
                            cmd.Parameters.AddWithValue("@user", userId)
                            cmd.Parameters.AddWithValue("@tanggal", dtpOrderDate.Value.Date)
                            cmd.Parameters.AddWithValue("@total", total)
                            cmd.ExecuteNonQuery()
                            orderId = cmd.LastInsertedId
                        End Using

                        nomorFinal = "ORD-" &
                            dtpOrderDate.Value.ToString("yyyyMMdd") & "-" &
                            orderId.ToString("D6")

                        If nomorFinal.Length > 30 Then
                            Throw New Exception("Nomor order melebihi 30 karakter.")
                        End If

                        Using cmd As New MySqlCommand(
                            "UPDATE orders SET order_no = @no WHERE order_id = @id", cn, tr)
                            cmd.Parameters.AddWithValue("@no", nomorFinal)
                            cmd.Parameters.AddWithValue("@id", orderId)
                            If cmd.ExecuteNonQuery() <> 1 Then
                                Throw New Exception("Gagal membuat nomor order final.")
                            End If
                        End Using

                        ' Mengurangi Stock HANYA jika stok cukup.
                        Using cmdStok As New MySqlCommand(
                            "UPDATE tblbarang " &
                            "SET Stock = Stock - @qty " &
                            "WHERE Kode_Barang = @kode AND Stock >= @qty", cn, tr)
                            cmdStok.Parameters.Add("@kode", MySqlDbType.VarChar)
                            cmdStok.Parameters.Add("@qty", MySqlDbType.Int32)

                            Using cmdDetail As New MySqlCommand(
                                "INSERT INTO orders_detail " &
                                "(order_id, kode_barang, qty, unit_price, subtotal) " &
                                "VALUES (@id, @kode, @qty, @harga, @subtotal)", cn, tr)
                                cmdDetail.Parameters.Add("@id", MySqlDbType.Int32)
                                cmdDetail.Parameters.Add("@kode", MySqlDbType.VarChar)
                                cmdDetail.Parameters.Add("@qty", MySqlDbType.Int32)
                                cmdDetail.Parameters.Add("@harga", MySqlDbType.Decimal)
                                cmdDetail.Parameters.Add("@subtotal", MySqlDbType.Decimal)

                                For Each r As DataRow In detailTable.Rows
                                    Dim kode As String = Convert.ToString(r("KodeBarang"))
                                    Dim nama As String = Convert.ToString(r("NamaBarang"))
                                    Dim qty As Integer = Convert.ToInt32(r("Qty"))
                                    Dim harga As Decimal = Convert.ToDecimal(r("UnitPrice"))
                                    Dim subtotal As Decimal = Convert.ToDecimal(r("Subtotal"))

                                    If qty < 1 OrElse harga <= 0D OrElse subtotal <> harga * qty Then
                                        Throw New Exception("Data item tidak valid: " & nama)
                                    End If

                                    cmdStok.Parameters("@kode").Value = kode
                                    cmdStok.Parameters("@qty").Value = qty
                                    Dim affected As Integer = cmdStok.ExecuteNonQuery()
                                    If affected <> 1 Then
                                        Throw New Exception(
                                            "Stok tidak cukup atau barang sudah tidak tersedia: " &
                                            nama & " (" & kode & "). Order dibatalkan.")
                                    End If

                                    cmdDetail.Parameters("@id").Value = CInt(orderId)
                                    cmdDetail.Parameters("@kode").Value = kode
                                    cmdDetail.Parameters("@qty").Value = qty
                                    cmdDetail.Parameters("@harga").Value = harga
                                    cmdDetail.Parameters("@subtotal").Value = subtotal
                                    cmdDetail.ExecuteNonQuery()
                                Next
                            End Using
                        End Using

                        ' Header, detail, dan stok disimpan bersama-sama.
                        tr.Commit()
                    Catch
                        Try
                            tr.Rollback()
                        Catch
                        End Try
                        Throw
                    End Try
                End Using
            End Using

            MessageBox.Show("Order berhasil disimpan: " & nomorFinal & vbCrLf &
                            "Stok barang telah dikurangi.",
                            "Berhasil", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            ' Refresh daftar barang supaya nilai stok tidak memakai cache lama.
            Try
                sedangMemuat = True
                MuatBarang()
                sedangMemuat = False
                ResetOrder()
            Catch ex As Exception
                sedangMemuat = False
                MessageBox.Show("Order SUDAH tersimpan, tetapi gagal menyegarkan form: " &
                                ex.Message, "Peringatan", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning)
            End Try
        Catch ex As Exception
            MessageBox.Show("Order gagal disimpan: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnSaveOrder.Enabled = True
        End Try
    End Sub

End Class
