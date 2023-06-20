CONNECT QLDA/admin123;
---ROLE TAICHINH
alter session set "_ORACLE_SCRIPT"=true;
CREATE ROLE TC;
CREATE USER  TC001 IDENTIFIED BY TC001;
GRANT CONNECT TO TC;
GRANT TC TO TC001;

--Xem toàn bộ trên quan hệ NHANVIEN
GRANT SELECT ON QLDA.V_QLDA_NHANVIEN TO TC;

--Xem toàn bộ trên quan hệ PHANCONG
GRANT SELECT ON QLDA.QLDA_PHANCONG TO TC;

--Sủa thông tin của quan hệ NHANVIEN, được quyền sửa thuộc tính LUONG và PHUCAP cho toàn bộ bảng.
--Nhưng thuộc tính NGAYSINH, DIACHI, SODT chỉ được sửa của chính mình.
GRANT UPDATE(LUONG, PHUCAP, NGAYSINH, DIACHI, SODT) ON QLDA.V_QLDA_NHANVIEN TO TC;

CREATE OR REPLACE FUNCTION QLDA.TC_SUA_TT_CA_NHAN_CUA_TC (
   P_SCHEMA IN VARCHAR2 DEFAULT NULL,
   P_OBJECT IN VARCHAR2 DEFAULT NULL
) 
RETURN VARCHAR2 
AS
  USERNAME VARCHAR2(128);
  USERROLE VARCHAR2(128);
BEGIN
  -- L?y username c?a user hi?n t?i
  USERNAME := SYS_CONTEXT('userenv', 'SESSION_USER');
  
  IF USERNAME = 'QLDA' THEN 
    RETURN '1=1'; -- Qu?n lý d? án có th? xem t?t c? thông tin
  END IF;
  
  SELECT GRANTED_ROLE INTO USERROLE FROM DBA_ROLE_PRIVS WHERE GRANTEE = ''||UPPER(USERNAME)||'';
  
  IF 'TC' IN (USERROLE) THEN
    RETURN 'MANV = '''||USERNAME||'''';
  ELSE
    RETURN '1=1'; -- Ng??i dùng khác không có quy?n xem
  END IF;
END;
/


BEGIN dbms_rls.add_policy 
(object_schema =>'QLDA',
object_name => 'V_QLDA_NHANVIEN',
policy_name => 'POLICY_TC_SUA_TT_CA_NHAN_CUA_TC',
function_schema => 'QLDA',
policy_function => 'TC_SUA_TT_CA_NHAN_CUA_TC',
statement_types => 'UPDATE',
sec_relevant_cols => 'NGAYSINH, DIACHI, SODT',
--sec_relevant_cols_opt => dbms_rls.ALL_ROWS,
update_check => TRUE);
END;
/

/*
BEGIN
  dbms_rls.drop_policy (
    object_schema => 'QLDA',
    object_name   => 'QLDA_NHANVIEN',
    policy_name   => 'POLICY_TC_SUA_TT_CA_NHAN_CUA_TC');
END;
*/

--Có thể sửa trên thuộc tính LUONG va PHUCAP
GRANT UPDATE(LUONG, PHUCAP) ON QLDA.QLDA_NHANVIEN TO TC;
CREATE OR REPLACE VIEW V_NV_PC
AS
SELECT PC.*
FROM QLDA.QLDA_NHANVIEN NV, QLDA.QLDA_PHANCONG PC
WHERE NV.MANV = PC.MANV AND NV.MANQL = SYS_CONTEXT('userenv', 'session_user');