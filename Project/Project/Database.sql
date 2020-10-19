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
	SODT char(50),
	EMAIL char(50),
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
	GIAPHONG float
)

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
	insert PHONG(ID) values ('PH00' + CONVERT(char, @i))
	set @i = @i + 1
end
select * from PHONG

declare @i int = 0;
while @i < 10 
begin
	insert DANGKI(ID) values ('DK00' + CONVERT(char, @i))
	set @i = @i + 1
end
select * from DANGKI
------------------------------------------------
create procedure us_UpdateTaiKhoan 
@userName varchar(40), @password varchar(40), @newPassword varchar(40), @Phanquyen char(20)
AS
BEGIN
	DECLARE @isRightPass INT = 0
		
	SELECT @isRightPass = COUNT(*) FROM TAIKHOAN 
		WHERE TENDN = @userName AND MATKHAU = @password

	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE TAIKHOAN 
			set PHANQUYEN = @Phanquyen
			WHERE TENDN = @userName
		END		
		ELSE
			UPDATE TAIKHOAN 
			SET MATKHAU = @newPassword 
			WHERE TENDN = @userName
	end
END
------------------------------------------------------
create procedure us_Login
(@user varchar(40), @pass varchar(40))
as
begin
	select * from TAIKHOAN where TENDN = @user and MATKHAU = @pass
end

--------------------------------------
create procedure room_Update
(@id char(5), @gia float)
as
BEGIN
	update PHONG set GIAPHONG = @gia  where ID = @id
	
END
-------------------------------------------
create procedure kh_UpdatePhone
(@email char(50) , @phone char(40))
as
BEGIN
	update KHACHHANG
	set SODT = @phone
	where EMAIL = @email
END
-------------------------------------
insert KHACHHANG(ID, EMAIL, SODT) 
values ('0','root@gmail.com','0')
select * from PHONG
select * from DANGKI
select * from KHACHHANG
delete DANGKI where ID = '-1'
insert TAIKHOAN(ID, TENDN, MAKH,PHANQUYEN)
values ('-1','root','0','0')
insert DANGKI(ID,NGNHANPHONG,NGTRAPHONG,TRANGTHAIDON,TGDOIPHONG)
values ('-1','1/1/2000','1/2/2000','root',0)
insert PHONG(ID,LOAI,TRANGTHAI,GIAPHONG)
values ('PH002','2','trong','800')