Option Strict Off
Option Explicit On

Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class Form1

    ' Inisialisasi variabel Connection, Command, dan DataReader
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader

    ' Subroutine untuk koneksi
    Sub koneksi()
        conn.Close()
        Dim connString As String = "Server=localhost;Port=3306;Username=root;Database=pemdesk;"
        conn = New MySqlConnection(connString)
        conn.Open()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        ListView1.Items.Clear()
        cmd = New MySqlCommand("SELECT kode_barang, nama_barang, jenis, satuan, harga_beli, harga_jual, stock from tblbarang", conn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                ListView1.Items.Add(dr.Item(0).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(2).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(3).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(4).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(5).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(6).ToString())
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub btnBr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBr.Click
        ' syntax untuk mengosongkan TextBox dan NumericUpDown
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
        ' DML syntax; tombol ini untuk menyimpan data
        cmd = New MySqlCommand("insert into tblbarang values ('" & kdBrg.Text & "','" & nmBrg.Text & "','" & jns.Text & "','" & satuan.Text & "'," & HB.Value & "," & HJ.Value & "," & stk.Value & ")", conn)
        cmd.ExecuteNonQuery()

        ' tampil data pada ListView setelah menyimpan data
        ListView1.Items.Clear()
        cmd = New MySqlCommand("SELECT kode_barang, nama_barang, jenis, satuan, harga_beli, harga_jual, stock from tblbarang", conn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                ListView1.Items.Add(dr.Item(0).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(2).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(3).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(4).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(5).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(6).ToString())
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbah.Click
        ' DML syntax; tombol ini untuk mengubah data
        cmd = New MySqlCommand("update tblbarang set nama_barang='" & nmBrg.Text & "', jenis='" & jns.Text & "', satuan='" & satuan.Text & "', harga_beli=" & HB.Value & ", harga_jual=" & HJ.Value & ", stock=" & stk.Value & " where kode_barang='" & kdBrg.Text & "'", conn)
        cmd.ExecuteNonQuery()

        ' tampil data pada ListView setelah update data
        ListView1.Items.Clear()
        cmd = New MySqlCommand("SELECT kode_barang, nama_barang, jenis, satuan, harga_beli, harga_jual, stock from tblbarang", conn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                ListView1.Items.Add(dr.Item(0).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(2).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(3).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(4).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(5).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(6).ToString())
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()
    End Sub

    Private Sub btnHps_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHps.Click
        ' DML syntax; tombol ini untuk menghapus data
        cmd = New MySqlCommand("delete from tblbarang where kode_barang='" & kdBrg.Text & "'", conn)
        cmd.ExecuteNonQuery()

        ' tampil data pada ListView setelah delete data
        ListView1.Items.Clear()
        cmd = New MySqlCommand("SELECT kode_barang, nama_barang, jenis, satuan, harga_beli, harga_jual, stock from tblbarang", conn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                ListView1.Items.Add(dr.Item(0).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(1).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(2).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(3).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(4).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(5).ToString())
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item(6).ToString())
            End While
            dr.Close()
        End If
        dr.Close()
        cmd.Dispose()
    End Sub

End Class