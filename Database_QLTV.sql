﻿
create database QuanLyThuVien
use QuanLyThuVien
drop database QuanLyThuVien
--drop table DanhSachSach
create table DanhSachSach
(
	MaSach varchar(5) constraint DSS_MaSach_PK primary key,
	TenSach Nvarchar(100), 
	TacGia nvarchar(100),
	TheLoai nvarchar(1) constraint DSS_TheLoai_CHK check(TheLoai in (N'A',N'B',N'C')),
	NamXuatBan int,
	NhaXuatBan nvarchar(100),
	NgayNhap datetime,
	TriGia int constraint DSS_TriGia_DF default(0),
	TinhTrang nvarchar(30) constraint DSS_TinhTrang_CHK check(TinhTrang in(N'Còn',N'Không có')),
	MaNgNhan varchar(5),
)
alter table DanhSachSach add constraint DSS_MaNgNhan_FK foreign key(MaNgNhan) references HoSo(MaNV)
--drop table TheDocGia
create table TheDocGia
(
	MS varchar(5) constraint TDG_MS_Pk primary key,
	TeDN varchar(50),
	MatKhau varchar(100) ,
	HoTen nvarchar(100),
	NgaySinh datetime,
	DiaChi nvarchar(100),
	Loai varchar(1) constraint TDG_Loai_CHK check(Loai in (N'X',N'Y')),
	Email varchar(50),
	NgayLapThe datetime,
	TongNo int constraint TDG_TongNo_DF default(0),
	MaNgLap varchar(5),
	MaNgThuTien varchar(5),
)

alter table TheDocGia add
	constraint TDG_MaNgLap_Fk foreign key(MaNgLap) references HoSo(MaNV),
	constraint TDG_MaNgThuTien_Fk foreign key(MaNgThuTien) references HoSo(MaNV)
--drop table HoSo
create table HoSo
(
	MaNV varchar(5) constraint HS_MaNV_Pk primary key,
	HoTen nvarchar(100),
	NgaySinh datetime,
	BangCap nvarchar(50),
	DiaChi nvarchar(100),
	DienThoai varchar(12),
	BoPhan nvarchar(10)
)

--drop table MuonSach
create table MuonSach
(
	MaDocGia varchar(5) constraint MS_MaDocGia_Fk foreign key(MaDocGia) references TheDocGia(MS),
	MaSach varchar(5) constraint MS_MaSach_Fk foreign key(MaSach) references DanhSachSach(MaSach),
	NgayMuon datetime,
	primary key(MaDocGia,MaSach),
)
--drop table TraSach
create table TraSach
(
	MaDocGia varchar(5) constraint TS_MaDocGia_Fk foreign key(MaDocGia) references THeDocGia(MS),
	MaSach varchar(5) constraint TS_MaSach_Fk foreign key(MaSach) references DanhSachSach(MaSach),
	primary key(MaDocGia,MaSach),
	NgayTra datetime,
	TienPhat int constraint TS_TienPhat_DF default(0),
	TienNo int constraint TS_TienNo_DF default(0),
	SoNgayMuon int constraint TS_SoNgayMuon_DF default(0),
)
--drop table MatSach
create table MatSach
(
	MaDocGia varchar(5) constraint MatS_MaDocGia_Fk foreign key(MaDocGia) references TheDocGia(MS),
	MaSach varchar(5) constraint Mat_S_MaSach_Fk foreign key(MaSach) references DanhSachSach(MaSach),
	MaNgGhiNhan varchar(5) constraint MatS_MaNgGhiNhan_Fk foreign key(MaNgGhiNhan) references HoSo(MaNV),
	primary key(MaDocGia,MaSach,MaNgGhiNhan),
	NgayGhiNhan datetime,
	SoTienThu int constraint MatS_SoTienThu_DF default(0)
)
--drop table ThanhLy
create table ThanhLy
(
	MaSach varchar(5) constraint TL_MaSach_Fk foreign key(MaSach) references DanhSachSach(MaSach),
	MaNgThanhLy varchar(5) constraint TL_MaNgThanhLy_FK foreign key(MaNgThanhLy) references HoSo(MaNV),
	NgayThanhLy datetime,
	LyDo nvarchar(50),
	primary key(MaNgThanhLy,MaSach)
)
Alter table ThanhLy
add 
select MS,HoTen,NgayLapThe, DATEDIFF(DAY,NgayLapThe,Getdate()) as N'Tổng số ngày'
from TheDocGia
where DATEDIFF(DAY,NgayLapThe,Getdate()) >180
select MS,TheDocGia.TeDN,TheDocGia.HoTen,CONVERT (varchar(10), TheDocGia.NgaySinh, 103) AS [NgaySinh],TheDocGia.DiaChi,Loai,Email,CONVERT (varchar(10), NgayLapThe, 103) AS [NgayLapThe],TongNo,HoSo.HoTen from TheDocGia,HoSo where TheDocGia.MaNgLap = HoSo.MaNV
select MS as N'Mã số',
																TheDocGia.TenDN as N'Tên đăng nhập',
                                                                TheDocGia.HoTen as N'Họ và tên',
                                                                CONVERT (varchar(10), TheDocGia.NgaySinh, 103) AS N'Ngày sinh',
                                                                TheDocGia.DiaChi as N'Địa chỉ',
                                                                Loai as N'Loại',
                                                                Email as Email,
                                                                CONVERT (varchar(10), NgayLapThe, 103) AS N'Ngày lập thẻ',
                                                                TongNo as N'Tổng nợ',
                                                                HoSo.HoTen as N'Họ và tên người lập' 
                                                                from TheDocGia,HoSo 
                                                                where TheDocGia.MaNgLap = HoSo.MaNV AND MS ='L.001'"