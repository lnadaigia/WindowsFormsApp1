GO

CREATE VIEW getNhanVien AS
select * from NhanVien

GO
CREATE VIEW getNhanVienDeChiaCa AS
SELECT MaNV,Hoten,SoDT,Ngaysinh FROM NhanVien where Role='employee'

GO
CREATE VIEW LoadTable AS
SELECT * FROM Ban
GO

GO
CREATE VIEW getvoucher AS
select * from voucher
GO


SELECT * FROM getvoucher

go

CREATE VIEW getDanhSachCa AS
select * FROM Ca
GO

SELECT * FROM getDanhSachCa
go

CREATE VIEW getDanhSachCaDeChiaCa AS
SELECT Maca,Tenca,GioBatDau,GioKetThuc FROM Ca
GO

select * from getDanhSachCaDeChiaCa