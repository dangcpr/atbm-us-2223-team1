SELECT * FROM QLDA.QLDA_PHANCONG;
SELECT * FROM QLDA.QLDA_NHANVIEN;


UPDATE QLDA.QLDA_NHANVIEN
SET LUONG = '1800.14008196981590'
WHERE MANV = 'NV038'; COMMIT;
SELECT * FROM QLDA.QLDA_NHANVIEN;

UPDATE QLDA.QLDA_NHANVIEN
SET PHUCAP = '1735.1449808484496'
WHERE MANV = 'NV031'; COMMIT;
SELECT * FROM QLDA.QLDA_NHANVIEN;

UPDATE QLDA.QLDA_NHANVIEN
SET TENNV = 'Trưởng đề án 2'
WHERE MANV = 'TA001'; COMMIT;
SELECT * FROM QLDA.QLDA_NHANVIEN
ORDER BY MANV;

UPDATE QLDA.QLDA_NHANVIEN
SET SODT = '0787094888'
WHERE MANV = 'TC001'; COMMIT;
SELECT * FROM QLDA.QLDA_NHANVIEN;

SELECT * FROM QLDA.QLDA_PHONGBAN;
SELECT * FROM QLDA.QLDA_DEAN;
