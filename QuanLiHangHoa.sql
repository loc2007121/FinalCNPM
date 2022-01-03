create database QuanLiHangHoa
use QuanLiHangHoa
DROP DATABASE QuanLiHangHoa
drop table DAILY

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DAILY](
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [varchar](50) NOT NULL,
	[TenDAILY] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [nvarchar](12) NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_DAILY] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
INSERT [dbo].[DAILY] ([TenDangNhap], [MatKhau], [TenDAILY], [DiaChi], [DienThoai], [Status]) VALUES (N'dailyThanhHung', N'123456', N'Trần Thanh Hùng', N'20 Nguyễn Công Trứ', N'0633213546',N'Không có đơn hàng')
INSERT [dbo].[DAILY] ([TenDangNhap], [MatKhau], [TenDAILY], [DiaChi], [DienThoai], [Status]) VALUES (N'dailyBilly', N'123456', N'Quán Cafe Billy', N'14 Paster', N'0633567845', N'Không có đơn hàng')
INSERT [dbo].[DAILY] ([TenDangNhap], [MatKhau], [TenDAILY], [DiaChi], [DienThoai], [Status]) VALUES (N'dailyChiHuong', N'123456',  N'Chị Hương', N'40 Trần Phú', N'098734554', N'Không có đơn hàng')
INSERT [dbo].[DAILY] ([TenDangNhap], [MatKhau], [TenDAILY], [DiaChi], [DienThoai], [Status]) VALUES (N'dailyXuanMai', N'123456', N'Tạp hóa Xuân Mai', N'15 Lê Hồng Phong', N'0988567456', N'Không có đơn hàng')
INSERT [dbo].[DAILY] ([TenDangNhap], [MatKhau], [TenDAILY], [DiaChi], [DienThoai], [Status]) VALUES (N'dailyAnhSau', N'123456',  N'Anh Sáu', N'47/1 Bùi Thị Xuân', N'0988546897', N'Không có đơn hàng')
INSERT [dbo].[DAILY] ([TenDangNhap], [MatKhau], [TenDAILY], [DiaChi], [DienThoai], [Status]) VALUES (N'dailyThiHoa', N'123456',  N'Lê Thị Hoa', N'20 Bùi Thị Xuân', N'0987543456', N'Không có đơn hàng')


DROP TABLE LOAIHANG

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIHANG](
	[MaLoai] [nvarchar](5) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAIHANG] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LOAIHANG] ([MaLoai], [TenLoai]) VALUES (N'USA', N'THỰC PHẨM CHỨC NĂNG CỦA MỸ')
INSERT [dbo].[LOAIHANG] ([MaLoai], [TenLoai]) VALUES (N'CHINA', N'THỰC PHẨM CHỨC NĂNG CỦA TRUNG QUỐC')
INSERT [dbo].[LOAIHANG] ([MaLoai], [TenLoai]) VALUES (N'JPA', N'THỰC PHẨM CHỨC NĂNG CỦA NHẬT')
INSERT [dbo].[LOAIHANG] ([MaLoai], [TenLoai]) VALUES (N'RUS', N'THỰC PHẨM CHỨC NĂNG CỦA NGA')
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAPKHO](
	[SoPhieuN] [nvarchar](10) NOT NULL,
	[NgayNhap] [datetime] NULL,
	[NguoiNhap] [nvarchar](50) NULL,
	[LyDoNhap] [nvarchar](200) NULL,
 CONSTRAINT [PK_NHAPKHO] PRIMARY KEY CLUSTERED 
(
	[SoPhieuN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NHAPKHO] ([SoPhieuN], [NgayNhap], [NguoiNhap], [LyDoNhap]) VALUES (N'NK01', CAST(0x0000A95700000000 AS DateTime), N'Nam', N'nhập hàng từ USA')
INSERT [dbo].[NHAPKHO] ([SoPhieuN], [NgayNhap], [NguoiNhap], [LyDoNhap]) VALUES (N'NK02', CAST(0x0000A95800000000 AS DateTime), N'Duy', N'nhập hàng từ TP HCM')
INSERT [dbo].[NHAPKHO] ([SoPhieuN], [NgayNhap], [NguoiNhap], [LyDoNhap]) VALUES (N'NK03', CAST(0x0000A98300E4E733 AS DateTime), N'Trí', N'nhập hàng từ Nhật bản')

SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHAPKHOUpdate]
	@SoPhieuN NVarChar(10), 
	@NgayNhap DateTime, 
	@NguoiNhap NVarChar(50), 
	@LyDoNhap NVarChar(200) 
AS

UPDATE [NHAPKHO] SET
	[NgayNhap] = @NgayNhap,
	[NguoiNhap] = @NguoiNhap,
	[LyDoNhap] = @LyDoNhap
WHERE
	[SoPhieuN] = @SoPhieuN
GO
/****** Object:  StoredProcedure [dbo].[NHAPKHOList]    Script Date: 12/08/2019 14:36:42 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHAPKHOList]
	
AS

SELECT
	[SoPhieuN] ,
	[NgayNhap] ,
	[NguoiNhap] ,
	[LyDoNhap] 
FROM [NHAPKHO]
GO
/****** Object:  StoredProcedure [dbo].[NHAPKHOGet]    Script Date: 12/08/2019 14:36:42 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[NHAPKHOGet]
	@SoPhieuN NVarChar(10)
	
AS

SELECT
	[SoPhieuN] ,
	[NgayNhap] ,
	[NguoiNhap] ,
	[LyDoNhap] 
FROM [NHAPKHO]
WHERE
	([SoPhieuN] = @SoPhieuN OR @SoPhieuN IS NULL)
GO
/****** Object:  StoredProcedure [dbo].[NHAPKHODelete]    Script Date: 12/08/2019 14:36:42 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHAPKHODelete]
	@SoPhieuN NVarChar(10)
AS

DELETE FROM [NHAPKHO]
WHERE
	[SoPhieuN] = @SoPhieuN
GO
/****** Object:  StoredProcedure [dbo].[NHAPKHOAdd]    Script Date: 12/08/2019 14:36:42 ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHAPKHOAdd]
	@SoPhieuN NVarChar(10),
	@NgayNhap DateTime,
	@NguoiNhap NVarChar(50),
	@LyDoNhap NVarChar(200)
AS

-- THIS STORED PROCEDURE NEEDS TO BE MANUALLY COMPLETED
-- MULITPLE PRIMARY KEY MEMBERS OR NON-GUID/INT PRIMARY KEY

INSERT INTO [NHAPKHO] (
	[SoPhieuN],
	[NgayNhap],
	[NguoiNhap],
	[LyDoNhap]
) VALUES (
	@SoPhieuN,
	@NgayNhap,
	@NguoiNhap,
	@LyDoNhap
)
               
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KETOAN](
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[Quyen] [int] NULL,
 CONSTRAINT [PK_KETOAN] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[KETOAN] ([TenDangNhap], [MatKhau], [Quyen]) VALUES (N'admin', N'123456', 2)
INSERT [dbo].[KETOAN] ([TenDangNhap], [MatKhau], [Quyen]) VALUES (N'tuan', N'123', 1)
INSERT [dbo].[KETOAN] ([TenDangNhap], [MatKhau], [Quyen]) VALUES (N'tri', N'123', 1)

DROP TABLE [dbo].[XUATKHO]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XUATKHO](
	[SoPhieuX] [nvarchar](10) NOT NULL,
	[NgayXuat] [datetime] NULL,
	[TenTKDaiLy] [nvarchar](50) NOT NULL,
	[LyDoXuat] [nvarchar](200) NULL,
 CONSTRAINT [PK_XUATKHO] PRIMARY KEY CLUSTERED 
(
	[SoPhieuX] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[XUATKHO] ([SoPhieuX], [NgayXuat], [TenTKDaiLy], [LyDoXuat]) VALUES (N'XK01', CAST(0x0000A97700000000 AS DateTime), N'dailyThanhHung', N'bán sĩ')
INSERT [dbo].[XUATKHO] ([SoPhieuX], [NgayXuat], [TenTKDaiLy], [LyDoXuat]) VALUES (N'XK02', CAST(0x0000A97800000000 AS DateTime), N'dailyBilly', N'bán lẻ')
INSERT [dbo].[XUATKHO] ([SoPhieuX], [NgayXuat], [TenTKDaiLy], [LyDoXuat]) VALUES (N'XK03', CAST(0x0000A99700000000 AS DateTime), N'dailyThiHoa', N'bán sĩ')
INSERT [dbo].[XUATKHO] ([SoPhieuX], [NgayXuat], [TenTKDaiLy], [LyDoXuat]) VALUES (N'XK04', CAST(0x0000A99E00000000 AS DateTime), N'dailyAnhSau', N'bán khách quen')

SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DAILYUpdate]
	@TenDangNhap NVarChar(10), 
	@TenKH NVarChar(50), 
	@DiaChi NVarChar(100), 
	@DienThoai NVarChar(12) 
AS

UPDATE [DAILY] SET
	[TenDAILY] = @TenKH,
	[DiaChi] = @DiaChi,
	[DienThoai] = @DienThoai
WHERE
	[TenDangNhap] = @TenDangNhap
GO

SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHACHHANGList]
	
AS

SELECT
	[TenDangNhap] ,
	[TenDAILY] ,
	[DiaChi] ,
	[DienThoai] 
FROM [DAILY]
GO

SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DaiLyGet]
	@TenDangNhap NVarChar(10)
	
AS

SELECT
	[TenDangNhap] ,
	[TenDAILY] ,
	[DiaChi] ,
	[DienThoai] 
FROM [DAILY]
WHERE
	([TenDangNhap] = @TenDangNhap OR @TenDangNhap IS NULL)
GO

SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHACHHANGDelete]
	@TenDangNhap NVarChar(10)
AS

DELETE FROM [DAILY]
WHERE
	[TenDangNhap] = @TenDangNhap
GO

SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KHACHHANGAdd]
	@TenDangNhap NVarChar(10),
	@TenDaiLy NVarChar(50),
	@DiaChi NVarChar(100),
	@DienThoai NVarChar(12)
AS

INSERT INTO [DAILY] (
	[TenDangNhap],
	[TenDAILY],
	[DiaChi],
	[DienThoai]
) VALUES (
	@TenDangNhap,
	@TenDaiLy,
	@DiaChi,
	@DienThoai
)
GO
DROP TABLE HANGHOA
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[MaHang] [nvarchar](10) NOT NULL,
	[TenHang] [nvarchar](50) NULL,
	[NhaCC] [nvarchar](50) NULL,
	[DVT] [nvarchar](20) NULL,
	[MaLoai] [nvarchar](5) NULL,
	[HinhAnh] [nvarchar](100) NULL,
 CONSTRAINT [PK_HANGHOA] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [NhaCC], [DVT], [MaLoai], [HinhAnh]) VALUES (N'USA01', N'Creatin', N'ABC', N'1 hộp /120 viên', N'USA', N'HinhAnh/biaSaiGon.jpg')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [NhaCC], [DVT], [MaLoai], [HinhAnh]) VALUES (N'USA02', N'Whey Protein', N'ABC', N'1 hộp / 1000g', N'USA', N'HinhAnh/banhCOSY.jpg')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [NhaCC], [DVT], [MaLoai], [HinhAnh]) VALUES (N'USA03', N'Glucosamin', N'ABC', N'1 hộp / 180 viên', N'USA', N'HinhAnh/bia333.jpg')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [NhaCC], [DVT], [MaLoai], [HinhAnh]) VALUES (N'JPA01', N'Creatin', N'ABC', N'1 hộp /120 viên', N'JPA', N'HinhAnh/biaheiniken.jpg')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [NhaCC], [DVT], [MaLoai], [HinhAnh]) VALUES (N'JPA02', N'Whey Protein', N'ABC', N'1 hộp / 1000g', N'JPA', NULL)
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [NhaCC], [DVT], [MaLoai], [HinhAnh]) VALUES (N'JPA03', N'Glucosamin', N'ABC', N'1 hộp / 180 viên', N'JPA', NULL)
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [NhaCC], [DVT], [MaLoai], [HinhAnh]) VALUES (N'RUS01', N'Creatin', N'ABC', N'1 hộp /120 viên', N'RUS', NULL)
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [NhaCC], [DVT], [MaLoai], [HinhAnh]) VALUES (N'RUS02', N'Whey Protein', N'ABC', N'1 hộp / 1000g', N'RUS', NULL)
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [NhaCC], [DVT], [MaLoai], [HinhAnh]) VALUES (N'RUS03', N'Glucosamin', N'ABC', N'1 hộp / 180 viên', N'RUS', NULL)

SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HANGHOAUpdate]
	@MaHang nvarchar(10), 
	@TenHang nvarchar(50), 
	@NhaCC nvarchar(50), 
	@DVT nvarchar(10), 
	@MaLoai nvarchar(5) 
AS

UPDATE HANGHOA SET
	[TenHang] = @TenHang,
	[NhaCC] = @NhaCC,
	[DVT] = @DVT,
	[MaLoai] = @MaLoai
WHERE
	[MaHang] = @MaHang
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XUATKHO_CT](
	[SoPhieuX] [nvarchar](10) NOT NULL,
	[STT] [int] NOT NULL,
	[MaHang] [nvarchar](10) NULL,
	[TKNguoiXuat] [nvarchar](50) NOT NULL,
	[SLXuat] [float] NULL,
	[DGXuat] [money] NULL,
 CONSTRAINT [PK_XUATKHO_CT] PRIMARY KEY CLUSTERED 
(
	[SoPhieuX] ASC,
	[STT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [TKNguoiXuat], [SLXuat], [DGXuat]) VALUES (N'XK01', 1, N'USA01', N'tuan', 2, 10000.0000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [TKNguoiXuat], [SLXuat], [DGXuat]) VALUES (N'XK01', 2, N'RUS02', N'tri', 1,  8000.0000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [TKNguoiXuat], [SLXuat], [DGXuat]) VALUES (N'XK01', 3, N'USA02', N'tuan', 5, 10000.0000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [TKNguoiXuat], [SLXuat], [DGXuat]) VALUES (N'XK02', 1, N'USA03', N'tuan', 10, 9000.0000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [TKNguoiXuat], [SLXuat], [DGXuat]) VALUES (N'XK02', 2, N'JPA01', N'tri', 15, 15000.0000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [TKNguoiXuat], [SLXuat], [DGXuat]) VALUES (N'XK02', 3, N'RUS03', N'tuan', 10, 7000.0000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [TKNguoiXuat], [SLXuat], [DGXuat]) VALUES (N'XK03', 1, N'JPA02', N'tri', 2, 2000.0000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [TKNguoiXuat], [SLXuat], [DGXuat]) VALUES (N'XK04', 1, N'JPA03', N'tri', 2, 20000.0000)
INSERT [dbo].[XUATKHO_CT] ([SoPhieuX], [STT], [MaHang], [TKNguoiXuat], [SLXuat], [DGXuat]) VALUES (N'XK04', 2, N'RUS01', N'tri', 3, 100000.0000)
--StoredProcedure [dbo].[HANGHOAList]  
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HANGHOAList]
AS

SELECT
	[MaHang],
	[TenHang],
	[NhaCC],
	[DVT],
	[MaLoai]
FROM HANGHOA
GO

SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HANGHOAGetByLOAIHANG]
	@MaLoai nvarchar(5)
AS

SELECT
	[MaHang],
	[TenHang],
	[NhaCC],
	[DVT],
	[MaLoai]
FROM HANGHOA
WHERE
	[MaLoai]=@MaLoai
GO

SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[HANGHOAGet]
	@MaHang nvarchar(10)
	
AS

SELECT
	[MaHang],
	[TenHang],
	[NhaCC],
	[DVT],
	[MaLoai]
FROM HANGHOA
WHERE
	[MaHang] = @MaHang
GO

SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HANGHOADelete]
	@MaHang nvarchar(10)
AS

DELETE FROM HANGHOA
WHERE
	[MaHang] = @MaHang
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Procedure HANGHOADelete
create procedure [dbo].[HANGHOADel] (@MaHang nvarchar(10))
as 
	delete from HANGHOA where MaHang=@MaHang
GO
--Procedure HANGHOAAdd
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HANGHOAAdd]
	@MaHang nvarchar(10),
	@TenHang nvarchar(50),
	@NhaCC nvarchar(50),
	@DVT nvarchar(10),
	@MaLoai nvarchar(5)
AS


INSERT INTO HANGHOA (
	[MaHang],
	[TenHang],
	[NhaCC],
	[DVT],
	[MaLoai]
) VALUES (
	@MaHang,
	@TenHang,
	@NhaCC,
	@DVT,
	@MaLoai
)

select SCOPE_IDENTITY()
GO
--Table [dbo].[NHAPKHO_CT]

DROP TABLE NHAPKHO_CT
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAPKHO_CT](
	[SoPhieuN] [nvarchar](10) NOT NULL,
	[STT] [int] NOT NULL,
	[MaHang] [nvarchar](10) NULL,
	[TKNguoiNhap] [nvarchar](50) NULL,
	[SLNhap] [float] NULL,
	[DGNhap] [money] NULL,
 CONSTRAINT [PK_NHAPKHO_CT] PRIMARY KEY CLUSTERED 
(
	[SoPhieuN] ASC,
	[STT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [TKNguoiNhap], [SLNhap], [DGNhap]) VALUES (N'NK01', 1, N'USA01', N'tuan', 50, 8000.0000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [TKNguoiNhap], [SLNhap], [DGNhap]) VALUES (N'NK01', 2,  N'JPA01', N'tuan', 100, 14000.0000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [TKNguoiNhap], [SLNhap], [DGNhap]) VALUES (N'NK01', 3, N'JPA01', N'tuan', 20, 32000.0000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [TKNguoiNhap], [SLNhap], [DGNhap]) VALUES (N'NK01', 4,  N'USA02', N'tuan', 10, 12000.0000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [TKNguoiNhap], [SLNhap], [DGNhap]) VALUES (N'NK01', 5,  N'USA03', N'tuan', 30, 11000.0000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [TKNguoiNhap], [SLNhap], [DGNhap]) VALUES (N'NK02', 1, N'RUS01', N'tuan', 40, 14500.0000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [TKNguoiNhap], [SLNhap], [DGNhap]) VALUES (N'NK02', 2,  N'RUS02', N'tuan', 50, 35000.0000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [TKNguoiNhap], [SLNhap], [DGNhap]) VALUES (N'NK02', 3,  N'USA03', N'tuan', 200, 30000.0000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [TKNguoiNhap], [SLNhap], [DGNhap]) VALUES (N'NK02', 4,  N'USA02', N'tuan', 30, 6000.0000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [TKNguoiNhap], [SLNhap], [DGNhap]) VALUES (N'NK02', 5, N'USA01', N'tuan', 50, 6000.0000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [TKNguoiNhap], [SLNhap], [DGNhap]) VALUES (N'NK03', 1,  N'RUS03', N'tuan', 2, 50000.0000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [TKNguoiNhap], [SLNhap], [DGNhap]) VALUES (N'NK03', 2,  N'JPA01', N'tuan', 2, 13000.0000)
INSERT [dbo].[NHAPKHO_CT] ([SoPhieuN], [STT], [MaHang], [TKNguoiNhap], [SLNhap], [DGNhap]) VALUES (N'NK03', 3,  N'USA01', N'tuan', 6, 15000.0000)
--StoredProcedure [NHAPKHO_CTUpdate]
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHAPKHO_CTUpdate]
	@SoPhieuN NVarChar(10), 
	@STT Int, 
	@MaHang NVarChar(10), 
	@SLNhap Float, 
	@DGNhap Money 
AS

UPDATE [NHAPKHO_CT] SET
	[MaHang] = @MaHang,
	[SLNhap] = @SLNhap,
	[DGNhap] = @DGNhap
WHERE
	[SoPhieuN] = @SoPhieuN
	AND [STT] = @STT
GO
--StoredProcedure [dbo].[NHAPKHO_CTList] 
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHAPKHO_CTList]
	
AS

SELECT
	[SoPhieuN] ,
	[STT] ,
	[MaHang] ,
	[SLNhap] ,
	[DGNhap] 
FROM [NHAPKHO_CT]
GO
--StoredProcedure [dbo].[NHAPKHO_CTGetByNHAPKHO]  
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHAPKHO_CTGetByNHAPKHO]
	@SoPhieuN NVarChar(10)
	
    
AS

SELECT
	[SoPhieuN] ,
	[STT] ,
	[MaHang] ,
	[SLNhap] ,
	[DGNhap],
	SLNhap*DGNhap as TTNhap 
FROM [NHAPKHO_CT]
WHERE  SoPhieuN=@SoPhieuN
GO
-- StoredProcedure [dbo].[NHAPKHO_CTGetByHANGHOA]   
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHAPKHO_CTGetByHANGHOA]
	@MaHang NVarChar(10)
	
    
AS

SELECT
	[SoPhieuN] ,
	[STT] ,
	[MaHang] ,
	[SLNhap] ,
	[DGNhap] 
FROM [NHAPKHO_CT]
WHERE  MaHang=@MaHang
GO
--StoredProcedure [dbo].[NHAPKHO_CTGet] 
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[NHAPKHO_CTGet]
	@SoPhieuN NVarChar(10),
	@STT Int
	
AS

SELECT
	[SoPhieuN] ,
	[STT] ,
	[MaHang] ,
	[SLNhap] ,
	[DGNhap] 
FROM [NHAPKHO_CT]
WHERE
	([SoPhieuN] = @SoPhieuN OR @SoPhieuN IS NULL)
	AND ([STT] = @STT OR @STT IS NULL)
GO
-- StoredProcedure [dbo].[NHAPKHO_CTDelete] 
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHAPKHO_CTDelete]
	@SoPhieuN NVarChar(10),
	@STT Int
AS

DELETE FROM [NHAPKHO_CT]
WHERE
	[SoPhieuN] = @SoPhieuN
	AND [STT] = @STT
GO
-- StoredProcedure [dbo].[NHAPKHO_CTAdd]  
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NHAPKHO_CTAdd]
	@SoPhieuN NVarChar(10),
	@STT Int,
	@MaHang NVarChar(10),
	@SLNhap Float,
	@DGNhap Money
AS

INSERT INTO [NHAPKHO_CT] (
	[SoPhieuN],
	[STT],
	[MaHang],
	[SLNhap],
	[DGNhap]
) VALUES (
	@SoPhieuN,
	@STT,
	@MaHang,
	@SLNhap,
	@DGNhap
)
GO
--  StoredProcedure [dbo].[HANGHOAList2]  
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[HANGHOAList2]
AS

SELECT Distinct
	HANGHOA.[MaHang],
	[TenHang],
	[NhaCC],
	[DVT],
	DGNhap+200 as DGBan
FROM HANGHOA Inner Join NHAPKHO_CT 
On HANGHOA.MaHang=NHAPKHO_CT.MaHang
GO
-- ForeignKey [FK_HANGHOA_LOAIHANG]  
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD  CONSTRAINT [FK_HANGHOA_LOAIHANG] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LOAIHANG] ([MaLoai])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HANGHOA] CHECK CONSTRAINT [FK_HANGHOA_LOAIHANG]
GO
--  ForeignKey [FK_NHAPKHO_CT_HANGHOA]   
ALTER TABLE [dbo].[NHAPKHO_CT]  WITH CHECK ADD  CONSTRAINT [FK_NHAPKHO_CT_HANGHOA] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HANGHOA] ([MaHang])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NHAPKHO_CT] CHECK CONSTRAINT [FK_NHAPKHO_CT_HANGHOA]
GO
--  ForeignKey [FK_NHAPKHO_CT_NHAPKHO] 
ALTER TABLE [dbo].[NHAPKHO_CT]  WITH CHECK ADD  CONSTRAINT [FK_NHAPKHO_CT_NHAPKHO] FOREIGN KEY([SoPhieuN])
REFERENCES [dbo].[NHAPKHO] ([SoPhieuN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NHAPKHO_CT] CHECK CONSTRAINT [FK_NHAPKHO_CT_NHAPKHO]
GO
--  ForeignKey [FK_XUATKHO_KHACHHANG]   
ALTER TABLE [dbo].[XUATKHO]  WITH CHECK ADD  CONSTRAINT [FK_XUATKHO_DAILY] FOREIGN KEY([TenTKDaiLy])
REFERENCES [dbo].[DAILY] ([TenDangNhap])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[XUATKHO] CHECK CONSTRAINT [FK_XUATKHO_DAILY]
GO

--  ForeignKey [FK_XUATKHO_CT_HANGHOA]   
ALTER TABLE [dbo].[XUATKHO_CT]  WITH CHECK ADD  CONSTRAINT [FK_XUATKHO_CT_HANGHOA] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HANGHOA] ([MaHang])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[XUATKHO_CT] CHECK CONSTRAINT [FK_XUATKHO_CT_HANGHOA]
GO
--  ForeignKey [FK_XUATKHO_CT_XUATKHO]   
ALTER TABLE [dbo].[XUATKHO_CT]  WITH CHECK ADD  CONSTRAINT [FK_XUATKHO_CT_XUATKHO] FOREIGN KEY([SoPhieuX])
REFERENCES [dbo].[XUATKHO] ([SoPhieuX])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[XUATKHO_CT] CHECK CONSTRAINT [FK_XUATKHO_CT_XUATKHO]
GO

ALTER TABLE [dbo].[XUATKHO_CT]  WITH CHECK ADD  CONSTRAINT [FK_XUATKHO_CT_KETOAN] FOREIGN KEY([TKNguoiXuat])
REFERENCES [dbo].[KETOAN] ([TenDangNhap])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[XUATKHO_CT] CHECK CONSTRAINT [FK_XUATKHO_CT_XUATKHO]
GO

ALTER TABLE [dbo].[NHAPKHO_CT]  WITH CHECK ADD  CONSTRAINT [FK_NHAPKHO_CT_KETOAN] FOREIGN KEY([TKNguoiNhap])
REFERENCES [dbo].[KETOAN] ([TenDangNhap])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NHAPKHO_CT] CHECK CONSTRAINT [FK_NHAPKHO_CT_KETOAN]
GO