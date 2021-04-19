CREATE DATABASE HeThong_QLDV_GiaoHangNhanh
GO

USE HeThong_QLDV_GiaoHangNhanh
GO

-- Hello world

CREATE TABLE TAIKHOAN
(
	TenDangNhap NVARCHAR(30) PRIMARY KEY NOT NULL, --Mã hoặc tên nhân viên
	TenHienThi NVARCHAR(30),
	MatKhau VARCHAR(15) NOT NULL, --Phức tạp: chữ thường, hoa và số
	QuyenTruyCap NVARCHAR(25) NOT NULL -- Quản trị viên, nhân viên
)
GO

CREATE TABLE NV_GIAOHANG
(
	MaSoNV VARCHAR(10) PRIMARY KEY NOT NULL, -- GHN + Random 7 số		VD: GHN2048536
	HoTenNV NVARCHAR(30) NOT NULL,
	GioiTinhNV NVARCHAR(4) NOT NULL, -- Nam, nữ hoặc khác
	SdtNV VARCHAR(10) NOT NULL, -- 10 số
	DiaChiNV NVARCHAR(70) NOT NULL,
	NgaySinhNV DATE NOT NULL, -- >= 18 tuổi
	LuongNV FLOAT NOT NULL DEFAULT 0, -- Số đơn hàng giao thành công * 5000đ
	GhiChuNV NVARCHAR(100)
)
GO

CREATE TABLE KHACHHANGGUI
(
	MaSoKHG VARCHAR(10) PRIMARY KEY NOT NULL, -- KHG + Random 7 số		VD: KHG0127856
	HoTenKHG NVARCHAR(30) NOT NULL,
	SdtKHG VARCHAR(10) NOT NULL, -- 10 số
	DiaChiKHG NVARCHAR(70) NOT NULL,
)
GO

CREATE TABLE KHACHHANGNHAN
(
	MaSoKHN VARCHAR(10) PRIMARY KEY NOT NULL, -- KHN + Random 7 số		VD: KHG9870123
	HoTenKHN NVARCHAR(30) NOT NULL,
	SdtKHN VARCHAR(10) NOT NULL, -- 10 số
	DiaChiKHN NVARCHAR(70) NOT NULL,
)
GO

CREATE TABLE DONHANG
(
	MaVanDon VARCHAR(12) PRIMARY KEY NOT NULL, -- Random: 2 chữ cái ở đầu, 10 số ở cuối
	TongDonHang FLOAT NOT NULL DEFAULT 0, -- Đơn vị tính VND
	PhiVanChuyen FLOAT NOT NULL DEFAULT 30000, -- Đơn vị tính VND
	NgayNhapKho DATE NOT NULL, -- Ngày khách hàng đến gửi chi nhánh
	NgayGui DATE, -- Ngày nhân viên giao hàng gửi cho khách hàng nhận
	GiaoThanhCong BIT, -- 1. Thành công, 0. Chưa giao
	HoanTra BIT, -- 1. Hoàn trả, 0. Chưa giao
	NguyenNhanHoanTra NVARCHAR(100), --Chỉ khác null khi bị hoàn trả
	MaSoNV VARCHAR(10) NOT NULL,
	MaSoKHG VARCHAR(10) NOT NULL,
	MaSoKHN VARCHAR(10) NOT NULL

	FOREIGN KEY (MaSoNV) REFERENCES NV_GIAOHANG(MaSoNV),
	FOREIGN KEY (MaSoKHG) REFERENCES KHACHHANGGUI(MaSoKHG),
	FOREIGN KEY (MaSoKHN) REFERENCES KHACHHANGNHAN(MaSoKHN)
)
GO

CREATE TABLE THONGTINSANPHAMDH
(
	MaSP NVARCHAR(8) PRIMARY KEY NOT NULL, -- SP + Random 6 số		VD: SP078946
	TenSP NVARCHAR(40) NOT NULL, 
	GiaSP FLOAT DEFAULT 0 NOT NULL, -- Đơn vị tính VND
	SoLuongSP INT DEFAULT 0 NOT NULL,
	ThanhTienSP FLOAT DEFAULT 0 NOT NULL, -- Thành tiền = Giá sản phẩm * Số lượng
	MaVanDon VARCHAR(12) NOT NULL

	FOREIGN KEY (MaVanDon) REFERENCES DONHANG(MaVanDon)
)
GO

INSERT INTO NV_GIAOHANG VALUES ('079097165226', N'Nguyễn Thanh Sơn', N'Nam', '0329138141', N'Hòa Hảo, Phường 5, Quận 10, TP.Hồ Chí Minh', '1997/12/06', 0, null)
INSERT INTO NV_GIAOHANG VALUES ('074099247261', N'Nguyễn Tấn Tài', N'Nam', '0335422423', N'Trần Văn Ơn,Phường Phú Hòa,TP.Thủ Dầu Một, Bình Dương', '1999-12-01', 0, null)
INSERT INTO NV_GIAOHANG VALUES ('092098907783', N'Tạ Thành Giác', N'Nam', '0938505623', N'Trần Hưng Đạo, Phường Lê Bình, Quận Cái Răng, TP.Cần Thơ', '1998-01-17', 0, null)
INSERT INTO NV_GIAOHANG VALUES ('075195016660', N'Trần Hoàng Anh', N'Nữ', '0986954591', N'Xã Tây Hòa, Huyện Trảng Bom, Đồng Nai', '1995-11-05', 0, N'Nghỉ việc')
INSERT INTO NV_GIAOHANG VALUES ('079300903397', N'Nguyễn Vân Anh', N'Nữ', '0918226870', N'Bửu Đình, Phường 5,Quận 6, TP.Hồ Chí Minh', '2000-12-07', 0, null)
GO

INSERT INTO KHACHHANGGUI VALUES ('079195074935', N'Trần Thị Thanh Huyền', '0983552627', N'31 Trần Phú, Phường 4, Quận 5, TP. Hồ Chí Minh')
INSERT INTO KHACHHANGGUI VALUES ('079098231665', N'Lâm Văn Khang', '0386211769', N'số 7, Phường Tân Thuận Đông, Quận 7, TP.Hồ Chí Minh')
INSERT INTO KHACHHANGGUI VALUES ('079200681953', N'Nguyễn Văn A', '0322649284', N'389 Hai Bà Trưng, Quận 3, TP.Hồ Chí Minh')
INSERT INTO KHACHHANGGUI VALUES ('075094200603', N'Nguyễn Phúc Tuấn', '0399666855', N'Phường Quyết Thắng, Thành phố Biên Hòa, Đồng Nai')
INSERT INTO KHACHHANGGUI VALUES ('079089789364', N'Tần Trí Thương', '0322245083', N'105, Phường 7, Quận 3, TP.Hồ Chí Minh')
GO

INSERT INTO KHACHHANGNHAN VALUES ('031096675574', N'Nguyễn Phùng Minh', '0860740042', N'2/55 Đường Ngô Quyền, Quận Ngô Quyền, TP. Hải Phòng')
INSERT INTO KHACHHANGNHAN VALUES ('001099789854', N'Đỗ Tiến Khoa', '0374177579', N'26 Quang Trung, Quận Hà Đông, Hà Nội')
INSERT INTO KHACHHANGNHAN VALUES ('001201185001', N'Bùi Đức Anh', '0936019846', N'42, Hàng Than, Phường Nguyễn Trung Trực, Quận Ba Đình, Hà Nội')
INSERT INTO KHACHHANGNHAN VALUES ('079300550737', N'Nguyễn Huỳnh Anh Thư', '0978831357', N'27, Nguyễn Bỉnh Khiêm, Phường Đa Kao, Quận 1, Hồ Chí Minh')
INSERT INTO KHACHHANGNHAN VALUES ('079199321088', N'Lê Thị Phương Anh', '0335480188', N'Phường 9, Quận Gò Vấp, TP.Hồ Chí Minh')
GO

INSERT INTO DONHANG VALUES ('Ag5539210712', 534000, 25000, '2020-05-02', '2020-05-06', 1, 0, N'', '079097165226', '079195074935', '031096675574')
INSERT INTO DONHANG VALUES ('BL9787366421', 320000, 30000, '2020-12-07', '2020-12-08', 0, 1, N'Sản phẩm bị lỗi', '074099247261', '079098231665', '001099789854')
INSERT INTO DONHANG VALUES ('Hb3199462633', 3250000, 34500, '2021-07-02', '2021-07-07', 1, 0, N'', '092098907783', '079200681953', '001201185001')
INSERT INTO DONHANG VALUES ('KG9907469541', 300000, 29000, '2021-01-18', '2021-01-20', 0, 1, N'Không đúng sản phẩm', '075195016660', '075094200603', '079300550737')
INSERT INTO DONHANG VALUES ('Rk3993948652', 80000, 15000, '2020-06-14', '2020-06-19', 1, 0, N'', '079300903397', '079089789364', '079199321088')
GO

INSERT INTO THONGTINSANPHAMDH VALUES ('SP413712', N'Áo khoác len mỏng', 160000, 2, 320000, 'BL9787366421')
INSERT INTO THONGTINSANPHAMDH VALUES ('SP310595', N'Đồng hồ thông minh Vikopa A1', 534000, 1, 534000, 'Ag5539210712')
INSERT INTO THONGTINSANPHAMDH VALUES ('SP443710', N'Pin sạc dự phòng Hoco', 325000, 1, 325000, 'Hb3199462633')
INSERT INTO THONGTINSANPHAMDH VALUES ('SP078932', N'Iphone 7 plus', 3430000, 1, 3430000, 'Hb3199462633')
INSERT INTO THONGTINSANPHAMDH VALUES ('SP841318', N'Tai nghe thể thao không dây Bluetooth', 40000, 2, 80000, 'Rk3993948652')
INSERT INTO THONGTINSANPHAMDH VALUES ('SP528423', N'Giày Thể Thao Nam', 300000, 1, 300000, 'KG9907469541')
GO

CREATE PROC SP_GetKhachHangGuiByMaKHG
@maKHG VARCHAR(10)
AS
BEGIN
	SELECT *
	FROM KhachHangGui
	WHERE MaSoKHG = @maKHG
END
GO

CREATE PROC SP_GetKhachHangNhanByMaKHN
@maKHN VARCHAR(10)
AS
BEGIN
	SELECT *
	FROM KhachHangNhan
	WHERE MaSoKHN = @maKHN
END
GO

CREATE PROC SP_GetNVGiaoHangByMaNV
@maNV VARCHAR(10)
AS
BEGIN
	SELECT *
	FROM NV_GiaoHang
	WHERE MaSoNV = @maNV
END
GO

CREATE PROC SP_GetDonHangByMaVanDon
@maVanDon VARCHAR(12)
AS
BEGIN
	SELECT *
	FROM DonHang
	WHERE MaVanDon = @maVanDon
END
GO

CREATE PROC SP_GetListThongTinSanPhamByMaVanDon
@maVanDon VARCHAR(12)
AS
BEGIN
	SELECT MaSP AS [Mã sản phẩm], TenSP AS [Tên sản phẩm], GiaSP AS [Giá], SoLuongSP AS [Số lượng], ThanhTienSP AS [Thành tiền]
	FROM THONGTINSANPHAMDH
	WHERE MaVanDon = @maVanDon
END
GO

CREATE VIEW View_GetListMaSoKHG
AS
	SELECT MaSoKHG
	FROM KHACHHANGGUI
GO

CREATE VIEW View_GetListMaSoKHN
AS
	SELECT MaSoKHN
	FROM KHACHHANGNHAN
GO

CREATE VIEW View_GetListMaSoNV
AS
	SELECT MaSoNV
	FROM NV_GIAOHANG
GO

-- Tạo mã random
CREATE VIEW View_GetRandValue
AS
SELECT RAND() AS Value
GO

CREATE FUNCTION Fn_RandomCodeWithAlphanumeric (@type VARCHAR(22))
RETURNS VARCHAR(100)
AS
BEGIN
	DECLARE @characters VARCHAR(52) = 'ABCDEFGHIJKLMNOPQRSTVUWXYZabcdefghijklmnopqrstvuwxyz'
	DECLARE @numbers VARCHAR(10) = '0123456789'
	DECLARE @len INT = LEN(@type)
	
	DECLARE @randomCode VARCHAR(100) = ''
	DECLARE @i INT = 0
	DECLARE @random INT

	WHILE (@i <= @len/2)
	BEGIN
		DECLARE @randType VARCHAR(1) = SUBSTRING(@type, @i*2-1, 1)
		DECLARE @times INT = SUBSTRING(@type, @i*2, 1)
		DECLARE @j INT = 0

		IF(@randType = 'C' OR @randType = 'c')
		BEGIN
			WHILE (@j < @times)
			BEGIN
				SET @random = CEILING((SELECT Value FROM View_GetRandValue)*52)
				SET @randomCode = CONCAT(@randomCode, SUBSTRING(@characters, @random, 1))
				SET @j = @j + 1
			END
		END

		IF(@randType = 'N' OR @randType = 'n')
		BEGIN
			WHILE (@j < @times)
			BEGIN
				SET @random = CEILING((SELECT Value FROM View_GetRandValue)*10)
				SET @randomCode = CONCAT(@randomCode, SUBSTRING(@numbers, @random, 1))
				SET @j = @j + 1
			END
		END
		SET @i = @i + 1
	END
	RETURN @randomCode
END
GO

-- Cập nhật tổng giá trị đơn hàng theo mã vận đơn
CREATE PROC SP_UpdateTongGiaTriDonHang
@maVanDon VARCHAR(12)
AS
BEGIN
	DECLARE @count INT = 0
	SELECT @count = COUNT(MaSP) FROM THONGTINSANPHAMDH WHERE MaVanDon = @maVanDon
	IF(@count <> 0)
	BEGIN
		DECLARE @tongThanhTienSP FLOAT
		SELECT @tongThanhTienSP = SUM(ThanhTienSP) FROM THONGTINSANPHAMDH WHERE MaVanDon = @maVanDon
		DECLARE @tongPhiVanChuyen FLOAT
		SELECT @tongPhiVanChuyen = PhiVanChuyen FROM DONHANG WHERE MaVanDon = @maVanDon
		UPDATE DONHANG SET TongDonHang = @tongThanhTienSP + @tongPhiVanChuyen WHERE MaVanDon = @maVanDon
	END
	ELSE
		UPDATE DONHANG SET TongDonHang = 0, PhiVanChuyen = 0 WHERE MaVanDon = @maVanDon
END
GO

CREATE PROC SP_AddThongTinSanPhamDH
@tenSP NVARCHAR(40),
@giaSP FLOAT,
@soLuongSP INT,
@maVanDon VARCHAR(12)
AS
BEGIN
	-- Tạo mã vận đơn mới
	DECLARE @maSP VARCHAR(8) = ''
	DECLARE @maTonTai BIT = 1
	WHILE (@maTonTai = 1)
	BEGIN
		SET @maSP = CONCAT('SP', dbo.Fn_RandomCodeWithAlphanumeric('N8'))
		DECLARE @tmp VARCHAR(8) = ''
		SELECT @tmp = MaSP FROM THONGTINSANPHAMDH WHERE MaSP = @maSP
		IF (@tmp = '')
			SET @maTonTai = 0
	END
	
	-- Thêm sản phẩm của đơn hàng mới
	INSERT INTO THONGTINSANPHAMDH 
	VALUES (@maSP, @tenSP, @giaSP, @soLuongSP, @giaSP * @soLuongSP, @maVanDon)

	EXEC SP_UpdateTongGiaTriDonHang @maVanDon
END
GO

CREATE PROC SP_UpdateThongTinSanPhamDH
@maSP VARCHAR(8),
@tenSP NVARCHAR(40),
@giaSP FLOAT,
@soLuongSP INT,
@maVanDon VARCHAR(12)
AS
BEGIN
	UPDATE THONGTINSANPHAMDH
	SET TenSP = @tenSP, GiaSP = @giaSP, SoLuongSP = @soLuongSP, ThanhTienSP = @giaSP * @soLuongSP
	WHERE MaSP = @maSP

	EXEC SP_UpdateTongGiaTriDonHang @maVanDon
END
GO

CREATE PROC SP_DeleteThongTinSanPhamDH
@maSP VARCHAR(8),
@maVanDon VARCHAR(12)
AS
BEGIN
	DELETE THONGTINSANPHAMDH
	WHERE MaSP = @maSP

	EXEC SP_UpdateTongGiaTriDonHang @maVanDon
END
GO

CREATE PROC SP_AddDonHang
@tongDonHang FLOAT,
@phiVanChuyen FLOAT,
@ngayNhapKho DATE,
@ngayGui DATE,
@giaoThanhCong BIT,
@hoanTra BIT,
@nguyenNhanHoanTra NVARCHAR(100),
@maSoNV VARCHAR(10),
@maSoKHG VARCHAR(10),
@maSoKHN VARCHAR(10)
AS
BEGIN
	-- Tạo mã vận đơn mới
	DECLARE @maVanDon VARCHAR(12) = ''
	DECLARE @maTonTai BIT = 1
	WHILE (@maTonTai = 1)
	BEGIN
		SET @maVanDon = dbo.Fn_RandomCodeWithAlphanumeric('C2N9N1')
		DECLARE @tmp VARCHAR(12) = ''
		SELECT @tmp = MaVanDon FROM DONHANG WHERE MaVanDon = @maVanDon
		IF (@tmp = '')
			SET @maTonTai = 0
	END
	
	-- Thêm đơn hàng mới
	INSERT INTO DONHANG 
	VALUES (@maVanDon, @tongDonHang, @phiVanChuyen, @ngayNhapKho, @ngayGui, @giaoThanhCong, @hoanTra, @nguyenNhanHoanTra, @maSoNV, @maSoKHG, @maSoKHN)
END
GO

