CREATE PROCEDURE SelectAllCustomers @manv int
AS
select * from NhanVien where manv = @manv
go

DECLARE @manv int
set @manv=12
EXEC SelectAllCustomers @manv = @manv;
GO


CREATE PROCEDURE GetNhanVienByID @manv int
AS
select * from NhanVien where manv = @manv
go




CREATE PROCEDURE GetNhanVienBySearch @hoten Nvarchar(50),@username Nvarchar(50)
AS
select * from NhanVien where Hoten like @hoten or UserName like @username
go


DECLARE @hoten Nvarchar(50)
DECLARE @username Nvarchar(50)
set @hoten='Tran Quang Dai'
set @username='dai'
EXEC GetNhanVienBySearch @hoten = @hoten,@username=@username
GO



CREATE PROCEDURE themNV @hoten Nvarchar(50),@sdt Nvarchar(50),@ngaysinh date,@username Nvarchar(50)
,@luong float,@password nvarchar(50),@MaNQL int,@Role nvarchar(50) 
AS
insert into NhanVien (hoten,SoDT,ngaysinh,luong,UserName,Password,MaNQL,Role) values( @hoten, @sdt, @ngaysinh, @luong,@username,@password,@MaNQL,@Role)
go

DECLARE @hoten Nvarchar(50)
DECLARE @username Nvarchar(50)
DECLARE @sdt Nvarchar(50)
DECLARE @ngaysinh date
DECLARE @luong float
DECLARE @password Nvarchar(50)
DECLARE @MaNQL int
DECLARE @Role Nvarchar(50)
set @hoten='Tran Quang Dai'
set @username='dai'
set @sdt='012912912921'
set @ngaysinh='2000-12-12'
set @luong=20000
set @password=1
set @MaNQL=8
set @Role='employee'
EXEC themNV @hoten = @hoten,@username=@username,@sdt=@sdt,@ngaysinh=@ngaysinh,@luong=@luong,@password=@password,@MaNQL=@MaNQL,@Role=@Role
GO


CREATE PROCEDURE suaNV @hoten Nvarchar(50),@sdt Nvarchar(50),@ngaysinh date,@username Nvarchar(50),@manv int
,@luong float,@password nvarchar(50),@MaNQL int 
AS
update NhanVien set hoten = @hoten, SoDT = @sdt, ngaysinh = @ngaysinh, luong = @luong,UserName = @username,Password = @password where manv = @manv
go


DECLARE @hoten Nvarchar(50)
DECLARE @username Nvarchar(50)
DECLARE @sdt Nvarchar(50)
DECLARE @ngaysinh date
DECLARE @luong float
DECLARE @password Nvarchar(50)
DECLARE @MaNQL int
DECLARE @Role Nvarchar(50)
DECLARE @manv int
set @hoten='Tran Quang Dai'
set @username='dai'
set @sdt='0129129129'
set @ngaysinh='2000-12-12'
set @luong=20000
set @password=2
set @MaNQL=8
set @manv=17
set @Role='employee'
EXEC suaNV @hoten = @hoten,@username=@username,@sdt=@sdt,@ngaysinh=@ngaysinh,@luong=@luong,@password=@password,@MaNQL=@MaNQL,@manv=@manv
GO



CREATE PROCEDURE SuaNVkhongmk @hoten Nvarchar(50),@sdt Nvarchar(50),@ngaysinh date,@username Nvarchar(50),@manv int
,@luong float
AS
update NhanVien set hoten = @hoten, SoDT = @sdt, ngaysinh = @ngaysinh, luong = @luong,UserName = @username where manv = @manv
go


DECLARE @hoten Nvarchar(50)
DECLARE @username Nvarchar(50)
DECLARE @sdt Nvarchar(50)
DECLARE @ngaysinh date
DECLARE @luong float
DECLARE @manv int
set @hoten='Tran Quang Dai'
set @username='dai'
set @sdt='0129129129'
set @ngaysinh='2000-12-12'
set @luong=30000
set @manv=17
EXEC SuaNVkhongmk @hoten = @hoten,@username=@username,@sdt=@sdt,@ngaysinh=@ngaysinh,@luong=@luong,@manv=@manv
GO



CREATE PROCEDURE xoaNV	@manv int
AS
delete NhanVien where manv = @manv
go

DECLARE @manv int
set @manv=17
EXEC xoaNV @manv=@manv
go 

CREATE PROCEDURE KTBanDangSD @maban int
AS
	select maban from hoadon where convert(date,Hoadon.Thoigian) = convert(date, getdate()) and trangthai = 0 and maban=@maban
go


DECLARE @maban int
set @maban=31
EXEC KTBanDangSD @maban=@maban
go 

CREATE PROCEDURE addTable @Tenban nvarchar(50),@Trangthai Nvarchar(50),@SoLuongKhach int
AS
	INSERT INTO dbo.Ban (Tenban ,Trangthai ,SoLuongKhach)VALUES  (@Tenban,@Trangthai,@SoLuongKhach )
go

DECLARE @Tenban nvarchar(50)
DECLARE @Trangthai  nvarchar(50)
DECLARE @SoLuongKhach  nvarchar(50)
set @Tenban='table 8'
set @Trangthai='available'
set @SoLuongKhach=0
EXEC addTable @Tenban=@Tenban,@Trangthai=@Trangthai,@SoLuongKhach=@SoLuongKhach
go 



CREATE PROCEDURE deleteTable @ID int
AS
	DELETE dbo.Ban WHERE Maban=@ID
go

DECLARE @ID  int
set @ID=39
EXEC deleteTable @ID=@ID
go


CREATE PROCEDURE UpdatetableStatus @Maban int,@Trangthai nvarchar(50)
AS
	UPDATE Ban SET	Trangthai=@Trangthai WHERE Maban=@Maban
go


DECLARE @Maban  int
set @Maban=38
DECLARE @Trangthai  nvarchar(50)
set @Trangthai='Available'
EXEC UpdatetableStatus @Trangthai=@Trangthai,@Maban=@Maban
go






CREATE PROCEDURE themVoucher @ngaybatdau date,@ngayketthuc date, @ten nvarchar(50),@chitiet nvarchar(50),@Discount float
AS
	insert into voucher (ngaybatdau,ngayketthuc,ten,chitiet,Discount) values(@ngaybatdau,@ngayketthuc,@ten,@chitiet,@Discount)
go

DECLARE @ngaybatdau  date
set @ngaybatdau='2020-12-16'
DECLARE @ngayketthuc  date
set @ngayketthuc='2020-12-18'
DECLARE @ten  nvarchar(50)
set @ten='40%'
DECLARE @chitiet  nvarchar(50)
set @chitiet='Giam gia 40%'
DECLARE @Discount  float
set @Discount=0.4
EXEC themVoucher @ngaybatdau=@ngaybatdau,@ngayketthuc=@ngayketthuc,@ten=@ten,@chitiet=@chitiet,@Discount=@Discount
go


CREATE PROCEDURE suaVoucher @ngaybatdau date,@ngayketthuc date, @ten nvarchar(50),@chitiet nvarchar(50),@Discount float,@mavoucher int
AS
	update voucher  set ten=@ten,chitiet=@chitiet,Discount=@Discount,ngaybatdau=@ngaybatdau,ngayketthuc=@ngayketthuc where mavoucher=@mavoucher
go


DECLARE @ngaybatdau  date
set @ngaybatdau='2020-12-16'
DECLARE @ngayketthuc  date
set @ngayketthuc='2020-12-18'
DECLARE @ten  nvarchar(50)
set @ten='90%'
DECLARE @chitiet  nvarchar(50)
set @chitiet='Giam gia 90%'
DECLARE @Discount  float
set @Discount=0.9
DECLARE @mavoucher  int
set @mavoucher=5
EXEC suaVoucher @ngaybatdau=@ngaybatdau,@ngayketthuc=@ngayketthuc,@ten=@ten,@chitiet=@chitiet,@Discount=@Discount,@mavoucher=@mavoucher
go


CREATE PROCEDURE xoaVoucher @mavoucher int
AS
	delete from voucher where mavoucher=@mavoucher
go

DECLARE @mavoucher  int
set @mavoucher=5
EXEC xoaVoucher @mavoucher=@mavoucher
go




CREATE PROCEDURE ThemVaoChiaCa @manv int,@maca int,@date date
AS
	INSERT INTO ChiaCa(Manv,Maca,ngay)VALUES (@manv,@maca,CONVERT(date,@date))
go


DECLARE @manv  int
set @manv=8
DECLARE @maca  int
set @maca=4
DECLARE @date  date
set @date='2020-12-20'
EXEC ThemVaoChiaCa @manv=@manv,@maca=@maca,@date=@date
go




CREATE PROCEDURE xoaChiaCa @manv int,@maca int,@ngay date
AS
	DELETE FROM ChiaCa WHERE Manv=@Manv AND Maca=@Maca ANd ngay=CONVERT(date,@ngay) 
go

DECLARE @manv  int
set @manv=8
DECLARE @maca  int
set @maca=4
DECLARE @ngay  date
set @ngay='2020-12-20'
EXEC xoaChiaCa @manv=@manv,@maca=@maca,@ngay=@ngay
go


CREATE PROCEDURE SuaChiaCa @manv int,@ngay date
AS
	UPDATE ChiaCa SET ngay=CONVERT(date,@ngay) WHERE Manv=@manv
go

DECLARE @manv  int
set @manv=8
DECLARE @ngay  date
set @ngay='2020-12-20'
EXEC SuaChiaCa @manv=@manv,@ngay=@ngay
go