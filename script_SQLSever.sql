USE [master]
GO
/****** Object:  Database [HRM]    Script Date: 14/11/2024 8:36:22 CH ******/
CREATE DATABASE [HRM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HRM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\HRM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HRM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\HRM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [HRM] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HRM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HRM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HRM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HRM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HRM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HRM] SET ARITHABORT OFF 
GO
ALTER DATABASE [HRM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HRM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HRM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HRM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HRM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HRM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HRM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HRM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HRM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HRM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HRM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HRM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HRM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HRM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HRM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HRM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HRM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HRM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HRM] SET  MULTI_USER 
GO
ALTER DATABASE [HRM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HRM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HRM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HRM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HRM] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HRM] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [HRM] SET QUERY_STORE = ON
GO
ALTER DATABASE [HRM] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [HRM]
GO
/****** Object:  UserDefinedFunction [dbo].[LaySoTaiKhoan]    Script Date: 14/11/2024 8:36:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[LaySoTaiKhoan]()
RETURNS INT
AS
BEGIN
    DECLARE @RowCount INT;

    SELECT @RowCount = COUNT(*) FROM TaiKhoan;

    RETURN @RowCount;
END;
GO
/****** Object:  Table [dbo].[DM_ChucVu]    Script Date: 14/11/2024 8:36:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_ChucVu](
	[MaChucVu] [nvarchar](10) NOT NULL,
	[TenChucVu] [nvarchar](100) NULL,
	[HeSoLuong] [decimal](5, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DM_Luong]    Script Date: 14/11/2024 8:36:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_Luong](
	[MaNhanVien] [nvarchar](10) NOT NULL,
	[LuongCoBan] [decimal](10, 2) NULL,
	[PhuCap] [decimal](10, 2) NULL,
	[KhauTruThue] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Luong]    Script Date: 14/11/2024 8:36:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Luong](
	[MaNhanVien] [nvarchar](10) NOT NULL,
	[ThangNam] [nvarchar](7) NOT NULL,
	[SoNgayLam] [int] NULL,
	[LuongThucLanh] [int] NULL,
 CONSTRAINT [PK_Luong] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC,
	[ThangNam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NgayNghi]    Script Date: 14/11/2024 8:36:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NgayNghi](
	[MaNhanVien] [nvarchar](10) NOT NULL,
	[ThangNam] [nvarchar](7) NOT NULL,
	[SoNgayNghi] [int] NULL,
	[GhiChu] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC,
	[ThangNam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 14/11/2024 8:36:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nvarchar](10) NOT NULL,
	[TenNhanVien] [nvarchar](100) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](200) NULL,
	[SoDienThoai] [nvarchar](15) NULL,
	[MaPhongBan] [nvarchar](10) NULL,
	[MaChucVu] [nvarchar](10) NULL,
	[TinhTrangLamViec] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 14/11/2024 8:36:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPhongBan] [nvarchar](10) NOT NULL,
	[TenPhongBan] [nvarchar](100) NULL,
	[VanPhong] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhongBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QT_CongTac]    Script Date: 14/11/2024 8:36:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QT_CongTac](
	[MaCT] [nvarchar](10) NOT NULL,
	[MaNhanVien] [nvarchar](10) NOT NULL,
	[BatDau] [date] NULL,
	[KetThuc] [date] NULL,
	[GhiChu] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCT] ASC,
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 14/11/2024 8:36:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[STT_Tk] [int] NOT NULL,
	[TenTaiKhoan] [nvarchar](100) NULL,
	[MatKhau] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[TinhTrang] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[STT_Tk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DM_ChucVu] ([MaChucVu], [TenChucVu], [HeSoLuong]) VALUES (N'GD', N'Giám Đốc', CAST(3.00 AS Decimal(5, 2)))
INSERT [dbo].[DM_ChucVu] ([MaChucVu], [TenChucVu], [HeSoLuong]) VALUES (N'NV', N'Nhân Viên', CAST(1.00 AS Decimal(5, 2)))
INSERT [dbo].[DM_ChucVu] ([MaChucVu], [TenChucVu], [HeSoLuong]) VALUES (N'PGD', N'Phó Giám Đốc', CAST(2.50 AS Decimal(5, 2)))
INSERT [dbo].[DM_ChucVu] ([MaChucVu], [TenChucVu], [HeSoLuong]) VALUES (N'PP', N'Phó Phòng', CAST(2.00 AS Decimal(5, 2)))
INSERT [dbo].[DM_ChucVu] ([MaChucVu], [TenChucVu], [HeSoLuong]) VALUES (N'TP', N'Trưởng Phòng', CAST(2.50 AS Decimal(5, 2)))
GO
INSERT [dbo].[DM_Luong] ([MaNhanVien], [LuongCoBan], [PhuCap], [KhauTruThue]) VALUES (N'TKD01', CAST(25000000.00 AS Decimal(10, 2)), CAST(5000000.00 AS Decimal(10, 2)), CAST(1200000.00 AS Decimal(10, 2)))
INSERT [dbo].[DM_Luong] ([MaNhanVien], [LuongCoBan], [PhuCap], [KhauTruThue]) VALUES (N'TKD02', CAST(12000000.00 AS Decimal(10, 2)), CAST(2500000.00 AS Decimal(10, 2)), CAST(600000.00 AS Decimal(10, 2)))
INSERT [dbo].[DM_Luong] ([MaNhanVien], [LuongCoBan], [PhuCap], [KhauTruThue]) VALUES (N'TKD03', CAST(10000000.00 AS Decimal(10, 2)), CAST(500000.00 AS Decimal(10, 2)), CAST(500000.00 AS Decimal(10, 2)))
INSERT [dbo].[DM_Luong] ([MaNhanVien], [LuongCoBan], [PhuCap], [KhauTruThue]) VALUES (N'TKD04', CAST(16000000.00 AS Decimal(10, 2)), CAST(3500001.00 AS Decimal(10, 2)), CAST(800000.00 AS Decimal(10, 2)))
INSERT [dbo].[DM_Luong] ([MaNhanVien], [LuongCoBan], [PhuCap], [KhauTruThue]) VALUES (N'TKD05', CAST(12000000.00 AS Decimal(10, 2)), CAST(2500000.00 AS Decimal(10, 2)), CAST(600000.00 AS Decimal(10, 2)))
INSERT [dbo].[DM_Luong] ([MaNhanVien], [LuongCoBan], [PhuCap], [KhauTruThue]) VALUES (N'TKD06', CAST(12000000.00 AS Decimal(10, 2)), CAST(2500000.00 AS Decimal(10, 2)), CAST(600000.00 AS Decimal(10, 2)))
INSERT [dbo].[DM_Luong] ([MaNhanVien], [LuongCoBan], [PhuCap], [KhauTruThue]) VALUES (N'TKD07', CAST(30000000.00 AS Decimal(10, 2)), CAST(6000000.00 AS Decimal(10, 2)), CAST(1500000.00 AS Decimal(10, 2)))
INSERT [dbo].[DM_Luong] ([MaNhanVien], [LuongCoBan], [PhuCap], [KhauTruThue]) VALUES (N'TKD08', CAST(18000000.00 AS Decimal(10, 2)), CAST(4000000.00 AS Decimal(10, 2)), CAST(900000.00 AS Decimal(10, 2)))
INSERT [dbo].[DM_Luong] ([MaNhanVien], [LuongCoBan], [PhuCap], [KhauTruThue]) VALUES (N'TKD09', CAST(16000000.00 AS Decimal(10, 2)), CAST(3500000.00 AS Decimal(10, 2)), CAST(800000.00 AS Decimal(10, 2)))
INSERT [dbo].[DM_Luong] ([MaNhanVien], [LuongCoBan], [PhuCap], [KhauTruThue]) VALUES (N'TKD10', CAST(10000000.00 AS Decimal(10, 2)), CAST(2000000.00 AS Decimal(10, 2)), CAST(500000.00 AS Decimal(10, 2)))
INSERT [dbo].[DM_Luong] ([MaNhanVien], [LuongCoBan], [PhuCap], [KhauTruThue]) VALUES (N'TKD11', CAST(12000000.00 AS Decimal(10, 2)), CAST(2500000.00 AS Decimal(10, 2)), CAST(600000.00 AS Decimal(10, 2)))
INSERT [dbo].[DM_Luong] ([MaNhanVien], [LuongCoBan], [PhuCap], [KhauTruThue]) VALUES (N'TKD12', CAST(12000000.00 AS Decimal(10, 2)), CAST(2500000.00 AS Decimal(10, 2)), CAST(600000.00 AS Decimal(10, 2)))
INSERT [dbo].[DM_Luong] ([MaNhanVien], [LuongCoBan], [PhuCap], [KhauTruThue]) VALUES (N'TKD13', CAST(18000000.00 AS Decimal(10, 2)), CAST(4000000.00 AS Decimal(10, 2)), CAST(900000.00 AS Decimal(10, 2)))
INSERT [dbo].[DM_Luong] ([MaNhanVien], [LuongCoBan], [PhuCap], [KhauTruThue]) VALUES (N'TKD14', CAST(16000000.00 AS Decimal(10, 2)), CAST(3500000.00 AS Decimal(10, 2)), CAST(800000.00 AS Decimal(10, 2)))
INSERT [dbo].[DM_Luong] ([MaNhanVien], [LuongCoBan], [PhuCap], [KhauTruThue]) VALUES (N'TKD15', CAST(30000000.00 AS Decimal(10, 2)), CAST(6000000.00 AS Decimal(10, 2)), CAST(1500000.00 AS Decimal(10, 2)))
INSERT [dbo].[DM_Luong] ([MaNhanVien], [LuongCoBan], [PhuCap], [KhauTruThue]) VALUES (N'TKD16', CAST(10000000.00 AS Decimal(10, 2)), CAST(600000.00 AS Decimal(10, 2)), CAST(150000.00 AS Decimal(10, 2)))
INSERT [dbo].[DM_Luong] ([MaNhanVien], [LuongCoBan], [PhuCap], [KhauTruThue]) VALUES (N'TKD17', CAST(12000000.00 AS Decimal(10, 2)), CAST(2500000.00 AS Decimal(10, 2)), CAST(600000.00 AS Decimal(10, 2)))
INSERT [dbo].[DM_Luong] ([MaNhanVien], [LuongCoBan], [PhuCap], [KhauTruThue]) VALUES (N'TKD18', CAST(18000001.00 AS Decimal(10, 2)), CAST(4000000.00 AS Decimal(10, 2)), CAST(900000.00 AS Decimal(10, 2)))
INSERT [dbo].[DM_Luong] ([MaNhanVien], [LuongCoBan], [PhuCap], [KhauTruThue]) VALUES (N'TKD19', CAST(16000000.00 AS Decimal(10, 2)), CAST(3500000.00 AS Decimal(10, 2)), CAST(800000.00 AS Decimal(10, 2)))
INSERT [dbo].[DM_Luong] ([MaNhanVien], [LuongCoBan], [PhuCap], [KhauTruThue]) VALUES (N'TKD20', CAST(12000000.00 AS Decimal(10, 2)), CAST(2500000.00 AS Decimal(10, 2)), CAST(600000.00 AS Decimal(10, 2)))
INSERT [dbo].[DM_Luong] ([MaNhanVien], [LuongCoBan], [PhuCap], [KhauTruThue]) VALUES (N'TKD21', CAST(10000000.00 AS Decimal(10, 2)), CAST(500000.00 AS Decimal(10, 2)), CAST(500000.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD01', N'02/2024', 21, 61092000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD01', N'03/2024', 20, 58488000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD01', N'04/2024', 21, 61092000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD01', N'05/2024', 22, 63696000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD01', N'06/2024', 21, 61092000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD01', N'07/2024', 21, 61092000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD01', N'08/2024', 22, 63696000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD01', N'09/2024', 23, 66300000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD01', N'12/2024', 23, 66300000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD02', N'02/2024', 19, 16900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD02', N'03/2024', 23, 19900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD02', N'04/2024', 19, 16900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD02', N'05/2024', 19, 16900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD02', N'06/2024', 18, 16150000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD02', N'07/2024', 23, 19900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD02', N'08/2024', 23, 19900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD02', N'09/2024', 22, 19150000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD02', N'12/2024', 21, 18400000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD03', N'02/2024', 22, 14375000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD03', N'03/2024', 24, 15000000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD03', N'04/2024', 24, 15000000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD03', N'05/2024', 21, 13750000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD03', N'06/2024', 22, 14375000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD03', N'07/2024', 19, 12500000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD03', N'08/2024', 20, 13125000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD03', N'09/2024', 21, 13750000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD03', N'12/2024', 21, 13750000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD04', N'02/2024', 24, 34700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD04', N'03/2024', 19, 29367000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD04', N'04/2024', 23, 34700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD04', N'05/2024', 23, 34700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD04', N'06/2024', 24, 34700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD04', N'07/2024', 24, 34700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD04', N'08/2024', 23, 34700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD04', N'09/2024', 23, 34700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD04', N'12/2024', 20, 30700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD05', N'02/2024', 20, 17650000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD05', N'03/2024', 21, 18400000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD05', N'04/2024', 20, 17650000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD05', N'05/2024', 18, 16150000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD05', N'06/2024', 20, 17650000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD05', N'07/2024', 22, 19150000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD05', N'08/2024', 24, 19900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD05', N'09/2024', 24, 19900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD05', N'12/2024', 24, 19900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD06', N'02/2024', 23, 19900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD06', N'03/2024', 22, 19150000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD06', N'04/2024', 22, 19150000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD06', N'05/2024', 20, 17650000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD06', N'06/2024', 17, 15400000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD06', N'07/2024', 20, 17650000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD06', N'08/2024', 21, 18400000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD06', N'09/2024', 22, 19150000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD06', N'12/2024', 23, 19900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD07', N'02/2024', 17, 72000000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD07', N'03/2024', 18, 75750000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD07', N'04/2024', 18, 75750000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD07', N'05/2024', 22, 90750000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD07', N'06/2024', 23, 94500000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD07', N'07/2024', 23, 94500000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD07', N'08/2024', 22, 90750000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD07', N'09/2024', 20, 83250000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD07', N'12/2024', 22, 90750000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD08', N'02/2024', 24, 48100000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD08', N'03/2024', 24, 48100000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD08', N'04/2024', 24, 48100000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD08', N'05/2024', 23, 48100000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD08', N'06/2024', 19, 40600000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD08', N'07/2024', 21, 44350000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD08', N'08/2024', 24, 48100000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD08', N'09/2024', 24, 48100000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD08', N'12/2024', 24, 48100000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD09', N'02/2024', 18, 28033000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD09', N'03/2024', 17, 26700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD09', N'04/2024', 21, 32033000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD09', N'05/2024', 17, 26700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD09', N'06/2024', 21, 32033000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD09', N'07/2024', 19, 29367000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD09', N'08/2024', 23, 34700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD09', N'09/2024', 23, 34700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD09', N'12/2024', 21, 32033000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD10', N'02/2024', 21, 15250000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD10', N'03/2024', 22, 15875000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD10', N'04/2024', 17, 12750000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD10', N'05/2024', 24, 16500000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD10', N'06/2024', 22, 15875000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD10', N'07/2024', 24, 16500000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD10', N'08/2024', 21, 15250000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD10', N'09/2024', 21, 15250000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD10', N'12/2024', 23, 16500000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD11', N'02/2024', 22, 19150000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD11', N'03/2024', 23, 19900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD11', N'04/2024', 23, 19900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD11', N'05/2024', 21, 18400000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD11', N'06/2024', 16, 14650000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD11', N'07/2024', 22, 19150000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD11', N'08/2024', 23, 19900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD11', N'09/2024', 23, 19900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD11', N'12/2024', 24, 19900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD12', N'02/2024', 16, 14650000)
GO
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD12', N'03/2024', 21, 18400000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD12', N'04/2024', 19, 16900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD12', N'05/2024', 22, 19150000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD12', N'06/2024', 23, 19900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD12', N'07/2024', 23, 19900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD12', N'08/2024', 24, 19900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD12', N'09/2024', 24, 19900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD12', N'12/2024', 24, 19900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD13', N'02/2024', 23, 48100000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD13', N'03/2024', 24, 48100000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD13', N'04/2024', 24, 48100000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD13', N'05/2024', 19, 40600000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD13', N'06/2024', 20, 42475000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD13', N'07/2024', 20, 42475000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD13', N'08/2024', 22, 46225000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD13', N'09/2024', 22, 46225000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD13', N'12/2024', 23, 48100000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD14', N'02/2024', 20, 30700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD14', N'03/2024', 16, 25367000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD14', N'04/2024', 22, 33367000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD14', N'05/2024', 18, 28033000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD14', N'06/2024', 24, 34700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD14', N'07/2024', 24, 34700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD14', N'08/2024', 23, 34700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD14', N'09/2024', 23, 34700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD14', N'12/2024', 22, 33367000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD15', N'02/2024', 24, 94500000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD15', N'03/2024', 22, 90750000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD15', N'04/2024', 20, 83250000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD15', N'05/2024', 22, 90750000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD15', N'06/2024', 18, 75750000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD15', N'07/2024', 21, 87000000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD15', N'08/2024', 22, 90750000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD15', N'09/2024', 21, 87000000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD15', N'12/2024', 23, 94500000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD16', N'02/2024', 22, 29200000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD16', N'03/2024', 23, 30450000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD16', N'04/2024', 23, 30450000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD16', N'05/2024', 20, 26700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD16', N'06/2024', 22, 29200000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD16', N'07/2024', 22, 29200000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD16', N'08/2024', 24, 30450000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD16', N'09/2024', 24, 30450000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD16', N'12/2024', 24, 30450000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD17', N'02/2024', 19, 16900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD17', N'03/2024', 24, 19900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD17', N'04/2024', 24, 19900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD17', N'05/2024', 23, 19900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD17', N'06/2024', 19, 16900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD17', N'07/2024', 23, 19900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD17', N'08/2024', 21, 18400000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD17', N'09/2024', 22, 19150000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD17', N'12/2024', 21, 18400000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD18', N'02/2024', 21, 44350000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD18', N'03/2024', 19, 40600000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD18', N'04/2024', 18, 38725000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD18', N'05/2024', 16, 34975000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD18', N'06/2024', 21, 44350000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD18', N'07/2024', 19, 40600000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD18', N'08/2024', 23, 48100000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD18', N'09/2024', 23, 48100000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD18', N'12/2024', 23, 48100000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD19', N'02/2024', 17, 26700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD19', N'03/2024', 20, 30700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD19', N'04/2024', 21, 32033000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD19', N'05/2024', 21, 32033000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD19', N'06/2024', 17, 26700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD19', N'07/2024', 22, 33367000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD19', N'08/2024', 24, 34700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD19', N'09/2024', 24, 34700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD19', N'12/2024', 24, 34700000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD20', N'02/2024', 18, 16150000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD20', N'03/2024', 18, 16150000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD20', N'04/2024', 16, 14650000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD20', N'05/2024', 17, 15400000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD20', N'06/2024', 23, 19900000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD20', N'07/2024', 21, 18400000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD20', N'08/2024', 20, 17650000)
INSERT [dbo].[Luong] ([MaNhanVien], [ThangNam], [SoNgayLam], [LuongThucLanh]) VALUES (N'TKD20', N'09/2024', 20, 17650000)
GO
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD01', N'01/2024', 3, N'Nghỉ để học cách nói chuyện với gió')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD01', N'02/2024', 3, N'Nghỉ để học cách nói chuyện với gió')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD01', N'03/2024', 4, N'Nghỉ để học cách nói chuyện với cây cảnh')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD01', N'04/2024', 3, N'Nghỉ để tập luyện “Không cười trong 10 phút”')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD01', N'05/2024', 2, N'Nghỉ để thử nghiệm “Ngày không dùng điện thoại”')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD01', N'06/2024', 3, N'Nghỉ để suy ngẫm về ý nghĩa của việc "làm việc chăm chỉ"')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD01', N'07/2024', 3, N'Nghỉ để đi tìm kho báu bị mất')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD01', N'08/2024', 2, N'Đi câu cá thư giãn')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD01', N'09/2024', 1, N'Đi bắt Pokemon')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD01', N'10/2024', 1, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD01', N'11/2024', 1, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD01', N'12/2024', 1, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD02', N'01/2024', 5, N'Nghỉ phép để tham gia "Hội thi ăn khoai tây không cần chấm muối"')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD02', N'02/2024', 5, N'Nghỉ phép để tham gia "Hội thi ăn khoai tây không cần chấm muối"')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD02', N'03/2024', 1, N'Thử nghiệm làm bữa sáng mà không nhìn công thức')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD02', N'04/2024', 5, N'Nghỉ đi tìm xem con ngõ nào ở thành phố có tiếng chim hót hay nhất')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD02', N'05/2024', 5, N'Nghỉ để viết nhật ký cho tương lai')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD02', N'06/2024', 6, N'Nghỉ luyện thi "Ai có thể ngáp dài hơn"')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD02', N'07/2024', 1, N'Cần thời gian xem hết series mới')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD02', N'08/2024', 1, N'Nghỉ dưỡng sức sau xem phim kinh dị')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD02', N'09/2024', 2, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD02', N'10/2024', 14, N'Nghỉ thai sản')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD02', N'11/2024', 3, N'Nghỉ thai')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD02', N'12/2024', 3, N'Nghỉ thai')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD03', N'01/2024', 2, N'Nghỉ dưỡng để phục hồi tinh thần sau kỳ nghỉ Tết')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD03', N'02/2024', 2, N'Nghỉ dưỡng để phục hồi tinh thần sau kỳ nghỉ Tết')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD03', N'03/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD03', N'04/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD03', N'05/2024', 3, N'Tham gia khóa học “Tìm hiểu cách mèo suy nghĩ”')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD03', N'06/2024', 2, N'Nghỉ tập dượt cho kỳ nghỉ hè sắp tới')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD03', N'07/2024', 5, N'Nghỉ ngơi để luyện giọng opera')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD03', N'08/2024', 4, N'Bị cảm do ngồi điều hòa quá lâu')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD03', N'09/2024', 3, N'Trời mưa không ra ngoài')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD03', N'10/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD03', N'11/2024', 3, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD03', N'12/2024', 3, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD04', N'01/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD04', N'02/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD04', N'03/2024', 5, N'Nghỉ phép để sưu tầm tiếng mưa ở mọi nơi trong nhà')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD04', N'04/2024', 1, N'Tham gia câu lạc bộ “Ngồi thiền với sen đá”')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD04', N'05/2024', 1, N'Nghỉ để học cách đánh thức bản thân đúng giờ')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD04', N'06/2024', 0, N'Đang tích cực làm việc để không cần nghỉ')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD04', N'07/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD04', N'08/2024', 1, N'Tập huấn khóa yoga nâng cao')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD04', N'09/2024', 1, N'Tham gia cuộc thi ăn phở')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD04', N'10/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD04', N'11/2024', 4, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD04', N'12/2024', 4, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD05', N'01/2024', 4, N'Nghỉ để tập "Yoga ngáp" vào mỗi buổi sáng')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD05', N'02/2024', 4, N'Nghỉ để tập "Yoga ngáp" vào mỗi buổi sáng')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD05', N'03/2024', 3, N'Tham gia câu lạc bộ “Nhìn lên trời không mỏi cổ”')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD05', N'04/2024', 4, N'Đi tham quan công viên chỉ để ngắm lá rụng')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD05', N'05/2024', 6, N'Tham gia cuộc thi ngủ trưa dài nhất thế giới')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD05', N'06/2024', 4, N'Tham gia hội thảo “Sống chung với thứ Hai”')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD05', N'07/2024', 2, N'Nghỉ đi thi tài lắp ghép Lego')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD05', N'08/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD05', N'09/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD05', N'10/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD05', N'11/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD05', N'12/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD06', N'01/2024', 1, N'Tham gia khoá học “Làm thế nào để không chờ xe buýt một cách nhàm chán”')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD06', N'02/2024', 1, N'Tham gia khoá học “Làm thế nào để không chờ xe buýt một cách nhàm chán”')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD06', N'03/2024', 2, N'Nghỉ dưỡng sau khi thua trong trận cờ vua với máy tính')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD06', N'04/2024', 2, N'Thử ngủ trưa mà không đặt báo thức')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD06', N'05/2024', 4, N'Nghỉ để đi săn lùng quán cà phê yên tĩnh nhất thành phố')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD06', N'06/2024', 7, N'Nghỉ để xây dựng pháo đài bằng gối tại nhà')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD06', N'07/2024', 4, N'Nằm nhà xem dự báo thời tiết')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD06', N'08/2024', 3, N'Nghỉ dưỡng sau lễ hội âm nhạc')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD06', N'09/2024', 2, N'Dự đám cưới bạn thân')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD06', N'10/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD06', N'11/2024', 1, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD06', N'12/2024', 1, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD07', N'01/2024', 7, N'Thử sức với việc đi bộ vòng quanh công viên mà không nhìn đồng hồ')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD07', N'02/2024', 7, N'Thử sức với việc đi bộ vòng quanh công viên mà không nhìn đồng hồ')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD07', N'03/2024', 6, N'Nghỉ để tập luyện thi đấu "Ai ngáp lâu nhất"')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD07', N'04/2024', 6, N'Nghỉ để tổ chức lễ hội riêng trong vườn nhà')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD07', N'05/2024', 2, N'Thử xem có thể ngủ mà không ngáy')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD07', N'06/2024', 1, N'Nghỉ để xem lại tất cả phim siêu anh hùng')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD07', N'07/2024', 1, N'Đi thi uống trà sữa nhanh nhất')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD07', N'08/2024', 2, N'Đi học kỹ năng sống')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD07', N'09/2024', 4, N'Đau chân vì đá bóng')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD07', N'10/2024', 2, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD07', N'11/2024', 2, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD07', N'12/2024', 2, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD08', N'01/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD08', N'02/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD08', N'03/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD08', N'04/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD08', N'05/2024', 1, N'Nghỉ để khám phá xem cây cảnh có tâm trạng không')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD08', N'06/2024', 5, N'Học cách kiểm soát cơn buồn ngủ trong giờ làm')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD08', N'07/2024', 3, N'Tham gia thi nhảy múa sáng tạo')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD08', N'08/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD08', N'09/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD08', N'10/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD08', N'11/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD08', N'12/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD09', N'01/2024', 6, N'Nghỉ để tìm hiểu tại sao lá cây lại rụng')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD09', N'02/2024', 6, N'Nghỉ để tìm hiểu tại sao lá cây lại rụng')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD09', N'03/2024', 7, N'Nghỉ để học cách ngồi yên như tảng đá')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD09', N'04/2024', 3, N'Tham gia cuộc thi ăn nhanh nhưng ngồi chậm')
GO
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD09', N'05/2024', 7, N'Nghỉ để luyện thi “Giữ yên lặng trong 8 giờ liên tục”')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD09', N'06/2024', 3, N'Đi thực nghiệm liệu mèo hay chó sẽ thắng trong cuộc đua chạy marathon')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD09', N'07/2024', 5, N'Nghỉ sáng tác bản nhạc mới')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD09', N'08/2024', 1, N'Tham gia giải chạy marathon')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD09', N'09/2024', 1, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD09', N'10/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD09', N'11/2024', 3, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD09', N'12/2024', 3, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD10', N'01/2024', 3, N'Nghỉ để nghiên cứu nghệ thuật "Nhìn xa xăm mà không buồn ngủ"')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD10', N'02/2024', 3, N'Nghỉ để nghiên cứu nghệ thuật "Nhìn xa xăm mà không buồn ngủ"')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD10', N'03/2024', 2, N'Đi dạo để tìm hiểu tại sao gió lại thổi')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD10', N'04/2024', 7, N'Nghỉ để học vẽ tranh phong cảnh nhưng chỉ với màu xanh')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD10', N'05/2024', 0, N'Chưa tìm thấy lý do để nghỉ')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD10', N'06/2024', 2, N'Nghỉ phép khám phá ẩm thực đường phố ngay tại phố nhà mình')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD10', N'07/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD10', N'08/2024', 3, N'Nghỉ phép đi chụp ảnh thiên nhiên')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD10', N'09/2024', 3, N'Đi thi đấu game online')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD10', N'10/2024', 1, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD10', N'11/2024', 1, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD10', N'12/2024', 1, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD11', N'01/2024', 2, N'Tham gia cuộc thi "Đếm bước chân khi đi bộ"')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD11', N'02/2024', 2, N'Tham gia cuộc thi "Đếm bước chân khi đi bộ"')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD11', N'03/2024', 1, N'Nghỉ để chờ chim sẻ tới đậu ở ban công')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD11', N'04/2024', 1, N'Nghỉ để xem liệu thời gian có trôi nhanh hơn khi ngắm mây')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD11', N'05/2024', 3, N'Nghỉ để theo dõi cuộc thi côn trùng đua nhanh')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD11', N'06/2024', 8, N'Nghỉ để thử nghiệm "Sống không Internet trong 1 tuần"')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD11', N'07/2024', 2, N'Đi khám phá vườn quốc gia')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD11', N'08/2024', 1, N'Nghỉ đi học nấu ăn')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD11', N'09/2024', 1, N'Tham gia hội chợ ẩm thực')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD11', N'10/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD11', N'11/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD11', N'12/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD12', N'01/2024', 8, N'Nghỉ phép để thiết kế "Bản đồ những đám mây"')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD12', N'02/2024', 8, N'Nghỉ phép để thiết kế "Bản đồ những đám mây"')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD12', N'03/2024', 3, N'Tập gấp origami mà không dùng kéo')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD12', N'04/2024', 5, N'Tham gia khóa học "Cách chờ xe buýt mà không bực bội"')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD12', N'05/2024', 2, N'Tham gia lớp học “Giữ tâm trạng vui vẻ trong giờ làm”')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD12', N'06/2024', 1, N'Nghỉ đi câu cá trong tưởng tượng')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD12', N'07/2024', 1, N'Nghỉ sáng tác thơ lãng mạn')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD12', N'08/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD12', N'09/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD12', N'10/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD12', N'11/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD12', N'12/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD13', N'01/2024', 1, N'Nghỉ để chờ bình minh và ghi lại khoảnh khắc đầu tiên của năm mới')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD13', N'02/2024', 1, N'Nghỉ để chờ bình minh và ghi lại khoảnh khắc đầu tiên của năm mới')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD13', N'03/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD13', N'04/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD13', N'05/2024', 5, N'Nghỉ để viết một cuốn sách hướng dẫn “Cách không làm việc”')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD13', N'06/2024', 4, N'Nghỉ để nghiên cứu cách pha cà phê hoàn hảo nhất')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD13', N'07/2024', 4, N'Dự thi ăn bánh bao không tay')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD13', N'08/2024', 2, N'Khám phá hang động')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD13', N'09/2024', 2, N'Đi leo núi thư giãn')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD13', N'10/2024', 1, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD13', N'11/2024', 1, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD13', N'12/2024', 1, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD14', N'01/2024', 4, N'Nghỉ để kiểm tra tốc độ tan chảy của một viên đá ngoài trời')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD14', N'02/2024', 4, N'Nghỉ để kiểm tra tốc độ tan chảy của một viên đá ngoài trời')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD14', N'03/2024', 8, N'Nghỉ phép để sáng tác bản nhạc “Tiếng thở dài”')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD14', N'04/2024', 2, N'Nghỉ để tìm kiếm cảm hứng sáng tạo trong tiếng mưa rơi')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD14', N'05/2024', 6, N'Nghỉ để làm nhà từ hộp bìa các tông cho mèo')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD14', N'06/2024', 0, N'Đang trong quá trình phục hồi và không cần nghỉ')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD14', N'07/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD14', N'08/2024', 1, N'Nghỉ đi du lịch')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD14', N'09/2024', 1, N'Đi học nhảy múa')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD14', N'10/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD14', N'11/2024', 2, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD14', N'12/2024', 2, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD15', N'01/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD15', N'02/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD15', N'03/2024', 2, N'Nghỉ phép để phân loại các loại lá khô ngoài vườn')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD15', N'04/2024', 4, N'Tập đánh thức đồng hồ báo thức thay vì để nó đánh thức mình')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD15', N'05/2024', 2, N'Tham gia hội thảo “Làm sao để chờ đợi mà không than vãn”')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD15', N'06/2024', 6, N'Nghỉ để thảo luận xem tại sao thứ Hai đến quá nhanh')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD15', N'07/2024', 3, N'Tham gia giải leo núi dã ngoại')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD15', N'08/2024', 2, N'Nghỉ để chăm sóc cây cảnh')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD15', N'09/2024', 3, N'Bận xem World Cup')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD15', N'10/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD15', N'11/2024', 1, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD15', N'12/2024', 1, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD16', N'01/2024', 2, N'Tham gia hội thảo "Sự kiên nhẫn trong việc chờ nước sôi"')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD16', N'02/2024', 2, N'Tham gia hội thảo "Sự kiên nhẫn trong việc chờ nước sôi"')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD16', N'03/2024', 1, N'Thử sức với việc nhắm mắt tưởng tượng mình ở bãi biển')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD16', N'04/2024', 1, N'Tham gia lớp học “Nghệ thuật búng tay”')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD16', N'05/2024', 4, N'Nghỉ để tập viết chữ đẹp cho thời đại công nghệ số')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD16', N'06/2024', 2, N'Tham gia buổi thực hành “Tập làm nông dân” ở vườn nhà')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD16', N'07/2024', 2, N'Nghỉ để học hát rap')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD16', N'08/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD16', N'09/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD16', N'10/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD16', N'11/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD16', N'12/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD17', N'01/2024', 5, N'Tham gia khóa học “Thổi bong bóng mùa đông”')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD17', N'02/2024', 5, N'Tham gia khóa học “Thổi bong bóng mùa đông”')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD17', N'03/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD17', N'04/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD17', N'05/2024', 1, N'Nghỉ để tìm câu trả lời cho câu hỏi “Con gà có trước hay quả trứng có trước”')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD17', N'06/2024', 5, N'Nghỉ để xem có thể ngủ bao lâu mà không thức giấc')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD17', N'07/2024', 1, N'Đi thăm bảo tàng bí ẩn')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD17', N'08/2024', 3, N'Tham gia lớp học làm đồ thủ công')
GO
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD17', N'09/2024', 2, N'Mệt vì chăm mèo con')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD17', N'10/2024', 3, N'Thăm người yêu')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD17', N'11/2024', 3, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD17', N'12/2024', 3, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD18', N'01/2024', 3, N'Nghỉ để sáng tạo "Bức tường trầm tư" tại góc làm việc')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD18', N'02/2024', 3, N'Nghỉ để sáng tạo "Bức tường trầm tư" tại góc làm việc')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD18', N'03/2024', 5, N'Tham gia lớp học “Chụp ảnh phong cảnh trong trí tưởng tượng”')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD18', N'04/2024', 6, N'Nghỉ để phát triển khả năng nhận diện tiếng chuông cửa từ xa')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD18', N'05/2024', 8, N'Nghỉ để thi đua nhịn nói chuyện trong một tuần')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD18', N'06/2024', 3, N'Nghỉ để thử nghiệm "Một ngày không đặt báo thức"')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD18', N'07/2024', 5, N'Nghỉ để quay vlog du lịch')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD18', N'08/2024', 1, N'Nghỉ phép đi học trượt ván')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD18', N'09/2024', 1, N'Nghỉ dưỡng sức đi du lịch')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD18', N'10/2024', 1, N'Đi chùa')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD18', N'11/2024', 1, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD18', N'12/2024', 1, N'Nghỉ phép')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD19', N'01/2024', 7, N'Nghỉ phép để học cách "Thưởng thức sự im lặng"')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD19', N'02/2024', 7, N'Nghỉ phép để học cách "Thưởng thức sự im lặng"')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD19', N'03/2024', 4, N'Khám phá liệu có thể ngủ khi đang ngồi không')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD19', N'04/2024', 3, N'Khám phá bí mật của tiếng cười chim hải âu')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD19', N'05/2024', 3, N'Khám phá liệu chó và mèo có thể làm bạn với nhau')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD19', N'06/2024', 7, N'Tham gia lớp học “Nghệ thuật thổi bong bóng xà phòng siêu to”')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD19', N'07/2024', 2, N'Cần thêm thời gian chăm sóc cá')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD19', N'08/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD19', N'09/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD19', N'10/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD19', N'11/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD19', N'12/2024', 0, N'')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD20', N'01/2024', 6, N'Khám phá xem có bao nhiêu loại cỏ dại trong công viên gần nhà')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD20', N'02/2024', 6, N'Khám phá xem có bao nhiêu loại cỏ dại trong công viên gần nhà')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD20', N'03/2024', 6, N'Nghỉ để tham gia cuộc thi "Tập nhìn vào khoảng không"')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD20', N'04/2024', 8, N'Nghỉ để thi "Ngủ trưa ở tư thế không thoải mái nhất"')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD20', N'05/2024', 7, N'Nghỉ để trải nghiệm cuộc sống không cà phê')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD20', N'06/2024', 1, N'Thực hiện dự án cá nhân "Đếm số lá cây rụng trong một ngày"')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD20', N'07/2024', 3, N'Nghỉ dưỡng sau đêm thi nấu ăn')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD20', N'08/2024', 4, N'Nghỉ khám phá núi lửa')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD20', N'09/2024', 4, N'Nghỉ vì nghiên cứu UFO')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD20', N'10/2024', 1, N'Nghỉ đi chùa cầu duyên')
INSERT [dbo].[NgayNghi] ([MaNhanVien], [ThangNam], [SoNgayNghi], [GhiChu]) VALUES (N'TKD20', N'11/2024', 1, N'Đi thăm vợ bé')
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai], [MaPhongBan], [MaChucVu], [TinhTrangLamViec]) VALUES (N'TKD01', N'Ma Cơ Bớt', CAST(N'1985-07-12' AS Date), N'146 đường 3/2, Ninh Kiều, Cần Thơ', N'0912345678', N'KD', N'PGD', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai], [MaPhongBan], [MaChucVu], [TinhTrangLamViec]) VALUES (N'TKD02', N'Lê Thị Bí', CAST(N'1990-08-25' AS Date), N'51 Hẻm 52, Ninh Kiều, Cần Thơ', N'0923456789', N'NS', N'NV', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai], [MaPhongBan], [MaChucVu], [TinhTrangLamViec]) VALUES (N'TKD03', N'Nguyễn Thị Bưởi', CAST(N'1995-09-20' AS Date), N'51 Hẻm 52, Ninh Kiều, Cần Thơ', N'0922222222', N'NS', N'NV', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai], [MaPhongBan], [MaChucVu], [TinhTrangLamViec]) VALUES (N'TKD04', N'Phạm Thị Dép', CAST(N'1989-11-14' AS Date), N'111 đường 30/4, Cần Thơ', N'0945678901', N'KD', N'PP', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai], [MaPhongBan], [MaChucVu], [TinhTrangLamViec]) VALUES (N'TKD05', N'Vũ Văn Ẻ', CAST(N'1995-05-20' AS Date), N'456  đường Ba Cu, Cần Thơ', N'0956789012', N'BH', N'NV', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai], [MaPhongBan], [MaChucVu], [TinhTrangLamViec]) VALUES (N'TKD06', N'Hoàng Thị Ga', CAST(N'1991-12-12' AS Date), N'23 Hẻm 24, Quận 1, Hồ Chí Minh', N'0967890123', N'SX', N'NV', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai], [MaPhongBan], [MaChucVu], [TinhTrangLamViec]) VALUES (N'TKD07', N'Huỳnh Thị Sếp', CAST(N'1987-04-05' AS Date), N'78 đường Nguyễn Trãi, Quận 5, Hồ Chí Minh', N'0978901234', N'KD', N'GD', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai], [MaPhongBan], [MaChucVu], [TinhTrangLamViec]) VALUES (N'TKD08', N'Trịnh Thị Hạc', CAST(N'1992-03-03' AS Date), N'15 đường Bạch Đằng, Cần Thơ', N'0989012345', N'NC', N'TP', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai], [MaPhongBan], [MaChucVu], [TinhTrangLamViec]) VALUES (N'TKD09', N'Đặng Văn Vịt', CAST(N'1983-06-22' AS Date), N'9 đường Trần Hưng Đạo, Cần Thơ', N'0990123456', N'PT', N'PP', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai], [MaPhongBan], [MaChucVu], [TinhTrangLamViec]) VALUES (N'TKD10', N'Phan Thị Mí', CAST(N'1990-07-07' AS Date), N'45 đường Trần Phú, Cần Thơ', N'0901234567', N'KT', N'NV', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai], [MaPhongBan], [MaChucVu], [TinhTrangLamViec]) VALUES (N'TKD11', N'Hoàng Châu Cạch Cạch', CAST(N'1988-11-11' AS Date), N'67 đường Lý Tự Trọng, Cần Thơ', N'0913456789', N'NS', N'NV', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai], [MaPhongBan], [MaChucVu], [TinhTrangLamViec]) VALUES (N'TKD12', N'Nguyễn Hí Hửng', CAST(N'1993-02-02' AS Date), N'22 đường Phan Châu Trinh, Cần Thơ', N'0924567890', N'IT', N'NV', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai], [MaPhongBan], [MaChucVu], [TinhTrangLamViec]) VALUES (N'TKD13', N'Phạm Văn Héo', CAST(N'1986-09-09' AS Date), N'89 đường Lê Duẩn, Cần Thơ', N'0935678901', N'KD', N'TP', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai], [MaPhongBan], [MaChucVu], [TinhTrangLamViec]) VALUES (N'TKD14', N'Vũ Hán', CAST(N'1994-01-15' AS Date), N'33 đường Hai Bà Trưng, Cần Thơ', N'0946789012', N'BH', N'PP', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai], [MaPhongBan], [MaChucVu], [TinhTrangLamViec]) VALUES (N'TKD15', N'Trần Văn Dê', CAST(N'1991-10-20' AS Date), N'88 đường Cộng Hòa, Hồ Chí Minh', N'0957890123', N'SX', N'GD', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai], [MaPhongBan], [MaChucVu], [TinhTrangLamViec]) VALUES (N'TKD16', N'Lý Sìu', CAST(N'1990-05-15' AS Date), N'12 đường Lý Chính Thắng, Quận 3, Hồ Chí Minh', N'0961234567', N'NC', N'GD', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai], [MaPhongBan], [MaChucVu], [TinhTrangLamViec]) VALUES (N'TKD17', N'Đỗ Văn Vở', CAST(N'1984-03-30' AS Date), N'18 đường Hoàng Sa, Quận 1, Hồ Chí Minh', N'0972345678', N'NC', N'NV', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai], [MaPhongBan], [MaChucVu], [TinhTrangLamViec]) VALUES (N'TKD18', N'Lưu Bá Đạo', CAST(N'1992-11-19' AS Date), N'27 đường Nguyễn Đình Chiểu, Quận 3, Hồ Chí Minh', N'0983456789', N'PT', N'TP', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai], [MaPhongBan], [MaChucVu], [TinhTrangLamViec]) VALUES (N'TKD19', N'Tống Ca', CAST(N'1995-08-08' AS Date), N'31 đường Võ Văn Tần, Quận 10, Hồ Chí Minh', N'0994567890', N'HC', N'PP', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai], [MaPhongBan], [MaChucVu], [TinhTrangLamViec]) VALUES (N'TKD20', N'Hồ Thị Diễm My', CAST(N'1989-12-25' AS Date), N'5 đường Nguyễn Văn Cừ, Quận 5, Hồ Chí Minh', N'0905678901', N'HC', N'NV', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai], [MaPhongBan], [MaChucVu], [TinhTrangLamViec]) VALUES (N'TKD21', N'Nguyễn Thị Bưởi', CAST(N'2003-09-19' AS Date), N'Hẻm 51, Ninh Kiều, Cần Thơ', N'0932877000', N'IT', N'TP', 1)
GO
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [VanPhong]) VALUES (N'BH', N'Phòng Bán Hàng', N'Hồ Chí Minh')
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [VanPhong]) VALUES (N'HC', N'Phòng Hành Chính', N'Cần Thơ')
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [VanPhong]) VALUES (N'IT', N'Phòng IT', N'Cần Thơ')
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [VanPhong]) VALUES (N'KD', N'Phòng Kinh Doanh', N'Hồ Chí Minh')
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [VanPhong]) VALUES (N'KT', N'Phòng Kế Toán', N'Cần Thơ')
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [VanPhong]) VALUES (N'KH', N'Phòng Chăm Sóc Khách Hàng', N'Cần Thơ')
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [VanPhong]) VALUES (N'NC', N'Phòng Nghiên Cứu', N'Hồ Chí Minh')
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [VanPhong]) VALUES (N'NS', N'Phòng Nhân Sự', N'Cần Thơ')
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [VanPhong]) VALUES (N'PT', N'Phòng Phát Triển', N'Hồ Chí Minh')
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [VanPhong]) VALUES (N'SX', N'Phòng Sản Xuất', N'Cần Thơ')
GO
INSERT [dbo].[QT_CongTac] ([MaCT], [MaNhanVien], [BatDau], [KetThuc], [GhiChu]) VALUES (N'BH65', N'TKD05', CAST(N'2013-07-01' AS Date), CAST(N'2018-09-01' AS Date), N'Công tác tại Phòng Bán Hàng')
INSERT [dbo].[QT_CongTac] ([MaCT], [MaNhanVien], [BatDau], [KetThuc], [GhiChu]) VALUES (N'BH65', N'TKD14', CAST(N'2022-12-01' AS Date), CAST(N'2027-02-01' AS Date), N'Công tác tại Phòng Bán Hàng')
INSERT [dbo].[QT_CongTac] ([MaCT], [MaNhanVien], [BatDau], [KetThuc], [GhiChu]) VALUES (N'HC03', N'TKD20', CAST(N'2028-01-01' AS Date), CAST(N'2033-02-01' AS Date), N'Công tác tại Phòng Hành Chính')
INSERT [dbo].[QT_CongTac] ([MaCT], [MaNhanVien], [BatDau], [KetThuc], [GhiChu]) VALUES (N'KDNN', N'TKD04', CAST(N'2012-05-01' AS Date), CAST(N'2017-06-01' AS Date), N'Công tác tại Phòng Kinh Doanh')
INSERT [dbo].[QT_CongTac] ([MaCT], [MaNhanVien], [BatDau], [KetThuc], [GhiChu]) VALUES (N'KT01', N'TKD10', CAST(N'2018-05-01' AS Date), CAST(N'2023-06-01' AS Date), N'Công tác tại Phòng Kế Toán')
INSERT [dbo].[QT_CongTac] ([MaCT], [MaNhanVien], [BatDau], [KetThuc], [GhiChu]) VALUES (N'KH01', N'TKD16', CAST(N'2024-05-01' AS Date), CAST(N'2029-06-01' AS Date), N'Công tác tại Phòng Chăm Sóc Khách Hàng')
INSERT [dbo].[QT_CongTac] ([MaCT], [MaNhanVien], [BatDau], [KetThuc], [GhiChu]) VALUES (N'NC02', N'TKD08', CAST(N'2016-01-01' AS Date), CAST(N'2021-02-01' AS Date), N'Công tác tại Phòng Nghiên Cứu')
INSERT [dbo].[QT_CongTac] ([MaCT], [MaNhanVien], [BatDau], [KetThuc], [GhiChu]) VALUES (N'NS11', N'TKD02', CAST(N'2015-02-01' AS Date), CAST(N'2020-03-01' AS Date), N'Công tác tại Phòng Nhân Sự, thêm 3 giờ làm việc')
INSERT [dbo].[QT_CongTac] ([MaCT], [MaNhanVien], [BatDau], [KetThuc], [GhiChu]) VALUES (N'PT24', N'TKD18', CAST(N'2026-09-01' AS Date), CAST(N'2031-10-01' AS Date), N'Công tác tại Phòng Phát Triển')
GO
INSERT [dbo].[TaiKhoan] ([STT_Tk], [TenTaiKhoan], [MatKhau], [Email], [TinhTrang]) VALUES (1, N'admin', N'240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', N'admin@company.com', 1)
INSERT [dbo].[TaiKhoan] ([STT_Tk], [TenTaiKhoan], [MatKhau], [Email], [TinhTrang]) VALUES (2, N'user', N'e606e38b0d8c19b24cf0ee3808183162ea7cd63ff7912dbb22b5e803286b4446', N'user123@gmail.com', 0)
INSERT [dbo].[TaiKhoan] ([STT_Tk], [TenTaiKhoan], [MatKhau], [Email], [TinhTrang]) VALUES (3, N'user4', N'fd8745886e65fef0b57c6b162f64b04ef5cba6bba1b36160aa3f9b8d16daa037', N'user4123@gmail.com', 0)
INSERT [dbo].[TaiKhoan] ([STT_Tk], [TenTaiKhoan], [MatKhau], [Email], [TinhTrang]) VALUES (4, N'user2', N'b8c871d486f147a9d99be27ab59c64c8781bb53c0472afd9804cbe00e174f648', N'user2123@gmail.com', 0)
INSERT [dbo].[TaiKhoan] ([STT_Tk], [TenTaiKhoan], [MatKhau], [Email], [TinhTrang]) VALUES (5, N'user1', N'58be779b29eb49f5cacaf55f1c77ef9b651c61359c0a9a956c39b33842eb3920', N'user1123@gmail.com', 0)
INSERT [dbo].[TaiKhoan] ([STT_Tk], [TenTaiKhoan], [MatKhau], [Email], [TinhTrang]) VALUES (6, N'user3', N'5ab82e0b9aafe583fa34498def3e876988746fe823c6af038a997bb1053e1eab', N'user3123@gmail.com', 0)
INSERT [dbo].[TaiKhoan] ([STT_Tk], [TenTaiKhoan], [MatKhau], [Email], [TinhTrang]) VALUES (7, N'user5', N'eef820f8dbc3bbbec163ae2f9fa85e70803bbdce6d838e714c626b952724354b', N'user5123@gmail.com', 0)
INSERT [dbo].[TaiKhoan] ([STT_Tk], [TenTaiKhoan], [MatKhau], [Email], [TinhTrang]) VALUES (8, N'user6', N'c9684d997a3012043d434bff8507ab10f911526c3da8e614ca6a82de6bab5e70', N'user6123@gmal.com', 1)
GO
ALTER TABLE [dbo].[DM_Luong]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[Luong]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[NgayNghi]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[DM_ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaPhongBan])
REFERENCES [dbo].[PhongBan] ([MaPhongBan])
GO
ALTER TABLE [dbo].[QT_CongTac]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
/****** Object:  StoredProcedure [dbo].[TrungTaiKhoan]    Script Date: 14/11/2024 8:36:22 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TrungTaiKhoan]
    @TenTaiKhoan NVARCHAR(50) -- Biến đầu vào, tên tài khoản cần kiểm tra
AS
BEGIN
    -- Kiểm tra tài khoản có tồn tại hay không
    IF EXISTS (SELECT 1 FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan)
    BEGIN
        -- Nếu tài khoản tồn tại, trả về 1
        SELECT 1 AS KetQua;
    END
    ELSE
    BEGIN
        -- Nếu tài khoản không tồn tại, trả về 0
        SELECT 0 AS KetQua;
    END
END;
GO
USE [master]
GO
ALTER DATABASE [HRM] SET  READ_WRITE 
GO
