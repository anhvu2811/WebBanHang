
drop database QL_THIETBIDIENTU
go
create database QL_THIETBIDIENTU
go
use QL_THIETBIDIENTU
go

create table NhanVien
(
	MaNV varchar(10),
	TenNV nvarchar(50),
	TaiKhoan varchar(50),
	Password varchar(50),
	Primary key(MaNV),
)
create table NhomHang
(
	MaNhom int,
	TenNhom nvarchar(50),
	Primary key(MaNhom),
)
create table HangHoa
(
	MaHH int,
	MaNhom int,
	TenHH nvarchar(50),
	HinhAnh varchar(50),
	Gia float,
	DonViTinh nvarchar(50),
	NoiSX nvarchar(50),
	Primary key(MaHH),
	Foreign key (MaNhom) references NhomHang(MaNhom),
)
create table HoaDon
(
	MaHD int,
	TenHD nvarchar(50),
	MaNV varchar(10),
	MaHH int,
	SoLuong int,
	Primary key(MaHD),
	Foreign key (MaNV) references NhanVien(MaNV),
	Foreign key (MaHH) references HangHoa(MaHH),
)

insert into NhanVien
values
('NV01', N'Võ Anh Vũ', 'anhvu', '123456'),
('NV02', N'Mã Trường Bảo', 'truongbao', '123456'),
('NV03', N'Đặng Văn Tú', 'vantu', '123456')

insert into NhomHang
values
(1,N'Điện thoại di động'),
(2,N'Đồ gia dụng'),
(3,N'Đồ chơi công nghệ')

SET DATEFORMAT dmy;
insert into HangHoa
values
(1, 1, N'Điện thoại SS a21s','ssA21s.jpg', 3000000, 'VND', N'TP.HCM'),
(2, 1, N'Điện thoại IP X','ipX.jpg', 5000000,'VND', N'TP.HCM'),
(3, 1, N'Cáp sạc','capsac.jpg',600000, 'VND', N'Hà Nội'),
(4, 1, N'Pin dự phòng','pinduphong.jpg', 100000, 'VND', N'Đà Nẵng'),

(5, 2, N'Nồi chiên không dầu','noichienkhongdau.jpg',2448000, 'VND', N'TP.HCM'),
(6, 2, N'Máy xay sinh tố','mayxaysinhto.jpg', 947000,'VND', N'TP.HCM'),
(7, 2, N'Bếp từ','beptu.png',2290000, 'VND', N'TP.HCM'),
(8, 2, N'Bàn ủi hơi nước','banuihoinuoc.jpg',300000, 'VND', N'TP.HCM')

select * from NhomHang
select * from HangHoa
