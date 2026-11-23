-- =============================================================================
-- Database Setup Script: dbtrial
-- Praktikum Pemrograman Desktop - Modul Week 13
-- Topik: SHA-256 Hashing, Role-Based Access Control (RBAC), Dashboard Integration
-- =============================================================================

-- 1. Inisialisasi Database
CREATE DATABASE IF NOT EXISTS dbtrial;
USE dbtrial;

-- =============================================================================
-- 2. Pembuatan Tabel Sesuai Spesifikasi Modul (Bab 3)
-- =============================================================================

-- Tabel 1: users (Penyimpanan akun, hash SHA-256 64-karakter, dan Role RBAC)
CREATE TABLE IF NOT EXISTS users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(64) NOT NULL,
    full_name VARCHAR(60) NOT NULL,
    role VARCHAR(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Tabel 2: tblsatuan (Tabel lookup referensi satuan barang)
CREATE TABLE IF NOT EXISTS tblsatuan (
    no INT AUTO_INCREMENT PRIMARY KEY,
    satuan VARCHAR(50) NOT NULL UNIQUE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Tabel 3: tblbarang (Master data barang / inventory)
CREATE TABLE IF NOT EXISTS tblbarang (
    Kode_Barang VARCHAR(50) PRIMARY KEY,
    Nama_Barang VARCHAR(50) NOT NULL,
    Jenis VARCHAR(50),
    Satuan VARCHAR(50),
    Harga_Beli INT NOT NULL DEFAULT 0,
    Harga_Jual INT NOT NULL DEFAULT 0,
    Stock INT NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Tabel 4: orders (Header transaksi penjualan)
CREATE TABLE IF NOT EXISTS orders (
    order_id INT AUTO_INCREMENT PRIMARY KEY,
    order_no VARCHAR(30) NOT NULL UNIQUE,
    user_id INT,
    order_date DATE NOT NULL,
    total DECIMAL(18,2) NOT NULL DEFAULT 0.00,
    CONSTRAINT fk_orders_user FOREIGN KEY (user_id) REFERENCES users(id)
        ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Tabel 5: orders_detail (Detail baris item penjualan)
CREATE TABLE IF NOT EXISTS orders_detail (
    detail_id INT AUTO_INCREMENT PRIMARY KEY,
    order_id INT NOT NULL,
    kode_barang VARCHAR(50) NOT NULL,
    qty INT NOT NULL DEFAULT 1,
    unit_price DECIMAL(18,2) NOT NULL DEFAULT 0.00,
    subtotal DECIMAL(18,2) NOT NULL DEFAULT 0.00,
    CONSTRAINT fk_detail_order FOREIGN KEY (order_id) REFERENCES orders(order_id)
        ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT fk_detail_barang FOREIGN KEY (kode_barang) REFERENCES tblbarang(Kode_Barang)
        ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- =============================================================================
-- 3. Migrasi & Pemastian Kolom Password (Modul Bab 3.1)
-- =============================================================================

-- Pastikan kolom password bertipe VARCHAR(64) untuk menampung digest SHA-256
ALTER TABLE users MODIFY COLUMN password VARCHAR(64) NOT NULL;

-- Konversi password plaintext warisan (panjang < 64) menjadi SHA-256 jika ada
UPDATE users
SET password = SHA2(password, 256)
WHERE CHAR_LENGTH(password) < 64 AND id > 0;

-- =============================================================================
-- 4. Seeding Data Akun Pengguna Demo (Admin & Cashier) (Modul Bab 3.1)
-- =============================================================================

-- Akun Default:
-- 1. admin   / admin123   -> Role: Admin   (Akses penuh)
-- 2. cashier / cashier123 -> Role: Cashier (Akses terbatas transaksi & dashboard)
INSERT IGNORE INTO users (id, username, password, full_name, role) VALUES
(1, 'admin',   SHA2('admin123', 256),   'System Administrator', 'Admin'),
(2, 'cashier', SHA2('cashier123', 256), 'Front Desk Cashier',   'Cashier');

-- =============================================================================
-- 5. Seeding Data Referensi Satuan (tblsatuan)
-- =============================================================================
INSERT IGNORE INTO tblsatuan (no, satuan) VALUES
(1, 'Pcs'),
(2, 'Box'),
(3, 'Unit'),
(4, 'Pack'),
(5, 'Lusin');

-- =============================================================================
-- 6. Seeding Master Data Barang (tblbarang - Minimal 5 Baris)
-- =============================================================================
INSERT IGNORE INTO tblbarang (Kode_Barang, Nama_Barang, Jenis, Satuan, Harga_Beli, Harga_Jual, Stock) VALUES
('BRG001', 'Laptop ASUS Vivobook',    'Elektronik', 'Unit', 6500000, 7500000, 25),
('BRG002', 'Mouse Wireless Logitech', 'Aksesoris',  'Pcs',   120000,  165000, 50),
('BRG003', 'Keyboard Mechanical RGB', 'Aksesoris',  'Unit',  350000,  450000, 30),
('BRG004', 'Monitor LG 24 Inch',      'Elektronik', 'Unit', 1400000, 1750000, 15),
('BRG005', 'Flashdisk SanDisk 64GB',  'Storage',    'Pcs',    65000,   95000, 80),
('BRG006', 'Headset Gaming HyperX',   'Aksesoris',  'Unit',  450000,  580000, 20);

-- =============================================================================
-- 7. Seeding Transaksi Penjualan (orders & orders_detail - Minimal 3 Orders)
-- Tanggal menggunakan CURDATE() agar KPI Dashboard dan Chart terisi saat pengujian
-- =============================================================================

-- Header Orders (3 transaksi hari ini)
INSERT INTO orders (order_id, order_no, user_id, order_date, total)
SELECT 1, 'ORD-INIT-001', id, CURDATE(), 710000.00 FROM users WHERE username = 'cashier' LIMIT 1
ON DUPLICATE KEY UPDATE order_date = CURDATE(), total = VALUES(total);

INSERT INTO orders (order_id, order_no, user_id, order_date, total)
SELECT 2, 'ORD-INIT-002', id, CURDATE(), 7950000.00 FROM users WHERE username = 'cashier' LIMIT 1
ON DUPLICATE KEY UPDATE order_date = CURDATE(), total = VALUES(total);

INSERT INTO orders (order_id, order_no, user_id, order_date, total)
SELECT 3, 'ORD-INIT-003', id, CURDATE(), 5155000.00 FROM users WHERE username = 'admin' LIMIT 1
ON DUPLICATE KEY UPDATE order_date = CURDATE(), total = VALUES(total);

-- Detail Orders (Item transaksi untuk mengisi grafik Top 5 Best-Selling Items)
-- Order 1: Mouse Wireless (2 pcs), Flashdisk (4 pcs) -> total 710.000
INSERT IGNORE INTO orders_detail (detail_id, order_id, kode_barang, qty, unit_price, subtotal) VALUES
(1, 1, 'BRG002', 2, 165000.00, 330000.00),
(2, 1, 'BRG005', 4,  95000.00, 380000.00);

-- Order 2: Laptop ASUS (1 unit), Keyboard Mechanical (1 unit) -> total 7.950.000
INSERT IGNORE INTO orders_detail (detail_id, order_id, kode_barang, qty, unit_price, subtotal) VALUES
(3, 2, 'BRG001', 1, 7500000.00, 7500000.00),
(4, 2, 'BRG003', 1,  450000.00,  450000.00);

-- Order 3: Mouse Wireless (3 pcs), Monitor LG (2 unit), Headset Gaming (2 unit) -> total 5.155.000
INSERT IGNORE INTO orders_detail (detail_id, order_id, kode_barang, qty, unit_price, subtotal) VALUES
(5, 3, 'BRG002', 3,  165000.00,  495000.00),
(6, 3, 'BRG004', 2, 1750000.00, 3500000.00),
(7, 3, 'BRG006', 2,  580000.00, 1160000.00);

-- =============================================================================
-- 8. Verifikasi Data (Sesuai Bab 3.1 & 8.1)
-- =============================================================================

-- Cek Akun Pengguna
SELECT id, username, password, full_name, role FROM users;

-- Cek KPI Dashboard Hari Ini (Modul FormDashboard: LoadDashboardMetrics)
SELECT 
    COUNT(*) AS total_orders_today,
    IFNULL(SUM(total), 0) AS total_revenue_today
FROM orders 
WHERE order_date = CURDATE();

-- Cek Top 5 Best-Selling Items untuk Chart chrSalesTrend
SELECT 
    b.Nama_Barang, 
    SUM(d.qty) AS total_sold
FROM orders_detail d
JOIN tblbarang b ON d.kode_barang = b.Kode_Barang
GROUP BY b.Kode_Barang, b.Nama_Barang
ORDER BY total_sold DESC 
LIMIT 5;
