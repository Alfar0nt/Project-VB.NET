Option Strict Off
Option Explicit On

Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class Form1

    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet

    Sub koneksi()
        Dim connString As String = "Server=localhost;Port=3306;Username=root;Database=pemdesk;"
        conn = New MySqlConnection(connString)
    End Sub

    Sub TampilData()
        ds.Clear()
        da = New MySqlDataAdapter("SELECT kode_barang, nama_barang, jenis, satuan, harga_beli, harga_jual, stock FROM tblbarang", conn)
        da.Fill(ds, "barang")
        DataGridView1.DataSource = ds.Tables("barang").DefaultView
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        TampilData()
    End Sub

    Private Sub btnBr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBr.Click
        Dim ctr As Control
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            End If
            If TypeOf ctr Is NumericUpDown Then
                ctr.Text = "0"
            End If
        Next
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        da = New MySqlDataAdapter("INSERT INTO tblbarang VALUES ('" & kdBrg.Text & "','" & nmBrg.Text & "','" & jns.Text & "','" & satuan.Text & "'," & HB.Value & "," & HJ.Value & "," & stk.Value & ")", conn)
        da.Fill(ds, "barang")

        MessageBox.Show("Data berhasil disimpan")
        TampilData()
    End Sub

    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbah.Click
        da = New MySqlDataAdapter("UPDATE tblbarang SET nama_barang='" & nmBrg.Text & "', jenis='" & jns.Text & "', satuan='" & satuan.Text & "', harga_beli=" & HB.Value & ", harga_jual=" & HJ.Value & ", stock=" & stk.Value & " WHERE kode_barang='" & kdBrg.Text & "'", conn)
        da.Fill(ds, "barang")

        MessageBox.Show("Data berhasil diubah")
        TampilData()
    End Sub

    Private Sub btnHps_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHps.Click
        da = New MySqlDataAdapter("DELETE FROM tblbarang WHERE kode_barang='" & kdBrg.Text & "'", conn)
        da.Fill(ds, "barang")

        MessageBox.Show("Data berhasil dihapus")
        TampilData()
    End Sub

End Class