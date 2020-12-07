create database PROJECT
use PROJECT
create table TAIKHOAN
(
	ID varchar(5) NOT NULL PRIMARY KEY,
	TENDN varchar(40)NOT NULL default 'tk_khach',
	MATKHAU varchar(40) NOT NULL default 'thach',
	MAKH varchar(5),
	PHANQUYEN varchar(20) NOT NULL,
)

alter table TAIKHOAN
	drop column MAKH
alter table TAIKHOAN
	add MANV char(5);
create table KHACHHANG
(
	ID varchar(5) NOT NULL PRIMARY KEY,	
	HOTEN nvarchar(40),
	SODT varchar(20),
	EMAIL varchar(30),
	DIACHI varchar(50)
)
alter table KHACHHANG 
	add CMND varchar(20)
create table DANGKI
(
	ID varchar(5) NOT NULL PRIMARY KEY,
	MAKH varchar (5),
	MAPHONG varchar(5),
	NGNHANPHONG smalldatetime,
	NGTRAPHONG smalldatetime,
	
	TRANGTHAIDON varchar(20),
	TGDOIPHONG int,
	GHICHU varchar(50)
)
alter table DANGKI
	add constraint ck_datetime check (NGTRAPHONG > NGNHANPHONG)
alter table DANGKI	
	add constraint df_ngay_nhan_phong default getdate() for NGNHANPHONG
create table PHONG
(
	ID varchar(5) NOT NULL PRIMARY KEY	,
	LOAI	varchar(20),
	TRANGTHAI nvarchar(20),
	GIAPHONG money
)
alter table PHONG 
	add constraint gt_trang_thai_phong check (TRANGTHAI = 'trong' or TRANGTHAI = 'dang cho' or TRANGTHAI = 'da nhan')
alter table PHONG 
	add constraint gt_loai_phong check (LOAI = 'Nomal1' or LOAI = 'Nomal2' or LOAI = 'Vip1' or LOAI = 'Vip2' )
create table NHANVIEN
(
	ID varchar(5) not null primary key,
	HOTEN nvarchar(40),
	CMND	varchar(20),
	SDT	  varchar(20),
	GIOITINH varchar(10),
	NGBD smalldatetime,
	TGHOPDONG int
)

alter table NHANVIEN
	alter column GIOITINH nvarchar(20)
alter table NHANVIEN	
	add constraint unique_cmnd unique(CMND)
insert into NHANVIEN (ID,HOTEN,CMND,SDT,GIOITINH) values ('0',' ','root','0','nam');
alter table TAIKHOAN
	add constraint fk_TK_NV 
	foreign key (MANV)
	references NHANVIEN(ID)
create procedure us_Login
(@user varchar(40), @pass varchar(40))
as
begin
	select * from TAIKHOAN where TENDN = @user and MATKHAU = @pass
end
select * from NHANVIEN
select * from KHACHHANG
select * from PHONG
select * from DANGKI
select * from TAIKHOAN
<<<<<<< Updated upstream
update TAIKHOAN set MATKHAU = '21232F297A57A5A743894A0E4A801FC3'
	where ID = '0'
=======
update TAIKHOAN set MATKHAU = 'C4CA4238A0B923820DCC509A6F75849B'
	where ID = '0'
insert into TAIKHOAN (ID, TENDN, MATKHAU, PHANQUYEN, MANV) values ('0','root',' ',' ','0');
>>>>>>> Stashed changes
