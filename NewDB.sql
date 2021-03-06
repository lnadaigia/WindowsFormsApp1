USE [master]
GO
/****** Object:  Database [DBMS]    Script Date: 12/21/2020 7:12:17 PM ******/
CREATE DATABASE [DBMS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBMS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DBMS.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBMS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DBMS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DBMS] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBMS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBMS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBMS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBMS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBMS] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBMS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBMS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBMS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBMS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBMS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBMS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBMS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBMS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBMS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBMS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBMS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBMS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBMS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBMS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBMS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBMS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBMS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBMS] SET  MULTI_USER 
GO
ALTER DATABASE [DBMS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBMS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBMS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBMS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DBMS] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DBMS]
GO
/****** Object:  User [thilyvu]    Script Date: 12/21/2020 7:12:17 PM ******/
CREATE USER [thilyvu] FOR LOGIN [thilyvu] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [sa1]    Script Date: 12/21/2020 7:12:17 PM ******/
CREATE USER [sa1] FOR LOGIN [sa1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Linh]    Script Date: 12/21/2020 7:12:17 PM ******/
CREATE USER [Linh] FOR LOGIN [Linh] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [dai]    Script Date: 12/21/2020 7:12:17 PM ******/
CREATE USER [dai] FOR LOGIN [dai] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [b]    Script Date: 12/21/2020 7:12:17 PM ******/
CREATE USER [b] FOR LOGIN [b] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [a]    Script Date: 12/21/2020 7:12:17 PM ******/
CREATE USER [a] FOR LOGIN [a] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [employee]    Script Date: 12/21/2020 7:12:17 PM ******/
CREATE ROLE [employee]
GO
ALTER ROLE [db_owner] ADD MEMBER [thilyvu]
GO
ALTER ROLE [employee] ADD MEMBER [sa1]
GO
ALTER ROLE [employee] ADD MEMBER [Linh]
GO
ALTER ROLE [employee] ADD MEMBER [dai]
GO
ALTER ROLE [employee] ADD MEMBER [b]
GO
ALTER ROLE [employee] ADD MEMBER [a]
GO
/****** Object:  UserDefinedTableType [dbo].[bang]    Script Date: 12/21/2020 7:12:17 PM ******/
CREATE TYPE [dbo].[bang] AS TABLE(
	[manl] [int] NULL,
	[mamonan] [int] NULL,
	[soluong] [float] NULL
)
GO
/****** Object:  UserDefinedFunction [dbo].[monan_daban]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[monan_daban](@mamonan int,@mahoadon int)
returns int
as
begin
	declare @soluong int,@tong int
	select @tong=tongsoluong from Monantheongay where Mamonan=@mamonan
	select @soluong=sum(ct.Soluong) from Chitiethoadon as ct, hoadon as hd
	where  convert(date,hd.thoigian)=convert(date,getdate()) and ct.Mamonan=@mamonan and hd.Mahoadon=ct.Mahoadon and ct.Mahoadon!=@mahoadon
	if(@soluong is null)
	set @soluong=0
	return @tong-@soluong
end

GO
/****** Object:  Table [dbo].[Ban]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ban](
	[Maban] [int] IDENTITY(1,1) NOT NULL,
	[Tenban] [nvarchar](50) NOT NULL,
	[Trangthai] [nvarchar](50) NULL,
	[SoLuongKhach] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Maban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ca]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ca](
	[Maca] [int] IDENTITY(1,1) NOT NULL,
	[Tenca] [nvarchar](50) NOT NULL,
	[GioBatDau] [nvarchar](50) NULL,
	[GioKetthuc] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Maca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiaCa]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiaCa](
	[Manv] [int] NOT NULL,
	[Maca] [int] NOT NULL,
	[ngay] [date] NOT NULL,
 CONSTRAINT [pk_chica] PRIMARY KEY CLUSTERED 
(
	[Manv] ASC,
	[Maca] ASC,
	[ngay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Chitiethoadon]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chitiethoadon](
	[Mahoadon] [int] NOT NULL,
	[Mamonan] [int] NOT NULL,
	[Soluong] [int] NOT NULL,
 CONSTRAINT [pk_chitiethoadon] PRIMARY KEY CLUSTERED 
(
	[Mahoadon] ASC,
	[Mamonan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Congthuc]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Congthuc](
	[Mamonan] [int] NOT NULL,
	[Manl] [int] NOT NULL,
	[soluong] [float] NOT NULL,
 CONSTRAINT [pk_congthuc] PRIMARY KEY CLUSTERED 
(
	[Mamonan] ASC,
	[Manl] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hoadon]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoadon](
	[Mahoadon] [int] IDENTITY(1,1) NOT NULL,
	[Maban] [int] NULL,
	[Thoigian] [datetime] NOT NULL,
	[Tongbill] [float] NULL DEFAULT ((0)),
	[Manv] [int] NULL,
	[mavoucher] [int] NULL,
	[Trangthai] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Mahoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Monan]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Monan](
	[Mamonan] [int] IDENTITY(1,1) NOT NULL,
	[tenmonan] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Mamonan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Monantheongay]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Monantheongay](
	[ngay] [date] NOT NULL,
	[Mamonan] [int] NOT NULL,
	[gia] [float] NOT NULL,
	[tongsoluong] [int] NOT NULL,
 CONSTRAINT [pk_monantheongay] PRIMARY KEY CLUSTERED 
(
	[Mamonan] ASC,
	[ngay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieu](
	[Manl] [int] IDENTITY(1,1) NOT NULL,
	[tenNL] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Manl] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nguyenlieutheongay]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nguyenlieutheongay](
	[ngay] [date] NOT NULL,
	[Manl] [int] NOT NULL,
	[gia] [float] NULL,
	[tongsoluong] [int] NOT NULL,
 CONSTRAINT [pk_nguyenlieutheongay] PRIMARY KEY CLUSTERED 
(
	[ngay] ASC,
	[Manl] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[Hoten] [nvarchar](50) NOT NULL,
	[SoDT] [nvarchar](50) NOT NULL,
	[Ngaysinh] [date] NOT NULL,
	[luong] [float] NULL,
	[MaNQL] [int] NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Role] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[voucher]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[voucher](
	[mavoucher] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[ngaybatdau] [date] NOT NULL,
	[ngayketthuc] [date] NOT NULL,
	[chitiet] [nvarchar](50) NULL,
	[Discount] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[mavoucher] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  UserDefinedFunction [dbo].[dsmonan]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[dsmonan]()
returns table
as
return
select ct.Mamonan,isnull(sum(ct.Soluong),0) as 'soluong_daban',convert(date,hd.Thoigian) as 'ngay' 
	from Chitiethoadon as ct,hoadon as hd 
	where hd.Mahoadon=ct.Mahoadon and convert(date,hd.Thoigian)=CONVERT(date,getdate()) 
	group by ct.Mamonan,convert(date,hd.Thoigian)


GO
/****** Object:  UserDefinedFunction [dbo].[getMonAndeban]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[getMonAndeban]()
returns table
as
return 
		select m.Mamonan,ma.tenmonan,m.gia,(m.tongsoluong-isnull(ham.soluong_daban,0)) as 'soluong_con',
		0 as 'soluong'  
		from Monantheongay as m 
		left join dsmonan() as ham 
		on m.Mamonan=ham.Mamonan and m.ngay=ham.ngay, Monan as ma 
		where m.Mamonan=ma.Mamonan and m.ngay=convert(date,getdate())


GO
/****** Object:  UserDefinedFunction [dbo].[bandangsd]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[bandangsd]()
returns table
as
	return select maban from hoadon
	where convert(date,Hoadon.Thoigian)=convert(date,getdate()) and trangthai=0

GO
/****** Object:  UserDefinedFunction [dbo].[ct_monan]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[ct_monan](@mamonan int)
returns table
as
return
	(
			select nl.Manl 
			from Nguyenlieutheongay as nl,
			(select * from Congthuc where Mamonan=@mamonan)as ct
			where nl.Manl=ct.Manl and nl.ngay=CONVERT(date,getdate())
	)
	
GO
/****** Object:  UserDefinedFunction [dbo].[getchitietbymahd]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[getchitietbymahd](@mahd int)
returns table
as
return select ct.Mamonan,ma.tenmonan,ct.Soluong ,m.gia,(m.gia*ct.Soluong) as 'thanhtien'
				from Chitiethoadon as ct, Hoadon as hd, Monan as ma, Monantheongay as m 
				where hd.Mahoadon = ct.Mahoadon and CONVERT(date, hd.Thoigian) = m.ngay 
				and m.Mamonan = ct.Mamonan and ma.Mamonan = m.Mamonan and hd.Mahoadon = @mahd

GO
/****** Object:  UserDefinedFunction [dbo].[getDanhSachCaChoNV]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create function [dbo].[getDanhSachCaChoNV](@manv int)
returns table
as
return
SELECT Ca.Tenca, Ca.GioBatDau,Ca.GioKetThuc FROM Ca,ChiaCa,NhanVien WHERE Ca.Maca=ChiaCa.Maca
 AND ChiaCa.Manv=NhanVien.MaNV  AND NhanVien.MaNV=@manv AND ChiaCa.ngay=CONVERT(Date,getdate())

GO
/****** Object:  UserDefinedFunction [dbo].[getDanhSachCaTheoNV]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[getDanhSachCaTheoNV](@MaNV int)
returns table
as
return
SELECT ChiaCa.ngay,Ca.* FROM ChiaCa,Ca WHERE ChiaCa.Maca= Ca.Maca AND Manv=@MaNV

GO
/****** Object:  UserDefinedFunction [dbo].[getDanhSachCaTheoNVVaTheoKhoang]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[getDanhSachCaTheoNVVaTheoKhoang](@MaNV int,@dateT date,@dateS date)
returns table
as
return
SELECT ChiaCa.ngay,Ca.* FROM ChiaCa,Ca WHERE ChiaCa.Maca= Ca.Maca 
AND Manv=@MaNV AND ChiaCa.ngay BETWEEN CONVERT(date,@dateT) AND CONVERT(date,@dateS) 

GO
/****** Object:  UserDefinedFunction [dbo].[getDanhSachCaTheoNVVaTheoNgay]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[getDanhSachCaTheoNVVaTheoNgay](@MaNV int,@date date)
returns table
as
return
SELECT ChiaCa.ngay,Ca.* FROM ChiaCa,Ca WHERE ChiaCa.Maca= Ca.Maca AND Manv=@MaNV AND ChiaCa.ngay=CONVERT(date,@date)

GO
/****** Object:  UserDefinedFunction [dbo].[getDanhSachChiaCa]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[getDanhSachChiaCa]()
returns table
as
return
SELECT NhanVien.MaNV,Hoten,Ngaysinh,SoDT,Tenca,ngay FROM ChiaCa,NhanVien,Ca
 WHERE ChiaCa.MaNV=NhanVIen.MaNV AND ChiaCa.Maca=Ca.Maca

GO
/****** Object:  UserDefinedFunction [dbo].[getDanhSachChiaCaFrmChiaCa]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[getDanhSachChiaCaFrmChiaCa]()
returns table
as
return
SELECT NhanVien.MaNV,Hoten,Ngaysinh,SoDT,Tenca,ngay,ChiaCa.Maca FROM ChiaCa,NhanVien,Ca WHERE ChiaCa.MaNV=NhanVIen.MaNV AND ChiaCa.Maca=Ca.Maca

GO
/****** Object:  UserDefinedFunction [dbo].[getDanhSachChiaCaTheoKhoang]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[getDanhSachChiaCaTheoKhoang](@ngaybatdau date,@ngayketthuc date)
returns table
as
return
SELECT NhanVien.MaNV,Hoten,Ngaysinh,SoDT,Tenca,ngay FROM ChiaCa,NhanVien,Ca
 WHERE ChiaCa.MaNV=NhanVIen.MaNV AND ChiaCa.Maca=Ca.Maca  AND ChiaCa.ngay BETWEEN @ngaybatdau AND  @ngayketthuc

GO
/****** Object:  UserDefinedFunction [dbo].[getDanhSachChiaCaTheoNgay]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[getDanhSachChiaCaTheoNgay](@ngay date)
returns table
as
return
SELECT NhanVien.MaNV,Hoten,Ngaysinh,SoDT,Tenca,ngay FROM ChiaCa,NhanVien,Ca
 WHERE ChiaCa.MaNV=NhanVIen.MaNV AND ChiaCa.Maca=Ca.Maca  AND ChiaCa.ngay=@ngay

GO
/****** Object:  UserDefinedFunction [dbo].[getDanhSachNhanVienVaCa]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[getDanhSachNhanVienVaCa](@gio time)
returns table
as
return
SELECT ChiaCa.*,Ca.Tenca,NhanVien.Hoten,NhanVien.SoDT,Ca.GioBatDau,Ca.GioKetThuc 
FROM ChiaCa,Ca,NhanVien where Ca.Maca=ChiaCa.Maca AND NhanVien.MaNV=ChiaCa.Manv 
AND ChiaCa.ngay = CONVERT(date, getdate()) AND CA.Maca in 
(SELECT Maca FROM Ca WHERE CONVERT(time, @gio) BETWEEN Ca.GioBatDau AND Ca.GioKetThuc)

GO
/****** Object:  UserDefinedFunction [dbo].[getHoaDonbyban]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[getHoaDonbyban](@maban int)
returns table
as
return 
		select ct.Mamonan,ma.tenmonan,ct.Soluong ,m.gia,(m.gia*ct.Soluong) as 'thanhtien' 
		from Chitiethoadon as ct, Hoadon as hd, Monan as ma, Monantheongay as m 
		where hd.Mahoadon = ct.Mahoadon and CONVERT(date, hd.Thoigian) = convert(date, GETDATE()) 
		and m.ngay = CONVERT(date, getdate()) and m.Mamonan = ct.Mamonan and ma.Mamonan = m.Mamonan 
		and hd.Maban = @maban and hd.Trangthai = 0

GO
/****** Object:  UserDefinedFunction [dbo].[getMonAntheongay]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[getMonAntheongay]()
returns table
as
return 
	select monan.*,isnull(m.gia,0) as 'gia',isnull(m.tongsoluong,0) as 'soluong' 
	from monan  left join Monantheongay as m on m.Mamonan=Monan.Mamonan and ngay=convert(date,getdate())

GO
/****** Object:  UserDefinedFunction [dbo].[thongkedoanhthu]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[thongkedoanhthu](@thang int)
returns table
as
return 
		select convert(date,hd.Thoigian) as 'ngay', sum(Tongbill) as 'doanh thu' 
			from hoadon as hd 
			where MONTH(hd.Thoigian) = @thang group by convert(date,hd.Thoigian)


GO
/****** Object:  View [dbo].[getDanhSachCa]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[getDanhSachCa] AS
select * FROM Ca

GO
/****** Object:  View [dbo].[getDanhSachCaDeChiaCa]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[getDanhSachCaDeChiaCa] AS
SELECT Maca,Tenca,GioBatDau,GioKetThuc FROM Ca

GO
/****** Object:  View [dbo].[getNhanVien]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[getNhanVien] AS
select * from NhanVien


GO
/****** Object:  View [dbo].[getNhanVienDeChiaCa]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[getNhanVienDeChiaCa] AS
SELECT MaNV,Hoten,SoDT,Ngaysinh FROM NhanVien where Role='employee'


GO
/****** Object:  View [dbo].[getvoucher]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[getvoucher] AS
select * from voucher

GO
/****** Object:  View [dbo].[LoadTable]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[LoadTable] AS
SELECT * FROM Ban

GO
SET IDENTITY_INSERT [dbo].[Ban] ON 

INSERT [dbo].[Ban] ([Maban], [Tenban], [Trangthai], [SoLuongKhach]) VALUES (1, N'Table 1', N'Available', 0)
INSERT [dbo].[Ban] ([Maban], [Tenban], [Trangthai], [SoLuongKhach]) VALUES (2, N'Table 2', N'Available', 0)
INSERT [dbo].[Ban] ([Maban], [Tenban], [Trangthai], [SoLuongKhach]) VALUES (3, N'Table 3', N'Available', 0)
INSERT [dbo].[Ban] ([Maban], [Tenban], [Trangthai], [SoLuongKhach]) VALUES (4, N'Table 4', N'Available', 0)
INSERT [dbo].[Ban] ([Maban], [Tenban], [Trangthai], [SoLuongKhach]) VALUES (5, N'Table 5', N'Available', 0)
INSERT [dbo].[Ban] ([Maban], [Tenban], [Trangthai], [SoLuongKhach]) VALUES (6, N'Table 6', N'Available', 0)
INSERT [dbo].[Ban] ([Maban], [Tenban], [Trangthai], [SoLuongKhach]) VALUES (7, N'Table 7', N'Available', 0)
INSERT [dbo].[Ban] ([Maban], [Tenban], [Trangthai], [SoLuongKhach]) VALUES (8, N'Table 8', N'Available', 0)
SET IDENTITY_INSERT [dbo].[Ban] OFF
SET IDENTITY_INSERT [dbo].[Ca] ON 

INSERT [dbo].[Ca] ([Maca], [Tenca], [GioBatDau], [GioKetthuc]) VALUES (1, N'Sang', N'08:00:00.0000000', N'11:00:00.0000000')
INSERT [dbo].[Ca] ([Maca], [Tenca], [GioBatDau], [GioKetthuc]) VALUES (2, N'Trua', N'11:00:00.0000000', N'14:00:00.0000000')
INSERT [dbo].[Ca] ([Maca], [Tenca], [GioBatDau], [GioKetthuc]) VALUES (3, N'Chieu', N'14:00:00.0000000', N'18:00:00.0000000')
INSERT [dbo].[Ca] ([Maca], [Tenca], [GioBatDau], [GioKetthuc]) VALUES (4, N'Toi', N'18:00:00.0000000', N'20:00:00.0000000')
SET IDENTITY_INSERT [dbo].[Ca] OFF
INSERT [dbo].[ChiaCa] ([Manv], [Maca], [ngay]) VALUES (18, 1, CAST(N'2020-12-25' AS Date))
INSERT [dbo].[ChiaCa] ([Manv], [Maca], [ngay]) VALUES (18, 2, CAST(N'2020-12-26' AS Date))
INSERT [dbo].[ChiaCa] ([Manv], [Maca], [ngay]) VALUES (18, 2, CAST(N'2020-12-27' AS Date))
INSERT [dbo].[ChiaCa] ([Manv], [Maca], [ngay]) VALUES (18, 3, CAST(N'2020-12-26' AS Date))
INSERT [dbo].[ChiaCa] ([Manv], [Maca], [ngay]) VALUES (25, 1, CAST(N'2020-12-20' AS Date))
INSERT [dbo].[ChiaCa] ([Manv], [Maca], [ngay]) VALUES (25, 1, CAST(N'2020-12-28' AS Date))
INSERT [dbo].[ChiaCa] ([Manv], [Maca], [ngay]) VALUES (25, 1, CAST(N'2020-12-31' AS Date))
INSERT [dbo].[ChiaCa] ([Manv], [Maca], [ngay]) VALUES (25, 2, CAST(N'2020-12-20' AS Date))
INSERT [dbo].[ChiaCa] ([Manv], [Maca], [ngay]) VALUES (25, 2, CAST(N'2020-12-24' AS Date))
INSERT [dbo].[ChiaCa] ([Manv], [Maca], [ngay]) VALUES (25, 2, CAST(N'2020-12-30' AS Date))
INSERT [dbo].[ChiaCa] ([Manv], [Maca], [ngay]) VALUES (25, 2, CAST(N'2020-12-31' AS Date))
INSERT [dbo].[ChiaCa] ([Manv], [Maca], [ngay]) VALUES (25, 3, CAST(N'2020-12-27' AS Date))
INSERT [dbo].[ChiaCa] ([Manv], [Maca], [ngay]) VALUES (29, 1, CAST(N'2020-12-20' AS Date))
INSERT [dbo].[ChiaCa] ([Manv], [Maca], [ngay]) VALUES (29, 1, CAST(N'2020-12-26' AS Date))
INSERT [dbo].[ChiaCa] ([Manv], [Maca], [ngay]) VALUES (29, 1, CAST(N'2020-12-27' AS Date))
INSERT [dbo].[ChiaCa] ([Manv], [Maca], [ngay]) VALUES (29, 2, CAST(N'2020-12-17' AS Date))
INSERT [dbo].[ChiaCa] ([Manv], [Maca], [ngay]) VALUES (29, 2, CAST(N'2020-12-29' AS Date))
SET IDENTITY_INSERT [dbo].[Hoadon] ON 

INSERT [dbo].[Hoadon] ([Mahoadon], [Maban], [Thoigian], [Tongbill], [Manv], [mavoucher], [Trangthai]) VALUES (92, 1, CAST(N'2020-12-15 00:00:00.000' AS DateTime), 80000, 18, 1, 1)
INSERT [dbo].[Hoadon] ([Mahoadon], [Maban], [Thoigian], [Tongbill], [Manv], [mavoucher], [Trangthai]) VALUES (93, 2, CAST(N'2020-12-16 00:00:00.000' AS DateTime), 0, 25, 1, 1)
INSERT [dbo].[Hoadon] ([Mahoadon], [Maban], [Thoigian], [Tongbill], [Manv], [mavoucher], [Trangthai]) VALUES (94, 3, CAST(N'2020-12-18 00:00:00.000' AS DateTime), 400000, 26, 2, 1)
INSERT [dbo].[Hoadon] ([Mahoadon], [Maban], [Thoigian], [Tongbill], [Manv], [mavoucher], [Trangthai]) VALUES (97, 4, CAST(N'2020-12-19 00:00:00.000' AS DateTime), 0, 29, 3, 1)
SET IDENTITY_INSERT [dbo].[Hoadon] OFF
SET IDENTITY_INSERT [dbo].[Monan] ON 

INSERT [dbo].[Monan] ([Mamonan], [tenmonan]) VALUES (12, N'banh mi nuong bo toi')
INSERT [dbo].[Monan] ([Mamonan], [tenmonan]) VALUES (10, N'beefsteak')
INSERT [dbo].[Monan] ([Mamonan], [tenmonan]) VALUES (11, N'bo luc lac')
INSERT [dbo].[Monan] ([Mamonan], [tenmonan]) VALUES (4, N'Bo vien')
INSERT [dbo].[Monan] ([Mamonan], [tenmonan]) VALUES (2, N'bun bo')
INSERT [dbo].[Monan] ([Mamonan], [tenmonan]) VALUES (1, N'com chien')
INSERT [dbo].[Monan] ([Mamonan], [tenmonan]) VALUES (16, N'ga cay sot pho mai')
INSERT [dbo].[Monan] ([Mamonan], [tenmonan]) VALUES (15, N'ga chien gion')
INSERT [dbo].[Monan] ([Mamonan], [tenmonan]) VALUES (5, N'hay')
INSERT [dbo].[Monan] ([Mamonan], [tenmonan]) VALUES (13, N'khoai tay chien')
INSERT [dbo].[Monan] ([Mamonan], [tenmonan]) VALUES (14, N'khoai tay sot bo bam')
INSERT [dbo].[Monan] ([Mamonan], [tenmonan]) VALUES (3, N'Lau')
INSERT [dbo].[Monan] ([Mamonan], [tenmonan]) VALUES (9, N'mi y sot bo bam')
INSERT [dbo].[Monan] ([Mamonan], [tenmonan]) VALUES (8, N'mi y sot kem')
INSERT [dbo].[Monan] ([Mamonan], [tenmonan]) VALUES (18, N'salad')
INSERT [dbo].[Monan] ([Mamonan], [tenmonan]) VALUES (6, N'sup bi do')
INSERT [dbo].[Monan] ([Mamonan], [tenmonan]) VALUES (7, N'sup rau cu')
SET IDENTITY_INSERT [dbo].[Monan] OFF
INSERT [dbo].[Monantheongay] ([ngay], [Mamonan], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-08' AS Date), 1, 10000, 100)
INSERT [dbo].[Monantheongay] ([ngay], [Mamonan], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-12' AS Date), 1, 40000, 1000)
INSERT [dbo].[Monantheongay] ([ngay], [Mamonan], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-14' AS Date), 1, 20000, 10)
INSERT [dbo].[Monantheongay] ([ngay], [Mamonan], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-15' AS Date), 1, 20000, 100)
INSERT [dbo].[Monantheongay] ([ngay], [Mamonan], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-19' AS Date), 1, 0, 9)
INSERT [dbo].[Monantheongay] ([ngay], [Mamonan], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-08' AS Date), 2, 20000, 200)
INSERT [dbo].[Monantheongay] ([ngay], [Mamonan], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-12' AS Date), 2, 12222, 111)
INSERT [dbo].[Monantheongay] ([ngay], [Mamonan], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-15' AS Date), 2, 10000, 100)
INSERT [dbo].[Monantheongay] ([ngay], [Mamonan], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-18' AS Date), 2, 0, 4)
INSERT [dbo].[Monantheongay] ([ngay], [Mamonan], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-09' AS Date), 3, 20000, 200)
INSERT [dbo].[Monantheongay] ([ngay], [Mamonan], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-09' AS Date), 4, 30000, 100)
INSERT [dbo].[Monantheongay] ([ngay], [Mamonan], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-14' AS Date), 4, 10000, 90)
INSERT [dbo].[Monantheongay] ([ngay], [Mamonan], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-18' AS Date), 4, 200000, 7)
SET IDENTITY_INSERT [dbo].[NguyenLieu] ON 

INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (3, N'banh mi')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (13, N'bap')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (20, N'bi do')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (21, N'bo')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (5, N'bo bam')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (17, N'ca chua')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (8, N'ca ngu')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (15, N'ca rot')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (2, N'com')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (18, N'dau ha lan')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (11, N'dua leo')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (6, N'ga')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (19, N'hanh tay')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (14, N'khoai tay')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (24, N'la huong thao')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (10, N'la salad')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (16, N'nam')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (23, N'ot')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (12, N'ot chuong')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (26, N'pho mai')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (1, N'soi mi y')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (25, N'sot kem')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (4, N'thit bo')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (22, N'toi')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (9, N'trung')
INSERT [dbo].[NguyenLieu] ([Manl], [tenNL]) VALUES (7, N'uc ga')
SET IDENTITY_INSERT [dbo].[NguyenLieu] OFF
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-08' AS Date), 1, NULL, 1000)
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-08' AS Date), 2, NULL, 2000)
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-08' AS Date), 3, NULL, 11000)
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-08' AS Date), 4, NULL, 10000)
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-08' AS Date), 5, NULL, 10000)
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-12' AS Date), 1, NULL, 10000)
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-12' AS Date), 2, NULL, 20000)
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-12' AS Date), 3, NULL, 34440)
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-12' AS Date), 4, NULL, 5550)
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-12' AS Date), 5, NULL, 5550)
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-14' AS Date), 1, NULL, 100)
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-14' AS Date), 2, NULL, 200)
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-14' AS Date), 3, NULL, 300)
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-15' AS Date), 1, NULL, 1000)
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-15' AS Date), 2, NULL, 2000)
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-15' AS Date), 3, NULL, 7000)
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-15' AS Date), 4, NULL, 5000)
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-15' AS Date), 5, NULL, 5000)
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-18' AS Date), 3, NULL, 160)
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-18' AS Date), 4, NULL, 200)
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-18' AS Date), 5, NULL, 200)
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-19' AS Date), 1, NULL, 90)
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-19' AS Date), 2, NULL, 180)
INSERT [dbo].[Nguyenlieutheongay] ([ngay], [Manl], [gia], [tongsoluong]) VALUES (CAST(N'2020-12-19' AS Date), 3, NULL, 270)
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [SoDT], [Ngaysinh], [luong], [MaNQL], [UserName], [Password], [Role]) VALUES (18, N'Thi Lý Vũ', N'0563010901', CAST(N'2000-01-10' AS Date), 20000, NULL, N'thilyvu', N'0901', N'manager')
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [SoDT], [Ngaysinh], [luong], [MaNQL], [UserName], [Password], [Role]) VALUES (25, N'Tran Quang Dai', N'0363738936', CAST(N'2020-12-07' AS Date), 2000, 18, N'dai', N'0', N'employee')
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [SoDT], [Ngaysinh], [luong], [MaNQL], [UserName], [Password], [Role]) VALUES (26, N'Nguyen Van Linh', N'098271621', CAST(N'2020-12-07' AS Date), 200000, 18, N'Linh', N'0', N'employee')
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [SoDT], [Ngaysinh], [luong], [MaNQL], [UserName], [Password], [Role]) VALUES (29, N'Chau Hoang Sa', N'0111001000', CAST(N'2000-11-01' AS Date), 20000, NULL, N'sa1', N'0', N'employee')
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [SoDT], [Ngaysinh], [luong], [MaNQL], [UserName], [Password], [Role]) VALUES (30, N'Nguyen A', N'0384129387', CAST(N'1998-02-02' AS Date), 10000, NULL, N'a', N'0', N'employee')
INSERT [dbo].[NhanVien] ([MaNV], [Hoten], [SoDT], [Ngaysinh], [luong], [MaNQL], [UserName], [Password], [Role]) VALUES (31, N'Nguyen B', N'0974519871', CAST(N'2002-04-01' AS Date), 3000, NULL, N'b', N'0', N'employee')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[voucher] ON 

INSERT [dbo].[voucher] ([mavoucher], [ten], [ngaybatdau], [ngayketthuc], [chitiet], [Discount]) VALUES (1, N'giam 50 % ', CAST(N'2020-12-08' AS Date), CAST(N'2020-12-30' AS Date), N'1', 0.5)
INSERT [dbo].[voucher] ([mavoucher], [ten], [ngaybatdau], [ngayketthuc], [chitiet], [Discount]) VALUES (2, N'giam 50 % ', CAST(N'2020-12-08' AS Date), CAST(N'2020-12-30' AS Date), N'nhieu', 0.5)
INSERT [dbo].[voucher] ([mavoucher], [ten], [ngaybatdau], [ngayketthuc], [chitiet], [Discount]) VALUES (3, N'giam 20%', CAST(N'2020-12-20' AS Date), CAST(N'2021-01-05' AS Date), N'1', 0.2)
SET IDENTITY_INSERT [dbo].[voucher] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Monan__057758C67EF746D1]    Script Date: 12/21/2020 7:12:17 PM ******/
ALTER TABLE [dbo].[Monan] ADD UNIQUE NONCLUSTERED 
(
	[tenmonan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__NguyenLi__FB74E83DB9F515E2]    Script Date: 12/21/2020 7:12:17 PM ******/
ALTER TABLE [dbo].[NguyenLieu] ADD UNIQUE NONCLUSTERED 
(
	[tenNL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiaCa]  WITH CHECK ADD FOREIGN KEY([Maca])
REFERENCES [dbo].[Ca] ([Maca])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiaCa]  WITH CHECK ADD FOREIGN KEY([Manv])
REFERENCES [dbo].[NhanVien] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Chitiethoadon]  WITH CHECK ADD FOREIGN KEY([Mahoadon])
REFERENCES [dbo].[Hoadon] ([Mahoadon])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Congthuc]  WITH CHECK ADD FOREIGN KEY([Mamonan])
REFERENCES [dbo].[Monan] ([Mamonan])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Congthuc]  WITH CHECK ADD FOREIGN KEY([Manl])
REFERENCES [dbo].[NguyenLieu] ([Manl])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Hoadon]  WITH CHECK ADD FOREIGN KEY([Maban])
REFERENCES [dbo].[Ban] ([Maban])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Hoadon]  WITH CHECK ADD FOREIGN KEY([Manv])
REFERENCES [dbo].[NhanVien] ([MaNV])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Hoadon]  WITH CHECK ADD FOREIGN KEY([mavoucher])
REFERENCES [dbo].[voucher] ([mavoucher])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Monantheongay]  WITH CHECK ADD FOREIGN KEY([Mamonan])
REFERENCES [dbo].[Monan] ([Mamonan])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Nguyenlieutheongay]  WITH CHECK ADD FOREIGN KEY([Manl])
REFERENCES [dbo].[NguyenLieu] ([Manl])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaNQL])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
/****** Object:  StoredProcedure [dbo].[addTable]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[addTable] @Tenban nvarchar(50),@Trangthai Nvarchar(50),@SoLuongKhach int
AS
	INSERT INTO dbo.Ban (Tenban ,Trangthai ,SoLuongKhach)VALUES  (@Tenban,@Trangthai,@SoLuongKhach )

GO
/****** Object:  StoredProcedure [dbo].[DatHang]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DatHang](@Maban int,@Thoigian datetime,@Tongbill float,@Manv int,@mavoucher int,@Trangthai bit)
as
begin
	insert into Hoadon (Maban,Thoigian,Tongbill,Manv,mavoucher,Trangthai) values(@Maban,@Thoigian,@Tongbill,@Manv,@mavoucher,@Trangthai)
end

drop procedure  ThanhToan

GO
/****** Object:  StoredProcedure [dbo].[deleteTable]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[deleteTable] @ID int
AS
	DELETE dbo.Ban WHERE Maban=@ID

GO
/****** Object:  StoredProcedure [dbo].[GetNhanVienByID]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GetNhanVienByID] @manv int
AS
select * from NhanVien where manv = @manv

GO
/****** Object:  StoredProcedure [dbo].[GetNhanVienBySearch]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[GetNhanVienBySearch] @hoten Nvarchar(50),@username Nvarchar(50)
AS
select * from NhanVien where Hoten like @hoten or UserName like @username

GO
/****** Object:  StoredProcedure [dbo].[KTBanDangSD]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[KTBanDangSD] @maban int
AS
	select maban from hoadon where convert(date,Hoadon.Thoigian) = convert(date, getdate()) and trangthai = 0 and maban=@maban

GO
/****** Object:  StoredProcedure [dbo].[SelectAllCustomers]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectAllCustomers] @manv int
AS
select * from NhanVien where manv = @manv

GO
/****** Object:  StoredProcedure [dbo].[SuaChiaCa]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[SuaChiaCa] @manv int,@ngay date
AS
	UPDATE ChiaCa SET ngay=CONVERT(date,@ngay) WHERE Manv=@manv

GO
/****** Object:  StoredProcedure [dbo].[suamonan]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[suamonan](@ten nvarchar(50),@ma int)
as
begin
	SET XACT_ABORT ON
	BEGIN TRAN
	BEGIN TRY
	  update Monan set tenmonan=@ten where Mamonan=@ma
	  COMMIT
	END TRY
	BEGIN CATCH
	   ROLLBACK
	   DECLARE @ErrorMessage VARCHAR(2000)
	   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
	   RAISERROR(@ErrorMessage, 16, 1)
	END CATCH
end
GO
/****** Object:  StoredProcedure [dbo].[suaMonAntheongay]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[suaMonAntheongay](@mamonan int,@gia float,@soluong int)
as
begin
	update Monantheongay  set tongsoluong=@soluong,gia=@gia where Mamonan=@mamonan and ngay=CONVERT(date,getdate())
end

drop procedure  xoaMonAntheongay

GO
/****** Object:  StoredProcedure [dbo].[suanl]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[suanl](@ten nvarchar(50),@ma int)
as
begin
	update NguyenLieu set tenNL=@ten where Manl=@ma
end
GO
/****** Object:  StoredProcedure [dbo].[suaNV]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[suaNV] @hoten Nvarchar(50),@sdt Nvarchar(50),@ngaysinh date,@username Nvarchar(50),@manv int
,@luong float,@password nvarchar(50),@MaNQL int 
AS
update NhanVien set hoten = @hoten, SoDT = @sdt, ngaysinh = @ngaysinh, luong = @luong,UserName = @username,Password = @password where manv = @manv

GO
/****** Object:  StoredProcedure [dbo].[SuaNVkhongmk]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[SuaNVkhongmk] @hoten Nvarchar(50),@sdt Nvarchar(50),@ngaysinh date,@username Nvarchar(50),@manv int
,@luong float
AS
update NhanVien set hoten = @hoten, SoDT = @sdt, ngaysinh = @ngaysinh, luong = @luong,UserName = @username where manv = @manv

GO
/****** Object:  StoredProcedure [dbo].[suaVoucher]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[suaVoucher] @ngaybatdau date,@ngayketthuc date, @ten nvarchar(50),@chitiet nvarchar(50),@Discount float,@mavoucher int
AS
	update voucher  set ten=@ten,chitiet=@chitiet,Discount=@Discount,ngaybatdau=@ngaybatdau,ngayketthuc=@ngayketthuc where mavoucher=@mavoucher

GO
/****** Object:  StoredProcedure [dbo].[ThanhToan]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ThanhToan](@Mahoadon int)
as
begin
	UPDATE HoaDon SET	Trangthai=1 WHERE Mahoadon=@Mahoadon
end

drop procedure  themmonan

GO
/****** Object:  StoredProcedure [dbo].[themct]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[themct] (@bang bang readonly,@mamonan int)
as
begin
		delete from Congthuc where Mamonan=@mamonan and Manl not in(select Manl from @bang)

		update Congthuc set congthuc.soluong=b.soluong 
		from @bang as b 
		where congthuc.Mamonan=@mamonan and b.Manl in(select manl from Congthuc where mamonan=@mamonan) 
		and Congthuc.Manl=b.manl
		

		insert into Congthuc (manl,Mamonan,soluong)
		select *
		from @bang as b 
		where b.Manl not in(select manl from Congthuc where mamonan=b.mamonan) 
end
GO
/****** Object:  StoredProcedure [dbo].[themdonhang]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[themdonhang](@mahoadon int,@mamonan int,@soluong int)
as
begin
	if((select count(*) from Chitiethoadon where Mahoadon=@mahoadon and Mamonan=@mamonan)>0)
	begin
		update Chitiethoadon set Soluong=@soluong where Mahoadon=@mahoadon and Mamonan=@mamonan
	end
	else
	begin
		insert into Chitiethoadon values(@mahoadon,@mamonan,@soluong)
	end
end

CREATE TYPE bang AS TABLE  
    ( manl int, mamonan int, soluong float ) 

GO
/****** Object:  StoredProcedure [dbo].[themmonan]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[themmonan](@ten nvarchar(50))
as
begin
	SET XACT_ABORT ON
	BEGIN TRAN
	BEGIN TRY
	  insert into Monan values (@ten)
	  COMMIT
	END TRY
	BEGIN CATCH
	   ROLLBACK
	   DECLARE @ErrorMessage VARCHAR(2000)
	   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
	   RAISERROR(@ErrorMessage, 16, 1)
	END CATCH
end

drop procedure  suamonan

GO
/****** Object:  StoredProcedure [dbo].[themMonAntheongay]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[themMonAntheongay](@mamonan int,@gia float,@soluong int)
as
begin
	insert into Monantheongay values(CONVERT(date,getdate()),@mamonan,@gia,@soluong)
end

drop procedure  suaMonAntheongay

GO
/****** Object:  StoredProcedure [dbo].[themnl]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[themnl](@ten nvarchar(50))
as
begin
	insert into NguyenLieu values (@ten)
end

GO
/****** Object:  StoredProcedure [dbo].[themNV]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[themNV] @hoten Nvarchar(50),@sdt Nvarchar(50),@ngaysinh date,@username Nvarchar(50)
,@luong float,@password nvarchar(50),@MaNQL int,@Role nvarchar(50) 
AS
insert into NhanVien (hoten,SoDT,ngaysinh,luong,UserName,Password,MaNQL,Role) values( @hoten, @sdt, @ngaysinh, @luong,@username,@password,@MaNQL,@Role)

GO
/****** Object:  StoredProcedure [dbo].[ThemVaoChiaCa]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[ThemVaoChiaCa] @manv int,@maca int,@date date
AS
	INSERT INTO ChiaCa(Manv,Maca,ngay)VALUES (@manv,@maca,CONVERT(date,@date))

GO
/****** Object:  StoredProcedure [dbo].[themVoucher]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO








CREATE PROCEDURE [dbo].[themVoucher] @ngaybatdau date,@ngayketthuc date, @ten nvarchar(50),@chitiet nvarchar(50),@Discount float
AS
	insert into voucher (ngaybatdau,ngayketthuc,ten,chitiet,Discount) values(@ngaybatdau,@ngayketthuc,@ten,@chitiet,@Discount)

GO
/****** Object:  StoredProcedure [dbo].[UpdatetableStatus]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[UpdatetableStatus] @Maban int,@Trangthai nvarchar(50)
AS
	UPDATE Ban SET	Trangthai=@Trangthai WHERE Maban=@Maban

GO
/****** Object:  StoredProcedure [dbo].[xoaChiaCa]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE PROCEDURE [dbo].[xoaChiaCa] @manv int,@maca int,@ngay date
AS
	DELETE FROM ChiaCa WHERE Manv=@Manv AND Maca=@Maca ANd ngay=CONVERT(date,@ngay) 

GO
/****** Object:  StoredProcedure [dbo].[xoamonan]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[xoamonan](@ma int)
as
begin
	SET XACT_ABORT ON
	BEGIN TRAN
	BEGIN TRY
	  delete from Monan where Mamonan=@ma
	  COMMIT
	END TRY
	BEGIN CATCH
	   ROLLBACK
	   DECLARE @ErrorMessage VARCHAR(2000)
	   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
	   RAISERROR(@ErrorMessage, 16, 1)
	END CATCH
end
GO
/****** Object:  StoredProcedure [dbo].[xoaMonAntheongay]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[xoaMonAntheongay](@mamonan int)
as
begin
	delete from Monantheongay where Mamonan=@mamonan and ngay=CONVERT(date,getdate())
end

drop procedure  DatHang

GO
/****** Object:  StoredProcedure [dbo].[xoanl]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[xoanl](@ma int)
as
begin
	delete from NguyenLieu where Manl=@ma
end


GO
/****** Object:  StoredProcedure [dbo].[xoaNV]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[xoaNV]	@manv int
AS
delete NhanVien where manv = @manv

GO
/****** Object:  StoredProcedure [dbo].[xoaVoucher]    Script Date: 12/21/2020 7:12:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[xoaVoucher] @mavoucher int
AS
	delete from voucher where mavoucher=@mavoucher

GO
USE [master]
GO
ALTER DATABASE [DBMS] SET  READ_WRITE 
GO
