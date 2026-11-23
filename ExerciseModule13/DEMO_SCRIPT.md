# NASKAH DEMO LAYAR (SCREEN RECORDING SCRIPT)
## Modul Praktikum Week 13: SHA-256 Hashing, RBAC, dan Dashboard Integration
**Mata Kuliah:** Pemrograman Desktop (VB.NET & MySQL)  
**Target Durasi:** Maksimal 5 Menit (Total Waktu: 04:45)  
**Bahasa Narasi:** Bahasa Indonesia  

---

### TABEL RINGKASAN TIMELINE (OVERVIEW)

| Bagian | Timestamp | Topik / Adegan | Fokus Pengujian (Modul Bab 8.1) |
|---|---|---|---|
| **1** | `00:00 - 00:35` | Struktur Project & Arsitektur Solusi | Verifikasi referensi library & struktur modul |
| **2** | `00:35 - 01:05` | Menjalankan Aplikasi & FormLogin | Inisialisasi Startup Form & UI Flat Design |
| **3** | `01:05 - 01:50` | Pengujian Login Gagal & Pertahanan SQL Injection | Checklist 1 (Invalid Pass) & Checklist 2 (SQL Injection) |
| **4** | `01:50 - 02:25` | Login Admin & Verifikasi Identitas | Checklist 3 (Admin Role Permissions) |
| **5** | `02:25 - 03:20` | Demonstrasi RBAC Admin & Fitur Penuh | Akses Master Barang, Transaksi, Laporan, & KPI/Chart |
| **6** | `03:20 - 03:55` | Transisi: Logout Admin & Login Cashier | Dialog Konfirmasi Logout & Transisi FormLogin |
| **7** | `03:55 - 04:35` | Demonstrasi RBAC Cashier (Master & Report Hidden) | Checklist 4 (Cashier Role Permissions & Hidden Menus) |
| **8** | `04:35 - 04:45` | Logout Cashier & Penutup | Dialog Konfirmasi Logout & Ringkasan Akhir |

---

### PRASYARAT SEBELUM RECORDING
1. Database MySQL aktif dan skrip `dbtrial_setup.sql` telah dieksekusi di database `dbtrial`.
2. Visual Studio terbuka dengan project `ExerciseModule13`.
3. Resolusi layar direkomendasikan 1920x1080 (1080p) dengan rasio 16:9.

---

## NASKAH LENGKAP DEMO SCREENPLAY

---

### BAGIAN 1: STRUKTUR PROJECT & ARSITEKTUR SOLUSI
* **Timestamp:** `00:00 - 00:35` (Durasi: 35 detik)
* **Tindakan Layar (Screen Action):**
  1. Arahkan kursor pada jendela Visual Studio IDE.
  2. Buka panel **Solution Explorer**, lakukan *expand* pada struktur folder dan file project.
  3. Sorot file `ExerciseModule13.vbproj`, `ModuleKoneksi.vb`, `ModuleSecurity.vb`, `FormLogin.vb`, `FormDashboard.vb`, `dbtrial_setup.sql`, dan `DEMO_SCRIPT.md`.
  4. Buka sejenak file `ModuleSecurity.vb` untuk memperlihatkan fungsi `HashSHA256()`.
* **Expected Visual:**
  - Jendela Visual Studio menampilkan hierarki project yang rapi di Solution Explorer.
  - Daftar referensi menampilkan `MySql.Data` dan `System.Windows.Forms.DataVisualization`.
  - Editor memperlihatkan implementasi algoritma SHA-256 menggunakan namespace `System.Security.Cryptography` yang mengembalikan string heksadesimal 64 karakter.
* **Narasi (Voice-Over):**
  > "Halo semuanya. Pada video demo kali ini, saya akan mendemonstrasikan implementasi keamanan autentikasi SHA-256, Role-Based Access Control atau RBAC, serta integrasi Main Dashboard pada aplikasi desktop berbasis VB.NET dan database MySQL dbtrial.
  > 
  > Sebelum menjalankan program, mari kita perhatikan struktur project pada Solution Explorer. Di sini kita memiliki `ModuleKoneksi.vb` untuk manajemen koneksi ADO.NET MySQL, `ModuleSecurity.vb` yang mengenkripsi password dengan algoritma hash SHA-256 64-karakter, FormLogin sebagai startup form, dan FormDashboard sebagai dashboard utama. Modul Master, Transaction, dan Report belum masuk scope minggu ini, sehingga tombol navigasinya hanya menampilkan placeholder."

---

### BAGIAN 2: MENJALANKAN APLIKASI & TAMPILAN FORMLOGIN
* **Timestamp:** `00:35 - 01:05` (Durasi: 30 detik)
* **Tindakan Layar (Screen Action):**
  1. Klik tombol **Start** / Run (F5) pada toolbar Visual Studio.
  2. Tunggu proses kompilasi hingga jendela dialog `FormLogin` muncul tepat di tengah layar (*CenterScreen*).
  3. Sorot elemen-elemen FormLogin: Banner atas, TextBox Username, TextBox Password bertopeng karakter sandi, CheckBox "Show Password", tombol LOGIN, dan tombol EXIT.
  4. Ketik beberapa karakter di password, centang CheckBox "Show Password", lalu hilangkan centangnya kembali.
* **Expected Visual:**
  - Aplikasi terbuka dengan mulus tanpa kendala runtime.
  - Tampil window `FormLogin` dengan `FormBorderStyle = FixedSingle` dan `MaximizeBox = False`.
  - Banner atas berwarna biru navy (`#1B365D`) dengan teks judul putih tebal: **SYSTEM LOGIN**.
  - Kolom teks password menggunakan `UseSystemPasswordChar = True`. Saat "Show Password" dicentang, teks sandi terbaca; saat di-uncheck, karakter kembali tertutup bulatan sandi.
* **Narasi (Voice-Over):**
  > "Kita jalankan aplikasi dengan menekan tombol Start. Aplikasi secara otomatis membuka FormLogin sebagai form awal di posisi tengah layar. 
  > 
  > Antarmuka login dirancang bersih dengan tema Flat UI. Di sini terdapat input Username, Password dengan proteksi karakter masking, fitur 'Show Password' untuk kenyamanan pengguna, serta tombol aksi Login dan Exit."

---

### BAGIAN 3: PENGUJIAN LOGIN GAGAL & PERTAHANAN SQL INJECTION
* **Timestamp:** `01:05 - 01:50` (Durasi: 45 detik)
* **Tindakan Layar (Screen Action):**
  1. **Uji 1 (Validasi Kosong):** Biarkan username dan password kosong, klik tombol **LOGIN**.
  2. **Uji 2 (Password Salah - Modul Bab 8.1 No. 1):**
     - Masukkan Username: `admin`
     - Masukkan Password: `wrong123`
     - Klik tombol **LOGIN**.
     - Setelah MessageBox muncul, klik tombol **OK**.
  3. **Uji 3 (Pertahanan SQL Injection - Modul Bab 8.1 No. 2):**
     - Masukkan Username: `' OR '1'='1`
     - Masukkan Password: `anypassword`
     - Klik tombol **LOGIN**.
     - Klik **OK** pada dialog penolakan.
* **Expected Visual:**
  - Saat input kosong: Muncul `MessageBox` warning dengan pesan *"Please enter both Username and Password."*
  - Saat password salah (`wrong123`): Muncul `MessageBox` error berikon silang merah bertajuk *"Authentication Failed"* dengan pesan *"Invalid username or password."*. Kolom password otomatis dikosongkan dan kursor terfokus kembali ke `txtPassword`.
  - Saat injeksi SQL (`' OR '1'='1`): Sistem tetap menolak autentikasi dan menampilkan *"Invalid username or password."*. Aplikasi tidak crash, query tidak bocor, membuktikan bahwa Parameterized Query (`@user`, `@pass`) bekerja efektif menolak manipulasi sintaks SQL.
* **Narasi (Voice-Over):**
  > "Sekarang kita masuki skenario pengujian keamanan sesuai Bab 8.1 Modul Praktikum.
  > 
  > Pertama, validasi field kosong: sistem langsung memberi peringatan jika input belum diisi.
  > 
  > Kedua, kita uji login dengan password salah: kita masukkan username 'admin' dengan password 'wrong123'. Sistem meng-hash input ini ke SHA-256 lalu memverifikasinya ke database dbtrial. Hasilnya otentikasi ditolak dengan alert 'Invalid username or password', dan kotak sandi langsung dibersihkan.
  > 
  > Ketiga, kita uji pertahanan terhadap serangan SQL Injection dengan memasukkan karakter kutip bypass: petik satu OR satu sama dengan satu. Seperti yang kita lihat, sistem tetap menolaknya dengan aman. Ini karena query menggunakan Parameterized Query MySqlCommand, di mana seluruh input diperlakukan murni sebagai nilai literal teks, bukan sintaks perintah SQL yang dapat dieksekusi."

---

### BAGIAN 4: LOGIN ADMIN & VERIFIKASI IDENTITAS
* **Timestamp:** `01:50 - 02:25` (Durasi: 35 detik)
* **Tindakan Layar (Screen Action):**
  1. Bersihkan kedua kolom input login.
  2. Masukkan Username: `admin`
  3. Masukkan Password: `admin123`
  4. Klik tombol **LOGIN**.
* **Expected Visual:**
  - `FormLogin` disembunyikan (`Me.Hide()`).
  - Jendela `FormDashboard` terbuka dalam status layar penuh (**Maximized**).
  - Pada area **Top Header Bar** (`pnlHeader`), di sudut kanan atas tertera label identitas autentikasi:  
    `User: System Administrator  |  Role: Admin`
  - Pada area **Left Sidebar** (`pnlSidebar`), seluruh tombol navigasi tampil lengkap secara vertikal:
    - `btnNavDashboard` ("Dashboard")
    - `btnNavMaster` ("Master Barang")
    - `btnNavTransaction` ("Transaction")
    - `btnNavReport` ("Report")
    - `btnLogout` ("Logout" di posisi paling bawah)
* **Narasi (Voice-Over):**
  > "Kini kita lakukan pengujian skenario ketiga: login sebagai Admin menggunakan kredensial valid, username 'admin' dan password 'admin123'. Kita klik Login.
  > 
  > FormLogin berhasil diverifikasi dan langsung membuka FormDashboard dalam mode layar penuh. Perhatikan area header kanan atas: sistem membaca dan menampilkan data pengguna aktif, yaitu 'User: System Administrator | Role: Admin'. 
  > 
  > Metode ApplyRoleAccess() membaca peran Admin, sehingga seluruh menu navigasi pada sidebar kiri ditampilkan secara utuh: Dashboard, Master Barang, Transaction, dan Report."

---

### BAGIAN 5: DEMONSTRASI RBAC ADMIN & KPI DASHBOARD
* **Timestamp:** `02:25 - 03:20` (Durasi: 55 detik)
* **Tindakan Layar (Screen Action):**
  1. **Sorot Dashboard Overview:** Arahkan kursor ke kartu KPI (Total Transaksi Hari Ini dan Total Pendapatan Hari Ini) serta grafik batang (Column Chart) "Top 5 Best-Selling Items".
  2. **Uji Menu Admin:** Klik tombol sidebar **Master Barang**, **Transaction**, dan **Report** secara bergantian.
  3. Setiap klik menampilkan MessageBox placeholder *"Coming Soon"* karena modul tersebut belum termasuk scope minggu ini. Klik **OK** untuk menutupnya.
  4. Klik kembali **Dashboard** untuk memastikan metrik tetap tampil setelah navigasi.
* **Expected Visual:**
  - **KPI Cards & Chart:**
    - Kartu KPI 1 (`lblTotalTrx`): Menampilkan total order hari ini (hasil query `CURDATE()`, bernilai 3 transaksi).
    - Kartu KPI 2 (`lblTotalRevenue`): Menampilkan total pendapatan hari ini (format `Rp 13.815.000`).
    - Grafik Batang (`chrSalesTrend`): Memuat 5 batang produk terlaris dengan label angka penjualan di atas batang (Mouse Wireless Logitech, Flashdisk SanDisk, Monitor LG, Headset HyperX, Laptop ASUS).
  - **Nav Admin:** Keempat tombol (`Dashboard`, `Master Barang`, `Transaction`, `Report`) terlihat. Klik Master/Transaction/Report memunculkan placeholder, bukan form baru.
* **Narasi (Voice-Over):**
  > "Mari kita cermati komponen Dashboard. Data metrik terisi otomatis berkat skrip inisialisasi dbtrial_setup.sql: kartu KPI Total Orders Hari Ini menunjukkan 3 transaksi, Total Revenue menampilkan omset hari ini, dan grafik kolom Sales Trend menampilkan 5 produk terlaris secara visual dan dinamis.
  > 
  > Sebagai Admin, seluruh tombol navigasi tampil: Dashboard, Master Barang, Transaction, dan Report. Sesuai scope minggu ini, tombol Master Barang, Transaction, dan Report belum membuka modul penuh; tombol tersebut hanya menampilkan pesan placeholder 'Coming Soon'. hal ini membuktikan ApplyRoleAccess() memberikan hak penuh pada peran Admin."

---

### BAGIAN 6: TRANSISI: LOGOUT ADMIN & LOGIN CASHIER
* **Timestamp:** `03:20 - 03:55` (Durasi: 35 detik)
* **Tindakan Layar (Screen Action):**
  1. Klik tombol **Logout** pada bagian bawah sidebar kiri.
  2. Dialog konfirmasi muncul. Klik tombol **Yes**.
  3. FormDashboard tertutup, layar kembali menampilkan `FormLogin`.
  4. Masukkan Username: `cashier`
  5. Masukkan Password: `cashier123`
  6. Klik tombol **LOGIN**.
* **Expected Visual:**
  - Saat tombol Logout diklik, muncul `MessageBox` bertajuk *"Confirm Logout"* dengan pertanyaan *"Are you sure you want to log out?"* bersimbol tanda tanya dan pilihan tombol Yes/No.
  - Memilih **Yes** mengaktifkan flag `isLoggingOut = True`, menutup `FormDashboard`, dan menampilkan kembali `FormLogin` secara bersih.
  - Setelah input kredensial kasir dimasukkan dan tombol Login ditekan, sistem berhasil masuk dan membuka kembali `FormDashboard`.
* **Narasi (Voice-Over):**
  > "Sekarang kita uji mekanisme logout yang aman. Kita klik tombol Logout di bagian bawah sidebar. Sistem memunculkan dialog konfirmasi untuk mencegah pengguna keluar tanpa sengaja. Kita pilih 'Yes'. FormDashboard ditutup dan kita kembali ke FormLogin.
  > 
  > Selanjutnya, kita masuk ke skenario pengujian keempat pada Bab 8.1: autentikasi peran Kasir. Kita ketikkan username 'cashier' dan password 'cashier123', kemudian klik Login."

---

### BAGIAN 7: DEMONSTRASI RBAC CASHIER (MASTER & REPORT HIDDEN)
* **Timestamp:** `03:55 - 04:35` (Durasi: 40 detik)
* **Tindakan Layar (Screen Action):**
  1. Sorot bagian header kanan atas untuk melihat verifikasi identitas user.
  2. Sorot sidebar sebelah kiri: tunjukkan secara jelas bahwa menu **Master Barang** dan **Report** tidak lagi tampak di layar.
  3. Klik tombol **Transaction** untuk membuktikan tombol tersebut tetap terlihat bagi kasir. Muncul placeholder *"Coming Soon"*, klik **OK**.
  4. Klik tombol **Dashboard** untuk menunjukkan metrik penjualan tetap dapat dipantau oleh kasir.
* **Expected Visual:**
  - Header kanan atas berubah menjadi:  
    `User: Front Desk Cashier  |  Role: Cashier`
  - Sidebar navigasi kiri mengalami perubahan dinamis (hasil eksekusi fungsi `ApplyRoleAccess`):
    - Tombol `btnNavMaster` (Master Barang) berstatus `Visible = False` (tersembunyi).
    - Tombol `btnNavReport` (Report) berstatus `Visible = False` (tersembunyi).
    - Hanya tombol `Dashboard`, `Transaction`, dan `Logout` yang terlihat dan aktif.
  - Tombol `btnNavTransaction` tetap terlihat dan dapat diklik, tetapi hanya menampilkan placeholder karena modul transaksi belum masuk scope minggu ini.
* **Narasi (Voice-Over):**
  > "Perhatikan perbedaan mendasar pada hak akses kasir. Pada header atas, status telah berubah menjadi 'User: Front Desk Cashier | Role: Cashier'.
  > 
  > Sesuai aturan RBAC yang dirancang pada modul, peran Kasir tidak diberikan hak untuk memanipulasi master barang maupun melihat laporan keuangan. Logika ApplyRoleAccess() secara otomatis mengatur properti Visible tombol 'Master Barang' dan 'Report' menjadi False. Menu tersebut benar-benar hilang dari sidebar kiri.
  > 
  > Kasir tetap melihat Dashboard untuk memantau performa harian dan tombol Transaction, tetapi Master Barang dan Report benar-benar hilang. Hak akses berhasil terisolasi secara aman sesuai prinsip Role-Based Access Control."

---

### BAGIAN 8: LOGOUT CASHIER & PENUTUP
* **Timestamp:** `04:35 - 04:45` (Durasi: 10 detik)
* **Tindakan Layar (Screen Action):**
  1. Klik tombol **Logout** pada sidebar kasir.
  2. Klik **Yes** pada dialog konfirmasi.
  3. Aplikasi kembali ke `FormLogin`, lalu klik tombol **EXIT** untuk menghentikan aplikasi secara sempurna (`Application.Exit()`).
* **Expected Visual:**
  - Dialog konfirmasi logout muncul dan direspon dengan klik Yes.
  - FormLogin tampil kembali.
  - Saat tombol EXIT ditekan, seluruh jendela tertutup dan sesi debugging Visual Studio berakhir dengan status sukses (*exit code 0*).
* **Narasi (Voice-Over):**
  > "Terakhir, kita klik Logout, konfirmasi 'Yes', dan klik tombol EXIT untuk menutup aplikasi. 
  > 
  > Seluruh skenario pengujian pada Bab 3.1 dan 8.1 modul praktikum—mulai dari enkripsi SHA-256, perlindungan Parameterized Query terhadap SQL Injection, penegakan RBAC untuk Admin dan Cashier, hingga visualisasi KPI dashboard—telah terverifikasi bekerja dengan sempurna. Sekian demonstrasi ini, terima kasih."

---

### MATRIKS VERIFIKASI PENGUJIAN (BAB 8.1 MODUL)

| No | Skenario Uji | Tindakan / Input | Hasil yang Diharapkan | Status Hasil Uji Demo |
|:--:|---|---|---|:--:|
| **1** | **Invalid Password Login** | Username: `admin`, Password: `wrong123` | Pesan *"Invalid username or password."*, field password dikosongkan. | **SESUAI** (Bagian 3) |
| **2** | **SQL Injection Defense** | Username: `' OR '1'='1`, Password: `any` | Otentikasi ditolak; parameter query memperlakukan input sebagai string literal. | **SESUAI** (Bagian 3) |
| **3** | **Admin Role Permissions** | Login: `admin` / `admin123` | Header `Role: Admin`; Tombol Master Barang, Transaction, dan Report semuanya tampil (klik menampilkan placeholder). | **SESUAI** (Bagian 4 & 5) |
| **4** | **Cashier Role Permissions**| Login: `cashier` / `cashier123` | Header `Role: Cashier`; Tombol Master Barang dan Report tersembunyi (*hidden*). | **SESUAI** (Bagian 6 & 7) |
| **5** | **Live KPI & Chart Metrics**| Akses FormDashboard | Nilai pesanan hari ini (`CURDATE()`), total pendapatan, dan grafik batang Top 5 terisi. | **SESUAI** (Bagian 5 & 7) |
| **6** | **Secure Logout Handler** | Klik tombol Logout | Muncul dialog konfirmasi; jika Yes, menutup dashboard dan membuka FormLogin. | **SESUAI** (Bagian 6 & 8) |
