USE DBMS
GO
CREATE ROLE employee 
GRANT SELECT ON NhanVien to employee WITH GRANT OPTION
GRANT UPDATE ON NhanVien to employee WITH GRANT OPTION
GRANT INSERT,SELECT,UPDATE,DELETE ON Ban to employee WITH GRANT OPTION
GRANT SELECT ON Ca to employee WITH GRANT OPTION
GRANT INSERT,SELECT,UPDATE ON Chitiethoadon to employee WITH GRANT OPTION
GRANT INSERT,SELECT,UPDATE ON Hoadon to employee WITH GRANT OPTION
GRANT SELECT ON voucher to employee WITH GRANT OPTION
GRANT SELECT ON Monantheongay to employee WITH GRANT OPTION
GRANT EXECUTE ON themdonhang to employee WITH GRANT OPTION
GRANT EXECUTE ON ban_sd to employee WITH GRANT OPTION

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
		IF ((SELECT COUNT(*) FROM [DBMS].sys.database_principals WHERE type = N'S' AND name = @username) = 0)
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
		IF ((SELECT COUNT(*) FROM [DBMS].sys.database_principals WHERE type= N'S' AND name = @username) = 0)
		BEGIN 
			SET @sql=' CREATE USER '+@username+' FOR LOGIN ' + @username
			EXEC (@sql)
			SET @sql= CONCAT('sp_addrolemember ', '''db_owner'',', '''', @username, '''')
			EXEC (@sql)
		END
	END
END
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
		
		IF ((SELECT COUNT(*) FROM [DBMS].sys.database_principals WHERE type = N'S' AND name = @username) > 0)
		BEGIN 
			SET @sql=' DROP USER '+@username+''
			EXEC (@sql)
			
		END
	END
END