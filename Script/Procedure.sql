alter session set "_ORACLE_SCRIPT"=true;

--Proc để Drop role nếu tồn tại
create or replace procedure drop_user(
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
create or replace procedure drop_role(
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
create or replace procedure drop_view(
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
create or replace procedure drop_proc(
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
EXEC drop_proc('check_user_role_exist');
EXEC drop_proc('grant_select_privilege');
EXEC drop_proc('grant_update_privilege');
EXEC drop_proc('grant_insert_privilege');
EXEC drop_proc('grant_delete_privilege');
EXEC drop_proc('grant_role');
EXEC drop_user('NV001');
EXEC drop_role('KH')
EXEC drop_role('NV');
EXEC drop_role('DV');
create user NV001 IDENTIFIED BY NV001;
create role NV;
create role KH;
create role DV;
grant connect to NV001;

--Kiểm tra user hoặc role có tồn tại hay không và trả về kêt quả 0 nếu không tồn tại, 1 nếu là user, 2 nếu là role
create or replace procedure check_user_role_exist(
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
   check_user_role_exist('NV001', res);
   dbms_output.put_line(res);
end;
/

--Test tạo user NV001 và phân quyền Connect. Nếu user đã tồn tại thì drop user đó đi
grant connect to NV001;

--Thủ tục cấp quyền select trên thuộc tính của một bảng cho một user hoặc role (không được dùng grant select vì trong Oracle không cho phép)
create or replace procedure grant_select_privilege(
    user_role in char,
    table_name in char,
    column_name in char,
    withgrantoption char
)
as
    view_string char(100);
begin
    view_string := 'V_' || user_role || '_' || table_name;
    drop_view(view_string);
    execute immediate 'CREATE OR REPLACE VIEW ' || view_string || ' AS SELECT ' || column_name || ' FROM ' || table_name;
    execute immediate 'GRANT SELECT ON ' || view_string || ' TO ' || user_role || ' ' || withgrantoption;   
end;
/
exec grant_select_privilege('NV001','TONGHOP','Nam, MaPB', 'WITH GRANT OPTION');
exec drop_view('V_NV001_TONGHOP')

--Thủ tục cấp quyền UPDATE trên thuộc tính của một bảng cho một user hoặc role (không được dùng grant select vì trong Oracle không cho phép)
create or replace procedure grant_update_privilege(
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
exec grant_update_privilege('NV001','TONGHOP','Nam, MaPB', '');


create or replace procedure grant_insert_privilege(
    user_role in char,
    table_name in char,
    withgrantoption char
)
is
begin
    execute immediate 'GRANT INSERT ON ' || table_name || ' TO ' || user_role || ' ' || withgrantoption;
end;
/
exec grant_insert_privilege('NV001','TONGHOP', '');

create or replace procedure grant_delete_privilege(
    user_role in char,
    table_name in char,
    withgrantoption char
)
is
begin
    execute immediate 'GRANT DELETE ON ' || table_name || ' TO ' || user_role || ' ' || withgrantoption;
end;
/
exec grant_delete_privilege('NV001','TONGHOP','WITH GRANT OPTION');

--Viết proc cấp role cho user, kiểm tra xem user và role đó đã tồn tại hay chưa
create or replace procedure grant_role(
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



