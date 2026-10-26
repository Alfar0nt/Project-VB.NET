create database db_module9;

USE db_module9;
 
CREATE TABLE IF NOT EXISTS `user` (
    user_id   INT AUTO_INCREMENT PRIMARY KEY,
    username  VARCHAR(50)  NOT NULL UNIQUE,
    password  VARCHAR(100) NOT NULL,
    role      VARCHAR(20)  NOT NULL DEFAULT 'kasir'
) ENGINE=InnoDB;
 
CREATE TABLE IF NOT EXISTS tblbarang (
    kode_barang VARCHAR(20)  PRIMARY KEY,
    nama_barang VARCHAR(100) NOT NULL,
    harga       DECIMAL(15,2) NOT NULL DEFAULT 0,
    stok        INT NOT NULL DEFAULT 0
) ENGINE=InnoDB;
 
CREATE TABLE IF NOT EXISTS order_counter (
    order_date DATE PRIMARY KEY,
    last_seq   INT NOT NULL DEFAULT 0
) ENGINE=InnoDB;
 
CREATE TABLE IF NOT EXISTS orders (
    order_id   INT AUTO_INCREMENT PRIMARY KEY,
    order_no   VARCHAR(25) NOT NULL,
    user_id    INT NOT NULL,
    order_date DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    total      DECIMAL(15,2) NOT NULL DEFAULT 0,
    CONSTRAINT uq_orders_order_no UNIQUE (order_no),
    CONSTRAINT fk_orders_user FOREIGN KEY (user_id) REFERENCES `user`(user_id)
) ENGINE=InnoDB;
 
CREATE TABLE IF NOT EXISTS orders_detail (
    detail_id   INT AUTO_INCREMENT PRIMARY KEY,
    order_id    INT NOT NULL,
    kode_barang VARCHAR(20) NOT NULL,
    qty         INT NOT NULL CHECK (qty > 0),
    unit_price  DECIMAL(15,2) NOT NULL,
    subtotal    DECIMAL(15,2) NOT NULL,
    CONSTRAINT fk_detail_order  FOREIGN KEY (order_id)    REFERENCES orders(order_id),
    CONSTRAINT fk_detail_barang FOREIGN KEY (kode_barang) REFERENCES tblbarang(kode_barang)
) ENGINE=InnoDB;
 
INSERT IGNORE INTO `user` (username, password, role) VALUES
 ('dhiarKasir', '123', 'kasir'),
 ('dhiarAdmin',  '123', 'admin');
 
INSERT IGNORE INTO tblbarang (kode_barang, nama_barang, harga, stok) VALUES
 ('BRG001', 'Pulpen',   3000,   100),
 ('BRG002', 'Buku Tulis', 5000,  50),
 ('BRG003', 'Penghapus', 2000,    5);
 
-- SELECT * FROM orders;
-- SELECT * FROM orders_detail;
-- SELECT * FROM order_counter;