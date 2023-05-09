--CONNECT QLDA/admin123;
--alter session set "_ORACLE_SCRIPT"=true;
CREATE USER NV001 IDENTIFIED BY NV001;
create role NV;
GRANT CONNECT TO NV;
grant NV to NV001;


grant select,update on QLDA.QLDA_NHANVIEN to NV;
CREATE VIEW V_NV_QLDA_NHANVIEN AS
select * from QLDA.QLDA_NHANVIEN;
grant select on QLDA.V_NV_QLDA_NHANVIEN TO NV;

-- Nhân viên ch? có th? xem, s?a thông tin c?a b?n thân 
--DROP FUNCTION NV_XEM_SUA_TT_CA_NHAN;
CREATE OR REPLACE FUNCTION QLDA.NV_XEM_SUA_TT_CA_NHAN(   
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
  
  IF USERNAME = 'QLDA' 
    THEN RETURN '';
  END IF;
  
  SELECT GRANTED_ROLE INTO USERROLE FROM DBA_ROLE_PRIVS WHERE GRANTEE = USERNAME;
  
  IF 'NV' IN (USERROLE) THEN
    RETURN 'MANV = ''' || USERNAME || '''';
  ELSE
    RETURN '1=1';
  END IF;
END;
/
BEGIN dbms_rls.add_policy 
(object_schema =>'QLDA',
object_name => 'QLDA_NHANVIEN',
policy_name => 'POLICY_NV_XEM_SUA_TT_CA_NHAN',
function_schema => 'QLDA',
policy_function => 'NV_XEM_SUA_TT_CA_NHAN',
statement_types => 'SELECT, UPDATE',
update_check => TRUE);
END;


/*
BEGIN
  dbms_rls.drop_policy (
    object_schema => 'QLDA',
    object_name   => 'QLDA_NHANVIEN',
    policy_name   => 'POLICY_NV_XEM_SUA_TT_CA_NHAN');
END;
*/


--REVOKE SELECT, update ON QLDA.QLDA_NHANVIEN FROM NV001;
--select * from QLDA.QLDA_NHANVIEN;
/
    
--drop user NV001 cascade;



