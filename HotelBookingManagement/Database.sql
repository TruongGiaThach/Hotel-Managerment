create database PROJECT
use PROJECT
create table TAIKHOAN
(
	ID varchar(5) NOT NULL PRIMARY KEY,
	TENDN varchar(40)NOT NULL default 'tk_khach',
	MATKHAU varchar(40) NOT NULL default 'thach',
	MANV varchar(5),
	PHANQUYEN varchar(20) NOT NULL,
)
		-----------------------------
create table KHACHHANG
(
	ID varchar(5) NOT NULL PRIMARY KEY,	
	HOTEN nvarchar(40),
	SODT varchar(20),
	EMAIL varchar(30),
	DIACHI varchar(50),
	CMND varchar(20)
)
		-----------------------------
create table DANGKI
(
	ID varchar(5) NOT NULL PRIMARY KEY,
	MAKH varchar (5),
	MAPHONG varchar(5),
	NGNHANPHONG smalldatetime,
	NGTRAPHONG smalldatetime,
	TRANGTHAIDON varchar(20),
	MAHD varchar(5) ,
	TGDOIPHONG int,
	GHICHU varchar(50)
)
alter table DANGKI	
	add constraint fk_DK_PHONG foreign key (MAPHONG) references PHONG(ID)
alter table DANGKI
	add constraint fk_DK_KH foreign key (MAKH) references KHACHHANG(ID)
alter table DANGKI
	add constraint fk_DK_HD foreign key (MAHD) references HOADON(ID)
alter table DANGKI
	add constraint ck_datetime check (NGTRAPHONG > NGNHANPHONG)
alter table DANGKI	
	add constraint df_ngay_nhan_phong default getdate() for NGNHANPHONG
alter table DANGKI
	add constraint gt_trangthaidon check (TRANGTHAIDON = 'dang cho' or TRANGTHAIDON = 'da nhan' or TRANGTHAIDON = 'da thanh toan');

create  trigger trigger_cap_nhat_gt_hoadon on DANGKI
for insert,update,delete
as
begin
	update HOADON 
	set CHUATHANHTOAN = 
	(
		select sum(PHONG.GIAPHONG * datediff(day,DANGKI.NGNHANPHONG,DANGKI.NGTRAPHONG))
		from PHONG,DANGKI
		where (HOADON.ID = DANGKI.MAHD)and(PHONG.ID = DANGKI.MAPHONG)
				and (DANGKI.TRANGTHAIDON = 'da nhan')		
	) 
	update HOADON 
	set DATHANHTOAN = 
	(
		select sum(PHONG.GIAPHONG)
		from PHONG,DANGKI
		where (HOADON.ID = DANGKI.MAHD)and(PHONG.ID = DANGKI.MAPHONG)
				and (DANGKI.TRANGTHAIDON = 'da thanh toan')		
	) 
end

		--------------------------------
create table PHONG
(
	ID varchar(5) NOT NULL PRIMARY KEY,
	LOAI	varchar(20),
	TRANGTHAI nvarchar(20),
	GIAPHONG money,
	TIENCOC money
)
alter table PHONG 
	add constraint gt_trang_thai_phong check (TRANGTHAI = 'trong' or TRANGTHAI = 'dang cho' or TRANGTHAI = 'da nhan')
alter table PHONG 
	add constraint gt_loai_phong check (LOAI = 'Nomal1' or LOAI = 'Nomal2' or LOAI = 'Vip1' or LOAI = 'Vip2' )
		------------------------------
create table NHANVIEN
(
	ID varchar(5) not null primary key,
	HOTEN nvarchar(40),
	CMND	varchar(20),
	SDT	  varchar(20),
	GIOITINH nvarchar(10),
	NGBD smalldatetime,
	TGHOPDONG int,
	LUONG int
)
alter table NHANVIEN	
	add constraint unique_cmnd unique(CMND)
alter table TAIKHOAN
	add constraint fk_TK_NV foreign key (MANV) references NHANVIEN(ID) on delete cascade
	-----------------
create table HOADON
(
	ID varchar(5) not null primary key,
	MAKH varchar(5),
	MANV varchar(5),
	CHUATHANHTOAN money,
	DATHANHTOAN money,
	NGHD smalldatetime
)

alter table HOADON
	add constraint df_gt default '0' for CHUATHANHTOAN
alter table HOADON
	add constraint df_gt2 default '0' for DATHANHTOAN
alter table HOADON
	add constraint fk_HD_KH foreign key (MAKH) references KHACHHANG(ID)
	-----------------
create procedure us_Login
(@user varchar(40), @pass varchar(40))
as
begin
	select * from TAIKHOAN where TENDN = @user and MATKHAU = @pass
end
	-------------------
select * from NHANVIEN
select * from KHACHHANG
select * from PHONG
select * from DANGKI
select * from TAIKHOAN
select *from HOADON
select * from MARKER
------------<<<<<<< Updated upstream
update TAIKHOAN set MATKHAU = '21232F297A57A5A743894A0E4A801FC3'
	where ID = '0'

update TAIKHOAN set MATKHAU = 'C4CA4238A0B923820DCC509A6F75849B'
	where ID = '0'
------------>>>>>>> Stashed changes

 create table MARKER
 (
	MARK_TABLE VARCHAR(10),
	NUMBER INT
 )
 INSERT INTO MARKER VALUES ('HOADON','0')
 insert into MARKER values ('DANGKI','0')
 insert into MARKER values ('KHACHHANG','0')
 insert into MARKER values ('NHANVIEN','0')
 insert into MARKER values ('TAIKHOAN','0')

 insert into NHANVIEN values ('NV0','Admin','Admin','Admin','Admin','1-1-2020',9999,0)
 insert into TAIKHOAN values ('0', 'Admin', '21232F297A57A5A743894A0E4A801FC3', 'NV0', 'admin')
 ---------------

 create table CHITIEU
 (
	T_DIEN Money,
	T_NUOC Money,
	T_LUONGNV Money,
	T_BAOTRI Money,
	T_KHAC Money,
	TONGCHI Money,
	THANG int,
	NAM int
	CONSTRAINT ChiTieu_pk PRIMARY KEY(THANG, NAM)
 )

 create table THUCHI
 (
	T_THU Money,
	T_CHI Money,
	T_LOINHUAN Money,
	THANG int,
	NAM int
	CONSTRAINT ThuChi_pk PRIMARY KEY(THANG, NAM)
 )

 create trigger cap_nhat_thu on HOADON
for insert,delete,update
as
Begin
		Update THUCHI
			set T_THU = 
				(select sum(DATHANHTOAN) 
	 			from HOADON h
         			where month(h.NGHD) = THUCHI.THANG and year(h.NGHD) = THUCHI.NAM        
				)

End

create trigger cap_nhat_chi on CHITIEU
for insert,delete,update
as
Begin
	update THUCHI
	set T_CHI = 
		(select sum(TONGCHI) 
		from CHITIEU c
		where (c.THANG = THUCHI.THANG) and (c.NAM = THUCHI.NAM)
		)
End
create trigger cap_nhat_loi_nhuan on THUCHI
for insert,delete,update
as
Begin
	update THUCHI
	set T_LOINHUAN = inserted.T_THU - inserted.T_CHI
	FROM inserted
	where (THUCHI.NAM = inserted.NAM) and (THUCHI.THANG = inserted.THANG)
End

select count 

select sum(LUONG) from NHANVIEN

