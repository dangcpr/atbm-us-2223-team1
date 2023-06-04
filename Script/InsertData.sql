--CONNECT QLDA/admin123;
-- Insert data into QLDA_NHANVIEN
BEGIN
    -- Vòng l?p t?o Nhân viên
   FOR i IN 1..300 LOOP
      INSERT INTO QLDA_NHANVIEN (MANV,TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, MAPB) VALUES (
         'NV' || LPAD(i, 3, '0'),
         'Nhân viên ' || i,
         CASE WHEN MOD(i, 2) = 0 THEN 'Nữ' ELSE 'Nam' END,
         TO_DATE('01-JAN-1970', 'DD-MON-YYYY') + DBMS_RANDOM.VALUE(1, 20000),
         'HCM ' || i,
         '0123456789',
         DBMS_RANDOM.VALUE(1000, 2000),
         DBMS_RANDOM.VALUE(1000, 2000),
         'Nhân viên',
         NULL,
         NULL
      );
   END LOOP; 
   -- Vòng l?p t?o Quản lý tr?c ti?p
   FOR i IN 1..20 LOOP
      INSERT INTO QLDA_NHANVIEN (MANV,TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, MAPB) VALUES (
         'QL' || LPAD(i, 3, '0'),
         'Quản lý ' || i,
         CASE WHEN MOD(i, 2) = 0 THEN 'Nữ' ELSE 'Nam' END,
         TO_DATE('01-JAN-1970', 'DD-MON-YYYY') + DBMS_RANDOM.VALUE(1, 20000),
         'HCM ' || i,
         '0123456789',
         DBMS_RANDOM.VALUE(1000, 2000),
         DBMS_RANDOM.VALUE(1000, 2000),
         'Quản lý',
         NULL,
         NULL
      );
   END LOOP; 
   -- Vòng l?p t?o Trưởng phòng
   FOR i IN 1..8 LOOP
      INSERT INTO QLDA_NHANVIEN (MANV,TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, MAPB) VALUES (
         'TP' || LPAD(i, 3, '0'),
         'Trưởng phòng ' || i,
         CASE WHEN MOD(i, 2) = 0 THEN 'Nữ' ELSE 'Nam' END,
         TO_DATE('01-JAN-1970', 'DD-MON-YYYY') + DBMS_RANDOM.VALUE(1, 20000),
         'HCM ' || i,
         '0123456789',
         DBMS_RANDOM.VALUE(1000, 2000),
         DBMS_RANDOM.VALUE(1000, 2000),
         'Trưởng phòng',
         NULL,
         NULL
      );
   END LOOP;
   -- Vòng l?p t?o nhân viên tài chính
   FOR i IN 1..5 LOOP
      INSERT INTO QLDA_NHANVIEN (MANV,TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, MAPB) VALUES (
         'TC' || LPAD(i, 3, '0'),
         'Tài chính ' || i,
         CASE WHEN MOD(i, 2) = 0 THEN 'Nữ' ELSE 'Nam' END,
         TO_DATE('01-JAN-1970', 'DD-MON-YYYY') + DBMS_RANDOM.VALUE(1, 20000),
         'HCM ' || i,
         '0123456789',
         DBMS_RANDOM.VALUE(1000, 2000),
         DBMS_RANDOM.VALUE(1000, 2000),
         'Tài chính',
         NULL,
         NULL
      );
   END LOOP;
   -- Vòng l?p t?o nhân viên Nhân sự
   FOR i IN 1..5 LOOP
      INSERT INTO QLDA_NHANVIEN (MANV,TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, MAPB) VALUES (
         'NS' || LPAD(i, 3, '0'),
         'Nhân sự ' || i,
         CASE WHEN MOD(i, 2) = 0 THEN 'Nữ' ELSE 'Nam' END,
         TO_DATE('01-JAN-1970', 'DD-MON-YYYY') + DBMS_RANDOM.VALUE(1, 20000),
         'HCM ' || i,
         '0123456789',
         DBMS_RANDOM.VALUE(1000, 2000),
         DBMS_RANDOM.VALUE(1000, 2000),
         'Nhân sự',
         NULL,
         NULL
      );
   END LOOP;
   -- Vòng l?p t?o Nhân viên Trưởng dự án
   FOR i IN 1..3 LOOP
      INSERT INTO QLDA_NHANVIEN (MANV,TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, MAPB) VALUES (
         'TA' || LPAD(i, 3, '0'),
         'Trưởng đề án ' || i,
         CASE WHEN MOD(i, 2) = 0 THEN 'Nữ' ELSE 'Nam' END,
         TO_DATE('01-JAN-1970', 'DD-MON-YYYY') + DBMS_RANDOM.VALUE(1, 20000),
         'HCM ' || i,
         '0123456789',
         DBMS_RANDOM.VALUE(1000, 2000),
         DBMS_RANDOM.VALUE(1000, 2000),
         'Trưởng dự án',
         NULL,
         NULL
      );
   END LOOP;
   -- Vòng l?p t?o ban Giám đốc
   FOR i IN 1..5 LOOP
      INSERT INTO QLDA_NHANVIEN (MANV,TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, MAPB) VALUES (
         'BG' || LPAD(i, 3, '0'),
         'Giám đốc ' || i,
         CASE WHEN MOD(i, 2) = 0 THEN 'Nữ' ELSE 'Nam' END,
         TO_DATE('01-JAN-1970', 'DD-MON-YYYY') + DBMS_RANDOM.VALUE(1, 20000),
         'HCM ' || i,
         '0123456789',
         DBMS_RANDOM.VALUE(1000, 2000),
         DBMS_RANDOM.VALUE(1000, 2000),
         'Giám đốc',
         NULL,
         NULL
      );
   END LOOP;
END;
/
-- Insert QLDA_PHONGBAN
INSERT INTO QLDA_PHONGBAN(MAPB,TENPB,TRPHG) 
VALUES ('PB001', 'Kỹ thuật', 'TP001');
INSERT INTO QLDA_PHONGBAN(MAPB,TENPB,TRPHG) 
VALUES ('PB002', 'Marketing', 'TP002');
INSERT INTO QLDA_PHONGBAN(MAPB,TENPB,TRPHG) 
VALUES ('PB003', 'Kinh doanh', 'TP003');
INSERT INTO QLDA_PHONGBAN(MAPB,TENPB,TRPHG) 
VALUES ('PB004', 'Quản lý sản xuất', 'TP004');
INSERT INTO QLDA_PHONGBAN(MAPB,TENPB,TRPHG) 
VALUES ('PB005', 'Hành chính và Thanh tra', 'TP005');
INSERT INTO QLDA_PHONGBAN(MAPB,TENPB,TRPHG) 
VALUES ('PB006', 'Đào tạo', 'TP006');
INSERT INTO QLDA_PHONGBAN(MAPB,TENPB,TRPHG) 
VALUES ('PB007', 'Khảo thí và ĐBCL', 'TP007');
INSERT INTO QLDA_PHONGBAN(MAPB,TENPB,TRPHG) 
VALUES ('PB008', 'Công tác sinh viên', 'TP008');
/
-- Insert QLDA_DEAN
INSERT INTO QLDA_DEAN(MADA, TENDA, NGAYBD, PHONG)
VALUES('DP11111', 'Shopee website', (TO_DATE('12/1/2023', 'DD/MM/YYYY')), 'PB001');
INSERT INTO QLDA_DEAN(MADA, TENDA, NGAYBD, PHONG)
VALUES('DP22222', 'School website', (TO_DATE('15/7/2023', 'DD/MM/YYYY')), 'PB001');
/
-- Insert QLDA_PHANCONG
INSERT INTO QLDA_PHANCONG(MANV, MADA, THOIGIAN)
VALUES('TA001', 'DP11111', (TO_DATE('12/1/2023', 'DD/MM/YYYY')));
COMMIT;
--INSERT INTO QLDA_NHANVIEN(MANV) VALUES ('QLDA');
INSERT INTO QLDA_PHANCONG(MANV, MADA, THOIGIAN)
VALUES('TA002', 'DP22222', (TO_DATE('15/1/2023', 'DD/MM/YYYY')));
COMMIT;

INSERT INTO QLDA_PHANCONG(MANV, MADA, THOIGIAN)
VALUES('QL001', 'DP11111', (TO_DATE('8/1/2023', 'DD/MM/YYYY')));
COMMIT;

INSERT INTO QLDA_PHANCONG(MANV, MADA, THOIGIAN)
VALUES('NV001', 'DP22222', (TO_DATE('15/1/2023', 'DD/MM/YYYY')));
COMMIT;

INSERT INTO QLDA_PHANCONG(MANV, MADA, THOIGIAN)
VALUES('NV040', 'DP22222', (TO_DATE('15/1/2023', 'DD/MM/YYYY')));
COMMIT;
/
 -- Update QLDA_NHANVIEN
UPDATE QLDA_NHANVIEN
SET MAPB = CASE
    WHEN MANV BETWEEN 'NV001' AND 'NV030' THEN 'PB001'
    WHEN MANV BETWEEN 'NV031' AND 'NV060' THEN 'PB002'
    WHEN MANV BETWEEN 'NV061' AND 'NV100' THEN 'PB003'
    WHEN MANV BETWEEN 'NV101' AND 'NV140' THEN 'PB004'
    WHEN MANV BETWEEN 'NV141' AND 'NV180' THEN 'PB005'
    WHEN MANV BETWEEN 'NV181' AND 'NV220' THEN 'PB006'
    WHEN MANV BETWEEN 'NV221' AND 'NV260' THEN 'PB007'
    WHEN MANV BETWEEN 'NV261' AND 'NV300' THEN 'PB008'
    WHEN MANV = 'TP001' THEN 'PB001'
    WHEN MANV = 'TP002' THEN 'PB002'
    WHEN MANV = 'TP003' THEN 'PB003'
    WHEN MANV = 'TP004' THEN 'PB004'
    WHEN MANV = 'TP005' THEN 'PB005'
    WHEN MANV = 'TP006' THEN 'PB006'
    WHEN MANV = 'TP007' THEN 'PB007'
    WHEN MANV = 'TP008' THEN 'PB008'
    WHEN MANV = 'QL001' THEN 'PB001'
    WHEN MANV = 'QL002' THEN 'PB001'
    WHEN MANV = 'QL003' THEN 'PB002'
    WHEN MANV = 'QL004' THEN 'PB002'
    WHEN MANV = 'QL005' THEN 'PB003'
    WHEN MANV = 'QL006' THEN 'PB003'
    WHEN MANV = 'QL007' THEN 'PB004'
    WHEN MANV = 'QL008' THEN 'PB004'
    WHEN MANV = 'QL009' THEN 'PB005'
    WHEN MANV = 'QL010' THEN 'PB005'
    WHEN MANV = 'QL011' THEN 'PB005'
    WHEN MANV = 'QL012' THEN 'PB006'
    WHEN MANV = 'QL013' THEN 'PB006'
    WHEN MANV = 'QL014' THEN 'PB006'
    WHEN MANV = 'QL015' THEN 'PB007'
    WHEN MANV = 'QL016' THEN 'PB007'
    WHEN MANV = 'QL017' THEN 'PB007'
    WHEN MANV = 'QL018' THEN 'PB008'
    WHEN MANV = 'QL019' THEN 'PB008'
    WHEN MANV = 'QL020' THEN 'PB008'
END;

UPDATE QLDA_NHANVIEN
SET MANQL = CASE
    WHEN MAPB = 'PB001' AND  MANV BETWEEN 'NV001' AND 'NV015' THEN 'QL001'
    WHEN MAPB = 'PB001' AND  MANV BETWEEN 'NV016' AND 'NV030' THEN 'QL002'
    WHEN MAPB = 'PB002' AND  MANV BETWEEN 'NV031' AND 'NV040' THEN 'QL003'
    WHEN MAPB = 'PB002' AND  MANV BETWEEN 'NV041' AND 'NV060' THEN 'QL004'
    WHEN MAPB = 'PB003' AND  MANV BETWEEN 'NV061' AND 'NV080' THEN 'QL005'
    WHEN MAPB = 'PB003' AND  MANV BETWEEN 'NV081' AND 'NV100' THEN 'QL006'
    WHEN MAPB = 'PB004' AND  MANV BETWEEN 'NV101' AND 'NV130' THEN 'QL007'
    WHEN MAPB = 'PB004' AND  MANV BETWEEN 'NV131' AND 'NV140' THEN 'QL008'
    WHEN MAPB = 'PB005' AND  MANV BETWEEN 'NV141' AND 'NV150' THEN 'QL009'
    WHEN MAPB = 'PB005' AND  MANV BETWEEN 'NV151' AND 'NV160' THEN 'QL010'
    WHEN MAPB = 'PB005' AND  MANV BETWEEN 'NV161' AND 'NV180' THEN 'QL011'
    WHEN MAPB = 'PB006' AND  MANV BETWEEN 'NV181' AND 'NV190' THEN 'QL012'
    WHEN MAPB = 'PB006' AND  MANV BETWEEN 'NV191' AND 'NV200' THEN 'QL013'
    WHEN MAPB = 'PB006' AND  MANV BETWEEN 'NV201' AND 'NV220' THEN 'QL014'
    WHEN MAPB = 'PB007' AND  MANV BETWEEN 'NV221' AND 'NV230' THEN 'QL015'
    WHEN MAPB = 'PB007' AND  MANV BETWEEN 'NV231' AND 'NV240' THEN 'QL015'
    WHEN MAPB = 'PB007' AND  MANV BETWEEN 'NV241' AND 'NV260' THEN 'QL017'
    WHEN MAPB = 'PB008' AND  MANV BETWEEN 'NV261' AND 'NV270' THEN 'QL018'
    WHEN MAPB = 'PB008' AND  MANV BETWEEN 'NV271' AND 'NV280' THEN 'QL019'
    WHEN MAPB = 'PB008' AND  MANV BETWEEN 'NV281' AND 'NV300' THEN 'QL020'
END;




select * from QLDA.QLDA_NHANVIEN where VAITRO = 'Nhân viên' order by MANV;
select * from QLDA.QLDA_NHANVIEN where VAITRO = 'Quản lý' order by MANV;
select * from QLDA.QLDA_NHANVIEN where VAITRO = 'Trưởng phòng' order by MANV;
select * from QLDA.QLDA_NHANVIEN where VAITRO = 'Tài chính' order by MANV;
select * from QLDA.QLDA_NHANVIEN where VAITRO = 'Nhân sự' order by MANV;
select * from QLDA.QLDA_NHANVIEN where VAITRO = 'Trưởng dự án' order by MANV;
select * from QLDA.QLDA_NHANVIEN where VAITRO = 'Giám đốc' order by MANV;

SELECT * FROM QLDA.QLDA_NHANVIEN WHERE MANV = 'NV338';
SELECT * FROM QLDA.QLDA_PHONGBAN;
SELECT * FROM QLDA.QLDA_PHANCONG;
SELECT * FROM QLDA.QLDA_DEAN;

SELECT owner
FROM QLDA.QLDA_NHANVIEN
WHERE MANV = 'NV001';
--Xem các thuộc tính bảng QLDA_NHANVIEN
SELECT * FROM USER_TAB_COLUMNS
WHERE TABLE_NAME = 'QLDA_NHANVIEN';
/*
DELETE FROM QLDA.QLDA_NHANVIEN;

DELETE FROM QLDA.QLDA_PHONGBAN;
DELETE FROM QLDA.QLDA_PHANCONG;
DELETE FROM QLDA.QLDA_DEAN;
COMMIT;
*/