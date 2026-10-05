create database db_vbnet;

use db_vbnet;

CREATE TABLE students (
 student_id VARCHAR(10) PRIMARY KEY,
 student_name VARCHAR(100) NOT NULL,
 major VARCHAR(50),
 phone VARCHAR(20)
);

INSERT INTO students
(student_id, student_name, major, phone)
VALUES
('S001', 'Andi Saputra', 'Information Systems', '081234567890'),
('S002', 'Siti Rahma', 'Informatics', '081234567891'),
('S003', 'Budi Santoso', 'Accounting', '081234567892');

describe students;
select*from students;