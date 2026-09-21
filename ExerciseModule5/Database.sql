create database pemdesk;
use pemdesk;

CREATE TABLE IF NOT EXISTS tblbarang (
    Kode_Barang VARCHAR(50) PRIMARY KEY,
    Nama_Barang VARCHAR(50),
    Jenis VARCHAR(50),
    Satuan VARCHAR(50),
    Harga_Beli INT,
    Harga_Jual INT,
    Stock INT
);

show tables;
describe tblbarang;
