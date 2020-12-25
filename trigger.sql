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
		print 'mon an da mo ban'
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
		print 'hoa don da thanh toan roi'
		rollback
	end
	if(@soluong<=0)
	begin
		print 'so luong phai >0'
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

	

	if (@soluong>@tong-@sldaban)
	begin
		print 'mon an da het'
		rollback
	end
	else
	begin
		declare @soluongcu int
		select @soluongcu=soluong from deleted
		if(@soluongcu is null)
		set @soluongcu=0
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
	begin
		print 'hoa don da thanh toan '
		rollback
	end
end

drop trigger if exists xoa_chitiethoadon
go
create trigger xoa_chitiethoadon on chitiethoadon for delete as
begin
	declare @trangthai bit,@soluong int, @gia float,@mahoadon int,@mamonan int

	select @mahoadon=mahoadon,@mamonan=Mamonan,@soluong=Soluong from deleted
	select @trangthai=trangthai from Hoadon where Mahoadon=@mahoadon
	if(@trangthai=1)
	begin
		print 'hoa don da thanh toan '
		rollback
	end
		select @gia=gia from Monantheongay where Mamonan=@mamonan and ngay=convert(date,getdate())
		update Hoadon set Tongbill=Tongbill-@soluong*@gia where Mahoadon=@mahoadon
end
go
drop trigger if exists XoaUser
go
CREATE trigger XoaUser on NhanVien for delete
as
begin
	declare @sql nvarchar(max)

	declare @username nvarchar(50)
	select @username=Username from deleted
	BEGIN 
		IF ((SELECT COUNT(*) FROM master.sys.syslogins WHERE name = @username) > 0)
			SET @sql=' DROP LOGIN '+@username+''
			EXEC (@sql)
		
		IF ((SELECT COUNT(*) FROM sys.database_principals WHERE type = N'S' AND name = @username) > 0)
		BEGIN 
			SET @sql=' DROP USER '+@username+''
			EXEC (@sql)
			
		END
	END
END
go
drop trigger if exists TaoUser
go
CREATE trigger TaoUser on NhanVien for insert,update as
begin
	declare @sql nvarchar(max)
	declare @role nvarchar(50)
	declare @oldpass nvarchar(50)
	declare @pass nvarchar(50)
	declare @username nvarchar(50)
	select @username=Username, @pass=Password,@role=Role from inserted
	select @oldpass from NhanVien where NhanVien.UserName=@username

	--employee--
	IF (@role = 'employee') 
	BEGIN 
		IF (@oldPass is not null)
			SET @sql=' ALTER LOGIN '+@username+' WITH Password = ''' + @pass + ''''
		ELSE IF ((SELECT COUNT(*) FROM master.sys.syslogins WHERE name = @username) > 0)
			SET @sql=' ALTER LOGIN '+@username+' WITH Password = ''' + @pass + ''' Old_Password = ''' + @oldPass + ''''
		ELSE
			SET @sql=' CREATE LOGIN '+@username+' WITH Password = ''' + @pass + ''''
		EXEC (@sql) 
		IF ((SELECT COUNT(*) FROM sys.database_principals WHERE type = N'S' AND name = @username) = 0)
		BEGIN 
			SET @sql=' CREATE USER '+@username+' FOR LOGIN ' + @username
			EXEC (@sql)
			SET @sql= CONCAT('sp_addrolemember ', '''employee'',', '''', @username, '''')
			EXEC (@sql)
		END
	END

	--admin--
	ELSE
	BEGIN
	IF (@oldPass is not null)
			SET @sql=' ALTER LOGIN '+@username+' WITH Password = ''' + @pass + ''''
		ELSE IF ((SELECT COUNT(*) FROM master.sys.syslogins where name = @username) > 0)
			SET @sql=' ALTER LOGIN '+@username+' WITH Password = ''' + @pass + ''' Old_Password = ''' + @oldPass + ''''
		ELSE
			SET @sql=' CREATE LOGIN '+@username+' WITH Password = ''' + @pass + ''''
		EXEC (@sql) 
		IF ((SELECT COUNT(*) FROM sys.database_principals WHERE type= N'S' AND name = @username) = 0)
		BEGIN 
			SET @sql=' CREATE USER '+@username+' FOR LOGIN ' + @username
			EXEC (@sql)
			SET @sql= CONCAT('sp_addrolemember ', '''db_owner'',', '''', @username, '''')
			EXEC (@sql)
		END
	END
END
go
drop trigger ThemVoucher
go
create trigger TrigerThemVoucher on voucher for insert,update
as
begin
	declare @Discount float 
	select @Discount=Discount from inserted
	if(@Discount>=1)
	begin
		print 'Khong duoc tao khuyen mai lon hon 100%'
		rollback
	end
end
go
create trigger KtChiaCa on ChiaCa for insert,update
as
begin
	declare @Manv int 
	declare @Maca int 
	select @Manv=Manv,@Maca=Maca from inserted
	if((Select count (*) From ChiaCa Where Maca=@Maca AND Manv=@Manv)>1)
	begin
		print 'Nhan vien nay da lam viec o thoi gian nay'
		rollback
	end
end
