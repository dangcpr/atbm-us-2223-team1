--Chính sách 6 cho người dùng có vai trò là Trưởng đề án
CONNECT QLDA/admin123;
alter session set "_ORACLE_SCRIPT"=true;
CREATE ROLE TA;
--Tạo user có role TA
CREATE USER TA001 IDENTIFIED BY TA001;
--Gán role TA cho user TA001
GRANT TA TO TA001;
GRANT CONNECT TO TA;
GRANT SELECT ON QLDA.QLDA_NHANVIEN TO TA;
GRANT SELECT, INSERT, DELETE, UPDATE ON QLDA.QLDA_DEAN TO TA;
--REVOKE SELECT, INSERT, DELETE, UPDATE ON QLDA.QLDA_DEAN FROM TA;

--Vì chính sách bảo mật 
--XÓA
/*
CONNECT QLDA/admin123;
alter session set "_ORACLE_SCRIPT"=true;
DROP USER TA001 CASCADE;
DROP ROLE TA;
-- hủy quyền
*/
