UPDATE QLDA.QLDA_NHANVIEN SET NgaySinh = TO_DATE('03/06/1972', 'DD/MM/YYYY'), DiaChi = 'HCM 383', SODT = '0123456789' WHERE MaNV = 'NV001';
COMMIT;
SELECT * FROM QLDA.QLDA_NHANVIEN;

SELECT * FROM QLDA.QLDA_PHONGBAN;
SELECT * FROM QLDA.QLDA_DEAN;
SELECT * FROM QLDA.QLDA_PHANCONG;

SELECT VaiTro FROM QLDA.QLDA_NHANVIEN WHERE MANV = 'NV001'
select sys_context('userenv', 'current_user') from dual;

SELECT
    luong,
    QLDA.encrypt_decrypt.decrypt_nhanvien_luong(luong, '3F569C3F19E25B18B2C12B975F9BC5BB') AS luong_giaima,
    phucap,
    QLDA.encrypt_decrypt.decrypt_nhanvien_phucap(phucap, '3F569C3F19E25B18B2C12B975F9BC5BB') AS phucap_giaima
FROM
    QLDA.qlda_nhanvien;