-- =====================================================================
-- Skrip Database MySQL untuk Desktop Programming - Week 11
-- Database: dbweek10 (Disesuaikan dengan database tugas sebelumnya)
-- =====================================================================

CREATE DATABASE IF NOT EXISTS dbweek10
CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;

USE dbweek10;

-- ---------------------------------------------------------------------
-- 1. Tabel users (Dibutuhkan untuk dropdown kasir/user di form order)
-- ---------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `users` (
    `id` INT AUTO_INCREMENT PRIMARY KEY,
    `username` VARCHAR(50) NOT NULL UNIQUE,
    `password` VARCHAR(255) NULL,
    `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Data Awal User (Contoh: tono seperti pada modul soal)
INSERT IGNORE INTO `users` (`id`, `username`) VALUES
(1, 'tono'),
(2, 'admin'),
(3, 'kasir');

-- ---------------------------------------------------------------------
-- 2. Tabel Master Satuan (dari Week 10)
-- ---------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `tblsatuan` (
    `no` INT NOT NULL PRIMARY KEY,
    `satuan` VARCHAR(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT IGNORE INTO `tblsatuan` (`no`, `satuan`) VALUES
(1, 'Pcs'),
(2, 'Kg'),
(3, 'AA'),
(4, 'Gr'),
(5, 'Pak'),
(6, 'Rim');

-- ---------------------------------------------------------------------
-- 3. Tabel Master Barang (dari Week 10)
-- ---------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `tblbarang` (
    `Kode_Barang` VARCHAR(50) NOT NULL PRIMARY KEY,
    `Nama_Barang` VARCHAR(50) NOT NULL,
    `Jenis` VARCHAR(50) NOT NULL,
    `Satuan` VARCHAR(50) NOT NULL,
    `Harga_Beli` INT NOT NULL DEFAULT 0,
    `Harga_Jual` INT NOT NULL DEFAULT 0,
    `Stock` INT NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Data Awal Barang (Termasuk data Week 10 dan produk di screenshot Week 11)
INSERT IGNORE INTO `tblbarang` (`Kode_Barang`, `Nama_Barang`, `Jenis`, `Satuan`, `Harga_Beli`, `Harga_Jual`, `Stock`) VALUES
('BRG001', 'Pensil 2B', 'Alat Tulis', 'Pcs', 1500, 2500, 100),
('BRG002', 'Buku Tulis 40 Lembar', 'Alat Tulis', 'Pcs', 2500, 4000, 76),
('BRG003', 'Pulpen', 'Alat Tulis', 'Pcs', 2000, 3500, 110),
('BRG004', 'Penggaris', 'Alat Tulis', 'Pcs', 3000, 5000, 60),
('BRG005', 'Stabilo', 'Alat Tulis', 'Pcs', 6000, 7500, 50),
('BRG006', 'Kertas A4 80gsm', 'Kertas', 'Pcs', 4500, 5500, 50);

-- Update jika nama BRG002 masih 'Buku Tulis' agar sesuai screenshot modul:
UPDATE `tblbarang` SET `Nama_Barang` = 'Buku Tulis 40 Lembar' WHERE `Kode_Barang` = 'BRG002' AND `Nama_Barang` = 'Buku Tulis';

-- ---------------------------------------------------------------------
-- 4. Tabel Header Transaksi (orders)
-- ---------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `orders` (
    `order_id` INT AUTO_INCREMENT PRIMARY KEY,
    `order_no` VARCHAR(30) NOT NULL,
    `user_id` INT NOT NULL,
    `order_date` DATE NOT NULL,
    `total` DECIMAL(18, 2) NOT NULL DEFAULT 0.00,
    `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT `fk_orders_user` FOREIGN KEY (`user_id`) REFERENCES `users` (`id`) ON UPDATE CASCADE ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- ---------------------------------------------------------------------
-- 5. Tabel Detail Transaksi (orders_detail)
-- ---------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `orders_detail` (
    `id` INT AUTO_INCREMENT PRIMARY KEY,
    `order_id` INT NOT NULL,
    `kode_barang` VARCHAR(50) NOT NULL,
    `qty` INT NOT NULL,
    `unit_price` DECIMAL(18, 2) NOT NULL DEFAULT 0.00,
    `subtotal` DECIMAL(18, 2) NOT NULL DEFAULT 0.00,
    CONSTRAINT `fk_detail_order` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`) ON UPDATE CASCADE ON DELETE CASCADE,
    CONSTRAINT `fk_detail_barang` FOREIGN KEY (`kode_barang`) REFERENCES `tblbarang` (`Kode_Barang`) ON UPDATE CASCADE ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

