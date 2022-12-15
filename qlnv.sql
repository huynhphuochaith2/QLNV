CREATE DATABASE QLNV
GO
USE QLNV;

CREATE TABLE chucvu(
	macv nvarchar(5) primary key,
	tencv nvarchar(50) not null,
	hsphucap float
) 
GO

CREATE TABLE nhanvien(
	manv nvarchar(5) primary key,
	holot nvarchar(50) not null,
	tennv nvarchar(10) not null,
	phai nvarchar(3),
	ngaysinh smalldatetime,
	macv nvarchar(5) not null foreign key(macv) references chucvu(macv),
	tinhtrang nvarchar(20) not null,
) 
GO
CREATE TABLE quatrinhluong(
	manv nvarchar(5) not null foreign key(manv) references nhanvien(manv),
	ngaybd smalldatetime,
	hsluong float not null,
	ghichu bit,
	primary key(manv,ngaybd)
)
GO

CREATE TABLE nguoidung(
	ten nvarchar(30) not null primary key,
	matkhau varchar(50),
	quyen tinyint,
)
GO

create table phongban(
   mapb nvarchar(20) not null,
   tenpb nvarchar(30) not null primary key,
   sdt varchar(10) not null,
   manv nvarchar(5) not null foreign key(manv) references nhanvien(manv),
   Trang_thai nvarchar(20) default N'Mở',
)
go

create table duan(
   manv nvarchar(5) not null foreign key(manv) references nhanvien(manv),
   mada nvarchar(15) not null primary key,
   tenda nvarchar(30) not null,
   makynang nvarchar(10) not null,
   tenkynang nvarchar(30) not null,
)
go

create table luong(
   luongcoban int primary key,
   manv nvarchar(5) not null foreign key(manv) references nhanvien(manv),
   hsluong float not null ,
   hsphucap float,
   ngaycong int,
)

INSERT INTO luong VALUES(500000,N'NV001',10,3.2,26);
INSERT INTO luong VALUES(560000,N'NV002',11,3.3,25);
INSERT INTO luong VALUES(570000,N'NV003',12,3.4,25);
INSERT INTO luong VALUES(580000,N'NV004',9,3.5,24);
INSERT INTO luong VALUES(590000,N'NV005',14,3.6,23);
INSERT INTO luong VALUES(510000,N'NV006',9,3.6,26);
INSERT INTO luong VALUES(520000,N'NV007',14,3.9,25);
INSERT INTO luong VALUES(530000,N'NV008',8,3.8,26);
INSERT INTO luong VALUES(540000,N'NV009',14,3.6,25);
INSERT INTO luong VALUES(550000,N'NV010',10,3.7,24);
INSERT INTO luong VALUES(513000,N'NV011',14,3.6,26);
INSERT INTO luong VALUES(512000,N'NV012',9,3.1,23);

INSERT INTO duan VALUES(N'NV001',N'VW',N'Viết Web',N'TK',N'Thiết kế');
INSERT INTO duan VALUES(N'NV003',N'XN',N'Xây nhà',N'LKH',N'Lên kế hoạch');
INSERT INTO duan VALUES(N'NV005',N'SXVL',N'Sản xuất vật liệu',N'KTVL',N'Kiểm tra vật liệu');
INSERT INTO duan VALUES(N'NV006',N'XDCN',N'Xây dựng công nghiệp',N'GS',N'Giám sát');
INSERT INTO duan VALUES(N'NV008',N'LR',N'Lắp ráp',N'LYT',N'Lên ý tưởng');
INSERT INTO duan VALUES(N'NV002',N'XDNM',N'Xây dựng nhà máy',N'VBV',N'Vẽ bản vẽ');
INSERT INTO duan VALUES(N'NV007',N'TN',N'Thí nghiệm',N'QS',N'Quan sát');

INSERT INTO phongban VALUES(N'TV',N'Tài vụ',N'012345678',N'NV001',N'Mở');
INSERT INTO phongban VALUES(N'BV',N'Bảo vệ',N'098765432',N'NV003',N'Đóng');
INSERT INTO phongban VALUES(N'NS',N'Nhân sự',N'055994432',N'NV005',N'Mở');
INSERT INTO phongban VALUES(N'QL',N'Quản lý',N'055223344',N'NV007',N'đóng');
INSERT INTO phongban VALUES(N'SX',N'Sản xuất',N'055336677',N'NV009',N'Mở');

-- Dữ liệu bảng nguoidung
INSERT INTO nguoidung VALUES(N'quantri','e99a18c428cb38d5f260853678922e03',1);	/* Mật khẩu abc123 */
INSERT INTO nguoidung VALUES(N'nhanvien','a906449d5769fa7361d7ecc6aa3f6d28',2);	/* Mật khẩu 123abc */


-- Dữ liệu bảng chucvu
INSERT INTO chucvu VALUES(N'TP',N'Trưởng phòng',0.5);
INSERT INTO chucvu VALUES(N'PP',N'Phó trưởng phòng',0.45);
INSERT INTO chucvu VALUES(N'CV',N'Chuyên viên',0.3);
INSERT INTO chucvu VALUES(N'KT',N'Kế toán',0.25);
INSERT INTO chucvu VALUES(N'LX',N'Lái xe cơ quan',0.25);

-- Dữ liệu bảng nhanvien 
INSERT INTO nhanvien VALUES(N'NV001',N'Nguyễn Phước Minh',N'Tân',N'Nam','1985-04-19',N'TP',N'Đã kết hôn');
INSERT INTO nhanvien VALUES(N'NV002',N'Hà Thị Thanh',N'Nhàn',N'Nữ','1974-03-09',N'PP',N'Đã kết hôn');
INSERT INTO nhanvien VALUES(N'NV003',N'Văn Minh',N'Tú',N'Nam','1970-02-15',N'CV',N'Độc thân');
INSERT INTO nhanvien VALUES(N'NV004',N'Lý Văn',N'Sang',N'Nam','1980-12-21',N'CV',N'Đã kết hôn');
INSERT INTO nhanvien VALUES(N'NV005',N'Nguyễn Thị Thu',N'An',N'Nữ','1991-08-22',N'PP',N'Đã kết hôn');
INSERT INTO nhanvien VALUES(N'NV006',N'Nguyễn Thanh',N'Tùng',N'Nam','1987-07-07',N'LX',N'Độc thân');
INSERT INTO nhanvien VALUES(N'NV007',N'Trần Văn',N'Sơn',N'Nam','1989-07-08',N'CV',N'Đã kết hôn');
INSERT INTO nhanvien VALUES(N'NV008',N'Cao Thị Ngọc',N'Nhung',N'Nữ','1990-06-19',N'KT',N'Độc thân');
INSERT INTO nhanvien VALUES(N'NV009',N'Lê Thành',N'Tấn',N'Nam','1994-12-05',N'CV',N'Đã kết hôn');
INSERT INTO nhanvien VALUES(N'NV010',N'Phan Thị Thủy',N'Tiên',N'Nữ','1997-10-25',N'KT',N'Độc thân');
GO
-- Dữ liệu bảng qtluong
INSERT INTO quatrinhluong VALUES(N'NV003','2011/01/01',2.34,0);
INSERT INTO quatrinhluong VALUES(N'NV001','2011/01/01',4.4,0);
INSERT INTO quatrinhluong VALUES(N'NV002','2011/01/01',4.4,0);
INSERT INTO quatrinhluong VALUES(N'NV008','2011/01/01',1.86,0);
INSERT INTO quatrinhluong VALUES(N'NV004','2012/06/01',2.34,0);
INSERT INTO quatrinhluong VALUES(N'NV008','2013/01/01',2.06,0);
INSERT INTO quatrinhluong VALUES(N'NV003','2014/01/01',2.67,0);
INSERT INTO quatrinhluong VALUES(N'NV002','2014/01/01',4.74,0);
INSERT INTO quatrinhluong VALUES(N'NV001','2014/01/01',4.74,0);
INSERT INTO quatrinhluong VALUES(N'NV008','2015/01/01',2.26,0);
INSERT INTO quatrinhluong VALUES(N'NV004','2015/06/01',2.67,0);
INSERT INTO quatrinhluong VALUES(N'NV005','2015/06/01',4.4,0);
INSERT INTO quatrinhluong VALUES(N'NV006','2015/06/01',2.05,0);
INSERT INTO quatrinhluong VALUES(N'NV008','2017/01/01',2.46,0);
INSERT INTO quatrinhluong VALUES(N'NV009','2017/01/01',2.34,0);
INSERT INTO quatrinhluong VALUES(N'NV003','2017/01/01',3,0);
INSERT INTO quatrinhluong VALUES(N'NV001','2017/01/01',5.08,0);
INSERT INTO quatrinhluong VALUES(N'NV006','2017/06/01',2.23,0);
INSERT INTO quatrinhluong VALUES(N'NV005','2018/06/01',4.74,0);
INSERT INTO quatrinhluong VALUES(N'NV004','2018/06/01',3,0);
INSERT INTO quatrinhluong VALUES(N'NV010','2018/06/01',1.86,0);
INSERT INTO quatrinhluong VALUES(N'NV007','2018/06/01',2.34,0);
INSERT INTO quatrinhluong VALUES(N'NV008','2019/01/01',2.66,0);
INSERT INTO quatrinhluong VALUES(N'NV006','2019/06/01',2.41,0);
INSERT INTO quatrinhluong VALUES(N'NV001','2020/01/01',5.42,1);
INSERT INTO quatrinhluong VALUES(N'NV009','2020/01/01',2.67,1);
INSERT INTO quatrinhluong VALUES(N'NV010','2020/06/01',2.06,1);
INSERT INTO quatrinhluong VALUES(N'NV008','2021/01/01',2.86,1);
INSERT INTO quatrinhluong VALUES(N'NV005','2021/06/01',5.08,1);
INSERT INTO quatrinhluong VALUES(N'NV007','2021/06/01',2.67,1);
INSERT INTO quatrinhluong VALUES(N'NV006','2021/06/01',2.59,1);
INSERT INTO quatrinhluong VALUES(N'NV004','2021/06/01',3.33,1);

select * from luong;