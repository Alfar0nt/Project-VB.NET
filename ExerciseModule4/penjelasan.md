# Penjelasan Kode ExerciseModule4

Program Form aplikasi VB.NET untuk input data mahasiswa (NPM, Nama, Prodi, Jenis Kelamin, Semester, No Telepon, dan UKM).

## Form1.vb

### Deklarasi Variabel
- `Dim arr(,) As String` — array 2 dimensi untuk menyimpan data mahasiswa (baris = data ke-i, kolom = field).
- `Dim i As Integer` — penunjuk baris data (indeks data berikutnya).

### Form1_Load (Form1.vb:4-16)
- `ReDim arr(20, 6)` — menyiapkan array berkapasitas 21 baris dan 7 kolom (kolom extra untuk UKM).
- `Dim semester() As Integer = {1,...,8}` — array 1 dimensi berisi semester 1-8, di-loop dengan `For` lalu ditambahkan ke `CbSemester.Items` dengan `Add()`.
- `Dim ukm() As String = {"E-Sport", "Renang", "Basket", "Volly", "UKKI"}` — array 1 dimensi berisi pilihan UKM, di-loop ke `CheckedListBox1` agar muncul sebagai opsi dengan checkbox.

### btnOk_Click (Form1.vb:18-74)
- Menyimpan isi TextBox dan pilihan ke `arr(i, ...)`: NPM, Nama, Prodi.
- `If RbLakilaki.Checked ... ElseIf RbPerempuan.Checked` — menentukan jenis kelamin sesuai RadioButton yang dipilih.
- Menyimpan semester dari `CbSemester.Text` dan telepon dari `tbTelepon.Text`.
- Looping `CheckedListBox1.GetItemChecked(t)` — mengecek tiap item UKM; yang tercentang digabung dengan koma ke `strUkm`, lalu disimpan ke `arr(i, 6)`.
- `i += 1` lalu `MsgBox("data sukses ditambah")` — pindah ke baris berikutnya dan memberi notifikasi.
- `lvDataMahasiswa.Items.Clear()` lalu loop `For K = 0 To arr.GetUpperBound(0)` — menampilkan ulang seluruh array ke ListView; `If arr(K, 0) <> Nothing` agar baris kosong tidak ikut tampil.
- Loop pengecekan `Me.Controls` — membersihkan form: TextBox dikosongkan, ComboBox di-reset (`SelectedItem = Nothing`), RadioButton di-uncheck, dan CheckedListBox di-`Clear()` lalu diisi ulang dari array UKM (reset ukum saat Save).

### btPrint_Click (Form1.vb:76-85)
- Menggabungkan semua data dari array ke variabel `Str` (hanya baris terisi), lalu ditampilkan lewat `MsgBox(Str)`.

## Form1.Designer.vb
- Mendefinisikan komponen UI: Label, TextBox (`tbName`, `tbNPM`, `tbProdi`, `tbTelepon`), RadioButton (`RbLakilaki`, `RbPerempuan`), ComboBox `CbSemester` (DropDownList, item diisi dari kode), CheckedListBox `CheckedListBox1`, tombol `btnOk` (Save) dan `btPrint` (Tampilkan).
- `Label7` = label "UKM" di atas CheckedListBox.
- `lvDataMahasiswa` — ListView mode Details dengan 7 kolom (`ColumnHeader1`-`ColumnHeader7`; kolom ke-7 "UKM").
- Item semester tidak lagi ditulis hardcoded di designer, melainkan diisi lewat array di `Form1_Load`.