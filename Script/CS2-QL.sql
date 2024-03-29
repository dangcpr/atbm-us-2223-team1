CONNECT QLDA/admin123;
alter session set "_ORACLE_SCRIPT"=true;
CREATE USER QL001 IDENTIFIED BY QL001;
--drop user QL001
create role QL;
GRANT CONNECT TO QL;
grant QL to QL001;
--GRANT SELECT ON QLDA.QLDA_NHANVIEN TO QL;
--REVOKE SELECT ON QLDA.QLDA_NHANVIEN FROM QL;
GRANT SELECT ON QLDA.V_QLDA_NHANVIEN_NS TO QL ; --View đã tạo bên CS5
select * from QLDA_NHANVIEN;

--drop table LOOKUP_QLDA_NHANVIEN;

--QL có thể xem thông tin của mình và nhân viên mình quản lý
CREATE OR REPLACE FUNCTION QLDA.QL_XEM_QH_NV(
  P_SCHEMA IN VARCHAR2 DEFAULT NULL,
  P_OBJECT IN VARCHAR2 DEFAULT NULL
) RETURN VARCHAR2 AS
  USERNAME VARCHAR2(128);
  USERROLE VARCHAR2(128);
  
BEGIN
 -- Lấy username của user hiện tại
  USERNAME := SYS_CONTEXT('userenv', 'SESSION_USER');
  IF USERNAME = 'QLDA' THEN
    RETURN '';
  END IF;
  SELECT GRANTED_ROLE INTO USERROLE
  FROM DBA_ROLE_PRIVS
  WHERE GRANTEE = USERNAME;
  IF 'QL' IN (USERROLE) THEN 
      RETURN 'MANQL = ''' ||USERNAME|| '''  OR MANV = '''||USERNAME||''' ';
  ELSE
    RETURN '1=1';
  END IF;
END;
/

BEGIN
  DBMS_RLS.ADD_POLICY (
    OBJECT_SCHEMA =>'QLDA',
    OBJECT_NAME => 'V_QLDA_NHANVIEN_NS',
    POLICY_NAME => 'POLICY_QL_XEM_QH_NV',
    FUNCTION_SCHEMA => 'QLDA',
    POLICY_FUNCTION => 'QL_XEM_QH_NV',
    STATEMENT_TYPES => 'SELECT',
    UPDATE_CHECK => TRUE
  );
END;
/

--NHANVIEN có quyền xem như NHANVIEN (đã cài trong CS3-TP)

/*
BEGIN
  dbms_rls.drop_policy (
    object_schema => 'QLDA',
    object_name   => 'QLDA_NHANVIEN',
    policy_name   => 'POLICY_QL_XEM_QH_NV');
END;
/
*/
/*
CREATE OR REPLACE FUNCTION QLDA.QL_XEM_PHANCONG(
  P_SCHEMA IN VARCHAR2 DEFAULT NULL,
  P_OBJECT IN VARCHAR2 DEFAULT NULL
) RETURN VARCHAR2 AS
  USERNAME VARCHAR2(128);
  USERROLE VARCHAR2(128);
BEGIN
 -- Lấy username của user hiện tại
  USERNAME := SYS_CONTEXT('userenv', 'SESSION_USER');
  IF USERNAME = 'QLDA' THEN
    RETURN '';
  END IF;
  SELECT GRANTED_ROLE INTO USERROLE
  FROM DBA_ROLE_PRIVS
  WHERE GRANTEE = USERNAME;
  IF 'QL' IN (USERROLE) THEN 
      RETURN 'MANQL = ''' ||USERNAME|| '''  OR MANV = '''||USERNAME||''' ';
  ELSE
    RETURN '1=1';
  END IF;
END;
/
*/

--Yêu cầu 2 của cs2. Khi làm giao diện thì cho select thẳng cái view này luôn.
--Quản lý chỉ được xem phân công nhân viên thuộc phòng ban của mình (đã cài VPD ở cs3)
CREATE OR REPLACE VIEW V_QLDA_PHANCONG_QL
AS
SELECT PC.*
FROM QLDA.QLDA_NHANVIEN NV, QLDA.QLDA_PHANCONG PC
WHERE NV.MANV = PC.MANV AND (NV.MANQL = USER OR NV.MANV = USER);

GRANT SELECT ON QLDA.V_QLDA_PHANCONG_QL TO QL;


--TP, QL chỉ sửa thông tin của chính mình
CREATE OR REPLACE FUNCTION QLDA.TP_QL_SUA_TT_CA_NHAN (
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
  
  IF 'QL' IN (USERROLE) OR 'TP' IN (USERROLE) THEN
    RETURN 'MANV = '''||USERNAME||'''';
  ELSE
    RETURN '1=1'; -- Ng??i dùng khác không có quy?n xem
  END IF;
END;
/


BEGIN dbms_rls.add_policy 
(object_schema =>'QLDA',
object_name => 'V_QLDA_NHANVIEN_NS',
policy_name => 'POLICY_TP_QL_SUA_TT_CA_NHAN',
function_schema => 'QLDA',
policy_function => 'TP_QL_SUA_TT_CA_NHAN',
statement_types => 'UPDATE',
update_check => TRUE);
END;
/
/*
BEGIN
  dbms_rls.drop_policy (
    object_schema => 'QLDA',
    object_name   => 'V_QLDA_NHANVIEN_NS',
    policy_name   => 'POLICY_TP_QL_SUA_TT_CA_NHAN');
END;
*/


SELECT * FROM DBA_POLICIES;