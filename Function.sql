create function getDanhSachCaChoNV(@manv int)
returns table
as
return
SELECT Ca.Tenca, Ca.GioBatDau,Ca.GioKetThuc FROM Ca,ChiaCa,NhanVien WHERE Ca.Maca=ChiaCa.Maca
 AND ChiaCa.Manv=NhanVien.MaNV  AND NhanVien.MaNV=@manv AND ChiaCa.ngay=CONVERT(Date,getdate())
go




declare @manv int 
set @manv=16
select * FROM getDanhSachCaChoNV(@manv)

go

create function getDanhSachNhanVienVaCa(@gio time)
returns table
as
return
SELECT ChiaCa.*,Ca.Tenca,NhanVien.Hoten,NhanVien.SoDT,Ca.GioBatDau,Ca.GioKetThuc 
FROM ChiaCa,Ca,NhanVien where Ca.Maca=ChiaCa.Maca AND NhanVien.MaNV=ChiaCa.Manv 
AND ChiaCa.ngay = CONVERT(date, getdate()) AND CA.Maca in 
(SELECT Maca FROM Ca WHERE CONVERT(time, @gio) BETWEEN Ca.GioBatDau AND Ca.GioKetThuc)
go


SELECT * FROM getDanhSachNhanVienVaCa('12:00:00')


go

create function getDanhSachCaTheoNV(@MaNV int)
returns table
as
return
SELECT ChiaCa.ngay,Ca.* FROM ChiaCa,Ca WHERE ChiaCa.Maca= Ca.Maca AND Manv=@MaNV
go

SELECT * FROM getDanhSachCaTheoNV(@MaNV)

go

create function getDanhSachCaTheoNVVaTheoNgay(@MaNV int,@date date)
returns table
as
return
SELECT ChiaCa.ngay,Ca.* FROM ChiaCa,Ca WHERE ChiaCa.Maca= Ca.Maca AND Manv=@MaNV AND ChiaCa.ngay=CONVERT(date,@date)
go


select * from getDanhSachCaTheoNVVaTheoNgay (@MaNV,@date)


go

create function getDanhSachCaTheoNVVaTheoKhoang(@MaNV int,@dateT date,@dateS date)
returns table
as
return
SELECT ChiaCa.ngay,Ca.* FROM ChiaCa,Ca WHERE ChiaCa.Maca= Ca.Maca 
AND Manv=@MaNV AND ChiaCa.ngay BETWEEN CONVERT(date,@dateT) AND CONVERT(date,@dateS) 
go


select * from getDanhSachCaTheoNVVaTheoKhoang (@MaNV,@dateT,@dateS)


go
create function getDanhSachChiaCaFrmChiaCa()
returns table
as
return
SELECT NhanVien.MaNV,Hoten,Ngaysinh,SoDT,Tenca,ngay,ChiaCa.Maca FROM ChiaCa,NhanVien,Ca WHERE ChiaCa.MaNV=NhanVIen.MaNV AND ChiaCa.Maca=Ca.Maca
go

SELECT * FROM getDanhSachChiaCaFrmChiaCa()


go
create function getDanhSachChiaCa()
returns table
as
return
SELECT NhanVien.MaNV,Hoten,Ngaysinh,SoDT,Tenca,ngay FROM ChiaCa,NhanVien,Ca
 WHERE ChiaCa.MaNV=NhanVIen.MaNV AND ChiaCa.Maca=Ca.Maca
go

SELECT * FROM getDanhSachChiaCa()


go
create function getDanhSachChiaCaTheoNgay(@ngay date)
returns table
as
return
SELECT NhanVien.MaNV,Hoten,Ngaysinh,SoDT,Tenca,ngay FROM ChiaCa,NhanVien,Ca
 WHERE ChiaCa.MaNV=NhanVIen.MaNV AND ChiaCa.Maca=Ca.Maca  AND ChiaCa.ngay=@ngay
go

declare @ngay date
set @ngay='2020-12-20'
SELECT * FROM getDanhSachChiaCaTheoNgay(@ngay)




go

create function getDanhSachChiaCaTheoKhoang(@ngaybatdau date,@ngayketthuc date)
returns table
as
return
SELECT NhanVien.MaNV,Hoten,Ngaysinh,SoDT,Tenca,ngay FROM ChiaCa,NhanVien,Ca
 WHERE ChiaCa.MaNV=NhanVIen.MaNV AND ChiaCa.Maca=Ca.Maca  AND ChiaCa.ngay BETWEEN @ngaybatdau AND  @ngayketthuc
go


declare @ngaybatdau date
set @ngaybatdau='2020-12-16'
declare @ngayketthuc date
set @ngayketthuc='2020-12-30'
SELECT * FROM getDanhSachChiaCaTheoKhoang(@ngaybatdau,@ngayketthuc)
go
