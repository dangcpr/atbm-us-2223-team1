ALTER SESSION SET CONTAINER = PDB1;

--Đăng nhập vào mỗi GD để xem sự khác nhau của thông báo.
SELECT * FROM QLDA_PDB1.THONGBAO;

DROP USER TP002;