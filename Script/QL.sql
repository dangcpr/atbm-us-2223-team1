SELECT NV1.*,  
    QLDA.encrypt_decrypt.decrypt_nhanvien_luong(luong, QLDA.ENCRYPT_DECRYPT.CREATE_KEY((SELECT MANV FROM QLDA.V_QLDA_NHANVIEN_NS NV2 WHERE NV1.MANV = NV2.MANV), QLDA.ENCRYPT_DECRYPT.SEQ_NUM)) AS luong_giaima,
    QLDA.encrypt_decrypt.decrypt_nhanvien_phucap(phucap, QLDA.ENCRYPT_DECRYPT.CREATE_KEY((SELECT MANV FROM QLDA.V_QLDA_NHANVIEN_NS NV2 WHERE NV1.MANV = NV2.MANV), QLDA.ENCRYPT_DECRYPT.SEQ_NUM)) AS phucap_giaima FROM QLDA.V_QLDA_NHANVIEN_NS NV1;
    
SELECT * FROM QLDA.V_QLDA_PHANCONG_QL;
--SELECT * FROM QLDA.QLDA_PHANCONG;


SELECT * FROM QLDA.QLDA_PHONGBAN;
SELECT * FROM QLDA.QLDA_DEAN;

UPDATE QLDA.V_QLDA_NHANVIEN_NS
SET SODT = '0986285783'
WHERE MANV = 'QL001';
COMMIT;
SELECT MANV, TENNV, LUONG FROM QLDA.V_QLDA_NHANVIEN_NS WHERE MANV = 'NV300';

UPDATE QLDA.V_QLDA_PHANCONG_QL
SET THOIGIAN = TO_DATE('11/1/2023', 'DD/MM/YYYY')
WHERE MANV = 'NS001';
COMMIT;
