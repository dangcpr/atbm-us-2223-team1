SELECT * FROM QLDA.QLDA_PHANCONG;
SELECT * FROM QLDA.QLDA_NHANVIEN;
 --ALTER SESSION SET QUERY_REWRITE_INTEGRITY = TRUSTED ;
--ALTER SESSION SET NLS_LENGTH_SEMANTICS=CHAR;
UPDATE QLDA.QLDA_NHANVIEN
SET LUONG = '1800'
WHERE MANV = 'NV038'; COMMIT;
SELECT * FROM QLDA.QLDA_NHANVIEN WHERE MANV = 'NV038';


UPDATE QLDA.QLDA_NHANVIEN
SET PHUCAP = '1735', LUONG = '1180'
WHERE MANV = 'NV031'; COMMIT;
SELECT * FROM QLDA.QLDA_NHANVIEN;

SELECT MANV, TENNV, LUONG FROM QLDA.QLDA_NHANVIEN;

UPDATE QLDA.QLDA_NHANVIEN
SET TENNV = 'Trưởng đề án 2'
WHERE MANV = 'TA001'; COMMIT;
SELECT * FROM QLDA.QLDA_NHANVIEN
ORDER BY MANV;

UPDATE QLDA.QLDA_NHANVIEN
SET SODT = '0787094888'
WHERE MANV = 'TC001'; COMMIT;
SELECT * FROM QLDA.QLDA_NHANVIEN WHERE MANV = USER;

SELECT * FROM QLDA.QLDA_PHONGBAN;
SELECT * FROM QLDA.QLDA_DEAN;

declare
    TEMP VARCHAR2(20);
begin
    --SELECT VAITRO INTO TEMP FROM QLDA.QLDA_NHANVIEN WHERE MANV = USER;
    IF('Nhân viên' = (SELECT VAITRO FROM QLDA.QLDA_NHANVIEN WHERE MANV = USER))
        then dbms_output.put_line(TEMP); 
    end if;
end;