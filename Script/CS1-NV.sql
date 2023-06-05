--CONNECT QLDA/admin123;
--alter session set "_ORACLE_SCRIPT"=true;
--ALTER SESSION SET CONTAINER = CDB$ROOT;
CREATE USER NV001 IDENTIFIED BY NV001;
create role NV;
GRANT CONNECT TO NV;
grant NV to NV001;

grant select,update on QLDA.QLDA_NHANVIEN to NV;
grant select on QLDA.QLDA_PHANCONG to NV;
--CREATE OR REPLACE VIEW V_NV_QLDA_NHANVIEN AS
--select * from QLDA.QLDA_NHANVIEN;
--grant select on QLDA.V_NV_QLDA_NHANVIEN TO NV;
SELECT *  FROM DBA_ROLE_PRIVS;
-- Nhân viên ch? có th? xem thông tin c?a b?n thân (TA cũng vậy, các role khác có chính sách riêng)
--DROP FUNCTION QLDA.NV_XEM_TT_CA_NHAN;
CREATE OR REPLACE FUNCTION QLDA.NV_XEM_TT_CA_NHAN (
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
  
  -- Qu?n lý d? án có th? xem t?t c? thông tin
  IF USERNAME = 'QLDA' THEN 
    RETURN ''; 
  END IF;
  
  SELECT GRANTED_ROLE INTO USERROLE FROM DBA_ROLE_PRIVS WHERE GRANTEE = ''|| USERNAME || '';
  
  -- Ng??i dùng khác không có quy?n xem
  IF 'NV' IN (USERROLE) OR  'TA' IN (USERROLE) THEN
    RETURN 'MANV = '''||USERNAME||'''';
  ELSE
    RETURN '1=1'; 
  END IF;
END;
/


BEGIN dbms_rls.add_policy 
(object_schema =>'QLDA',
object_name => 'QLDA_NHANVIEN',
policy_name => 'POLICY_NV_XEM_TT_CA_NHAN',
function_schema => 'QLDA',
policy_function => 'NV_XEM_TT_CA_NHAN',
statement_types => 'SELECT',
update_check => TRUE);
END;
/*
BEGIN
  dbms_rls.drop_policy (
    object_schema => 'QLDA',
    object_name   => 'QLDA_NHANVIEN',
    policy_name   => 'POLICY_NV_XEM_TT_CA_NHAN');
END;
*/
/
/*
REVOKE UPDATE ON QLDA.QLDA_NHANVIEN FROM NV;
REVOKE SELECT ON QLDA.QLDA_NHANVIEN FROM QL;
REVOKE SELECT ON QLDA.QLDA_NHANVIEN FROM TP;
REVOKE SELECT ON QLDA.QLDA_NHANVIEN FROM TC;
REVOKE SELECT ON QLDA.QLDA_NHANVIEN FROM NS;
REVOKE SELECT ON QLDA.QLDA_NHANVIEN FROM TA;
*/

--Các role NV, QL, TP, TA có quyền sửa các thuộc tính NGAYSINH, DIACHI, SODT của chính mình (còn role TC, NS có chính sách khác)
GRANT UPDATE(NGAYSINH,DIACHI,SODT) ON QLDA.QLDA_NHANVIEN TO NV;
--GRANT UPDATE(NGAYSINH,DIACHI,SODT) ON QLDA.QLDA_NHANVIEN TO QL;
--GRANT UPDATE(NGAYSINH,DIACHI,SODT) ON QLDA.QLDA_NHANVIEN TO TP;
GRANT UPDATE(NGAYSINH,DIACHI,SODT) ON QLDA.QLDA_NHANVIEN TO TA;
GRANT UPDATE(NGAYSINH,DIACHI,SODT) ON QLDA.V_QLDA_NHANVIEN_NS TO TP;
GRANT UPDATE(NGAYSINH,DIACHI,SODT) ON QLDA.V_QLDA_NHANVIEN_NS TO QL;

CREATE OR REPLACE FUNCTION QLDA.NV_SUA_TT_CA_NHAN (
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
  
  IF 'NV' IN (USERROLE) OR 'TA' IN (USERROLE) THEN
    RETURN 'MANV = '''||USERNAME||'''';
  ELSE
    RETURN '1=1'; -- Ng??i dùng khác không có quy?n xem
  END IF;
END;
/


BEGIN dbms_rls.add_policy 
(object_schema =>'QLDA',
object_name => 'QLDA_NHANVIEN',
policy_name => 'POLICY_NV_SUA_TT_CA_NHAN',
function_schema => 'QLDA',
policy_function => 'NV_SUA_TT_CA_NHAN',
statement_types => 'UPDATE',
update_check => TRUE);
END;
/

/*
BEGIN
  dbms_rls.drop_policy (
    object_schema => 'QLDA',
    object_name   => 'QLDA_NHANVIEN',
    policy_name   => 'POLICY_NV_SUA_TT_CA_NHAN');
END;
*/

--Được quyền xem toàn bộ dữ liệu trên quan hệ PHONGBAN, DEAN (cả 6 role)
GRANT SELECT ON QLDA.QLDA_PHONGBAN TO NV;
GRANT SELECT ON QLDA.QLDA_PHONGBAN TO QL;
GRANT SELECT ON QLDA.QLDA_PHONGBAN TO TP;
GRANT SELECT ON QLDA.QLDA_PHONGBAN TO TC;
GRANT SELECT ON QLDA.QLDA_PHONGBAN TO NS;
GRANT SELECT ON QLDA.QLDA_PHONGBAN TO TA;

GRANT SELECT ON QLDA.QLDA_DEAN TO NV;
GRANT SELECT ON QLDA.QLDA_DEAN TO QL;
GRANT SELECT ON QLDA.QLDA_DEAN TO TP;
GRANT SELECT ON QLDA.QLDA_DEAN TO TC;
GRANT SELECT ON QLDA.QLDA_DEAN TO NS;
GRANT SELECT ON QLDA.QLDA_DEAN TO TA;

CREATE USER NV001 IDENTIFIED BY NV001;
create role NV;
GRANT CONNECT TO NV;
grant NV to NV001;
grant select,update on QLDA.QLDA_NHANVIEN to NV;

--drop USER NV002;
CREATE USER NV002 IDENTIFIED BY NV002;
--create role NV;
--GRANT CONNECT TO NV;
grant NV to NV002;
--drop user NV002;

--REVOKE SELECT, update ON QLDA.QLDA_NHANVIEN FROM NV;
/
select * from QLDA.QLDA_NHANVIEN;
/
CREATE OR REPLACE FUNCTION QLDA.NV_NS_TA_XEM_QH_PC (
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
  
  IF 'NV' IN (USERROLE) OR 'NS' IN (USERROLE) OR 'TA' IN (USERROLE) THEN
    RETURN 'MANV = '''||USERNAME||'''';
  ELSE
    RETURN '1=1'; -- Ng??i dùng khác không có quy?n xem
  END IF;
END;
/


BEGIN dbms_rls.add_policy 
(object_schema =>'QLDA',
object_name => 'QLDA_PHANCONG',
policy_name => 'POLICY_NV_NS_TA_XEM_QH_PC',
function_schema => 'QLDA',
policy_function => 'NV_NS_TA_XEM_QH_PC',
statement_types => 'SELECT',
update_check => TRUE);
END;
--Xóa
/*
BEGIN
  dbms_rls.drop_policy (
    object_schema => 'QLDA',
    object_name   => 'QLDA_PHANCONG',
    policy_name   => 'POLICY_NV_NS_TA_XEM_QH_PC');
END;
*/



