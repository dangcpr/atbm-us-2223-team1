SELECT * FROM QLDA.QLDA_NHANVIEN;
SELECT * FROM QLDA.V_QLDA_PHANCONG_QL;

SELECT * FROM QLDA.QLDA_PHONGBAN;
SELECT * FROM QLDA.QLDA_DEAN;

UPDATE QLDA.QLDA_NHANVIEN
SET SODT = '0986285783'
WHERE MANV = 'QL001';
COMMIT;
SELECT * FROM QLDA.QLDA_NHANVIEN;