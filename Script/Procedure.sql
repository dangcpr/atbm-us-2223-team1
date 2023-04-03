--Kiểm tra user hoặc role có tồn tại hay không và trả về kêt quả 0 nếu không tồn tại, 1 nếu là user, 2 nếu là role
alter session set "_ORACLE_SCRIPT"=true;

--Viết proc để Drop user nếu tồn tại
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

begin
   execute immediate 'drop function check_user_role_exist';
exception when others then
   if sqlcode != -4043 then
      raise;
   end if;
end;
/

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
exec drop_user('NV001');
create user NV001 identified by 123;
grant connect to NV001;

--Thủ tục cấp quyền select trên thuộc tính của một bảng cho một user hoặc role (không được dùng grant select vì trong Oracle không cho phép)
create or replace procedure grant_select_privilege(
    user_role in char,
    table_name in char,
    column_name in char
)
as
    view_string char(100);
begin
    view_string := 'V_' || user_role || '_' || table_name;
    execute immediate 'CREATE OR REPLACE VIEW ' || view_string || ' AS SELECT ' || column_name || ' FROM ' || table_name;
    execute immediate 'GRANT SELECT ON ' || view_string || ' TO ' || user_role;   
end;
/
exec grant_select_privilege('NV001','TONGHOP','Nam, MaPB');

--Thủ tục cấp quyền UPDATE trên thuộc tính của một bảng cho một user hoặc role (không được dùng grant select vì trong Oracle không cho phép)
create or replace procedure grant_update_privilege(
    user_role in char,
    table_name in char,
    column_name in char
)
is
begin
    execute immediate 'GRANT UPDATE (' || column_name || ') ON ' || table_name || ' TO ' || user_role;
end;
/
exec grant_update_privilege('NV001','TONGHOP','Nam, MaPB');


create or replace procedure grant_insert_privilege(
    user_role in char,
    table_name in char
)
is
begin
    execute immediate 'GRANT INSERT ON ' || table_name || ' TO ' || user_role;
end;
/
exec grant_insert_privilege('NV001','TONGHOP');

create or replace procedure grant_delete_privilege(
    user_role in char,
    table_name in char
)
is
begin
    execute immediate 'GRANT DELETE ON ' || table_name || ' TO ' || user_role;
end;
/
exec grant_delete_privilege('NV001','TONGHOP');

--Viết proc cấp role cho user, kiểm tra xem user và role đó đã tồn tại hay chưa
create or replace function grant_role(
    user_name in char,
    role_name in char
)
return int
as
    user_role_exist int;
BEGIN
    check_user_role_exist(user_name, user_role_exist);
    if user_role_exist = 0 then --Nếu user_name không tồn tại
        return -1;
    end if;
    check_user_role_exist(role_name, user_role_exist);
    if user_role_exist = 0 then --Nếu role_name không tồn tại
        return -2;
    end if;
    execute immediate 'GRANT ' || role_name || ' TO ' || user_name;
    return 3;
EXCEPTION
    WHEN OTHERS THEN
        IF SQLCODE != -01918 THEN
            RAISE;
        END IF;
END;
/
create role NV;
set serveroutput on
begin
    dbms_output.put_line(grant_role('NV001','NV'));
end;
/
--Kiểm tra các role đã cấp của 1 user
select * from DBA_ROLE_PRIVS where GRANTEE = 'NV001';

--Check quyền của 1 user/role có quyền update, insert trên 1 số thuộc tính của một bảng hay không



