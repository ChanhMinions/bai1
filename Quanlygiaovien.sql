create database QuanLyGiaoVien
USE QuanLyGiaoVien
create table KETNOI
(
tenmay NVARCHAR(50),
tencsdl NVARCHAR(50),
dangnhap NVARCHAR(50),
matkhau NVARCHAR(50),
primary key (tenmay),
)
create table COSO
(
macoso  NVARCHAR(50),
tencoso  NVARCHAR(50),
primary key (macoso),
)
create table GiaoVien
(
magv  NVARCHAR(50),
hoten   NVARCHAR(50),
sdt NVARCHAR(50),
ghichu  NVARCHAR(50),
madonvi NVARCHAR(50),
primary key (magv),
)
create table DONVI
(
madonvi NVARCHAR(50),
tendonvi NVARCHAR(50),
macoso NVARCHAR(50),
primary key (madonvi),
)
insert into KETNOI values ('ON','quanlygiaovien','abc','123')

insert into COSO values ('MCS01','CNTT')
insert into COSO values ('MCS02','Co Khi')
insert into COSO values ('MCS03','CBMA')
insert into COSO values ('MCS04','The Duc')
insert into COSO values ('MCS05','QTKS')

insert into GiaoVien values ('MG01','Nguyen Van A','0124215',NULL,'MDV01')
insert into GiaoVien values ('MG02','Nguyen Van B','0112421',NULL,'MDV02')
insert into GiaoVien values ('MG03','Nguyen Van C','0124757',NULL,'MDV03')
insert into GiaoVien values ('MG04','Nguyen Van D','0125685',NULL,'MDV04')
insert into GiaoVien values ('MG05','Nguyen Van E','0124374',NULL,'MDV05')

insert into DONVI values ('MDV01','T01','MCS01')
insert into DONVI values ('MDV02','T01','MCS02')
insert into DONVI values ('MDV03','T03','MCS03')
insert into DONVI values ('MDV04','T02','MCS04')
insert into DONVI values ('MDV05','T02','MCS05')
 Select*
 from COSO
  Select*
 from DONVI
   Select*
 from GiaoVien
 Select COSO.macoso,DONVI.madonvi
            FROM COSO Inner join DONVI 
            ON COSO.macoso = DONVI.macoso
            WHERE COSO.macoso = DONVI.macoso
Select GiaoVien.hoten,COSO.macoso,DONVI.tendonvi 
            FROM GiaoVien Inner Join DONVI 
            ON GiaoVien.hoten = DONVI.tendonvi Inner join COSO 
            ON DONVI.macoso = COSO.macoso 
            WHERE(COSO.macoso = COSO.macoso) and (DONVI.tendonvi = DONVI.tendonvi )
			 








