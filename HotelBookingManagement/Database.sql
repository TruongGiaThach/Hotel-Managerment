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
alter table KHACHHANG 
	add CMND varchar(20)
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
alter table DANGKI	
	add constraint df_ngay_nhan_phong default getdate() for NGNHANPHONG
create table PHONG
(
	ID char(5) NOT NULL PRIMARY KEY	,
	LOAI	varchar(20),
	TRANGTHAI char(20),
	GIAPHONG money
)
alter table PHONG 
	add constraint gt_trang_thai_phong check (TRANGTHAI = 'trong' or TRANGTHAI = 'dang cho')
alter table PHONG 
	add constraint gt_loai_phong check (LOAI = 'nomal1' or LOAI = 'nomal2' or LOAI = 'vip1' or LOAI = 'vip2' )
create table NHANVIEN
(
	ID char(5) not null primary key,
	HOTEN varchar(40),
	CMND	varchar(20),
	SDT	  varchar(20),
	GIOITINH varchar(10),
	NGBD smalldatetime,
	TGHOPDONG int
)
alter table NHANVIEN
	add constraint GT_GIOI_TINH check (GIOITINH = 'nam' or GIOITINH = 'nu')
alter table NHANVIEN	
	add constraint unique_cmnd unique(CMND)
insert into NHANVIEN (ID,HOTEN,CMND,SDT,GIOITINH) values ('0',' ','root','0','nam');
create procedure us_Login
(@user varchar(40), @pass varchar(40))
as
begin
	select * from TAIKHOAN where TENDN = @user and MATKHAU = @pass
end
select * from NHANVIEN
select * from KHACHHANG
select * from PHONG