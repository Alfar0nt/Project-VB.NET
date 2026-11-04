CREATE DATABASE IF NOT EXISTS dbweek10
CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;

USE dbweek10;

-- 1. Tabel Master Satuan
CREATE TABLE IF NOT EXISTS tblsatuan (
    `no` INT NOT NULL PRIMARY KEY,
    `satuan` VARCHAR(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- 2. Tabel Master Barang
CREATE TABLE IF NOT EXISTS tblbarang (
    `Kode_Barang` VARCHAR(50) NOT NULL PRIMARY KEY,
    `Nama_Barang` VARCHAR(50) NOT NULL,
    `Jenis` VARCHAR(50) NOT NULL,
    `Satuan` VARCHAR(50) NOT NULL,
    `Harga_Beli` INT NOT NULL DEFAULT 0,
    `Harga_Jual` INT NOT NULL DEFAULT 0,
    `Stock` INT NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Data Awal Master Satuan
INSERT IGNORE INTO tblsatuan (`no`, `satuan`) VALUES
(1, 'Pcs'),
(2, 'Kg'),
(3, 'AA'),
(4, 'Gr'),
(5, 'Pak');

-- Data Awal Master Barang
INSERT IGNORE INTO tblbarang (`Kode_Barang`, `Nama_Barang`, `Jenis`, `Satuan`, `Harga_Beli`, `Harga_Jual`, `Stock`) VALUES
('BRG001', 'Pensil 2B', 'Alat Tulis', 'Pcs', 1500, 2500, 100),
('BRG002', 'Buku Tulis', 'Alat Tulis', 'Pcs', 2500, 4000, 76),
('BRG003', 'Pulpen', 'Alat Tulis', 'Pcs', 2000, 3500, 110),
('BRG004', 'Penggaris', 'Alat Tulis', 'Pcs', 3000, 5000, 60),
('BRG005', 'Stabilo', 'Alat Tulis', 'Pcs', 6000, 7500, 50);