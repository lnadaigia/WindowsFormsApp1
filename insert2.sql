insert into Monan values('com chien')
insert into Monan values('bun bo')
go
insert into NguyenLieu values('com')
insert into NguyenLieu values('trung')
insert into NguyenLieu values('hang')
insert into NguyenLieu values('bo')
insert into NguyenLieu values('bun')
go
insert into Congthuc values(1,1,10)
insert into Congthuc values(1,2,20)
insert into Congthuc values(1,3,30)
insert into Congthuc values(2,3,40)
insert into Congthuc values(2,4,50)
insert into Congthuc values(2,5,50)
go
insert into Monantheongay values(CONVERT(date,getdate()),1,10000,100)
insert into Monantheongay values(CONVERT(date,getdate()),2,20000,200)
go
--update Monantheongay  set tongsoluong=50 where Mamonan=1 and ngay=CONVERT(date,getdate())
go
--delete from Monantheongay where Mamonan=1 and ngay=CONVERT(date,getdate())
go
select * from Monantheongay where ngay=CONVERT(date,getdate())
select * from Nguyenlieutheongay where ngay=CONVERT(date,getdate())
go

insert into Hoadon values(null,CONVERT(datetime,getdate()),0,null,null,0)
go
insert into Chitiethoadon values(1,2,1)

--update Chitiethoadon set Soluong=199 where Mahoadon=1 and Mamonan=2
go
select ct.* ,m.gia,ma.tenmonan
from Chitiethoadon as ct,Hoadon as hd ,Monan as ma,Monantheongay as m
where hd.Mahoadon=ct.Mahoadon and CONVERT(date,hd.Thoigian)=convert(date,GETDATE()) 
and m.ngay=CONVERT(date,getdate()) and m.Mamonan=ct.Mamonan and ma.Mamonan=m.Mamonan

select * from Hoadon where CONVERT(date,Hoadon.Thoigian)=convert(date,GETDATE())
select * from Monantheongay where ngay=CONVERT(date,getdate())
go
select m.Mamonan,m.gia,m.tongsoluong,(m.tongsoluong-ham.soluong_daban) as 'soluong_con',0 as 'soluong' from Monantheongay as m right join
(
	select ct.Mamonan,isnull(sum(ct.Soluong),0) as 'soluong_daban',convert(date,hd.Thoigian) as 'ngay' 
	from Chitiethoadon as ct,hoadon as hd 
	where hd.Mahoadon=ct.Mahoadon and convert(date,hd.Thoigian)=CONVERT(date,getdate()) 
	group by ct.Mamonan,convert(date,hd.Thoigian)
) as ham
on m.Mamonan=ham.Mamonan and m.ngay=ham.ngay
go
drop procedure if exists themdonhang
go

execute themdonhang 4,1,2