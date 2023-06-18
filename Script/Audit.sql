alter session set "_ORACLE_SCRIPT"=true;

--CAU A
BEGIN
  DBMS_FGA.ADD_POLICY(
    object_schema    => 'QLDA',
    object_name      => 'QLDA_PHANCONG',
    policy_name      => 'THOIGIAN_PHANCONG_AUDIT',
    audit_column     => 'THOIGIAN',
    audit_condition  => NULL,
    statement_types  => 'UPDATE',
    audit_trail => dbms_fga.db + dbms_fga.extended);
END;

/*
BEGIN
       DBMS_FGA.drop_policy (object_schema      => 'QLDA',
                             object_name        => 'QLDA_PHANCONG',
                             policy_name        => 'THOIGIAN_PHANCONG_AUDIT');
END;
*/

--CAU B.
--Hàm check user audit vì có một số user dùng table, 1 số user dùng view
CREATE OR REPLACE FUNCTION AUD_F_TABLE_NV(pTxtUser IN VARCHAR2)
RETURN PLS_INTEGER
AS
  USERROLE VARCHAR2(20);
BEGIN
    IF(pTxtUser = 'QLDA') THEN
        RETURN 1;
    END IF;
    
    SELECT GRANTED_ROLE INTO USERROLE FROM DBA_ROLE_PRIVS WHERE GRANTEE = pTxtUser;
    
    IF('NV' IN (USERROLE) OR 'TA' IN (USERROLE) OR 'GD' IN (USERROLE) OR 'TC' IN (USERROLE)) THEN
        RETURN 1;
    ELSIF('QL' IN (USERROLE) OR 'TP' IN (USERROLE) OR 'NS' IN (USERROLE)) THEN
        RETURN 2;
    ELSE
        RETURN 0;
    END IF;
END;
--DROP function AUD_F_TABLE_NV;
--Audit Table QLDA_NHANVIEN
begin
    dbms_fga.add_policy(
        object_schema => 'QLDA',
        object_name => 'QLDA_NHANVIEN',
        policy_name => 'AUDIT_SELECT_LUONG_PHUCAP',
        audit_column => 'LUONG, PHUCAP',
        audit_condition => 'MANV != USER AND (QLDA.AUD_F_TABLE_NV(USER) = 1 OR QLDA.AUD_F_TABLE_NV(USER) = 0)',
        handler_schema     =>   NULL, 
        handler_module     =>   NULL,
        statement_types => 'SELECT',
        --audit_column_opts => dbms_fga.all_columns,
        audit_trail => dbms_fga.db + dbms_fga.extended);
end;

/
--Audit view V_QLDA_NHANVIEN_NS
begin
    dbms_fga.add_policy(
        object_schema => 'QLDA',
        object_name => 'V_QLDA_NHANVIEN_NS',
        policy_name => 'AUDIT_SELECT_V_LUONG_PHUCAP',
        audit_column => 'LUONG, PHUCAP',
        audit_condition => 'MANV != USER AND (QLDA.AUD_F_TABLE_NV(USER) = 2  OR QLDA.AUD_F_TABLE_NV(USER) = 0)',
        handler_schema     =>   NULL, 
        handler_module     =>   NULL,
        statement_types => 'SELECT',
        --audit_column_opts => dbms_fga.all_columns,
        audit_trail => dbms_fga.db + dbms_fga.extended);
end;

/

/*
--drop FGA
BEGIN
       DBMS_FGA.drop_policy (object_schema      => 'QLDA',
                             object_name        => 'QLDA_NHANVIEN',
                             policy_name        => 'AUDIT_SELECT_LUONG_PHUCAP');
END;

BEGIN
       DBMS_FGA.drop_policy (object_schema      => 'QLDA',
                             object_name        => 'V_QLDA_NHANVIEN_NS',
                             policy_name        => 'AUDIT_SELECT_V_LUONG_PHUCAP');
END;
/
*/

--CAU C.
--Hàm kiểm tra role TC, nếu 1 là không bị audit, 0 là bị audit
CREATE OR REPLACE FUNCTION CHECK_TC(pTxtUser IN VARCHAR2)
RETURN PLS_INTEGER
AS
  USERROLE VARCHAR2(20);
BEGIN
    IF(pTxtUser = 'QLDA') THEN
        RETURN 1;
    END IF;
    
    SELECT GRANTED_ROLE INTO USERROLE FROM DBA_ROLE_PRIVS WHERE GRANTEE = pTxtUser;
    
    IF('TC' IN (USERROLE)) THEN
        RETURN 1;
    ELSE
        RETURN 0;
    END IF;
END;

/*
SET SERVEROUTPUT ON
BEGIN
    IF (AUD_F_TABLE_NV('TP001') = 1) THEN
        DBMS_OUTPUT.PUT_LINE('AUDIT');
    ELSE
        DBMS_OUTPUT.PUT_LINE('NO AUDIT');
    END IF;
END;
*/ 
  
begin
    dbms_fga.add_policy(
        object_schema => 'QLDA',
        object_name => 'QLDA_NHANVIEN',
        policy_name => 'AUDIT_UPDATE_LUONG_PHUCAP',
        audit_column => 'LUONG, PHUCAP',
        audit_condition => 'QLDA.CHECK_TC(USER) = 0',
        handler_schema     =>   NULL,
        handler_module     =>   NULL,
        statement_types => 'UPDATE',
        --audit_column_opts => dbms_fga.all_columns,
        audit_trail => dbms_fga.db + dbms_fga.extended);
end;
/
/*
--drop FGA
BEGIN
       DBMS_FGA.drop_policy (object_schema      => 'QLDA',
                             object_name        => 'QLDA_NHANVIEN',
                             policy_name        => 'AUDIT_UPDATE_LUONG_PHUCAP');
END;
*/

--CAU D
select AUDIT_TYPE, DBUSERNAME, EVENT_TIMESTAMP, ACTION_NAME, OBJECT_NAME, SQL_TEXT, FGA_POLICY_NAME, OBJECT_TYPE 
from unified_audit_trail
where FGA_POLICY_NAME = 'THOIGIAN_PHANCONG_AUDIT' and OBJECT_NAME = 'QLDA_PHANCONG';

select AUDIT_TYPE, DBUSERNAME, EVENT_TIMESTAMP, ACTION_NAME, OBJECT_NAME, SQL_TEXT, FGA_POLICY_NAME, OBJECT_TYPE
from unified_audit_trail;

select AUDIT_TYPE, DBUSERNAME, EVENT_TIMESTAMP, ACTION_NAME, OBJECT_NAME, SQL_TEXT, FGA_POLICY_NAME, OBJECT_TYPE 
from unified_audit_trail
where FGA_POLICY_NAME = 'AUDIT_SELECT_LUONG_PHUCAP' OR FGA_POLICY_NAME = 'AUDIT_SELECT_V_LUONG_PHUCAP';


select AUDIT_TYPE, DBUSERNAME, EVENT_TIMESTAMP, ACTION_NAME, OBJECT_NAME, SQL_TEXT, FGA_POLICY_NAME, OBJECT_TYPE 
from unified_audit_trail
where FGA_POLICY_NAME = 'AUDIT_UPDATE_LUONG_PHUCAP' and OBJECT_NAME = 'QLDA_NHANVIEN';


--TEST
create user ACCTEST identified by ACCTEST;
create role ROLETEST;
grant EXECUTE ON QLDA.ENCRYPT_DECRYPT to ROLETEST;
grant connect to ROLETEST;
--revoke EXECUTE ON QLDA.ENCRYPT_DECRYPT from ROLETEST;
--grant TC TO ROLETEST;
--revoke TC from ROLETEST;
GRANT INSERT, SELECT, UPDATE ON QLDA.QLDA_NHANVIEN TO ROLETEST;
GRANT SELECT, UPDATE ON QLDA.QLDA_PHANCONG TO ROLETEST;
GRANT ROLETEST TO ACCTEST;

update  QLDA.QLDA_NHANVIEN
SET LUONG = '1770'
WHERE MANV = 'NV001';

SELECT * FROM QLDA.QLDA_NHANVIEN;
/*
--Xóa dữ liệu audit
BEGIN
DBMS_AUDIT_MGMT.CLEAN_AUDIT_TRAIL(
audit_trail_type => DBMS_AUDIT_MGMT.AUDIT_TRAIL_UNIFIED,
use_last_arch_timestamp => FALSE);
END;
*/
--select list audit policies
select *
from
  user_audit_policies
where
  policy_name = 'AUDIT_SELECT_V_LUONG_PHUCAP';