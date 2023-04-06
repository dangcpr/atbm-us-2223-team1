-- Insert data into QLDA_NHANVIEN
INSERT INTO QLDA_NHANVIEN(MANV,TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, MAPB)
VALUES('001', 'Dang', 'Nam', (TO_DATE('01/02/2002', 'DD/MM/YYYY')), 'Ho Chi Minh City', '0967173233', 3000, 1000, 'Manager',NULL,NULL);

INSERT INTO QLDA_NHANVIEN(MANV,TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, MAPB)
VALUES('002', 'Nam', 'Nam', (TO_DATE('02/07/2002', 'DD/MM/YYYY')), 'Ho Chi Minh City', '0967173232', 2500, 1200, 'Employee',NULL,NULL);

INSERT INTO QLDA_NHANVIEN(MANV,TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, MAPB)
VALUES('003', 'Thai', 'Nam', (TO_DATE('03/09/2002', 'DD/MM/YYYY')), 'Ho Chi Minh City', '0967173212', 2500, 1000, 'Employee',NULL,NULL);

INSERT INTO QLDA_NHANVIEN(MANV,TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, MAPB)
VALUES('004', 'Hieu', 'Nam', (TO_DATE('08/12/2002', 'DD/MM/YYYY')), 'Ho Chi Minh City', '0967173200', 2200, 1300, 'Employee',NULL,NULL);

INSERT INTO QLDA_NHANVIEN(MANV,TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, MAPB)
VALUES('005', 'Amee', 'Nu', (TO_DATE('03/04/2002', 'DD/MM/YYYY')), 'Ho Chi Minh City', '0967173254', 3000, 1100, 'Employee',NULL,NULL);

INSERT INTO QLDA_NHANVIEN(MANV,TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, MAPB)
VALUES('006', 'Smith', 'Nam', (TO_DATE('06/08/2002', 'DD/MM/YYYY')), 'Ho Chi Minh City', '0967173284', 3000, 1100, 'Manager',NULL,NULL);

INSERT INTO QLDA_NHANVIEN(MANV,TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, MAPB)
VALUES('007', 'Rose', 'Nu', (TO_DATE('10/04/2002', 'DD/MM/YYYY')), 'Ho Chi Minh City', '0967173654', 3000, 1100, 'Manager',NULL,NULL);

-- Insert data into QLDA_PHONGBAN
INSERT INTO QLDA_PHONGBAN(MAPB, TENPB, TRPHG)
VALUES('P101', 'Software', '001');

INSERT INTO QLDA_PHONGBAN(MAPB, TENPB, TRPHG)
VALUES('P201', 'Human resources', '006');

INSERT INTO QLDA_PHONGBAN(MAPB, TENPB, TRPHG)
VALUES('P401', 'Technical', '007');

-- Insert data into QLDA_DEAN
INSERT INTO QLDA_DEAN(MADA, TENDA, NGAYBD, PHONG)
VALUES('DP11111', 'Shopee website', (TO_DATE('12/1/2023', 'DD/MM/YYYY')), 'P101');

INSERT INTO QLDA_DEAN(MADA, TENDA, NGAYBD, PHONG)
VALUES('DP22222', 'School website', (TO_DATE('15/7/2023', 'DD/MM/YYYY')), 'P101');

-- Insert data into QLDA_PHANCONG
INSERT INTO QLDA_PHANCONG(MANV, MADA, THOIGIAN)
VALUES('001', 'DP11111', (TO_DATE('12/1/2023', 'DD/MM/YYYY')));

INSERT INTO QLDA_PHANCONG(MANV, MADA, THOIGIAN)
VALUES('007', 'DP22222', (TO_DATE('15/1/2023', 'DD/MM/YYYY')));

----------------
UPDATE QLDA_NHANVIEN
SET MANQL = '001'
WHERE MANV = '002';

UPDATE QLDA_NHANVIEN
SET MANQL = '001'
WHERE MANV = '003';

UPDATE QLDA_NHANVIEN
SET MANQL = '001'
WHERE MANV = '004';

UPDATE QLDA_NHANVIEN
SET MANQL = '001'
WHERE MANV = '005';

UPDATE QLDA_NHANVIEN
SET MANQL = NULL
WHERE MANV = '006';

-------------

UPDATE QLDA_NHANVIEN
SET MAPB = 'P101'
WHERE MANV = '001';

UPDATE QLDA_NHANVIEN
SET MAPB = 'P101'
WHERE MANV = '002';

UPDATE QLDA_NHANVIEN
SET MAPB = 'P101'
WHERE MANV = '003';

UPDATE QLDA_NHANVIEN
SET MAPB = 'P101'
WHERE MANV = '004';

UPDATE QLDA_NHANVIEN
SET MAPB = 'P101'
WHERE MANV = '005';

UPDATE QLDA_NHANVIEN
SET MAPB = 'P201'
WHERE MANV = '006';

UPDATE QLDA_NHANVIEN
SET MAPB = 'P401'
WHERE MANV = '007';

/*
SELECT * from QLDA_NHANVIEN;
SELECT * FROM QLDA_DEAN;
SELECT * from QLDA_PHANCONG;
SELECT * from QLDA_PHONGBAN;
*/