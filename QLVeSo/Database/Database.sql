﻿CREATE DATABASE QLVeSo
GO
--
USE QLVeSo
GO

--TABLE--
CREATE TABLE DaiLy
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	MaDaiLy VARCHAR(10) UNIQUE NOT NULL,
	Ten NVARCHAR(100),
	DiaChi NVARCHAR(200),
	DienThoai VARCHAR(12),
	TinhTrang NVARCHAR(20)
)

CREATE TABLE LoaiVeSo
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	MaLoaiVeSo VARCHAR(10) UNIQUE NOT NULL,
	Tinh NVARCHAR(50),
	TinhTrang NVARCHAR(20)
)

CREATE TABLE DangKy
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	IdDaiLy UNIQUEIDENTIFIER NOT NULL, --FK--
	IdLoaiVeSo UNIQUEIDENTIFIER NOT NULL, --FK--
	NgayDangKy DATETIME,
	SoLuong INT
)

CREATE TABLE PhanPhoi
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	IdDaiLy UNIQUEIDENTIFIER NOT NULL, --FK--
	IdLoaiVeSo UNIQUEIDENTIFIER NOT NULL, --FK--
	Ngay DATE,
	SoLuongGiao INT,
	SoLuongBan INT,
	TiLe FLOAT
)

CREATE TABLE Giai
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	MaGiai VARCHAR(10) UNIQUE NOT NULL,
	GiaiThuong FLOAT
)

CREATE TABLE KetQuaXoSo
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	MaKetQua VARCHAR(10) UNIQUE NOT NULL,
	IdLoaiVeSo UNIQUEIDENTIFIER NOT NULL, --FK--
	Ngay DATE,
	IdGiai UNIQUEIDENTIFIER NOT NULL, --FK--
	SoTrung VARCHAR(20)
)

CREATE TABLE CongNo
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	MaCongNo VARCHAR(10) UNIQUE NOT NULL,
	IdDaiLy UNIQUEIDENTIFIER NOT NULL, --FK--
	Ngay DATETIME,
	TongTien FLOAT
)

CREATE TABLE PhieuThu
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	MaPhieuThu VARCHAR(10) UNIQUE NOT NULL,
	IdDaiLy UNIQUEIDENTIFIER NOT NULL, --FK--
	Ngay DATETIME,
	TongTien FLOAT
)

--CONSTRAINT--
ALTER TABLE DangKy
	ADD
		CONSTRAINT FK_DangKy_DaiLy_IdDaiLy FOREIGN KEY (IdDaiLy) REFERENCES DaiLy(Id),
		CONSTRAINT FK_DangKy_LoaiVeSo_IdLoaiVeSo FOREIGN KEY (IdLoaiVeSo) REFERENCES LoaiVeSo(Id)

ALTER TABLE PhanPhoi
	ADD
		CONSTRAINT FK_PhanPhoi_LoaiVeSo_IdLoaiVeSo FOREIGN KEY (IdLoaiVeSo) REFERENCES LoaiVeSo(Id),
		CONSTRAINT FK_PhanPhoi_DaiLy_IdDaiLy FOREIGN KEY (IdDaiLy) REFERENCES DaiLy(Id)

ALTER TABLE KetQuaXoSo
	ADD
		CONSTRAINT FK_KetQuaXoSo_LoaiVeSo_IdLoaiVeSo FOREIGN KEY (IdLoaiVeSo) REFERENCES LoaiVeSo(Id),
		CONSTRAINT FK_KetQuaXoSo_Giai_IdGiai FOREIGN KEY (IdGiai) REFERENCES Giai(Id)

ALTER TABLE CongNo
	ADD
		CONSTRAINT FK_CongNo_DaiLy_IdDaiLy FOREIGN KEY (IdDaiLy) REFERENCES DaiLy(Id)

ALTER TABLE PhieuThu
	ADD
		CONSTRAINT FK_PhieuThu_DaiLy_IdDaiLy FOREIGN KEY (IdDaiLy) REFERENCES DaiLy(Id)

--ADD DATA--
INSERT INTO LoaiVeSo
	VALUES('EE5A75E6-89C5-461E-B11B-D3E23D78F550', 'VSBT', N'Bến Tre', N'Không khoá'),
		  ('730D0C60-2546-4854-B88A-6DDFBFE11CBB', 'VSLA', N'Long An', N'Không khoá'),
	      ('570B0397-2061-4ADD-8563-2E965322CF01', 'VSCM', N'Cà Mau', N'Không khoá'),
		  ('CC3CF4FE-9665-4C5F-ADA5-C1D14BDD8B78', 'VSVT', N'Vũng Tàu', N'Không khoá'),
		  ('4E8B9EF4-CBFF-40D5-AE44-2FF4F3C6BBFB', 'VSCT', N'Cần Thơ', N'Không khoá'),
		  ('5469FDA6-AE0F-4772-9BEC-757A2AE4245F', 'VSBL', N'Bạc Liêu', N'Không khoá'),
		  ('0219A36F-E572-4921-AD4E-C920FF75CF23', 'VSVL', N'Vĩnh Long', N'Không khoá'),
		  ('543571F0-C178-4F29-A7C9-603BE01D1A8A', 'VSRG', N'Rạch giá', N'Không khoá'),
		  ('758B0C57-D32C-412E-B30D-D55E445F4220', 'VSLX', N'Long Xuyên', N'Không khoá'),
	      ('DBA7FA9B-C5AA-4541-985D-8E27131468F8', 'VSCL', N'Cao Lãnh', N'Không khoá'),
		  ('DE25F16C-43F4-4A41-9089-7F21C0FDB26F', 'VSTA', N'Tân An', N'Không khoá'),
		  ('5CF29F46-BC5B-4B4F-B6A4-CFA74057764F', 'VSBH', N'Biên Hoà', N'Không khoá'),
		  ('F7E693CC-2CC9-4141-B6BF-D90BB1D7BD63', 'VSPT', N'Phan Thiết', N'Không khoá'),
		  ('AA0A7B91-85E6-4D14-AE3B-AD1A6BE67D65', 'VSPR', N'Phan Rang', N'Không khoá')

INSERT INTO DaiLy
	VALUES('1D627550-FDCB-4DF8-8141-A5AD9900FB2B','DL01',N'Đại lý 1',N'26 Nguuyễn Trãi',N'0935263748',N'Không khoá'),
		  ('0064E9B1-2992-4258-B800-D4BAFC43EAF7','DL02',N'Đại lý 2',N'73 An Dương Vương',N'0943728574',N'Không khoá'),
		  ('44FA4066-84B9-44EC-924B-8CA535314CD3','DL03',N'Đại lý 3',N'94 Kinh Dương Vương',N'0912345673',N'Không khoá'),
		  ('4411C19D-E4C2-46B6-8AA1-0FDE5A36234D','DL04',N'Đại lý 4',N'122 Vĩnh Viễn',N'0962835263',N'Không khoá'),
		  ('74CDBB04-A926-4221-83C3-9643B846199B','DL05',N'Đại lý 5',N'12 Hoà Hảo',N'0946372839',N'Không khoá')

INSERT INTO DangKy
	VALUES('397C5455-1FD5-4BB3-9743-7D04AFFAA522','1D627550-FDCB-4DF8-8141-A5AD9900FB2B', 'EE5A75E6-89C5-461E-B11B-D3E23D78F550','2018-05-01',50),
		  ('E1017914-E230-4926-A553-FFF6ECFABBB7','1D627550-FDCB-4DF8-8141-A5AD9900FB2B', '730D0C60-2546-4854-B88A-6DDFBFE11CBB','2018-06-01',80),
		  ('D361AF43-9F6C-4C4B-9B5D-30419B902000','0064E9B1-2992-4258-B800-D4BAFC43EAF7', 'CC3CF4FE-9665-4C5F-ADA5-C1D14BDD8B78','2018-02-02',100),
		  ('800CA87B-BE3D-4225-ABF2-0BA90F1C2D76','44FA4066-84B9-44EC-924B-8CA535314CD3', '758B0C57-D32C-412E-B30D-D55E445F4220','2018-03-06',150)
GO

--Hàm tự động thêm số lượng giao--
CREATE PROC Them_PhanPhoi
AS
	--Con trỏ--
	DECLARE CUR CURSOR FOR
	SELECT Table2.IdDaiLy, Table2.IdLoaiVeSo, Table2.SoLuong
	FROM
	(
		SELECT IdDaiLy, MAX(NgayDangKy) AS NgayDangKy
		FROM DangKy
		GROUP BY IdDaiLy
	) AS Table1, DangKy as Table2
	WHERE Table1.IdDaiLy = Table2.IdDaiLy AND Table1.NgayDangKy = Table2.NgayDangKy
	--
	DECLARE @IdDaiLy UNIQUEIDENTIFIER
	DECLARE @IdLoaiVeSo UNIQUEIDENTIFIER
	DECLARE @SoLuong INT
	--
	OPEN CUR
	FETCH NEXT FROM CUR INTO @IdDaiLy, @IdLoaiVeSo, @SoLuong --Chạy từng dòng trong table đã khai báo trên--
	WHILE @@FETCH_STATUS = 0 --Nếu con trỏ còn dữ liệu để trỏ đến--
	BEGIN
		----
		IF(@SoLuong != 0)
		BEGIN
			--Kiểm tra nếu đã tồn tại trong bảng hay chưa--
			IF EXISTS
			(
				SELECT TOP 1 *
				FROM PhanPhoi
				WHERE IdDaiLy = @IdDaiLy
			)
			BEGIN
				DECLARE @CheckTiLe FLOAT
				--
				SELECT @CheckTiLe = TiLe
				FROM PhanPhoi
				WHERE IdDaiLy = @IdDaiLy
				--
				IF(@CheckTiLe IS NOT NULL)
				BEGIN
					--Tính tỉ lệ--
					DECLARE @TiLe FLOAT
					--
					SELECT @TiLe = AVG(TiLe)
					FROM PhanPhoi
					WHERE Id IN 
					(
						SELECT TOP 3 Id
						FROM PhanPhoi
						WHERE IdDaiLy = @IdDaiLy
						ORDER BY Ngay DESC
					)
					--Insert vào bảng--
					DECLARE @SoLuongGiao INT = CAST((@TiLe / 100 * @SoLuong) AS INT)
					--Bỏ vào bảng phân phối--
					INSERT INTO PhanPhoi(Id, IdDaiLy, IdLoaiVeSo, Ngay, SoLuongGiao)
						VALUES(NEWID(), @IdDaiLy, @IdLoaiVeSo, CONVERT(DATE, GETDATE()), @SoLuongGiao)
				END
			END
			ELSE
			BEGIN
				--Bỏ vào bảng phân phối--
				INSERT INTO PhanPhoi(Id, IdDaiLy, IdLoaiVeSo, Ngay, SoLuongGiao)
					VALUES(NEWID(), @IdDaiLy, @IdLoaiVeSo, CONVERT(DATE, GETDATE()), @SoLuong)
			END
		END
		FETCH NEXT FROM CUR INTO @IdDaiLy, @IdLoaiVeSo, @SoLuong
	END
	CLOSE CUR
	DEALLOCATE CUR
GO

--Tính tỉ lệ sau khi thêm số vé bán được--
CREATE TRIGGER TG_Them_TiLe ON PhanPhoi AFTER UPDATE
AS
	DECLARE @Id UNIQUEIDENTIFIER
	DECLARE @SoLuongGiaoInserted INT
	DECLARE @SoLuongGiaoDeleted INT
	DECLARE @SoLuongBan INT
	DECLARE @TongTiLe FLOAT
	--
	SELECT @SoLuongGiaoInserted = SoLuongGiao
	FROM inserted
	--
	SELECT @SoLuongGiaoDeleted = SoLuongGiao
	FROM deleted
	--
	SELECT @SoLuongBan = SoLuongBan
	FROM inserted
	--
	IF(@SoLuongGiaoInserted = @SoLuongGiaoDeleted)
	BEGIN
		IF(@SoLuongBan IS NOT NULL)
		BEGIN
			SELECT @Id = Id, @SoLuongGiaoInserted = SoLuongGiao, @SoLuongBan = SoLuongBan
			FROM inserted
			--
			SET @TongTiLe = (CAST(@SoLuongBan AS FLOAT) / CAST(@SoLuongGiaoInserted AS FLOAT)) * 100
			--
			UPDATE PhanPhoi
			SET TiLe = @TongTiLe
			WHERE Id = @Id
		END
	END
	ELSE
	BEGIN
		IF(@SoLuongBan IS NOT NULL)
		BEGIN
			SELECT @Id = Id, @SoLuongGiaoInserted = SoLuongGiao, @SoLuongBan = SoLuongBan
			FROM inserted
			--
			SET @TongTiLe = (CAST(@SoLuongBan AS FLOAT) / CAST(@SoLuongGiaoInserted AS FLOAT)) * 100
			--
			UPDATE PhanPhoi
			SET TiLe = @TongTiLe
			WHERE Id = @Id
		END
	END
GO