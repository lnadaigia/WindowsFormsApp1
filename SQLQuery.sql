
create table NguyenLieu
(
	Manl int primary key  IDENTITY(1,1),
	tenNL nvarchar(50) not null unique
)
go
create table Monan
(
	Mamonan int primary key  IDENTITY(1,1),
	tenmonan nvarchar(50) not null unique
)
go
create table Congthuc
(
	Mamonan int not null references monan(Mamonan) on delete cascade on update cascade,
	Manl int not null references nguyenlieu(Manl) on delete cascade on update cascade,
	soluong float not null,
	constraint pk_congthuc primary key (mamonan,manl)
)
go
create table Monantheongay
(
	ngay date not null,
	Mamonan int not null references monan(Mamonan) on update cascade,
	gia float not null,
	tongsoluong int not null,
	constraint pk_monantheongay primary key (Mamonan,ngay),
)
go

create table Nguyenlieutheongay
(
	ngay date not null,
	Manl int not null references nguyenlieu(Manl)  on update cascade ,
	gia float ,
	tongsoluong int not null,
	constraint pk_nguyenlieutheongay primary key(ngay,manl)
)
go


create table NhanVien
(
	MaNV int primary key  IDENTITY(1,1),
	Hoten nvarchar(50) not null,
	SoDT nvarchar(50) not null,
	Ngaysinh date not null,
	luong float,
	MaNQL int references Nhanvien(manv)
)
go
create table Ca
(
	Maca int primary key  IDENTITY(1,1),
	Tenca nvarchar(50) not null
)
go
create table ChiaCa
(
	Manv int not null  references nhanvien(manv) on delete cascade on update cascade,
	Maca int not null  references ca(Maca) on delete cascade on update cascade,
	ngay date not null,
	constraint pk_chica primary key (manv,maca,ngay)
)
go
create table Ban
(
	Maban int primary key  IDENTITY(1,1),
	Tenban nvarchar(50) not null,
	Trangthai nvarchar(50),
	SoLuongKhach int
)
go
create table voucher
(
	mavoucher int primary key  IDENTITY(1,1),
	ten nvarchar(50) not null,
	ngaybatdau date not null,
	ngayketthuc date not null,
	chitiet nvarchar(50),
	Discount float not null
)
go

create table Hoadon
(
	Mahoadon int primary key  IDENTITY(1,1),
	Maban int references ban(maban) on delete set null on update cascade,
	Thoigian datetime not null,
	Tongbill float default 0,
	Manv int references nhanvien(manv) on delete set null on update cascade,
	mavoucher int  references voucher(mavoucher) on delete set null on update cascade,
	Trangthai bit not null
)
go

create table Chitiethoadon
(
	Mahoadon int not null references hoadon(mahoadon) on delete cascade on update cascade,
	Mamonan int not null ,
	Soluong int not null ,
	constraint pk_chitiethoadon primary key (mahoadon,mamonan)
)
go

create function bandangsd()
returns table
as
	return select maban from hoadon
	where convert(date,Hoadon.Thoigian)=convert(date,getdate()) and trangthai=0
go

drop function if exists monan_daban
go
CREATE function monan_daban(@mamonan int,@mahoadon int)
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

go
create function ct_monan(@mamonan int)
returns table
as
return
	(
			select nl.Manl 
			from Nguyenlieutheongay as nl,
			(select * from Congthuc where Mamonan=@mamonan)as ct
			where nl.Manl=ct.Manl and nl.ngay=CONVERT(date,getdate())
	)
	
go
drop trigger if exists Monan_theongay
go
create trigger Monan_theongay on monantheongay for insert,update as
begin
	declare @mamonan int
	declare @sl int
	select @mamonan=mamonan,@sl=tongsoluong from inserted

		declare @soluongcu int
		select @soluongcu=tongsoluong from deleted
		if(@soluongcu is null)
		begin
			set @soluongcu=0
		end

		update Nguyenlieutheongay  set tongsoluong=tongsoluong +ct.soluong*(@sl-@soluongcu)
		from Congthuc as ct 
		where ct.Mamonan=@mamonan and ct.Manl in(select *from ct_monan(@mamonan)) 
		and ngay=CONVERT(date,getdate()) 
		and Nguyenlieutheongay.Manl =ct.Manl

		insert into Nguyenlieutheongay 
		(ngay,Manl,tongsoluong) 
		select CONVERT(date,getdate()),Manl,soluong*(@sl-@soluongcu)
		from Congthuc
		where Mamonan=@mamonan and Manl not in(select *from ct_monan(@mamonan))

end
go
drop trigger if exists  xoa_monan_theongay
go
create trigger xoa_monan_theongay on monantheongay for delete
as
begin
	declare @mamonan int,@tongsoluong int
	select @mamonan=mamonan,@tongsoluong=tongsoluong from deleted
	declare @sldaban int
	select @sldaban=soluong_daban from dsmonan() where Mamonan=@mamonan
	if(@sldaban>0)
	begin
		rollback
	end
	else
	begin
		update Nguyenlieutheongay  set tongsoluong=tongsoluong -ct.soluong*(@tongsoluong)
			from Congthuc as ct 
			where ct.Mamonan=@mamonan and ct.Manl in(select *from ct_monan(@mamonan)) 
			and ngay=CONVERT(date,getdate()) 
			and Nguyenlieutheongay.Manl =ct.Manl
	end
end
go

drop trigger if exists  ban_sd
go
CREATE trigger ban_sd on hoadon for insert ,update
as
begin
	declare @maban int,@t int
	select @maban=maban from inserted
	select @t=count(*) 
	from hoadon
	where convert(date,Hoadon.Thoigian)=convert(date,getdate()) and trangthai=0 and maban=@maban
	if(@t>1)
	begin
		print 'ban dang su dung'
		rollback
	end
	
end
go
drop trigger if exists Chitiet_hoadon
go
create trigger Chitiet_hoadon on chitiethoadon for insert,update as
begin
	declare @mamonan int	, @gia float	, @soluong int	, @mahoadon int,@tong int,@sldaban int
	Declare @t int
	select @mamonan=mamonan,@soluong=soluong,@mahoadon=mahoadon from inserted
	if((select count(*) from hoadon where mahoadon=@mahoadon and trangthai=1)>0)
	begin
		print 'hoa don da chot roi'
		rollback
	end
	if(@soluong<=0)
	begin
		print 'so luong >0'
		rollback
	end
	select @gia=gia,@tong=tongsoluong from monantheongay where mamonan=@mamonan and ngay=convert(date,getdate()) 
	if(@gia is null)
	begin
		print 'mon an chua duoc mo ban'
		rollback
	end

	select @sldaban=sum(ct.Soluong) from Chitiethoadon as ct, hoadon as hd
	where  convert(date,hd.thoigian)=convert(date,getdate()) 
	and ct.Mamonan=@mamonan and hd.Mahoadon=ct.Mahoadon and ct.Mahoadon!=@mahoadon
	if(@sldaban is null)
	set @sldaban=0

	declare @soluongcu int
	select @soluongcu=soluong from deleted
	if(@soluongcu is null)
		set @soluongcu=0

	if (@soluong>@tong-@sldaban)
	begin
		print 'mon an da het'
		rollback
	end
	else
	begin
		
		update hoadon set tongbill=tongbill+@gia*(@soluong-@soluongcu) where mahoadon=@mahoadon
	end
end
go
drop trigger if exists xoahoadon
go
create trigger xoahoadon on hoadon for delete
as
begin
	declare @trangthai bit
	select @trangthai=trangthai from deleted
	if(@trangthai=1)
		rollback
end

drop trigger if exists xoa_chitiethoadon
go
create trigger xoa_chitiethoadon on chitiethoadon for delete as
begin
	declare @trangthai bit,@soluong int, @gia float,@mahoadon int,@mamonan int

	select @mahoadon=mahoadon,@mamonan=Mamonan,@soluong=Soluong from deleted
	select @trangthai=trangthai from Hoadon where Mahoadon=@mahoadon
	if(@trangthai=1)
		rollback
	else 
		select @gia=gia from Monantheongay where Mamonan=@mamonan and ngay=convert(date,getdate())
		update Hoadon set Tongbill=Tongbill-@soluong*@gia where Mahoadon=@mahoadon
end
go
create procedure themdonhang(@mahoadon int,@mamonan int,@soluong int)
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
drop function if exists dsmonan
go
create function dsmonan()
returns table
as
return
select ct.Mamonan,isnull(sum(ct.Soluong),0) as 'soluong_daban',convert(date,hd.Thoigian) as 'ngay' 
	from Chitiethoadon as ct,hoadon as hd 
	where hd.Mahoadon=ct.Mahoadon and convert(date,hd.Thoigian)=CONVERT(date,getdate()) 
	group by ct.Mamonan,convert(date,hd.Thoigian)
go

CREATE TYPE bang AS TABLE  
    ( manl int, mamonan int, soluong float ) 
go

drop procedure if exists themct
go
create procedure themct (@bang bang readonly,@mamonan int)
as
begin
		update Congthuc set congthuc.soluong=b.soluong 
		from @bang as b 
		where congthuc.Mamonan=@mamonan and b.Manl in(select manl from Congthuc where mamonan=@mamonan) 
		and Congthuc.Manl=b.manl
		

		insert into Congthuc (manl,Mamonan,soluong)
		select *
		from @bang as b 
		where b.Manl not in(select manl from Congthuc where mamonan=b.mamonan) 
end

CREATE TYPE chitiet AS TABLE  
    ( mamonan int, soluong float ) 
go
drop procedure if exists themchitiet
go
CREATE procedure themchitiet (@bang chitiet readonly,@maban int)
as
begin
		declare @mahoadon int
		select @mahoadon =mahoadon from Hoadon where Maban=@maban and Trangthai=0
		if(@mahoadon is null)
		begin
			insert into Hoadon values(@maban,CONVERT(datetime,getdate()),0,null,null,0)
			select @mahoadon =mahoadon from Hoadon where Maban=@maban and Trangthai=0
		end
		delete from Chitiethoadon where Mahoadon=@mahoadon
		if((select count (*) from @bang)>0)
		begin
		
			insert into Chitiethoadon (Mahoadon,Mamonan,Soluong)
				select @mahoadon,b.mamonan,b.soluong
				from @bang as b 
				where b.mamonan not in(select mamonan from Chitiethoadon where Mahoadon=@mahoadon)
		
			
			update Chitiethoadon set Chitiethoadon.Soluong=b.soluong
			from @bang as b 
			where b.mamonan in(select mamonan from Chitiethoadon where Mahoadon=@mahoadon) 
			and Chitiethoadon.Mahoadon=@mahoadon and b.mamonan=Chitiethoadon.Mamonan
		end
		
			
end