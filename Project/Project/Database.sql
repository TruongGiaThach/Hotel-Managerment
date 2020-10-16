create database PROJECT
use PROJECT
create table TAIKHOAN
(
	ID char(5) NOT NULL PRIMARY KEY,
	TENDN varchar(40)NOT NULL default 'tk_khach',
	MATKHAU varchar(40) NOT NULL default 'thach',
	MAKH char(5),
	PHANQUYEN char(20) NOT NULL,
)
create table KHACHHANG
(
	ID char(5) NOT NULL PRIMARY KEY,	
	HOTEN char(40),
	SODT char(20),
	EMAIL char(30),
	DIACHI char(50)
)
create table DANGKI
(
	ID char(5) NOT NULL PRIMARY KEY,
	MAKH char (5),
	MAPHONG char(5),
	NGNHANPHONG smalldatetime,
	NGTRAPHONG smalldatetime,
	check (NGTRAPHONG > NGNHANPHONG),
	TRANGTHAIDON char(20),
	TGDOIPHONG int,
	GHICHU varchar(50)
)

create table PHONG
(
	ID char(5) NOT NULL PRIMARY KEY	,
	LOAI	int,
	TRANGTHAI char(20),
	GIAPHONG money
)
create procedure us_Login
(@user varchar(40), @pass varchar(40))
as
begin
	select * from TAIKHOAN where TENDN = @user and MATKHAU = @pass
end

insert TAIKHOAN(ID,TENDN,MATKHAU,PHANQUYEN) values ('0','root','1','0')
declare @i int = 0;
while @i < 10 
begin
	insert TAIKHOAN (ID) values (CONVERT(char, @i))
	set @i = @i + 1
end

select * from TAIKHOAN

declare @i int = 0;
while @i < 10 
begin
	insert KHACHHANG (ID) values ('KH00' + CONVERT(char, @i))
	set @i = @i + 1
end
select * from KHACHHANG

declare @i int = 0;
while @i < 10 
begin
	insert PHONG(ID) values ('KH00' + CONVERT(char, @i))
	set @i = @i + 1
end
select * from PHONG

declare @i int = 0;
while @i < 10 
begin
	insert DANGKI(ID) values ('KH00' + CONVERT(char, @i))
	set @i = @i + 1
end
select * from DANGKI

select * from TAIKHOAN
