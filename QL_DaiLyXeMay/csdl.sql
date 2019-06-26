﻿create database QUANLYDAILY
USE QUANLYDAILY
create table QUAN
(
	MaQuan char(4),
	TenQuan nchar(50),
	constraint quan_ma_pk primary key(MaQuan)
)
INSERT INTO dbo.QUAN
        ( MaQuan, TenQuan )
VALUES  ( 'Q1', N'Quận 1'), ( 'Q2', N'Quận 2'), ( 'Q3', N'Quận 3'), ( 'Q4', N'Quận 4'), ( 'Q5', N'Quận 5'),
( 'Q6', N'Quận 6'), ( 'Q7', N'Quận 7'), ( 'Q8', N'Quận 8'), ( 'Q9', N'Quận 9'), ( 'Q10', N'Quận 10'), ( 'Q11', N'Quận 11'), ( 'Q12', N'Quận 12')

create table LOAIDAILY
(
	MaLoaiDaiLy char(3),
	TenLoaiDaiLy nchar(30),
	TienNo money,
	constraint loaidl_ma_pk primary key(MaLoaiDaiLy)
)
INSERT INTO dbo.LOAIDAILY
        ( MaLoaiDaiLy, TenLoaiDaiLy, TienNo )
VALUES  ( '001', N'ĐL loại 1', 50000000  ), ( '002', N'ĐL loại 2', 20000000  )
CREATE TABLE DAILY
(
	MaDaiLy char(6),	
	TenDaiLy nchar(250) not null,
	MaLoaiDaiLy char(3),
	DienThoai char(13),
	Email char(30),
	DiaChi nchar(300) not null,
	MaQuan char(4),
	NgayTiepNhan date,
	SoNo money,
	constraint dl_ma_pk primary key(MaDaiLy),
	constraint dl_loaidl_fk foreign key(MaLoaiDaiLy) references LOAIDAILY(MaLoaiDaiLy),
	constraint dl_maquan_fk foreign key(MaQuan) references QUAN(MaQuan)
)

ALTER TABLE dbo.DAILY ADD GhiChu NCHAR(250)
ALTER TABLE dbo.DAILY ADD MaNhanVien CHAR(6)
ALTER TABLE dbo.DAILY ALTER COLUMN SoNo DECIMAL


create table PHIEUTHUTIEN
(
	MaPhieuThuTien char(8),
	MaDaiLy char(6),
	NgayThuTien date,
	SoTienThu money not null,
	NoiDung nchar(1000) not null,
	constraint ptt_ma_pk primary key(MaPhieuThuTien),
	constraint ptt_madl_fk foreign key(MaDaiLy) references DAILY(MaDaiLy)
)
create table TAIKHOAN
(
	MaNhanVien char(6),
	TenNhanVien NVARCHAR(250) not null,
	MatKhau char(16) not null,
	LoaiTaiKhoan NVARCHAR(20),
	constraint tk_ma_pk primary key(MaNhanVien)
)

create table DOANHSO
(
	MaDaiLy char(6),
	Thang date,
	SoPhieuXuat int,
	TongGiaTri money,
	constraint ds_madl_fk foreign key(MaDaiLy) references DAILY(MaDaiLy),
	constraint ds_pk primary key(MaDaiLy, Thang)
)

create table PHIEUXUATHANG
(
	MaPhieuXuatHang char(6),
	MaDaiLy char(6),
	TraTruoc DECIMAL,
	NgayLap date,
	MaNhanVien CHAR(6),
	TienConLai DECIMAL,
	constraint pxh_madl_fk foreign key(MaDaiLy) references dbo.DAILY(MaDaiLy),
	constraint pxh_manv_fk foreign KEY(MaNhanVien) references dbo.TAIKHOAN(MaNhanVien),
	constraint pxh_mapxh_pk primary key(MaPhieuXuatHang)
)
ALTER TABLE dbo.PHIEUXUATHANG ADD TongTien DECIMAL
create table MATHANG
(
	MaMatHang char(6),
	TenMatHang nchar(250),
	SoLuongCon int,
	DonViTinh nvarchar(20),
	DonGia DECIMAL,
	constraint mh_pk primary key(MaMatHang)
)
create table CHITIETXUAT
(
	ID INT IDENTITY PRIMARY KEY,
	MaPhieuXuatHang char(6),
	MaMatHang char(6),
	SoLuong int,
	ThanhTien DECIMAL,
	constraint ctt_mapxh_fk foreign key(MaPhieuXuatHang) references PHIEUXUATHANG(MaPhieuXuatHang),
	constraint ctt_mamh_fk foreign key(MaMatHang) references MATHANG(MaMatHang)
)

SELECT * FROM dbo.MATHANG
SELECT * FROM dbo.CHITIETXUAT
SELECT * FROM dbo.PHIEUXUATHANG
SELECT * FROM dbo.DAILY
SELECT MaDaiLy,MaNhanVien,TongTien,TraTruoc,TienConLai FROM dbo.PHIEUXUATHANG WHERE MaPhieuXuatHang = 'XH0001'
SELECT CHITIETXUAT.MaMatHang,TenMatHang,DonViTinh,SoLuong,DonGia,ThanhTien FROM dbo.CHITIETXUAT,dbo.MATHANG WHERE MaPhieuXuatHang = 'XH0001'
SELECT dbo.CHITIETXUAT.MaMatHang, TenMatHang, DonViTinh, SoLuong, DonGia, ThanhTien FROM dbo.CHITIETXUAT,dbo.MATHANG WHERE MaPhieuXuatHang = 'XH0001'
SELECT MaPhieuXuatHang AS MaPhieuXuat FROM dbo.PHIEUXUATHANG
INSERT INTO dbo.MATHANG( MaMatHang ,TenMatHang ,SoLuongCon , DonViTinh ,DonGia)
VALUES  ( 'YMH001' ,N'Yamaha 50cc' , 20 ,N'xe' , 10000000 )
INSERT INTO dbo.MATHANG( MaMatHang ,TenMatHang ,SoLuongCon , DonViTinh ,DonGia)
VALUES  ( 'YMH002' ,N'Yamaha 100cc' , 25 ,N'xe' , 30000000 )
INSERT INTO dbo.MATHANG( MaMatHang ,TenMatHang ,SoLuongCon , DonViTinh ,DonGia)
VALUES  ( 'YMH003' ,N'Yamaha 150cc' , 10 ,N'xe' , 50000000 )

SELECT MaPhieuXuatHang,MaDaiLy,NgayLap FROM dbo.PHIEUXUATHANG
INSERT INTO dbo.PHIEUXUATHANG( MaPhieuXuatHang ,MaDaiLy ,TraTruoc ,NgayLap ,MaNhanVien ,TienConLai,TongTien)
VALUES  ( 'XH0001' , 'DL0001' , 10000000 , '6-20-2019' ,'A' , 10000000 , 20000000)
INSERT INTO dbo.CHITIETXUAT(MaPhieuXuatHang ,MaMatHang ,SoLuong ,ThanhTien)
VALUES  ('XH0001' ,'YMH001' , 2 , 20000000  )

SELECT LoaiTaiKhoan FROM dbo.TAIKHOAN WHERE MaNhanVien = '1'
create table CONGNO
(
	MaDaiLy char(6),
	Thang date,
	NoDau money,
	PhatSinh money,
	NoCuoi money,
	constraint cn_madl_fk foreign key(MaDaiLy) references DAILY(MaDaiLy),
	constraint cn_pk primary key(MaDaiLy, Thang)
)
create table THAMSO
(
	id INT IDENTITY,
	SoDaiLyToiDa tinyint,
	SoLoaiDaiLy tinyint,
	SoMatHang tinyint,
)
INSERT INTO dbo.THAMSO( SoDaiLyToiDa , SoLoaiDaiLy , SoMatHang)
VALUES  ( 4 ,2 , 3 )
SELECT MaNhanVien, MatKhau FROM dbo.TAIKHOAN

DELETE FROM dbo.DAILY WHERE MaDaiLy = ''
SELECT MaLoaiDaiLy FROM dbo.LOAIDAILY WHERE TenLoaiDaiLy = N'ĐL loại 1'
SELECT MaPhieuXuatHang, NgayLap FROM dbo.PHIEUXUATHANG
 
 SELECT * FROM dbo.PHIEUTHUTIEN
 SELECT * FROM dbo.DAILY WHERE MaDaiLy = ''
 
 INSERT INTO dbo.PHIEUTHUTIEN( MaPhieuThuTien ,MaDaiLy ,NgayThuTien ,SoTienThu ,NoiDung )
 VALUES  ( 'TT0001' , 'DL0001' , '6-24-2019' , 10000000 , N'Tiền đặt cọc' )
 SELECT * FROM dbo.PHIEUXUATHANG
 UPDATE dbo.DAILY SET SoNo = ''