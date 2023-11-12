CREATE DATABASE QuanLyQuanAn
GO

USE QuanLyQuanAn
GO

-- ACCOUNT
-- FOOD
-- TABLE
-- FOOD CATEGORY
-- BILL
-- BILL DETAIL

CREATE TABLE Account (
	UserName NVARCHAR(100) PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL,
	Password NVARCHAR(1000) NOT NULL DEFAULT 0,
	TypeAccount NVARCHAR(20) NOT NULL DEFAULT N'Nhân Viên'
)
GO

CREATE TABLE Customer (
	PhoneNumber NVARCHAR(10) PRIMARY KEY,
	NameCustomer NVARCHAR(100) NOT NULL,
	Point INT NOT NULL DEFAULT 0,
)

CREATE TABLE TableFood (
	IdTable INT IDENTITY PRIMARY KEY,
	NameTable NVARCHAR(100) NOT NULL DEFAULT N'Chưa Đặt tên',
	StatusTable NVARCHAR(100) NOT NULL DEFAULT N'Trống', --(0: Trống, 1: Có người)--
	Position NVARCHAR(100) NOT NULL DEFAULT 0,
)
GO

CREATE TABLE FoodCategory (
	IdFC INT IDENTITY PRIMARY KEY,
	NameFC NVARCHAR(100) NOT NULL DEFAULT N'Chưa Đặt Tên'
)
GO

CREATE TABLE Food (
	IdFood INT IDENTITY PRIMARY KEY,
	NameFood NVARCHAR(100) NOT NULL DEFAULT N'Chưa Đặt Tên',
	IdFC INT NOT NULL,
	Price FLOAT NOT NULL,
	ImgFood image NOT NULL
	FOREIGN KEY (IdFC) REFERENCES dbo.FoodCategory(IdFC)

)


CREATE TABLE Bill (
	IdBill INT IDENTITY PRIMARY KEY,
	IdTable INT NOT NULL,
	DateIn DATE NOT NULL DEFAULT GETDATE(),	
	DateOut DATE,
	StatusBill INT DEFAULT 0,
	TotalPrice FLOAT DEFAULT 0,
	Discount INT DEFAULT 0,
	FOREIGN KEY (IdTable) REFERENCES dbo.TableFood(IdTable)
)
GO


CREATE TABLE BillDetail (
	IdBD INT IDENTITY PRIMARY KEY,
	IdBill INT NOT NULL,
	IdFood INT NOT NULL,
	Quantity INT NOT NULL DEFAULT 0,
	Note NVARCHAR(500),
	FOREIGN KEY (IdBill) REFERENCES dbo.Bill(IdBill),
	FOREIGN KEY (IdFood) REFERENCES dbo.Food(IdFood)
)
GO


CREATE TABLE Supplier
(
	IdSupplier INT IDENTITY PRIMARY KEY,
	NameSupplier NVARCHAR(100) NOT NULL,
	PhoneNumber NVARCHAR(10) NOT NULL UNIQUE,
)
GO

CREATE TABLE Ingredient
(
	IdIngredient INT IDENTITY PRIMARY KEY,
	NameIngredient NVARCHAR(100) NOT NULL,

	
)
GO

CREATE TABLE Supplier_Ingredient
(
	IdSupplier INT NOT NULL,
	IdIngredient INT NOT NULL,
	Price FLOAT NOT NULL,
	PRIMARY KEY (IdSupplier, IdIngredient),
	FOREIGN KEY (IdSupplier) REFERENCES dbo.Supplier(IdSupplier),
	FOREIGN KEY (IdIngredient) REFERENCES dbo.Ingredient(IdIngredient)

)
GO


CREATE TABLE Storage (
	IdIngredient INT PRIMARY KEY,
	Quantity INT DEFAULT 0,
	Measure NVARCHAR(100) NOT NULL DEFAULT N'Kg',
	DateIn Date NOT NULL DEFAULT GETDATE(),
	expiry int NOT NULL DEFAULT 1,
	StatusStorage NVARCHAR(100) NOT NULL DEFAULT N'Còn hạn', --(0: Còn Hạn, 1: Hết Hạn)--
	FOREIGN KEY (IdIngredient) REFERENCES dbo.Ingredient(idIngredient)
)
GO


CREATE TABLE Bill_Ingredient
(
	IdB_I INT IDENTITY PRIMARY KEY,
	DateIn DATE,
	StatusBill INT DEFAULT 0,
	TotalPrice FLOAT DEFAULT 0,
)
GO

CREATE TABLE BillDetail_Ingredient
(
	IdBD_I INT IDENTITY PRIMARY KEY,
	IdB_I INT NOT NULL,
	IdIngredient INT NOT NULL,
	IdSupplier INT NOT NULL,
	Quantity INT NOT NULL DEFAULT 0,
	FOREIGN KEY (IdB_I) REFERENCES dbo.Bill_Ingredient(IdB_I),
	FOREIGN KEY (IdSupplier) REFERENCES dbo.Supplier(IdSupplier),
	FOREIGN KEY (IdIngredient) REFERENCES dbo.Ingredient(IdIngredient)
)
GO

CREATE TABLE Revenue
(
	NameMonth int NOT NULL,
	NameYear int NOT NULL,
	revenue float NOT NULL,
)
GO


-- ADD ACCOUNT
INSERT INTO dbo.Account VALUES('1', N'admin', '1', N'Quản lí')
INSERT INTO dbo.Account VALUES('minhhehe', N'Minh', '123456', N'Quản lí')
INSERT INTO dbo.Account VALUES('dunghoho', N'Dũng', '123456', N'Nhân Viên')
INSERT INTO dbo.Account VALUES('kienhuhu', N'Kiên', '123456', N'Nhân Viên')
INSERT INTO dbo.Account VALUES('duchaha', N'Đức', '123456', N'Nhân Viên')
INSERT INTO dbo.Account VALUES('hoahihi', N'Hòa', '123456', N'Nhân Viên')
GO	

-- ADD CUSTOMER
INSERT INTO dbo.Customer VALUES('0988125225', N'Võ Thiên Minh', 0)
INSERT INTO dbo.Customer VALUES('0988124534', N'Sơn Tùng MTP', 0)
INSERT INTO dbo.Customer VALUES('0988136254', N'Charlie Puth', 0)
GO

-- ADD TABLE
INSERT INTO dbo.TableFood VALUES (N'Bàn 01', N'Trống', N'Trệt')
INSERT INTO dbo.TableFood VALUES (N'Bàn 02', N'Trống', N'Trệt')
INSERT INTO dbo.TableFood VALUES (N'Bàn 03', N'Trống', N'Trệt')
INSERT INTO dbo.TableFood VALUES (N'Bàn 04', N'Trống', N'Trệt')
INSERT INTO dbo.TableFood VALUES (N'Bàn 05', N'Trống', N'Trệt')
INSERT INTO dbo.TableFood VALUES (N'Bàn 06', N'Trống', N'Trệt')
INSERT INTO dbo.TableFood VALUES (N'Bàn 07', N'Trống', N'Trệt')
INSERT INTO dbo.TableFood VALUES (N'Bàn 08', N'Trống', N'Trệt')
INSERT INTO dbo.TableFood VALUES (N'Bàn 09', N'Trống', N'Trệt')
INSERT INTO dbo.TableFood VALUES (N'Bàn 10', N'Trống', N'Trệt')
INSERT INTO dbo.TableFood VALUES (N'Bàn 11', N'Trống', N'Trệt')
INSERT INTO dbo.TableFood VALUES (N'Bàn 12', N'Trống', N'Trệt')
INSERT INTO dbo.TableFood VALUES (N'Bàn 13', N'Trống', N'Trệt')
INSERT INTO dbo.TableFood VALUES (N'Bàn 14', N'Trống', N'Trệt')
INSERT INTO dbo.TableFood VALUES (N'Bàn 15', N'Trống', N'Trệt')
INSERT INTO dbo.TableFood VALUES (N'Bàn 16', N'Trống', N'Trệt')
INSERT INTO dbo.TableFood VALUES (N'Bàn 17', N'Trống', N'Trệt')
INSERT INTO dbo.TableFood VALUES (N'Bàn 18', N'Trống', N'Trệt')
INSERT INTO dbo.TableFood VALUES (N'Bàn 19', N'Trống', N'Trệt')
INSERT INTO dbo.TableFood VALUES (N'Bàn 20', N'Trống', N'Trệt')



INSERT INTO dbo.TableFood VALUES (N'Bàn 21', N'Trống', N'Lầu')
INSERT INTO dbo.TableFood VALUES (N'Bàn 22', N'Trống', N'Lầu')
INSERT INTO dbo.TableFood VALUES (N'Bàn 23', N'Trống', N'Lầu')
INSERT INTO dbo.TableFood VALUES (N'Bàn 24', N'Trống', N'Lầu')
INSERT INTO dbo.TableFood VALUES (N'Bàn 25', N'Trống', N'Lầu')
INSERT INTO dbo.TableFood VALUES (N'Bàn 26', N'Trống', N'Lầu')
INSERT INTO dbo.TableFood VALUES (N'Bàn 27', N'Trống', N'Lầu')
INSERT INTO dbo.TableFood VALUES (N'Bàn 28', N'Trống', N'Lầu')
INSERT INTO dbo.TableFood VALUES (N'Bàn 29', N'Trống', N'Lầu')
INSERT INTO dbo.TableFood VALUES (N'Bàn 30', N'Trống', N'Lầu')
INSERT INTO dbo.TableFood VALUES (N'Bàn 31', N'Trống', N'Lầu')
INSERT INTO dbo.TableFood VALUES (N'Bàn 32', N'Trống', N'Lầu')
INSERT INTO dbo.TableFood VALUES (N'Bàn 33', N'Trống', N'Lầu')
INSERT INTO dbo.TableFood VALUES (N'Bàn 34', N'Trống', N'Lầu')
INSERT INTO dbo.TableFood VALUES (N'Bàn 35', N'Trống', N'Lầu')
INSERT INTO dbo.TableFood VALUES (N'Bàn 36', N'Trống', N'Lầu')
INSERT INTO dbo.TableFood VALUES (N'Bàn 37', N'Trống', N'Lầu')
INSERT INTO dbo.TableFood VALUES (N'Bàn 38', N'Trống', N'Lầu')
INSERT INTO dbo.TableFood VALUES (N'Bàn 39', N'Trống', N'Lầu')
INSERT INTO dbo.TableFood VALUES (N'Bàn 40', N'Trống', N'Lầu')

GO

-- ADD CATEGORY
INSERT INTO dbo.FoodCategory VALUES(N'Mì cay')
INSERT INTO dbo.FoodCategory VALUES(N'Nước uống')
INSERT INTO dbo.FoodCategory VALUES(N'Ăn vặt')
INSERT INTO dbo.FoodCategory VALUES(N'Lẩu')
GO

-- ADD FOOD


-- BILL
INSERT INTO dbo.Bill VALUES(9, '20221110', '20221110', 1, 300000, 0)
INSERT INTO dbo.Bill VALUES(3, '20221110', '20221110', 1, 195000, 0)
INSERT INTO dbo.Bill VALUES(6, '20221110', '20221110', 1, 450000, 0)
INSERT INTO dbo.Bill VALUES(1, '20221110', '20221110', 1, 210000, 0)
INSERT INTO dbo.Bill VALUES(2, '20221110', '20221110', 1, 105000, 0)
INSERT INTO dbo.Bill VALUES(5, '20221110', '20221110', 1, 90000, 0)
GO

SELECT * FROM BILL

-- SUPPLIER
INSERT INTO dbo.Supplier(NameSupplier, PhoneNumber) VALUES(N'Bò Long Thành', '0905340511')
INSERT INTO dbo.Supplier(NameSupplier, PhoneNumber) VALUES(N'Bò Đồng Nai', '0905342544')
INSERT INTO dbo.Supplier(NameSupplier, PhoneNumber) VALUES(N'Hải Sản Tường An', '0905320321')
INSERT INTO dbo.Supplier(NameSupplier, PhoneNumber) VALUES(N'Biển xanh', '0905320122')
INSERT INTO dbo.Supplier(NameSupplier, PhoneNumber) VALUES(N'Gà Nhà Trồng', '0905329663')
INSERT INTO dbo.Supplier(NameSupplier, PhoneNumber) VALUES(N'Gà Xí Nghiệp', '0905329677')
INSERT INTO dbo.Supplier(NameSupplier, PhoneNumber) VALUES(N'Đại Lý Pepsico', '0905340152')
INSERT INTO dbo.Supplier(NameSupplier, PhoneNumber) VALUES(N'Đại Lý Cocala', '0905340892')
INSERT INTO dbo.Supplier(NameSupplier, PhoneNumber) VALUES(N'Bách Hóa Xanh', '0905341566')
INSERT INTO dbo.Supplier(NameSupplier, PhoneNumber) VALUES(N'WinMart', '0905341448')
INSERT INTO dbo.Supplier(NameSupplier, PhoneNumber) VALUES(N'Mì Hảo Hảo', '0905341223')
INSERT INTO dbo.Supplier(NameSupplier, PhoneNumber) VALUES(N'Thế Giới Mì', '0905341428')
GO
-- INGREDIENT
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Bắp Bò Mỹ')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Sụn Bò Mỹ')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Bắp Bò Úc')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Sụn Bò Úc')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Tôm Hoàng Đế')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Cua Hùm')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Ghẹ Xanh')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Bạch Tuộc')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Gà Ta')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Gà Tre')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Gà Chọi')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Gà Ác')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Trứng Gà')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Mì Ống')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Mì Gói')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Coca Cola')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Pepsi')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Sting')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Bia Tiger')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Bia Sài Gòn')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Cải Tím')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Kim Chi')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Súp Lơ')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Hành Lá')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Rau Muống')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Hoa Chuối')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Bắp Cải')
INSERT INTO dbo.Ingredient(NameIngredient) VALUES(N'Ngô')
GO

-- SUPPLIER_INGREDIENT
INSERT INTO dbo.Supplier_Ingredient VALUES(1, 1, 400000) -- Bò Long Thành --> Bắp Bò Mỹ
INSERT INTO dbo.Supplier_Ingredient VALUES(1, 2, 300000) -- Bò Long Thành --> Sụn Bò Mỹ
INSERT INTO dbo.Supplier_Ingredient VALUES(1, 3, 350000) -- Bò Long Thành --> Bắp Bò Úc
INSERT INTO dbo.Supplier_Ingredient VALUES(1, 4, 250000) -- Bò Long Thành --> Sụn Bò Úc
INSERT INTO dbo.Supplier_Ingredient VALUES(2, 1, 420000) -- Bò Đồng Nai --> Bắp Bò Mỹ
INSERT INTO dbo.Supplier_Ingredient VALUES(2, 2, 270000) -- Bò Đồng Nai --> Sụn Bò Mỹ
INSERT INTO dbo.Supplier_Ingredient VALUES(2, 3, 300000) -- Bò Đồng Nai --> Bắp Bò Úc
INSERT INTO dbo.Supplier_Ingredient VALUES(2, 4, 280000) -- Bò Đồng Nai --> Sụn Bò Úc
INSERT INTO dbo.Supplier_Ingredient VALUES(3, 5, 1000000) -- Hải Sản Tường An --> Tôm Hoàng Đế
INSERT INTO dbo.Supplier_Ingredient VALUES(3, 6, 1000000) -- Hải Sản Tường An --> Cua Hùm
INSERT INTO dbo.Supplier_Ingredient VALUES(3, 7, 200000) -- Hải Sản Tường An --> Ghẹ Xanh
INSERT INTO dbo.Supplier_Ingredient VALUES(3, 8, 200000) -- Hải Sản Tường An --> Bạch Tuộc
GO

-- STORAGE
INSERT INTO dbo.Storage VALUES(1, 10, N'Kg', '12/6/2022',1,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(2, 15, N'Kg', '12/5/2022',1,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(3, 15, N'Kg', GETDATE(),7,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(4, 15, N'Kg', GETDATE(),7,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(5, 5, N'Kg', GETDATE(),7,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(6, 5, N'Kg', GETDATE(),7,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(7, 5, N'Kg', GETDATE(),10,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(8, 20, N'Kg', GETDATE(),10,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(9, 20, N'Kg', GETDATE(),10,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(10, 20, N'Kg', GETDATE(),10,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(11, 20, N'Kg', GETDATE(),10,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(12, 20, N'Kg', GETDATE(),10,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(13, 100, N'Quả', GETDATE(),10,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(14, 50, N'Gói', GETDATE(),10,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(15, 100, N'Gói', GETDATE(),10,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(16, 100, N'Lon', GETDATE(),10,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(17, 100, N'Lon', GETDATE(),10,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(18, 100, N'Lon', GETDATE(),10,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(19, 100, N'Lon', GETDATE(),10,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(20, 100, N'Lon', GETDATE(),14,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(21, 20, N'Kg', GETDATE(),14,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(22, 100, N'Kg', GETDATE(),5,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(23, 50, N'Kg', GETDATE(),14,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(24, 100, N'Kg', GETDATE(),5,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(25, 100, N'Kg', GETDATE(),14,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(26, 100, N'Kg', GETDATE(),14,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(27, 100, N'Kg', GETDATE(),5,N'Còn hạn')
INSERT INTO dbo.Storage VALUES(28, 100, N'Kg', GETDATE(),5,N'Còn hạn')

GO
--ADD REVENUE--
INSERT INTO dbo.Revenue VALUES(1,2022,0)
INSERT INTO dbo.Revenue VALUES(2,2022,0)
INSERT INTO dbo.Revenue VALUES(3,2022,0)
INSERT INTO dbo.Revenue VALUES(4,2022,0)
INSERT INTO dbo.Revenue VALUES(5,2022,0)
INSERT INTO dbo.Revenue VALUES(6,2022,0)
INSERT INTO dbo.Revenue VALUES(7,2022,0)
INSERT INTO dbo.Revenue VALUES(8,2022,0)
INSERT INTO dbo.Revenue VALUES(9,2022,0)
INSERT INTO dbo.Revenue VALUES(10,2022,0)
INSERT INTO dbo.Revenue VALUES(11,2022,0)
INSERT INTO dbo.Revenue VALUES(12,2022,0)
Go


-- PROCEDURE
CREATE PROC USP_GetAccountByUserName
@UserName NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @UserName
END
GO

CREATE PROC USP_GetTotalPriceByDate
@DateIn Date, @DateOut Date
AS
BEGIN
	SELECT SUM(TotalPrice)
	FROM dbo.Bill
	WHERE DateIn >= @DateIn AND DateOut <= @DateOut
END
GO


CREATE PROC USP_GetTablelist
AS SELECT * FROM dbo.TableFood
GO

CREATE PROC USP_InsertBill
@IdTable INT
AS
BEGIN
	INSERT dbo.BILL (IdTable, DateIn, DateOut, StatusBill) VALUES (@IdTable, GETDATE(), NULL, 0);
END
GO

CREATE PROC USP_InsertBillDetail
@IdBill INT, @IdFood INT, @Quantity INT, @Note NVARCHAR(500)
AS
BEGIN
	DECLARE @isExistBill INT;
	DECLARE @foodQuantity INT = 1;
	SELECT @isExistBill = IdBD, @foodQuantity = Quantity FROM dbo.BillDetail WHERE IdBill = @IdBill AND IdFood = @IdFood;

	IF(@isExistBill > 0)
	BEGIN
		DECLARE @newQuantity INT = @foodQuantity + @Quantity
		IF(@newQuantity > 0)
		BEGIN
			IF(@Note = '')
				UPDATE dbo.BilLDetail SET Quantity = @foodQuantity + @Quantity WHERE IdFood = @IdFood
			ELSE
				UPDATE dbo.BilLDetail SET Quantity = @foodQuantity + @Quantity, Note = @Note WHERE IdFood = @IdFood

		END
		ELSE
			DELETE dbo.BillDetail WHERE IdBill = @IdBill AND IdFood = @IdFood

	END
	ELSE
	BEGIN
		IF(@Quantity > 0)
		BEGIN
			INSERT dbo.BillDetail (IdBill, IdFood, Quantity, Note) VALUES (@IdBill, @IdFood, @Quantity, @Note);
		END
	END
END
GO

CREATE PROC USP_InsertBill_Ingredient
AS
BEGIN
	INSERT dbo.Bill_Ingredient(DateIn, StatusBill, TotalPrice) VALUES (GETDATE(), 0, 0);
END
GO


CREATE PROC USP_InsertBillDetail_Ingredient
@IdB_I INT, @IdIngredient INT, @IdSupplier INT, @Quantity INT
AS
BEGIN
	DECLARE @isExistBill INT;
	DECLARE @IngredientQuantity INT = 1;
	SELECT @isExistBill = IdBD_I, @IngredientQuantity = Quantity FROM dbo.BillDetail_Ingredient WHERE IdB_I = @IdB_I AND IdSupplier = @IdSupplier AND IdIngredient = @IdIngredient;

	IF(@isExistBill > 0)
	BEGIN
		DECLARE @newQuantity INT = @IngredientQuantity + @Quantity
		IF(@newQuantity > 0)
		BEGIN
			UPDATE dbo.BilLDetail_Ingredient SET Quantity = @IngredientQuantity + @Quantity WHERE IdB_I = @IdB_I AND IdSupplier = @IdSupplier AND IdIngredient = @IdIngredient;
		END
		ELSE
			DELETE dbo.BillDetail_Ingredient WHERE IdB_I = @IdB_I AND IdB_I = @IdB_I AND IdSupplier = @IdSupplier AND IdIngredient = @IdIngredient;

	END
	ELSE
	BEGIN
		IF(@Quantity > 0)
		BEGIN
			INSERT dbo.BillDetail_Ingredient (IdB_I, IdIngredient, IdSupplier, Quantity) VALUES (@IdB_I, @IdIngredient, @IdSupplier, @Quantity);
		END
	END
END
GO

CREATE PROC USP_GetListBillDetail_IngredientByIdB_I
@IdB_I INT
AS
BEGIN
	SELECT i.NameIngredient, s.NameSupplier, Quantity, Price, Quantity*Price AS totalPrice
	FROM BillDetail_Ingredient bdi, Ingredient i, Supplier s, Supplier_Ingredient si
	WHERE bdi.IdIngredient = i.IdIngredient AND bdi.IdSupplier = s.IdSupplier AND si.IdIngredient = i.IdIngredient AND si.IdSupplier = s.IdSupplier AND IdB_I = @IdB_I
END
GO

CREATE PROC USP_PlusPointToCustomer
@PhoneNumber NVARCHAR(10), @Point INT
AS
BEGIN
	IF((SELECT COUNT(*) FROM dbo.Customer WHERE PhoneNumber = @PhoneNumber) > 0)
	BEGIN
		UPDATE dbo.Customer SET Point = Point + @Point WHERE PhoneNumber = @PhoneNumber
	END	
END
GO

CREATE PROC USP_GetListBilLByDate
@DateIn Date, @DateOut Date
AS
BEGIN
	SELECT b.IdBill AS N'Số hóa đơn', t.NameTable AS N'Tên bàn', DateIn AS N'Ngày vào', DateOut AS N'Ngày ra', Discount AS N'Khuyến mãi', b.TotalPrice AS N'Thành tiền'
	FROM dbo.Bill AS b, dbo.TableFood AS t
	WHERE DateIn >= @DateIn AND DateOut <= @DateOut AND b.StatusBill = 1 AND t.IdTable = b.IdTable
END
GO


CREATE PROC USP_GetListIngredient
AS
BEGIN
	SELECT NameIngredient AS N'Tên Nguyên Liệu', Price AS N'Giá Tiền', NameSupplier AS N'Nhà Cung Cấp', i.IdIngredient, s.IdSupplier
	FROM Supplier AS s, Ingredient AS i, Supplier_Ingredient si
	WHERE s.IdSupplier = si.IdSupplier AND i.IdIngredient = si.IdIngredient
END
GO

CREATE PROC USP_GetListIngredientByIdSupplier
@IdSupplier INT
AS
BEGIN
	SELECT NameSupplier AS N'Nhà Cung Cấp', NameIngredient AS N'Tên Nguyên Liệu', Price AS N'Giá Tiền', i.IdIngredient, s.IdSupplier
	FROM Supplier AS s, Ingredient AS i, Supplier_Ingredient AS si
	WHERE s.IdSupplier = si.IdSupplier AND i.IdIngredient = si.IdIngredient AND s.IdSupplier = @IdSupplier
END
GO


CREATE PROC USP_GetListSupplierByIdIngredient
@IdIngredient INT
AS
BEGIN
	SELECT NameIngredient AS N'Tên Nguyên Liệu', NameSupplier AS N'Nhà Cung Cấp', Price AS N'Giá Tiền', i.IdIngredient, s.IdSupplier
	FROM Supplier AS s, Ingredient AS i, Supplier_Ingredient AS si
	WHERE s.IdSupplier = si.IdSupplier AND i.IdIngredient = si.IdIngredient AND i.IdIngredient = @IdIngredient
END
GO


CREATE PROC USP_GetListIngredientInStorage
AS
BEGIN
	SELECT i.IdIngredient AS N'Mã Nguyên Liệu', i.NameIngredient AS N'Tên Nguyên Liệu', Quantity AS N'Số lượng', Measure AS N'Đơn Vị Tính', DateIn AS N'Ngày Nhập', expiry as N'Hạn sử dụng',StatusStorage as N'Tình trạng'
	FROM Storage AS s, Ingredient AS i
	WHERE s.IdIngredient = i.IdIngredient
END
GO

CREATE PROC USP_GetListIngredientExpired
AS
BEGIN
	SELECT i.IdIngredient AS N'Mã Nguyên Liệu', i.NameIngredient AS N'Tên Nguyên Liệu', Quantity AS N'Số lượng', Measure AS N'Đơn Vị Tính', DateIn AS N'Ngày Nhập', expiry as N'Hạn sử dụng',StatusStorage as N'Tình trạng'
	FROM Storage AS s, Ingredient AS i
	WHERE s.IdIngredient = i.IdIngredient AND StatusStorage = N'Hết hạn'
END
GO

CREATE PROC USP_GetListIngredientOutOfStock
@Quantity INT
AS
BEGIN
	SELECT i.IdIngredient AS N'Mã Nguyên Liệu', i.NameIngredient AS N'Tên Nguyên Liệu', Quantity AS N'Số lượng', Measure AS N'Đơn Vị Tính', DateIn AS N'Ngày Nhập', expiry as N'Hạn sử dụng',StatusStorage as N'Tình trạng'
	FROM Storage AS s, Ingredient AS i
	WHERE s.IdIngredient = i.IdIngredient AND Quantity < @Quantity
END
GO

CREATE proc USP_UpdateStorage
as
	DECLARE @IdIngredient INT = 0
	WHILE @IdIngredient < 1000
	BEGIN
	SET @IdIngredient = @IdIngredient + 1
		DECLARE @Datein Date
		SELECT @Datein = Datein FROM dbo.Storage WHERE IdIngredient = @IdIngredient 
		Declare @Datenow int
		SELECT @Datenow = DATEDIFF (day,@Datein ,GETDATE());
		Declare @expiry int
		SELECT @expiry = expiry FROM dbo.Storage WHERE IdIngredient = @IdIngredient 
	if(@Datenow > @expiry)
		UPDATE dbo.Storage SET StatusStorage = N'Hết hạn', Quantity = 0 WHERE IdIngredient = @IdIngredient
	IF(@Datenow < @expiry)
		UPDATE dbo.Storage SET StatusStorage = N'Còn hạn' WHERE IdIngredient = @IdIngredient
	END;
GO

CREATE PROC USP_InsertFood
@NameFood NVARCHAR(100),
@IdFC INT,
@Price FLOAT,
@ImgFood image
AS
	BEGIN
		INSERT INTO dbo.Food VALUES(@NameFood,@IdFC,@Price,@ImgFood)
	END
GO
-- TRIGGER

CREATE TRIGGER UTG_UpdateBillDetail
ON dbo.BillDetail FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @IdBill INT
	SELECT @IdBill = IdBill FROM INSERTED
	DECLARE @IdTable INT
	SELECT @IdTable = IdTable FROM dbo.Bill WHERE IdBill = @IdBill AND StatusBill = 0

	UPDATE dbo.TableFood SET StatusTable = N'Có Người' WHERE IdTable = @IdTable
END
GO

CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @IdBill INT
	SELECT @IdBill = IdBill FROM INSERTED

	DECLARE @IdTable INT

	SELECT @IdTable = IdTable FROM dbo.Bill WHERE IdBill = @IdBill
	
	DECLARE @Count INT = 0

	SELECT @Count = COUNT(*) FROM dbo.Bill WHERE IdTable = @IdTable AND StatusBill = 0

	IF(@Count = 0)
		UPDATE dbo.TableFood SET StatusTable = N'Trống' WHERE IdTable = @IdTable
END
GO

CREATE TRIGGER UTG_UpdateQuantityIngredient
ON dbo.Bill_Ingredient FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @IdB_I INT
	SELECT @IdB_I = Max(IdB_I) FROM dbo.Bill_Ingredient

	DECLARE @Quantity INT
	DECLARE @IdIngredient INT
	DECLARE @Count INT = 0
	DECLARE @Status INT = 0
	DECLARE @i INT

	SELECT @Status = StatusBill FROM dbo.Bill_Ingredient WHERE IdB_I = @IdB_I

	SELECT @Count = Max(idBD_I) FROM dbo.BillDetail_Ingredient WHERE IdB_I = @IdB_I
	SELECT @i = Min(idBD_I) FROM dbo.BillDetail_Ingredient WHERE IdB_I = @IdB_I

	IF(@Status = 1)
	BEGIN
		WHILE(@i <= @Count)
		BEGIN
			SELECT @Quantity = Quantity FROM dbo.BillDetail_Ingredient WHERE IdBD_I = @i
			SELECT @IdIngredient = IdIngredient FROM dbo.BillDetail_Ingredient WHERE IdBD_I = @i
			UPDATE dbo.Storage SET Quantity = Quantity + @Quantity, DateIn = GETDATE() WHERE IdIngredient = @IdIngredient

			SET @i = @i + 1
		END
	END
END
GO

CREATE TRIGGER UTG_UpdateRevenue
ON dbo.Bill FOR Insert, UPDATE
AS
BEGIN
	DECLARE @IdBill INT
	SELECT @IdBill = IdBill FROM INSERTED 

	DECLARE @TotalPrice FLOAT
	SELECT @TotalPrice = TotalPrice FROM dbo.Bill WHERE IdBill = @IdBill

	DECLARE @DateMonth int
	SELECT @DateMonth = MONTH(GETDATE())

	DECLARE @DateYear int
	SELECT @DateYEAR = YEAR(GETDATE())

	DECLARE @Revenue Float
	SELECT @Revenue = Revenue FROM dbo.revenue Where NameMonth = @DateMonth and NameYear = @DateYEAR

	DECLARE @AddRevenue FLOAT
	SELECT @AddRevenue = @Revenue + @TotalPrice

	UPDATE dbo.Revenue SET revenue = @AddRevenue WHERE NameMonth = @DateMonth
END
GO


CREATE VIEW UV_Ingredient AS
SELECT * FROM INGREDIENT
GO

CREATE VIEW UV_Bill_Ingredient AS
SELECT * FROM Bill_Ingredient
GO

CREATE VIEW UV_BillDetail_Ingredient AS
SELECT * FROM BillDetail_Ingredient
GO

CREATE VIEW UV_Supplier_Ingredient AS
SELECT * FROM Supplier_Ingredient
GO

CREATE VIEW UV_Storage AS
SELECT * FROM STORAGE
GO

CREATE VIEW UV_Food AS
SELECT * FROM FOOD
GO


CREATE VIEW UV_TableFood AS
SELECT * FROM TableFood
GO




