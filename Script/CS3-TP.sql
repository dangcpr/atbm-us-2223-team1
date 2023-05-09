--CONNECT QLDA/admin123;
--alter session set "_ORACLE_SCRIPT"=true;
CREATE USER TP001 IDENTIFIED BY TP001;
create role TP;
GRANT CONNECT TO TP;
grant TP to TP001;
grant select on QLDA.QLDA_NHANVIEN TO TP;
--drop role TP;
--drop user TP001;

-- Nhân viên ch? có th? xem, s?a thông tin c?a b?n thân 

CREATE OR REPLACE FUNCTION QLDA.TP_XEM_QH_NV(   
   P_SCHEMA IN VARCHAR2 DEFAULT NULL,
   P_OBJECT IN VARCHAR2 DEFAULT NULL
) 
RETURN VARCHAR2 
AS
  USERNAME VARCHAR2(128);
  USERROLE VARCHAR2(128);
  PHONGBAN CHAR(7);
BEGIN
  -- L?y username c?a user hi?n t?i
  USERNAME := SYS_CONTEXT('userenv', 'SESSION_USER');
  
  IF USERNAME = 'QLDA' 
    THEN RETURN '';
  END IF;
  
  SELECT GRANTED_ROLE INTO USERROLE FROM DBA_ROLE_PRIVS WHERE GRANTEE = USERNAME;
  --PB := 'PB001';

  IF 'TP' IN (USERROLE) THEN
    --SELECT MAPB INTO PHONGBAN FROM QLDA_NHANVIEN WHERE MANV = USERNAME;
    RETURN 'MAPB = ''' || 'PB001' || '''';
  ELSE
    RETURN '1=1';
  END IF;
END;

    
/
BEGIN dbms_rls.add_policy 
(object_schema =>'QLDA',
object_name => 'QLDA_NHANVIEN',
policy_name => 'POLICY_TP_XEM_QH_NV',
function_schema => 'QLDA',
policy_function => 'TP_XEM_QH_NV',
statement_types => 'SELECT',
update_check => TRUE);
END;
--Xem danh sách chính sách VPD đã tạo
SELECT *
FROM DBA_POLICIES
/*
BEGIN
  dbms_rls.drop_policy (
    object_schema => 'QLDA',
    object_name   => 'QLDA_NHANVIEN',
    policy_name   => 'POLICY_TP_XEM_QH_NV');
END;
*/
/
CREATE OR REPLACE FUNCTION QLDA.TP_XEM_TT_CUA_TP(   
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

  IF 'TP' IN (USERROLE) THEN
    RETURN 'MANV = ''' || USERNAME || '''';
  ELSE
    RETURN '1=1';
  END IF;
END;
/
BEGIN dbms_rls.add_policy 
(object_schema =>'QLDA',
object_name => 'QLDA_NHANVIEN',
policy_name => 'POLICY_TP_XEM_TT_CUA_TP',
function_schema => 'QLDA',
policy_function => 'TP_XEM_TT_CUA_TP',
statement_types => 'SELECT',
sec_relevant_cols => 'LUONG, PHUCAP',
sec_relevant_cols_opt => dbms_rls.ALL_ROWS,
update_check => TRUE);
END;


/*
BEGIN
  dbms_rls.drop_policy (
    object_schema => 'QLDA',
    object_name   => 'QLDA_NHANVIEN',
    policy_name   => 'POLICY_TP_XEM_TT_CUA_TP');
END;
*/


--REVOKE SELECT, update ON QLDA.QLDA_NHANVIEN FROM NV001;
--  SELECT MAPB FROM QLDA_NHANVIEN WHERE MANV = 'TP001';
    
--drop user NV001 cascade;
--SELECT GRANTED_ROLE FROM DBA_ROLE_PRIVS WHERE GRANTEE = 'TP001';


