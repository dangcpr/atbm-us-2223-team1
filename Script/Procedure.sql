alter session set "_ORACLE_SCRIPT"=true;

--REVOKE DBA FROM QLDA;

-- Xo� user QLTT n?u t?n t?i
/*
BEGIN
  EXECUTE IMMEDIATE 'DROP USER QLDA CASCADE' ;
EXCEPTION
  WHEN OTHERS THEN
    IF SQLCODE != -1918 THEN
      RAISE;
    END IF;
END;
*/
/

CREATE USER QLDA IDENTIFIED BY admin123
ENABLE EDITIONS;
/

GRANT DBA TO QLDA WITH ADMIN OPTION;
GRANT CONNECT TO QLDA WITH ADMIN OPTION;
GRANT SELECT ANY DICTIONARY TO QLDA;
GRANT CREATE SESSION, CREATE VIEW, ALTER SESSION, CREATE SEQUENCE TO QLDA;
GRANT CREATE SYNONYM, CREATE DATABASE LINK, RESOURCE , UNLIMITED TABLESPACE TO QLDA;
GRANT CREATE USER, CREATE ROLE, ALTER USER, ALTER ANY ROLE, DROP USER, DROP ANY ROLE TO QLDA;
GRANT EXECUTE ON DBMS_CRYPTO TO QLDA; 

CONNECT QLDA/admin123;
alter session set "_ORACLE_SCRIPT"=true;
--Xem các proc đã tạo
SELECT * FROM ALL_OBJECTS WHERE OBJECT_TYPE = 'PROCEDURE';
--Xem các user đã tạo và owner của user
SELECT * FROM ALL_USERS;
--Proc để Drop role nếu tồn tại
create or replace procedure QLDA.drop_user(
    user_name in char
)
IS
BEGIN
    execute immediate 'DROP USER ' || user_name || ' CASCADE';
EXCEPTION
    WHEN OTHERS THEN
        IF SQLCODE != -01918 THEN
            RAISE;
        END IF;
END;
/

--Proc để Drop role nếu tồn tại
create or replace procedure QLDA.drop_role(
    role_name in char
)
IS
BEGIN
    execute immediate 'DROP ROLE ' || role_name;
EXCEPTION
    WHEN OTHERS THEN
        IF SQLCODE != -01919 THEN
            RAISE;
        END IF;
END;
/

--Thủ tục drop 1 view nếu tồn tại
create or replace procedure QLDA.drop_view(
    view_name in char
)
IS
BEGIN
    execute immediate 'DROP VIEW ' || view_name;
EXCEPTION
    WHEN OTHERS THEN
        IF SQLCODE != -00942 THEN
            RAISE;
        END IF;
END;
/
--Thủ tục drop 1 proc đã tồn tại
create or replace procedure QLDA.drop_proc(
    proc_name in char
)
IS
BEGIN
    execute immediate 'DROP PROCEDURE ' || proc_name;
EXCEPTION
    WHEN OTHERS THEN
        IF SQLCODE != -04043 THEN
            RAISE;
        END IF;
END;
/
EXEC QLDA.drop_proc('QLDA.check_user_role_exist');
EXEC QLDA.drop_proc('QLDA.grant_select_privilege');
EXEC QLDA.drop_proc('QLDA.grant_update_privilege');
EXEC QLDA.drop_proc('QLDA.grant_insert_privilege');
EXEC QLDA.drop_proc('QLDA.grant_delete_privilege');
EXEC QLDA.drop_proc('QLDA.grant_role');
EXEC QLDA.drop_user('NV001');
EXEC QLDA.drop_role('KH')
EXEC QLDA.drop_role('NV');
EXEC QLDA.drop_role('DV');
create user NV001 IDENTIFIED BY NV001;
create role NV;
create role KH;
create role DV;
grant connect to NV001;

--Kiểm tra user hoặc role có tồn tại hay không và trả về kêt quả 0 nếu không tồn tại, 1 nếu là user, 2 nếu là role
create or replace procedure QLDA.check_user_role_exist(
    user_role in char,
    result_ out number
)
as
    cnt int;
begin
    SELECT count(*) into cnt FROM DBA_ROLES WHERE role = user_role;
    if cnt > 0 then
        result_ := 2;
    else 
        begin
            SELECT count(*) into cnt FROM DBA_USERS WHERE username = user_role;
            if cnt > 0 then
                result_ := 1;
            else
                result_ := 0;
            end if;
        end;
    end if;
end;
/
SET SERVEROUTPUT ON
declare
    res number;
begin
   QLDA.check_user_role_exist('NV001', res);
   dbms_output.put_line(res);
end;
/

--Test tạo user NV001 và phân quyền Connect. Nếu user đã tồn tại thì drop user đó đi
--grant connect to NV001;

--Thủ tục cấp quyền select trên thuộc tính của một bảng cho một user hoặc role (không được dùng grant select vì trong Oracle không cho phép)
create or replace procedure QLDA.grant_select_privilege(
    user_role in char,
    schema_name in char,
    table_name in char,
    column_name in char,
    withgrantoption in char
)
as
    view_string char(100);
begin
    view_string := 'V_' || table_name || '_' || user_role ;
    drop_view(schema_name || '.' ||view_string);
    execute immediate 'CREATE OR REPLACE VIEW ' || schema_name || '.' || view_string || ' AS SELECT ' ||column_name || ' FROM ' ||schema_name || '.' || table_name;
    execute immediate 'GRANT SELECT ON ' || schema_name || '.' || view_string || ' TO ' || user_role || ' ' || withgrantoption;   
end;
/
--Test tạo view và phân quyền select cho user NV001
--exec QLDA.grant_select_privilege('NV001', 'QLDA', 'QLDA_PHONGBAN', 'MAPB, TENPB', 'WITH GRANT OPTION');
CREATE OR REPLACE VIEW QLDA.ABC AS SELECT MAPB, TENPB FROM QLDA.QLDA_PHONGBAN;
--exec drop_view('V_NV001_TONGHOP')
--xem các view đã tạo
SELECT * FROM ALL_OBJECTS WHERE OBJECT_TYPE = 'VIEW' and OWNER = 'SYS';

--Thủ tục cấp quyền UPDATE trên thuộc tính của một bảng cho một user hoặc role (không được dùng grant select vì trong Oracle không cho phép)
create or replace procedure QLDA.grant_update_privilege(
    user_role in char,
    table_name in char,
    column_name in char,
    withgrantoption char
)
is
begin
    execute immediate 'GRANT UPDATE (' || column_name || ') ON ' || table_name || ' TO ' || user_role || ' ' || withgrantoption;
end;
/
--exec QLDA.grant_update_privilege('NV001','TONGHOP','Nam, MaPB', '');


create or replace procedure QLDA.grant_insert_privilege(
    user_role in char,
    table_name in char,
    withgrantoption char
)
is
begin
    execute immediate 'GRANT INSERT ON ' || table_name || ' TO ' || user_role || ' ' || withgrantoption;
end;
/
--exec QLDA.grant_insert_privilege('NV001','TONGHOP', '');

create or replace procedure QLDA.grant_delete_privilege(
    user_role in char,
    table_name in char,
    withgrantoption char
)
is
begin
    execute immediate 'GRANT DELETE ON ' || table_name || ' TO ' || user_role || ' ' || withgrantoption;
end;
/
--exec QLDA.grant_delete_privilege('NV001','TONGHOP','WITH GRANT OPTION');

--Viết proc cấp role cho user, kiểm tra xem user và role đó đã tồn tại hay chưa
create or replace procedure QLDA.grant_role(
    user_name in char,
    role_name in char,
    withadminoption in char,
    result_ out number
)
as
    user_role_exist int;
BEGIN
    check_user_role_exist(user_name, user_role_exist);
    if user_role_exist = 0 or user_role_exist = 2 then --Nếu user_name không tồn tại
        result_ := -1;
        return;
    end if;
    check_user_role_exist(role_name, user_role_exist);
    if user_role_exist = 0 or user_role_exist = 1 then --Nếu role_name không tồn tại
        result_ := -2;
        return;
    end if;
    execute immediate 'GRANT ' || role_name || ' TO ' || user_name || ' ' || withadminoption;
    result_ := 3;
    return;
EXCEPTION
    WHEN OTHERS THEN
        IF SQLCODE != -01918 THEN
            RAISE;
        END IF;
END;
/
set serveroutput on
declare res int;
begin
    grant_role('NV001','NV', 'WITH ADMIN OPTION', res);
    dbms_output.put_line(res);
end;
/
--Kiểm tra các role đã cấp của 1 user
select * from DBA_ROLE_PRIVS where GRANTEE = 'NV001';

--Check quyền của 1 user/role có quyền update, insert.
select * from DBA_TAB_PRIVS where GRANTEE = 'NV001';
select * from DBA_TAB_PRIVS where GRANTEE = 'KH';
--exec GRANT_UPDATE_PRIVILEGE('NV','TONGHOP','Nam, MaPB', '');
--Check thuộc tính trên một view mà user có quyền.
select * from DBA_COL_PRIVS where GRANTEE = 'NV001';
DESCRIBE V_NV001_QLDA_PHANCONG;

CREATE OR REPLACE PROCEDURE QLDA.revoke_privil
(
    username varchar2,
    table_view varchar2,
    privil varchar,
    result_ OUT int
)
IS
BEGIN  
    EXECUTE IMMEDIATE ('REVOKE ' || privil || ' ON ' || table_view || ' from ' || username);
    result_ := 1;
    EXCEPTION
    WHEN OTHERS THEN
        result_ := 0;
END;

/

--Tao user.
CREATE OR REPLACE PROCEDURE QLDA.create_user(p_username IN VARCHAR2, p_password IN VARCHAR2)
IS
BEGIN
  EXECUTE IMMEDIATE 'CREATE USER ' || p_username || ' IDENTIFIED BY ' || p_password;
  EXECUTE IMMEDIATE 'GRANT CONNECT TO ' || p_username;
END;
/
--BEGIN 
--create_user('MANGA', '123');
--END;
--/

--Xoa user.
CREATE OR REPLACE PROCEDURE QLDA.delete_user(p_username IN VARCHAR2)
IS
BEGIN
  EXECUTE IMMEDIATE ('DROP USER ' || p_username);
END;
/




--Update tai khoan
CREATE OR REPLACE PROCEDURE QLDA.change_password (
   p_username IN VARCHAR2,
   p_new_password IN VARCHAR2
) AS
   v_user_count NUMBER;
BEGIN
   -- Check if the user exists and the old password is correct
   SELECT COUNT(*)
   INTO v_user_count
   FROM dba_users
   WHERE username = p_username;
   
   IF v_user_count = 0 THEN
      RAISE_APPLICATION_ERROR(-20001, 'User does not exist is incorrect');
   END IF;
   
   -- Change the user's password
   EXECUTE IMMEDIATE 'ALTER USER ' || p_username || ' IDENTIFIED BY ' || p_new_password;
   DBMS_OUTPUT.PUT_LINE('Password changed successfully');
EXCEPTION
   WHEN OTHERS THEN
      DBMS_OUTPUT.PUT_LINE('Error: ' || SQLERRM);
END;
/
--BEGIN
--    change_password('MANGA','234');
--END;
--/

--Tao role 
CREATE OR REPLACE PROCEDURE QLDA.create_role(
  p_role_name IN VARCHAR2,
  p_password IN VARCHAR2 DEFAULT NULL
)
IS
BEGIN
  IF p_password IS NULL THEN
  BEGIN
    EXECUTE IMMEDIATE ('CREATE ROLE ' || p_role_name);
    EXECUTE IMMEDIATE 'GRANT CONNECT TO ' || p_role_name;
  END;
  ELSE
    EXECUTE IMMEDIATE ('CREATE ROLE ' || p_role_name || ' IDENTIFIED BY ' || p_password);
  END IF;
END;
/
--BEGIN
--create_role ('LMN');
--END;
--/


--Drop role
CREATE OR REPLACE PROCEDURE QLDA.delete_role (
    p_role_name IN VARCHAR2
) AS
BEGIN
        EXECUTE IMMEDIATE ('DROP ROLE ' || p_role_name);
EXCEPTION
    WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20001, 'Error deleting role: ' || SQLERRM);
END delete_role;
/
--BEGIN
--delete_role('LMN');
--END;
--/

--Change role
CREATE OR REPLACE PROCEDURE QLDA.change_role_password(
  p_role_name IN VARCHAR2,
  p_new_password IN VARCHAR2
)
IS
  role_exists NUMBER;
BEGIN
  SELECT COUNT(*)
  INTO role_exists
  FROM dba_roles
  WHERE role = p_role_name;

  IF role_exists > 0 THEN
    IF (p_new_password IS NULL) THEN
      EXECUTE IMMEDIATE 'ALTER ROLE ' || p_role_name || ' NOT IDENTIFIED';
      DBMS_OUTPUT.PUT_LINE('Password for role ' || p_role_name || ' has been removed.');
    ELSE
      EXECUTE IMMEDIATE 'ALTER ROLE ' || p_role_name || ' IDENTIFIED BY ' || p_new_password;
      DBMS_OUTPUT.PUT_LINE('Password for role ' || p_role_name || ' has been changed.');
    END IF;
  ELSE
    DBMS_OUTPUT.PUT_LINE('Role ' || p_role_name || ' does not exist.');
  END IF;
END;
/
GRANT NV TO NV001;
REVOKE NV FROM NV001;

--BEGIN
--  change_role_password('YUGI', '123');
--END;
--/
--Proc revoke role của user, kiểm tra user có tồn tại hay không, role có tồn tại hay không, role đó có được cấp cho user chưa.
CREATE OR REPLACE PROCEDURE QLDA.revoke_role
(
    user_name varchar2,
    role_name varchar2,
    result_ OUT int
)
IS
    user_role_exist int;
    res int;
BEGIN
    check_user_role_exist(user_name, user_role_exist);
    if user_role_exist = 0 or user_role_exist = 2 then --Nếu user_name không tồn tại
        result_ := -1;
        return;
    end if;
    check_user_role_exist(role_name, user_role_exist);
    if user_role_exist = 0 or user_role_exist = 1 then --Nếu role_name không tồn tại
        result_ := -2;
        return;
    end if;
    select count(*) into res from dba_role_privs where grantee = user_name and granted_role = role_name;
    if res = 0 then
        result_ := -3;
        return;
    end if;
    execute immediate ('REVOKE ' || role_name || ' FROM ' || user_name);
    result_ := 3;
EXCEPTION
    WHEN OTHERS THEN
        IF SQLCODE != -01918 THEN
            RAISE;
        END IF;
END;
/
--revoke NV from NV001;
--grant role DV to NV001;

--select bảng role của user
select * from dba_role_privs where grantee = 'NV001';

--Xem các table đã tạo
select * from dba_tables where owner = 'QLDA';
--xem các quyền đã tạo
select * from dba_tab_privs where grantee = 'TP';



open result_ for
select COLUMN_NAME from dba_tab_columns where table_name = 'QLDA_PHONGBAN';
-- lấy user trong connection hiện tại
select sys_context('userenv', 'current_user') from dual;
-- Lấy owner của view
select * from dba_tables where owner = 'QLDA';
--Lấy role của user
select * from dba_role_privs where grantee = 'NV001';



