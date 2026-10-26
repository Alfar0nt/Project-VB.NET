1\. Logika Penomoran Order



Format: ORD-yyyyMMdd-0001, yaitu tanggal order dan nomor urut harian 4 digit, misalnya ORD-20261020-0001.



Cara kerja: nomor tidak memakai MAX(order\_no) + 1, karena dua kasir yang menyimpan bersamaan bisa membaca nilai MAX yang sama dan mendapat nomor kembar. Sebagai gantinya dipakai tabel order\_counter yang menyimpan satu baris per tanggal beserta urutan terakhirnya (last\_seq). Saat Save, urutan dinaikkan di dalam transaksi dengan satu perintah SQL:



sql

INSERT INTO order\_counter (order\_date, last\_seq) VALUES (@d, 1)

ON DUPLICATE KEY UPDATE last\_seq = last\_seq + 1



Baris counter terkunci oleh database sampai transaksi COMMIT atau ROLLBACK. Kasir kedua harus menunggu kasir pertama selesai, sehingga tidak mungkin ada dua order dengan nomor sama. Pengamannya ada dua lapis:



Lapis aplikasi: counter yang dikunci database.

Lapis database: constraint UNIQUE pada kolom order\_no.



Nomor read-only dan preview: kotak Order Number tidak bisa diedit. Saat tanggal diganti, kotak hanya menampilkan perkiraan nomor berikutnya tanpa mengubah counter. Nomor final baru diambil saat Save, lalu ditampilkan di kotak yang sama.



Lokasi kode:



Bagian	File	Lokasi

Tabel counter	schema\_order.sql	CREATE TABLE order\_counter

Constraint unik	schema\_order.sql	CONSTRAINT uq\_orders\_order\_no UNIQUE (order\_no) di tabel orders

Preview nomor	FormOrder.vb	Sub RefreshOrderNumberPreview() dan dtpOrderDate\_ValueChanged

Nomor final	FormOrder.vb	btnSave\_Click, bagian komentar ' 2. Nomor order unik berbasis database

Kotak read-only	FormOrder.Designer.vb	txtOrderNumber.ReadOnly = True

2\. Penanganan Error



a. Validasi input (ErrorProvider). Input yang salah ditandai ikon seru merah di samping kontrol:



User atau Product belum dipilih.

Quantity kosong, bukan angka (abc), nol, atau negatif.

Quantity melebihi stok. Ini dicek di database saat Save, bukan hanya di layar.



Lokasi: Function ValidateQty, txtQuantity\_Validating, dan blok ' ---- Validasi input ---- di awal btnSave\_Click.



b. Try...Catch dengan jenis exception yang relevan. Semua proses simpan ada di dalam Try, dengan Catch terpisah dan pesan yang mudah dipahami:



Exception	Kapan terjadi	Pesan untuk pengguna

ApplicationException	Stok kurang, user atau produk tidak ditemukan	Pesan bisnis, misalnya “Stok tidak cukup”

MySqlException	Masalah database (kode 1062 duplikat, 1452 relasi tidak valid, 1213 konflik, 2003 koneksi gagal)	Pesan sesuai kode error

InvalidCastException, NullReferenceException	Tipe data tidak cocok atau data belum terisi	Pesan kesalahan data

Exception	Kesalahan tak terduga	Pesan umum, aplikasi tidak crash



Lokasi: blok Try ... Catch ... Finally di btnSave\_Click. Ada juga Try...Catch di FormOrder\_Load untuk koneksi awal.



c. Transaksi dan rollback. Pembuatan nomor, header (orders), detail (orders\_detail), dan pengurangan stok berjalan dalam satu transaksi (conn.BeginTransaction()). Jika ada langkah yang gagal, SafeRollback(trx) membatalkan semuanya, jadi tidak ada header tanpa detail dan stok tidak berkurang sendiri. Jika semua berhasil, trx.Commit() dijalankan. Finally menutup koneksi di kedua kasus.



Lokasi: BeginTransaction, trx.Commit(), dan Sub SafeRollback di FormOrder.vb.



3\. Hasil Pengujian



Tabel ini berisi hasil yang diharapkan dari kode. Silakan cocokkan dengan hasil asli di komputer Anda saat merekam, lalu ubah kolom hasil jika ada yang berbeda.



No	Skenario	Input	Hasil

1	Order berhasil	User tono, Map Plastik, qty 4	Tersimpan, nomor ORD-20261020-0001, total Rp 12.000,00

2	Order kedua	Clear, lalu simpan order lain	Nomor berubah menjadi -0002, tidak ada duplikat

3	Tanggal berbeda	Pilih tanggal lain	Nomor urut mulai lagi dari -0001 untuk tanggal itu

4	Quantity kosong	(kosong)	Ditolak, “Quantity tidak boleh kosong”

5	Quantity bukan angka	abc	Ditolak, “harus berupa angka bulat”

6	Quantity nol atau negatif	0 dan -5	Ditolak, “harus lebih besar dari 0”

7	User belum dipilih	User kosong	Ditolak, “User harus dipilih”

8	Product belum dipilih	Product kosong	Ditolak, “Product harus dipilih”

9	Quantity melebihi stok	Qty lebih besar dari stok	Ditolak, “Stok tidak cukup”, data tidak tersimpan

10	Database mati	Stop MySQL, lalu Save	Pesan “Tidak dapat terhubung ke server database”, aplikasi tidak crash



Setelah tiap skenario gagal, tunjukkan di MySQL bahwa data tidak bertambah:



sql

SELECT \* FROM orders;

SELECT \* FROM orders\_detail;

SELECT \* FROM order\_counter;

Saran Alur Video (maks. 5 menit)

0:00–0:30: perkenalan, tampilkan form dan struktur database.

0:30–1:30: demo sukses (skenario 1 dan 2), lalu tunjukkan isi tabel di MySQL.

1:30–3:30: demo gagal (skenario 4 sampai 9), tunjukkan ErrorProvider dan pesan error.

3:30–4:15: buka kode, jelaskan order\_counter dan btnSave\_Click (nomor, transaksi, rollback).

4:15–5:00: demo database mati (skenario 10), lalu tutup dengan ringkasan.



Jika ingin demo bahwa dua kasir tidak mendapat nomor sama, jalankan aplikasi dua kali (dua jendela) lalu tekan Save hampir bersamaan. Hasilnya harus dua nomor berbeda berurutan.

