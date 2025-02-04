USE [master]
GO
/****** Object:  Database [dbQLCHThucAnNhanh]    Script Date: 11/10/2019 22:10:44 ******/
CREATE DATABASE [dbQLCHThucAnNhanh] ON  PRIMARY 
( NAME = N'dbQLCHThucAnNhanh', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\dbQLCHThucAnNhanh.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbQLCHThucAnNhanh_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\dbQLCHThucAnNhanh_log.LDF' , SIZE = 768KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbQLCHThucAnNhanh].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET ANSI_NULLS OFF
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET ANSI_PADDING OFF
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET ARITHABORT OFF
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET AUTO_CLOSE ON
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET  ENABLE_BROKER
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET  READ_WRITE
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET RECOVERY SIMPLE
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET  MULTI_USER
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [dbQLCHThucAnNhanh] SET DB_CHAINING OFF
GO
USE [dbQLCHThucAnNhanh]
GO
/****** Object:  Table [dbo].[tblLoaiNguyenLieu]    Script Date: 11/25/2018 22:10:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblLoaiNguyenLieu](
	[MaLoaiNL] [varchar](10) NOT NULL,
	[TenLoaiNL] [nvarchar](50) NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK__tblLoaiN__122523160EA330E9] PRIMARY KEY CLUSTERED 
(
	[MaLoaiNL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblLoaiNguyenLieu] ([MaLoaiNL], [TenLoaiNL], [TrangThai]) VALUES (N'LNL01', N'Thịt tươi', 1)
INSERT [dbo].[tblLoaiNguyenLieu] ([MaLoaiNL], [TenLoaiNL], [TrangThai]) VALUES (N'LNL02', N'Bột', 1)
INSERT [dbo].[tblLoaiNguyenLieu] ([MaLoaiNL], [TenLoaiNL], [TrangThai]) VALUES (N'LNL03', N'Trứng', 1)
INSERT [dbo].[tblLoaiNguyenLieu] ([MaLoaiNL], [TenLoaiNL], [TrangThai]) VALUES (N'LNL04', N'Rau củ quả', 1)
INSERT [dbo].[tblLoaiNguyenLieu] ([MaLoaiNL], [TenLoaiNL], [TrangThai]) VALUES (N'LNL05', N'Gia vị', 1)
INSERT [dbo].[tblLoaiNguyenLieu] ([MaLoaiNL], [TenLoaiNL], [TrangThai]) VALUES (N'LNL06', N'Bơ', 1)
INSERT [dbo].[tblLoaiNguyenLieu] ([MaLoaiNL], [TenLoaiNL], [TrangThai]) VALUES (N'LNL07', N'Gạo', 1)
/****** Object:  Table [dbo].[tblLoaiMonAn]    Script Date: 11/25/2018 22:10:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblLoaiMonAn](
	[MaLoaiMon] [varchar](10) NOT NULL,
	[TenLoaiMon] [nvarchar](50) NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK__tblLoaiM__612C5AE407020F21] PRIMARY KEY CLUSTERED 
(
	[MaLoaiMon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblLoaiMonAn] ([MaLoaiMon], [TenLoaiMon], [TrangThai]) VALUES (N'LM01', N'Gà', 1)
INSERT [dbo].[tblLoaiMonAn] ([MaLoaiMon], [TenLoaiMon], [TrangThai]) VALUES (N'LM02', N'Cơm', 1)
INSERT [dbo].[tblLoaiMonAn] ([MaLoaiMon], [TenLoaiMon], [TrangThai]) VALUES (N'LM03', N'Hamburger', 1)
INSERT [dbo].[tblLoaiMonAn] ([MaLoaiMon], [TenLoaiMon], [TrangThai]) VALUES (N'LM04', N'Thức ăn nhẹ', 1)
INSERT [dbo].[tblLoaiMonAn] ([MaLoaiMon], [TenLoaiMon], [TrangThai]) VALUES (N'LM05', N'Tráng miệng&Thức uống', 1)
INSERT [dbo].[tblLoaiMonAn] ([MaLoaiMon], [TenLoaiMon], [TrangThai]) VALUES (N'LM06', N'Combo', 1)
/****** Object:  Table [dbo].[tblTaiKhoan]    Script Date: 11/25/2018 22:10:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTaiKhoan](
	[TenTaiKhoan] [varchar](20) NOT NULL,
	[MatKhau] [varchar](30) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[SoDT] [varchar](10) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[LaAdmin] [int] NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK__tblTaiKh__B106EAF97F60ED59] PRIMARY KEY CLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1: Chủ cửa hàng, 2: Quản lý cửa hàng, 3: Quản lý bán hàng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblTaiKhoan', @level2type=N'COLUMN',@level2name=N'LaAdmin'
GO
INSERT [dbo].[tblTaiKhoan] ([TenTaiKhoan], [MatKhau], [HoTen], [Email], [SoDT], [DiaChi], [LaAdmin], [TrangThai]) VALUES (N'chucuahang', N'123456789', N'Hiếu Vinh Hòa', N'hvh@gmail.com', NULL, NULL, 0, 1)
INSERT [dbo].[tblTaiKhoan] ([TenTaiKhoan], [MatKhau], [HoTen], [Email], [SoDT], [DiaChi], [LaAdmin], [TrangThai]) VALUES (N'userqlbh', N'123456789', N'Nguyễn Tấn Hải', N'qlbh@gmail.com', NULL, NULL, 2, 1)
INSERT [dbo].[tblTaiKhoan] ([TenTaiKhoan], [MatKhau], [HoTen], [Email], [SoDT], [DiaChi], [LaAdmin], [TrangThai]) VALUES (N'userqlbh1', N'123456789', N'Nguyễn Hoài Hậu', N'qlbh1@gmail.com', NULL, NULL, 2, 1)
INSERT [dbo].[tblTaiKhoan] ([TenTaiKhoan], [MatKhau], [HoTen], [Email], [SoDT], [DiaChi], [LaAdmin], [TrangThai]) VALUES (N'userqlbh2', N'123456789', N'Trần Gia Khiêm', N'qlbh2@gmail.com', NULL, NULL, 2, 1)
INSERT [dbo].[tblTaiKhoan] ([TenTaiKhoan], [MatKhau], [HoTen], [Email], [SoDT], [DiaChi], [LaAdmin], [TrangThai]) VALUES (N'userqlch', N'123456789', N'Nguyễn Trung Hiếu', N'qlch@gmail.com', NULL, NULL, 1, 1)
INSERT [dbo].[tblTaiKhoan] ([TenTaiKhoan], [MatKhau], [HoTen], [Email], [SoDT], [DiaChi], [LaAdmin], [TrangThai]) VALUES (N'userqlch2', N'123456789', N'Trần Quang Vinh', N'qlch2@gmail.com', NULL, NULL, 1, 1)
INSERT [dbo].[tblTaiKhoan] ([TenTaiKhoan], [MatKhau], [HoTen], [Email], [SoDT], [DiaChi], [LaAdmin], [TrangThai]) VALUES (N'userqlch3', N'123456789', N'Nguyễn Thế Hòa', N'qlch1@gmail.com', NULL, NULL, 1, 1)
/****** Object:  Table [dbo].[tblNhaCungCap]    Script Date: 11/25/2018 22:10:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblNhaCungCap](
	[MaNCC] [varchar](10) NOT NULL,
	[TenNhaCC] [nvarchar](50) NULL,
	[DiaChiNCC] [nvarchar](max) NULL,
	[SDTNCC] [varchar](10) NULL,
	[EmailNCC] [nvarchar](50) NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblNhaCungCap] ([MaNCC], [TenNhaCC], [DiaChiNCC], [SDTNCC], [EmailNCC], [TrangThai]) VALUES (N'NCC001', N'Công ty thực phẩm công nghệ', N'TP. Hồ Chí Minh', N'987654321', N'nhacungcap01@gmail.com', 1)
INSERT [dbo].[tblNhaCungCap] ([MaNCC], [TenNhaCC], [DiaChiNCC], [SDTNCC], [EmailNCC], [TrangThai]) VALUES (N'NCC002', N'Công ty thực phẩm', N'Hà Nội', N'123456789', N'nhacungcap02@gmail.com', 1)
INSERT [dbo].[tblNhaCungCap] ([MaNCC], [TenNhaCC], [DiaChiNCC], [SDTNCC], [EmailNCC], [TrangThai]) VALUES (N'NCC003', N'Công ty cung cấp thực phẩm', N'TP. Đà Nẵng', N'123456789', N'nhacungcap03@gmail.com', 1)
/****** Object:  Table [dbo].[tblNguyenLieu]    Script Date: 11/25/2018 22:10:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblNguyenLieu](
	[MaNL] [varchar](10) NOT NULL,
	[MaLoaiNL] [varchar](10) NULL,
	[MaNCC] [varchar](10) NULL,
	[TenNL] [nvarchar](50) NULL,
	[DonViTinh] [nvarchar](10) NULL,
	[DonGia] [int] NULL,
	[SoLuongTonKho] [int] NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK__tblNguye__2725D73C0AD2A005] PRIMARY KEY CLUSTERED 
(
	[MaNL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL001', N'LNL01', N'NCC001', N'Đùi gà', N'kg', 35000, 100, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL002', N'LNL01', N'NCC001', N'Cánh gà', N'kg', 35000, 100, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL003', N'LNL01', N'NCC001', N'Ất gà', N'kg', 35000, 100, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL004', N'LNL02', N'NCC001', N'Bột mì', N'gram', 25000, 500, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL005', N'LNL02', N'NCC001', N'Bột chiên giòn', N'gram', 25000, 500, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL006', N'LNL02', N'NCC001', N'Bột bắp', N'gram', 25000, 1000, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL007', N'LNL03', N'NCC001', N'Trứng gà', N'quả', 5000, 200, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL008', N'LNL03', N'NCC001', N'Trứng vịt', N'quả', 5000, 200, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL009', N'LNL04', N'NCC001', N'Xà lách', N'gram', 10000, 1000, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL010', N'LNL04', N'NCC001', N'Bắp cải trắng', N'gram', 10000, 1000, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL011', N'LNL04', N'NCC001', N'Khoai tây', N'gram', 10000, 1000, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL012', N'LNL04', N'NCC001', N'Khoai tây', N'gram', 10000, 1000, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL013', N'LNL04', N'NCC001', N'Cà chua', N'quả', 10000, 200, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL014', N'LNL04', N'NCC001', N'Dưa leo', N'quả', 10000, 200, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL015', N'LNL04', N'NCC001', N'Cà rốt', N'quả', 10000, 200, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL016', N'LNL04', N'NCC001', N'Chanh', N'quả', 10000, 200, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL017', N'LNL05', N'NCC001', N'Dầu ăn', N'gram', 50000, 1000, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL018', N'LNL05', N'NCC001', N'Đường', N'gram', 10000, 1000, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL019', N'LNL05', N'NCC001', N'Muối', N'gram', 10000, 1000, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL020', N'LNL05', N'NCC001', N'Tiêu', N'gram', 10000, 1000, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL021', N'LNL05', N'NCC001', N'Giấm', N'gram', 10000, 1000, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL022', N'LNL05', N'NCC001', N'Hạt nêm', N'gram', 10000, 1000, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL023', N'LNL05', N'NCC001', N'Tương ớt', N'gram', 10000, 1000, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL024', N'LNL05', N'NCC001', N'Tương cà', N'gram', 10000, 1000, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL025', N'LNL05', N'NCC001', N'Xốt Mayonnaise', N'gram', 10000, 1000, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL026', N'LNL06', N'NCC001', N'Bơ thực vật', N'gram', 20000, 1000, 1)
INSERT [dbo].[tblNguyenLieu] ([MaNL], [MaLoaiNL], [MaNCC], [TenNL], [DonViTinh], [DonGia], [SoLuongTonKho], [TrangThai]) VALUES (N'NL027', N'LNL07', N'NCC001', N'Gạo tài nguyên', N'gram', 300000, 1000, 1)
/****** Object:  Table [dbo].[tblMonAn]    Script Date: 11/25/2018 22:10:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblMonAn](
	[MaMon] [varchar](10) NOT NULL,
	[MaLoaiMon] [varchar](10) NULL,
	[TenMon] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[HinhAnh] [nvarchar](max) NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK__tblMonAn__3A5B29A803317E3D] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA001', N'LM01', N'Gà giòn không cay (1 Miếng)', 35000, N'ga\ga-01.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA002', N'LM01', N'Gà giòn không cay (3 Miếng)', 98000, N'ga\ga-02.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA003', N'LM01', N'Gà giòn không cay (6 Miếng)', 189000, N'ga\ga-03.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA004', N'LM01', N'Gà giòn cay (1 Miếng)', 35000, N'ga\ga-04.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA005', N'LM01', N'Gà giòn cay (3 Miếng)', 98000, N'ga\ga-05.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA006', N'LM01', N'Gà giòn cay (6 Miếng)', 189000, N'ga\ga-06.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA007', N'LM01', N'Cánh gà giòn cay (3 Miếng)', 47000, N'ga\ga-07.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA008', N'LM01', N'Cánh gà giòn cay (5 Miếng)', 69000, N'ga\ga-08.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA009', N'LM01', N'Gà truyền thống (1 Miếng)', 35000, N'ga\ga-09.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA010', N'LM01', N'Gà truyền thống (3 Miếng)', 98000, N'ga\ga-10.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA011', N'LM01', N'Gà truyền thống (6 Miếng)', 189000, N'ga\ga-11.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA012', N'LM01', N'Gà quay tiêu', 66000, N'ga\ga-12.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA013', N'LM01', N'Gà quay giấy bạc', 66000, N'ga\ga-13.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA014', N'LM02', N'Cơm phi-lê gà giòn', 41000, N'com\com-01.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA015', N'LM02', N'Cơm gà viên sốt hàn', 41000, N'com\com-02.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA016', N'LM02', N'Cơm gà viên sốt nhật', 41000, N'com\com-03.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA017', N'LM02', N'Cơm trộn veggie', 41000, N'com\com-04.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA018', N'LM02', N'Cơm gà rán giòn cay', 41000, N'com\com-05.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA019', N'LM02', N'Cơm phi-lê gà quay flava', 41000, N'com\com-06.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA020', N'LM02', N'Cơm phi-lê gà tiêu quay', 41000, N'com\com-07.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA021', N'LM02', N'Cơm gà truyền thống', 41000, N'com\com-08.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA022', N'LM03', N'Bơ-gơ gà giòn', 42000, N'hamburger\ham-01.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA023', N'LM03', N'Bơ-gơ gà quay flava', 45000, N'hamburger\ham-02.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA024', N'LM03', N'Bơ-gơ zinger', 49000, N'hamburger\ham-03.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA025', N'LM04', N'Khoai tây chiên (Vừa)', 14000, N'khoaitay\khoai-01.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA026', N'LM04', N'Khoai tây chiên (Lớn)', 27000, N'khoaitay\khoai-02.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA027', N'LM04', N'Khoai tây chiên (Đại)', 37000, N'khoaitay\khoai-03.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA028', N'LM04', N'Khoai tây nghiền (Vừa)', 12000, N'khoaitay\khoai-04.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA029', N'LM04', N'Khoai tây nghiền (Lớn)', 22000, N'khoaitay\khoai-05.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA030', N'LM04', N'Khoai tây nghiền (Đại)', 32000, N'khoaitay\khoai-06.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA031', N'LM04', N'Bắp cải trộn (Vừa)', 12000, N'rautron\rau-01.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA032', N'LM04', N'Bắp cải trộn (Lớn)', 22000, N'rautron\rau-02.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA033', N'LM04', N'Bắp cải trộn (Đại)', 32000, N'rautron\rau-03.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA034', N'LM05', N'Kem ốc quế', 5000, N'kem\kem-01.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA035', N'LM05', N'Kem phủ sô-cô-la', 7000, N'kem\kem-02.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA036', N'LM05', N'Kem sundae', 12000, N'kem\kem-03.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA037', N'LM05', N'Bánh trứng nướng (1 Cái)', 17000, N'banhtrung\banh-01.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA038', N'LM05', N'Bánh trứng nướng (4 Cái)', 50000, N'banhtrung\banh-02.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA039', N'LM05', N'Chai aquafina 500ml', 15000, N'nuoc\nuoc-01.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA040', N'LM05', N'Pepsi (Vừa)', 10000, N'nuoc\nuoc-02.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA041', N'LM05', N'Pepsi (Lớn)', 17000, N'nuoc\nuoc-03.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA042', N'LM05', N'Coca cola', 20000, N'nuoc\nuoc-04.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA043', N'LM06', N'Combo Kiddie 1', 55000, N'combo\cb-01.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA044', N'LM06', N'Combo Kiddie 2', 72000, N'combo\cb-02.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA045', N'LM06', N'Combo Kiddie Family 1', 209000, N'combo\cb-03.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA046', N'LM06', N'Combo Kiddie Family 2', 209000, N'combo\cb-04.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA047', N'LM06', N'Combo XL', 99000, N'combo\cb-05.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA048', N'LM06', N'Combo Double Meal', 180000, N'combo\cb-06.jpg', 1)
INSERT [dbo].[tblMonAn] ([MaMon], [MaLoaiMon], [TenMon], [DonGia], [HinhAnh], [TrangThai]) VALUES (N'MA049', N'LM06', N'Combo Family Meal', 250000, N'combo\cb-07.jpg', 1)
/****** Object:  Table [dbo].[tblHDXuat]    Script Date: 11/25/2018 22:10:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblHDXuat](
	[MaHDXuat] [int] NOT NULL,
	[TenTaiKhoan] [varchar](20) NULL,
	[NgayXuat] [datetime] NULL,
	[TongTien] [int] NULL,
	[TrangThai] [bit] NOT NULL,
	[TonTai] [bit] NOT NULL,
 CONSTRAINT [PK__tblHDXua__CC55350D21B6055D] PRIMARY KEY CLUSTERED 
(
	[MaHDXuat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0: Chờ xử lý - 1: Đã xử lý' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblHDXuat', @level2type=N'COLUMN',@level2name=N'TrangThai'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0: Không tồn tại - 1: Còn tồn tại' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblHDXuat', @level2type=N'COLUMN',@level2name=N'TonTai'
GO
INSERT [dbo].[tblHDXuat] ([MaHDXuat], [TenTaiKhoan], [NgayXuat], [TongTien], [TrangThai], [TonTai]) VALUES (1, N'userqlbh', CAST(0x0000A9A500000000 AS DateTime), 100000, 1, 1)
INSERT [dbo].[tblHDXuat] ([MaHDXuat], [TenTaiKhoan], [NgayXuat], [TongTien], [TrangThai], [TonTai]) VALUES (2, N'userqlbh', CAST(0x0000A9A600000000 AS DateTime), 100000, 1, 1)
/****** Object:  Table [dbo].[tblHDNhap]    Script Date: 11/25/2018 22:10:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblHDNhap](
	[MaHDNhap] [int] NOT NULL,
	[TenTaiKhoan] [varchar](20) NULL,
	[MaNCC] [varchar](10) NULL,
	[NgayNhap] [datetime] NULL,
	[TongTien] [int] NULL,
	[TrangThai] [bit] NOT NULL,
	[TonTai] [bit] NOT NULL,
 CONSTRAINT [PK__tblHDNha__78BCAC741A14E395] PRIMARY KEY CLUSTERED 
(
	[MaHDNhap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1: Đã thanh toán, 2: Chưa thanh toán, 3: Hủy' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblHDNhap', @level2type=N'COLUMN',@level2name=N'TrangThai'
GO
INSERT [dbo].[tblHDNhap] ([MaHDNhap], [TenTaiKhoan], [MaNCC], [NgayNhap], [TongTien], [TrangThai], [TonTai]) VALUES (1, N'userqlbh', N'NCC001', CAST(0x0000A9A300000000 AS DateTime), 50000, 1, 1)
INSERT [dbo].[tblHDNhap] ([MaHDNhap], [TenTaiKhoan], [MaNCC], [NgayNhap], [TongTien], [TrangThai], [TonTai]) VALUES (2, N'userqlbh', N'NCC001', CAST(0x0000A9A300000000 AS DateTime), 50000, 1, 1)
INSERT [dbo].[tblHDNhap] ([MaHDNhap], [TenTaiKhoan], [MaNCC], [NgayNhap], [TongTien], [TrangThai], [TonTai]) VALUES (3, N'userqlbh', N'NCC002', CAST(0x0000A9A400000000 AS DateTime), 100000, 1, 1)
/****** Object:  Table [dbo].[tblHDBanHang]    Script Date: 11/25/2018 22:10:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblHDBanHang](
	[MaHD] [int] NOT NULL,
	[TenTaiKhoan] [varchar](20) NULL,
	[NgayLapHD] [datetime] NULL,
	[TongTien] [int] NULL,
	[TienCuaKH] [int] NULL,
	[TienThua] [int] NULL,
	[GhiChu] [nvarchar](max) NULL,
	[TrangThai] [int] NOT NULL,
	[TonTai] [bit] NULL,
 CONSTRAINT [PK__tblHDTha__2725A6E01273C1CD] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1: Đã thanh toán, 2: Chưa thanh toán, 3: Hủy hóa đơn' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblHDBanHang', @level2type=N'COLUMN',@level2name=N'TrangThai'
GO
INSERT [dbo].[tblHDBanHang] ([MaHD], [TenTaiKhoan], [NgayLapHD], [TongTien], [TienCuaKH], [TienThua], [GhiChu], [TrangThai], [TonTai]) VALUES (1, N'userqlbh', CAST(0x0000A9A30111D7C6 AS DateTime), 158000, 200000, 42000, N'', 1, 1)
/****** Object:  Table [dbo].[tblCTHDXuat]    Script Date: 11/25/2018 22:10:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCTHDXuat](
	[MaHDXuat] [int] NOT NULL,
	[MaNL] [varchar](10) NOT NULL,
	[DonGia] [int] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK__tblCTHDX__1E27687E25869641] PRIMARY KEY CLUSTERED 
(
	[MaHDXuat] ASC,
	[MaNL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCTHDNhap]    Script Date: 11/25/2018 22:10:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCTHDNhap](
	[MaHDNhap] [int] NOT NULL,
	[MaNL] [varchar](10) NOT NULL,
	[DonGia] [int] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK__tblCTHDN__AACEF1071DE57479] PRIMARY KEY CLUSTERED 
(
	[MaHDNhap] ASC,
	[MaNL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCTHDBanHang]    Script Date: 11/25/2018 22:10:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCTHDBanHang](
	[MaHD] [int] NOT NULL,
	[MaMon] [varchar](10) NOT NULL,
	[DonGia] [int] NULL,
	[SoLuong] [int] NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK__tblCTHDT__B480147A164452B1] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaMon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblCTHDBanHang] ([MaHD], [MaMon], [DonGia], [SoLuong], [GhiChu]) VALUES (1, N'MA005', 98000, 1, N'')
INSERT [dbo].[tblCTHDBanHang] ([MaHD], [MaMon], [DonGia], [SoLuong], [GhiChu]) VALUES (1, N'MA038', 50000, 1, N'')
INSERT [dbo].[tblCTHDBanHang] ([MaHD], [MaMon], [DonGia], [SoLuong], [GhiChu]) VALUES (1, N'MA040', 10000, 1, N'')
/****** Object:  ForeignKey [FK_tblNguyenLieu_tblLoaiNguyenLieu]    Script Date: 11/25/2018 22:10:46 ******/
ALTER TABLE [dbo].[tblNguyenLieu]  WITH CHECK ADD  CONSTRAINT [FK_tblNguyenLieu_tblLoaiNguyenLieu] FOREIGN KEY([MaLoaiNL])
REFERENCES [dbo].[tblLoaiNguyenLieu] ([MaLoaiNL])
GO
ALTER TABLE [dbo].[tblNguyenLieu] CHECK CONSTRAINT [FK_tblNguyenLieu_tblLoaiNguyenLieu]
GO
/****** Object:  ForeignKey [FK_tblNguyenLieu_tblNhaCungCap]    Script Date: 11/25/2018 22:10:46 ******/
ALTER TABLE [dbo].[tblNguyenLieu]  WITH CHECK ADD  CONSTRAINT [FK_tblNguyenLieu_tblNhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[tblNhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[tblNguyenLieu] CHECK CONSTRAINT [FK_tblNguyenLieu_tblNhaCungCap]
GO
/****** Object:  ForeignKey [FK_tblMaMon_tblLoaiMonAn]    Script Date: 11/25/2018 22:10:46 ******/
ALTER TABLE [dbo].[tblMonAn]  WITH CHECK ADD  CONSTRAINT [FK_tblMaMon_tblLoaiMonAn] FOREIGN KEY([MaLoaiMon])
REFERENCES [dbo].[tblLoaiMonAn] ([MaLoaiMon])
GO
ALTER TABLE [dbo].[tblMonAn] CHECK CONSTRAINT [FK_tblMaMon_tblLoaiMonAn]
GO
/****** Object:  ForeignKey [FK_tblHDXuat_tblTaiKhoan]    Script Date: 11/25/2018 22:10:46 ******/
ALTER TABLE [dbo].[tblHDXuat]  WITH CHECK ADD  CONSTRAINT [FK_tblHDXuat_tblTaiKhoan] FOREIGN KEY([TenTaiKhoan])
REFERENCES [dbo].[tblTaiKhoan] ([TenTaiKhoan])
GO
ALTER TABLE [dbo].[tblHDXuat] CHECK CONSTRAINT [FK_tblHDXuat_tblTaiKhoan]
GO
/****** Object:  ForeignKey [FK_tblHDNhap_tblNhaCungCap]    Script Date: 11/25/2018 22:10:46 ******/
ALTER TABLE [dbo].[tblHDNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblHDNhap_tblNhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[tblNhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[tblHDNhap] CHECK CONSTRAINT [FK_tblHDNhap_tblNhaCungCap]
GO
/****** Object:  ForeignKey [FK_tblHDNhap_tblTaiKhoan]    Script Date: 11/25/2018 22:10:46 ******/
ALTER TABLE [dbo].[tblHDNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblHDNhap_tblTaiKhoan] FOREIGN KEY([TenTaiKhoan])
REFERENCES [dbo].[tblTaiKhoan] ([TenTaiKhoan])
GO
ALTER TABLE [dbo].[tblHDNhap] CHECK CONSTRAINT [FK_tblHDNhap_tblTaiKhoan]
GO
/****** Object:  ForeignKey [FK_tblHDThanhToan_tblTaiKhoan]    Script Date: 11/25/2018 22:10:46 ******/
ALTER TABLE [dbo].[tblHDBanHang]  WITH CHECK ADD  CONSTRAINT [FK_tblHDThanhToan_tblTaiKhoan] FOREIGN KEY([TenTaiKhoan])
REFERENCES [dbo].[tblTaiKhoan] ([TenTaiKhoan])
GO
ALTER TABLE [dbo].[tblHDBanHang] CHECK CONSTRAINT [FK_tblHDThanhToan_tblTaiKhoan]
GO
/****** Object:  ForeignKey [FK_tblCTHDXuat_tblHDXuat]    Script Date: 11/25/2018 22:10:46 ******/
ALTER TABLE [dbo].[tblCTHDXuat]  WITH CHECK ADD  CONSTRAINT [FK_tblCTHDXuat_tblHDXuat] FOREIGN KEY([MaHDXuat])
REFERENCES [dbo].[tblHDXuat] ([MaHDXuat])
GO
ALTER TABLE [dbo].[tblCTHDXuat] CHECK CONSTRAINT [FK_tblCTHDXuat_tblHDXuat]
GO
/****** Object:  ForeignKey [FK_tblCTHDXuat_tblNguyenLieu]    Script Date: 11/25/2018 22:10:46 ******/
ALTER TABLE [dbo].[tblCTHDXuat]  WITH CHECK ADD  CONSTRAINT [FK_tblCTHDXuat_tblNguyenLieu] FOREIGN KEY([MaNL])
REFERENCES [dbo].[tblNguyenLieu] ([MaNL])
GO
ALTER TABLE [dbo].[tblCTHDXuat] CHECK CONSTRAINT [FK_tblCTHDXuat_tblNguyenLieu]
GO
/****** Object:  ForeignKey [FK_tblCTHDNhap_tblHDNhap]    Script Date: 11/25/2018 22:10:46 ******/
ALTER TABLE [dbo].[tblCTHDNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblCTHDNhap_tblHDNhap] FOREIGN KEY([MaHDNhap])
REFERENCES [dbo].[tblHDNhap] ([MaHDNhap])
GO
ALTER TABLE [dbo].[tblCTHDNhap] CHECK CONSTRAINT [FK_tblCTHDNhap_tblHDNhap]
GO
/****** Object:  ForeignKey [FK_tblCTHDNhap_tblNguyenLieu]    Script Date: 11/25/2018 22:10:46 ******/
ALTER TABLE [dbo].[tblCTHDNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblCTHDNhap_tblNguyenLieu] FOREIGN KEY([MaNL])
REFERENCES [dbo].[tblNguyenLieu] ([MaNL])
GO
ALTER TABLE [dbo].[tblCTHDNhap] CHECK CONSTRAINT [FK_tblCTHDNhap_tblNguyenLieu]
GO
/****** Object:  ForeignKey [FK_tblCTHDThanhToan_tblHDThanhToan]    Script Date: 11/25/2018 22:10:46 ******/
ALTER TABLE [dbo].[tblCTHDBanHang]  WITH CHECK ADD  CONSTRAINT [FK_tblCTHDThanhToan_tblHDThanhToan] FOREIGN KEY([MaHD])
REFERENCES [dbo].[tblHDBanHang] ([MaHD])
GO
ALTER TABLE [dbo].[tblCTHDBanHang] CHECK CONSTRAINT [FK_tblCTHDThanhToan_tblHDThanhToan]
GO
/****** Object:  ForeignKey [FK_tblCTHDThanhToan_tblMonAn]    Script Date: 11/25/2018 22:10:46 ******/
ALTER TABLE [dbo].[tblCTHDBanHang]  WITH CHECK ADD  CONSTRAINT [FK_tblCTHDThanhToan_tblMonAn] FOREIGN KEY([MaMon])
REFERENCES [dbo].[tblMonAn] ([MaMon])
GO
ALTER TABLE [dbo].[tblCTHDBanHang] CHECK CONSTRAINT [FK_tblCTHDThanhToan_tblMonAn]
GO
