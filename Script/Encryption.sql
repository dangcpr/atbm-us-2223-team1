CREATE USER ENC IDENTIFIED BY 123;
GRANT CONNECT TO ENC;
GRANT CREATE PROCEDURE, CREATE TRIGGER TO ENC;
GRANT SELECT, UPDATE ON QLDA.QLDA_NHANVIEN TO ENC;

CONNECT ENC/123;
----------------- MÃ HOÁ -----------------
  -- Mã hoá thông tin LUONG và PHUCAP
  -- Tạo package hỗ trợ mã hoá - giải mã
CREATE OR REPLACE PACKAGE ENCRYPT_DECRYPT AS
  FUNCTION ENCRYPT_NHANVIEN_LUONG(
    P_IN IN NVARCHAR2,
    P_KEY IN CHAR
  ) RETURN RAW DETERMINISTIC;
  FUNCTION DECRYPT_NHANVIEN_LUONG(
    P_IN IN RAW,
    P_KEY IN CHAR
  ) RETURN NVARCHAR2 DETERMINISTIC;
  FUNCTION ENCRYPT_NHANVIEN_PHUCAP(
    P_IN IN NVARCHAR2,
    P_KEY IN CHAR
  ) RETURN RAW DETERMINISTIC;
  FUNCTION DECRYPT_NHANVIEN_PHUCAP(
    P_IN IN RAW,
    P_KEY IN CHAR
  ) RETURN NVARCHAR2 DETERMINISTIC;
END ENCRYPT_DECRYPT;
/
--Xóa package nếu tồn tại
--DROP PACKAGE ENCRYPT_DECRYPT;

-- Cài đặt các function trong package trên
CREATE OR REPLACE PACKAGE BODY ENCRYPT_DECRYPT IS
  ENCRYPTION_TYPE PLS_INTEGER := DBMS_CRYPTO.ENCRYPT_DES +DBMS_CRYPTO.CHAIN_CBC +DBMS_CRYPTO.PAD_PKCS5;
  FUNCTION ENCRYPT_NHANVIEN_LUONG(
    P_IN IN NVARCHAR2,
    P_KEY IN CHAR
  ) RETURN RAW DETERMINISTIC IS
    ENCRYPTED_RAW RAW(2000);
  BEGIN
    ENCRYPTED_RAW := DBMS_CRYPTO.ENCRYPT( SRC => UTL_RAW.CAST_TO_RAW(P_IN), TYP => ENCRYPTION_TYPE, KEY => UTL_RAW.CAST_TO_RAW(P_KEY) );
    RETURN ENCRYPTED_RAW;
  END ENCRYPT_NHANVIEN_LUONG;
  FUNCTION DECRYPT_NHANVIEN_LUONG(
    P_IN IN RAW,
    P_KEY IN CHAR
  ) RETURN NVARCHAR2 DETERMINISTIC IS
    DECRYPTED_RAW RAW(2000);
  BEGIN
    DECRYPTED_RAW := DBMS_CRYPTO.DECRYPT( SRC => P_IN, TYP => ENCRYPTION_TYPE, KEY => UTL_RAW.CAST_TO_RAW(P_KEY) );
    RETURN UTL_RAW.CAST_TO_NVARCHAR2(DECRYPTED_RAW);
  END DECRYPT_NHANVIEN_LUONG;
  
  FUNCTION ENCRYPT_NHANVIEN_PHUCAP(
    P_IN IN NVARCHAR2,
    P_KEY IN CHAR
  ) RETURN RAW DETERMINISTIC IS
    ENCRYPTED_RAW RAW(2000);
  BEGIN
    ENCRYPTED_RAW := DBMS_CRYPTO.ENCRYPT( SRC => UTL_RAW.CAST_TO_RAW(P_IN), TYP => ENCRYPTION_TYPE, KEY => UTL_RAW.CAST_TO_RAW(P_KEY) );
    RETURN ENCRYPTED_RAW;
  END ENCRYPT_NHANVIEN_PHUCAP;
  FUNCTION DECRYPT_NHANVIEN_PHUCAP(
    P_IN IN RAW,
    P_KEY IN CHAR
  ) RETURN NVARCHAR2 DETERMINISTIC IS
    DECRYPTED_RAW RAW(2000);
  BEGIN
    DECRYPTED_RAW := DBMS_CRYPTO.DECRYPT( SRC => P_IN, TYP => ENCRYPTION_TYPE, KEY => UTL_RAW.CAST_TO_RAW(P_KEY) );
    RETURN UTL_RAW.CAST_TO_NVARCHAR2(DECRYPTED_RAW);
  END DECRYPT_NHANVIEN_PHUCAP;
END ENCRYPT_DECRYPT;
/

CREATE OR REPLACE FUNCTION CREATE_KEY (ma NVARCHAR2, seq NUMBER)
    RETURN RAW
IS
    MS varchar2(20);
    MS_RAW RAW(128);
    C_KEY RAW(128);
    T_RAW RAW(128);
BEGIN
    SELECT  MANV INTO MS
        FROM QLDA.QLDA_NHANVIEN
        WHERE MANV = ma;
    T_RAW := UTL_RAW.CAST_TO_RAW('ATBM_HTTT_T1' || seq);
    MS_RAW := UTL_RAW.CAST_TO_RAW(seq || MS);
    C_KEY :=  UTL_RAW.BIT_XOR(T_RAW, MS_RAW);
    RETURN C_KEY;
END CREATE_KEY;


-- Mã hoá tất cả thông tin lương và phụ cấp trong bảng nhân viên
--Cách 1
DECLARE
    CURSOR CUR IS SELECT MANV
                  FROM QLDA_NHANVIEN;    
    strSQL VARCHAR2(2000);
BEGIN
    FOR C IN CUR LOOP
        strSQL := 'UPDATE QLDA_NHANVIEN
                    SET LUONG = ENCRYPT_DECRYPT.ENCRYPT_NHANVIEN_LUONG(LUONG, CREATE_KEY(' || C.MANV ||', 0))
                    WHERE MANV = ''' || C.MANV ||''';';
    EXECUTE IMMEDIATE (strSQL);
    END LOOP;
END;

--Cách 2
UPDATE QLDA_NHANVIEN NV1
SET
  LUONG = (
    SELECT ENCRYPT_DECRYPT.ENCRYPT_NHANVIEN_LUONG(LUONG, CREATE_KEY(NV1.MANV,0)) FROM QLDA_NHANVIEN NV2 WHERE NV1.MANV = NV2.MANV
  );
COMMIT;

/
UPDATE QLDA_NHANVIEN NV1
SET
  PHUCAP = (
    SELECT ENCRYPT_DECRYPT.ENCRYPT_NHANVIEN_PHUCAP(PHUCAP, CREATE_KEY(NV1.MANV,0)) FROM QLDA_NHANVIEN NV2 WHERE NV1.MANV = NV2.MANV
  );
COMMIT;
/

-- Tự động mã hoá thông tin LUONG VA PHU CAP khi thêm, sửa
CREATE OR REPLACE TRIGGER auto_encrypted_nhanvien BEFORE
    INSERT OR UPDATE ON qlda.qlda_nhanvien
    FOR EACH ROW
DECLARE BEGIN
    if (INSERTING) then
      :new.luong := encrypt_decrypt.encrypt_nhanvien_luong(:new.luong, CREATE_KEY(NV1.MANV,0));
    end if;

    if (INSERTING) then
      :new.phucap := encrypt_decrypt.encrypt_nhanvien_phucap(:new.phucap, '3F569C3F19E25B18B2C12B975F9BC5BB');
    end if;

    if (:new.luong is not null and UPDATING and ((:new.luong <> :old.luong) or (:old.luong is null))) then
      :new.luong := encrypt_decrypt.encrypt_nhanvien_luong(:new.luong, '3F569C3F19E25B18B2C12B975F9BC5BB');
    end if;

    if (:new.phucap is not null and UPDATING and ((:new.phucap <> :old.phucap) or (:old.phucap is null))) then
      :new.phucap := encrypt_decrypt.encrypt_nhanvien_phucap(:new.phucap, '3F569C3F19E25B18B2C12B975F9BC5BB');
    end if;
END;
 -- Câu lệnh test trigger AUTO_ENCRYPTED_NHANVIEN
INSERT INTO QLDA_NHANVIEN (MANV,TENNV, PHAI, NGAYSINH, DIACHI, SODT, LUONG, PHUCAP, VAITRO, MANQL, MAPB) VALUES (
         'NV400',
         'Nhân viên 400',
         'Nam',
         TO_DATE('01-JAN-1970', 'DD-MON-YYYY'),
         'HCM',
         '0123456789',
         NULL,
         NULL,
         'Nhân viên',
         'QL001',
         'PB001'
      );
    UPDATE QLDA_NHANVIEN SET LUONG = 10000000, PHUCAP = 1000000 WHERE MANV = 'NV400';
    SELECT * FROM QLDA_NHANVIEN WHERE MANV='NV400';
--select LUONG, phucap FROM QLDA_NHANVIEN WHERE MANV='NV400';
--Xóa hàm
--DROP TRIGGER auto_encrypted_nhanvien;
GRANT EXECUTE ON QLDA.ENCRYPT_DECRYPT TO NV;
GRANT EXECUTE ON QLDA.ENCRYPT_DECRYPT TO QL;
GRANT EXECUTE ON QLDA.ENCRYPT_DECRYPT TO TP;
GRANT EXECUTE ON QLDA.ENCRYPT_DECRYPT TO TC;
GRANT EXECUTE ON QLDA.ENCRYPT_DECRYPT TO NS;
GRANT EXECUTE ON QLDA.ENCRYPT_DECRYPT TO TA;
GRANT EXECUTE ON QLDA.ENCRYPT_DECRYPT TO TA;
--GRANT EXECUTE ON QLDA.ENCRYPT_DECRYPT TO NEWUSER;
--REVOKE EXECUTE ON QLDA.ENCRYPT_DECRYPT FROM NEWUSER;


SELECT
    luong,
    encrypt_decrypt.decrypt_nhanvien_luong(luong, '3F569C3F19E25B18B2C12B975F9BC5BB') AS luong_giaima,
    phucap,
    encrypt_decrypt.decrypt_nhanvien_phucap(phucap, '3F569C3F19E25B18B2C12B975F9BC5BB') AS phucap_giaima
FROM
    QLDA.qlda_nhanvien;

--DELETE FROM QLDA_NHANVIEN WHERE MANV='NV400';
    
DECLARE 
    L FLOAT;
    V_R RAW(300);
    LU NUMBER(10,2);
BEGIN
    SELECT LUONG INTO L  FROM QLDA_NHANVIEN  WHERE MANV = 'NV131';
    dbms_output.put_line(L);
    SELECT ENCRYPT_DECRYPT.ENCRYPT_NHANVIEN_LUONG(LUONG, CREATE_KEY('NV131',0)) INTO V_R  FROM QLDA_NHANVIEN  WHERE MANV = 'NV131';
    dbms_output.put_line(V_R);
    SELECT ENCRYPT_DECRYPT.DECRYPT_NHANVIEN_LUONG(V_R, CREATE_KEY('NV131',0)) INTO LU  FROM QLDA_NHANVIEN  WHERE MANV = 'NV131';
    dbms_output.put_line(LU);
END;