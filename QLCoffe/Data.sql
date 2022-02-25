CREATE DATABASE [Coffee]
GO

USE [Coffee]
GO

CREATE FUNCTION [fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO

CREATE TABLE [Account]
(
	[UserName] nvarchar(100) NOT NULL,
	[DisplayName] nvarchar(100) NOT NULL,
	[PassWord] nvarchar(1000) NOT NULL,
	[Type] int NOT NULL,
	PRIMARY KEY([UserName])
)
GO

CREATE TABLE [Bill]
(
	[id] int IDENTITY(1,1) NOT NULL,
	[DateCheckIn] datetime NOT NULL,
	[DateCheckOut] datetime NULL,
	[idTable] int NOT NULL,
	[status] int NOT NULL,
	[totalPrice] int NULL,
	[Cashier] nvarchar(100) NULL,
	PRIMARY KEY([id]) 
)
GO

CREATE TABLE [BillInfo]
(
	[id] int IDENTITY(1,1) NOT NULL,
	[idBill] int NOT NULL,
	[idFood] int NOT NULL,
	[count] int NOT NULL,
	PRIMARY KEY([id])
) 
GO

CREATE TABLE [Food]
(
	[id] int IDENTITY(1,1) NOT NULL,
	[name] nvarchar(100) NOT NULL,
	[idCategory] int NOT NULL,
	[price] float NOT NULL,
	PRIMARY KEY([id])
) 
GO

CREATE TABLE [FoodCategory]
(
	[id] int IDENTITY(1,1) NOT NULL,
	[name] nvarchar(100) NOT NULL,
	PRIMARY KEY([id])
)
GO

CREATE TABLE [TableFood]
(
	[id] int IDENTITY(1,1) NOT NULL,
	[name] nvarchar(100) NOT NULL,
	[status] nvarchar(100) NOT NULL,
	PRIMARY KEY([id])
)
GO

INSERT INTO [Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'admin', N'Chủ quán', N'123', 1)
INSERT INTO [Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'staff1', N'Nhân viên 1', N'123', 0)
INSERT INTO [Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'staff2', N'Nhân viên 2', N'123', 0)
SET IDENTITY_INSERT [Bill] ON 

INSERT INTO [Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [totalPrice], [Cashier]) VALUES (1, CAST(N'2021-09-27T10:18:47.790' AS DateTime), CAST(N'2021-09-27T10:20:08.670' AS DateTime), 2, 1, 124000, N'admin')
INSERT INTO [Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [totalPrice], [Cashier]) VALUES (2, CAST(N'2021-09-27T10:33:33.500' AS DateTime), CAST(N'2021-09-27T10:33:38.350' AS DateTime), 2, 1, 100000, N'staff1')
INSERT INTO [Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [totalPrice], [Cashier]) VALUES (3, CAST(N'2021-09-27T10:33:41.813' AS DateTime), CAST(N'2021-09-27T10:33:47.390' AS DateTime), 12, 1, 126000, N'staff1')
INSERT INTO [Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [totalPrice], [Cashier]) VALUES (4, CAST(N'2021-09-27T10:34:00.987' AS DateTime), CAST(N'2021-09-27T10:34:06.367' AS DateTime), 10, 1, 166000, N'staff2')
INSERT INTO [Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [totalPrice], [Cashier]) VALUES (5, CAST(N'2021-09-27T10:51:09.957' AS DateTime), CAST(N'2021-09-27T10:51:15.760' AS DateTime), 8, 1, 126000, N'admin')
INSERT INTO [Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [totalPrice], [Cashier]) VALUES (6, CAST(N'2021-09-27T11:22:01.103' AS DateTime), CAST(N'2021-09-27T11:22:07.707' AS DateTime), 12, 1, 505000, N'admin')
INSERT INTO [Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [totalPrice], [Cashier]) VALUES (7, CAST(N'2021-09-27T11:38:49.283' AS DateTime), CAST(N'2021-09-27T11:39:01.737' AS DateTime), 7, 1, 200000, N'admin')
INSERT INTO [Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [totalPrice], [Cashier]) VALUES (8, CAST(N'2021-09-27T12:15:22.857' AS DateTime), CAST(N'2021-09-27T12:15:30.953' AS DateTime), 1, 1, 250000, N'admin')
INSERT INTO [Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [totalPrice], [Cashier]) VALUES (9, CAST(N'2021-09-27T12:30:11.800' AS DateTime), CAST(N'2021-10-01T09:52:43.983' AS DateTime), 1, 1, 22000, N'admin')
INSERT INTO [Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [totalPrice], [Cashier]) VALUES (10, CAST(N'2021-09-28T23:18:50.197' AS DateTime), CAST(N'2021-10-01T09:42:53.047' AS DateTime), 7, 1, 102000, N'admin')
SET IDENTITY_INSERT [Bill] OFF
SET IDENTITY_INSERT [BillInfo] ON 

INSERT INTO [BillInfo] ([id], [idBill], [idFood], [count]) VALUES (1, 1, 1, 2)
INSERT INTO [BillInfo] ([id], [idBill], [idFood], [count]) VALUES (2, 1, 5, 1)
INSERT INTO [BillInfo] ([id], [idBill], [idFood], [count]) VALUES (3, 2, 2, 5)
INSERT INTO [BillInfo] ([id], [idBill], [idFood], [count]) VALUES (4, 3, 5, 3)
INSERT INTO [BillInfo] ([id], [idBill], [idFood], [count]) VALUES (5, 3, 6, 2)
INSERT INTO [BillInfo] ([id], [idBill], [idFood], [count]) VALUES (6, 4, 10, 3)
INSERT INTO [BillInfo] ([id], [idBill], [idFood], [count]) VALUES (7, 4, 14, 1)
INSERT INTO [BillInfo] ([id], [idBill], [idFood], [count]) VALUES (8, 4, 7, 1)
INSERT INTO [BillInfo] ([id], [idBill], [idFood], [count]) VALUES (9, 5, 11, 3)
INSERT INTO [BillInfo] ([id], [idBill], [idFood], [count]) VALUES (10, 5, 15, 3)
INSERT INTO [BillInfo] ([id], [idBill], [idFood], [count]) VALUES (11, 6, 3, 5)
INSERT INTO [BillInfo] ([id], [idBill], [idFood], [count]) VALUES (12, 6, 5, 3)
INSERT INTO [BillInfo] ([id], [idBill], [idFood], [count]) VALUES (13, 6, 4, 2)
INSERT INTO [BillInfo] ([id], [idBill], [idFood], [count]) VALUES (14, 7, 22, 2)
INSERT INTO [BillInfo] ([id], [idBill], [idFood], [count]) VALUES (15, 7, 23, 2)
INSERT INTO [BillInfo] ([id], [idBill], [idFood], [count]) VALUES (16, 7, 24, 1)
INSERT INTO [BillInfo] ([id], [idBill], [idFood], [count]) VALUES (17, 8, 22, 1)
INSERT INTO [BillInfo] ([id], [idBill], [idFood], [count]) VALUES (18, 8, 24, 1)
INSERT INTO [BillInfo] ([id], [idBill], [idFood], [count]) VALUES (19, 8, 15, 1)
INSERT INTO [BillInfo] ([id], [idBill], [idFood], [count]) VALUES (20, 8, 20, 1)
INSERT INTO [BillInfo] ([id], [idBill], [idFood], [count]) VALUES (21, 9, 21, 1)
INSERT INTO [BillInfo] ([id], [idBill], [idFood], [count]) VALUES (22, 10, 21, 1)
INSERT INTO [BillInfo] ([id], [idBill], [idFood], [count]) VALUES (23, 10, 22, 4)
SET IDENTITY_INSERT [BillInfo] OFF
SET IDENTITY_INSERT [Food] ON 

INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (1, N'Phở bò', 1, 25000)
INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (2, N'Hủ tiếu', 1, 25000)
INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (3, N'Bánh canh', 1, 25000)
INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (4, N'Bò né', 1, 25000)
INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (5, N'Cà phê đá', 2, 18000)
INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (6, N'Cà phê sữa', 2, 20000)
INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (7, N'Espresso', 2, 30000)
INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (8, N'Cappuccino', 2, 30000)
INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (9, N'Trà sữa truyền thống', 3, 20000)
INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (10, N'Trà sữa Matcha', 3, 25000)
INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (11, N'Trà sữa Chocolate', 3, 25000)
INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (12, N'Sinh tố bơ', 4, 20000)
INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (13, N'Sinh tố dưa hấu', 4, 20000)
INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (14, N'Sinh tố dứa', 4, 20000)
INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (15, N'Sinh tố sa bô', 4, 20000)
INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (16, N'Đá xay Oreo', 5, 25000)
INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (17, N'Đá xay việt quất', 5, 25000)
INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (18, N'Cafe đá xay', 5, 20000)
INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (19, N'Nước cam ép', 6, 23000)
INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (20, N'Nước ổi ép', 6, 23000)
INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (21, N'Nước táo ép', 6, 23000)
INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (22, N'7 Up', 7, 15000)
INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (23, N'Pesi', 7, 15000)
INSERT INTO [Food] ([id], [name], [idCategory], [price]) VALUES (24, N'Bò húc', 7, 15000)
SET IDENTITY_INSERT [Food] OFF
SET IDENTITY_INSERT [FoodCategory] ON 

INSERT INTO [FoodCategory] ([id], [name]) VALUES (1, N'Điểm tâm')
INSERT INTO [FoodCategory] ([id], [name]) VALUES (2, N'Cà phê')
INSERT INTO [FoodCategory] ([id], [name]) VALUES (3, N'Trà sữa')
INSERT INTO [FoodCategory] ([id], [name]) VALUES (4, N'Sinh tố')
INSERT INTO [FoodCategory] ([id], [name]) VALUES (5, N'Đá xay')
INSERT INTO [FoodCategory] ([id], [name]) VALUES (6, N'Nước ép')
INSERT INTO [FoodCategory] ([id], [name]) VALUES (7, N'Nước ngọt')
SET IDENTITY_INSERT [FoodCategory] OFF
SET IDENTITY_INSERT [TableFood] ON

INSERT INTO [TableFood] ([id], [name], [status]) VALUES (1, N'Bàn 01', N'Trống')
INSERT INTO [TableFood] ([id], [name], [status]) VALUES (2, N'Bàn 02', N'Trống')
INSERT INTO [TableFood] ([id], [name], [status]) VALUES (3, N'Bàn 03', N'Trống')
INSERT INTO [TableFood] ([id], [name], [status]) VALUES (4, N'Bàn 04', N'Trống')
INSERT INTO [TableFood] ([id], [name], [status]) VALUES (5, N'Bàn 05', N'Trống')
INSERT INTO [TableFood] ([id], [name], [status]) VALUES (6, N'Bàn 06', N'Có người')
INSERT INTO [TableFood] ([id], [name], [status]) VALUES (7, N'Bàn 07', N'Trống')
INSERT INTO [TableFood] ([id], [name], [status]) VALUES (8, N'Bàn 08', N'Trống')
INSERT INTO [TableFood] ([id], [name], [status]) VALUES (9, N'Bàn 09', N'Trống')
INSERT INTO [TableFood] ([id], [name], [status]) VALUES (10, N'Bàn 10', N'Trống')
INSERT INTO [TableFood] ([id], [name], [status]) VALUES (11, N'Bàn 11', N'Trống')
INSERT INTO [TableFood] ([id], [name], [status]) VALUES (12, N'Bàn 12', N'Trống')
INSERT INTO [TableFood] ([id], [name], [status]) VALUES (13, N'Bàn 13', N'Trống')
INSERT INTO [TableFood] ([id], [name], [status]) VALUES (14, N'Bàn 14', N'Trống')
INSERT INTO [TableFood] ([id], [name], [status]) VALUES (15, N'Bàn 15', N'Trống')
SET IDENTITY_INSERT [TableFood] OFF
SET ANSI_PADDING ON
GO

CREATE UNIQUE NONCLUSTERED INDEX [name] ON [TableFood]
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

ALTER TABLE [Account] ADD  DEFAULT ((0)) FOR [PassWord]
GO

ALTER TABLE [Account] ADD  DEFAULT ((0)) FOR [Type]
GO

ALTER TABLE [Bill] ADD  DEFAULT (getdate()) FOR [DateCheckIn]
GO

ALTER TABLE [Bill] ADD  DEFAULT ((0)) FOR [status]
GO

ALTER TABLE [BillInfo] ADD  DEFAULT ((0)) FOR [count]
GO

ALTER TABLE [Food] ADD  DEFAULT (N'Chưa đặt tên') FOR [name]
GO

ALTER TABLE [Food] ADD  DEFAULT ((0)) FOR [price]
GO

ALTER TABLE [FoodCategory] ADD  DEFAULT (N'Chưa đặt tên') FOR [name]
GO

ALTER TABLE [TableFood] ADD  DEFAULT (N'Bàn chưa có tên') FOR [name]
GO

ALTER TABLE [TableFood] ADD  DEFAULT (N'Trống') FOR [status]
GO

ALTER TABLE [Bill]  WITH CHECK ADD FOREIGN KEY([Cashier])
REFERENCES [Account] ([UserName])
GO

ALTER TABLE [Bill]  WITH CHECK ADD FOREIGN KEY([idTable])
REFERENCES [TableFood] ([id])
GO

ALTER TABLE [BillInfo]  WITH CHECK ADD FOREIGN KEY([idBill])
REFERENCES [Bill] ([id])
GO

ALTER TABLE [BillInfo]  WITH CHECK ADD FOREIGN KEY([idFood])
REFERENCES [Food] ([id])
GO

ALTER TABLE [Food]  WITH CHECK ADD FOREIGN KEY([idCategory])
REFERENCES [FoodCategory] ([id])
GO

CREATE PROC [USP_GetTableList]
AS SELECT * FROM dbo.TableFood
GO

CREATE PROC [USP_InsertBill]
@idTable INT
AS
BEGIN
	INSERT dbo.Bill 
	        ( DateCheckIn ,
	          DateCheckOut ,
	          idTable ,
	          status
	        )
	VALUES  ( GETDATE() , -- DateCheckIn - date
	          NULL , -- DateCheckOut - date
	          @idTable , -- idTable - int
	          0  -- status - int
	        )
END
GO

CREATE PROC [USP_InsertBillInfo]
@idBill INT, @idFood INT, @count INT
AS
BEGIN

	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1
	
	SELECT @isExitsBillInfo = id, @foodCount = b.count 
	FROM dbo.BillInfo AS b 
	WHERE idBill = @idBill AND idFood = @idFood

	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE dbo.BillInfo	SET count = @foodCount + @count WHERE idFood = @idFood AND idBill = @idBill
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT	dbo.BillInfo
        ( idBill, idFood, count )
		VALUES  ( @idBill, -- idBill - int
          @idFood, -- idFood - int
          @count  -- count - int
          )
	END
END
GO

CREATE PROC [USP_Login](@id nvarchar(100), @pass nvarchar(100))
AS
BEGIN
	SELECT * FROM Account WHERE Account.UserName = @id AND Account.PassWord = @pass
END
GO

CREATE PROC [USP_Recipe](@idBill nvarchar(100))
AS
BEGIN
SELECT TableFood.name, Food.name, BillInfo.count, Food.price, BillInfo.count*Food.price, Account.DisplayName, Bill.totalPrice, Bill.DateCheckIn, Bill.DateCheckOut
FROM Bill, BillInfo, Food, TableFood, Account
WHERE
	Bill.id = BillInfo.idBill AND 
	BillInfo.idFood=Food.id AND 
	Bill.idTable = TableFood.id  AND
	Bill.Cashier = Account.UserName AND
	Bill.id = @idBill
END
GO

CREATE PROC [USP_Report]
	(
	@dateFrom Datetime,
	@dateTo Datetime
	)
AS
	BEGIN
		SELECT c.name , SUM(b.count) , FORMAT(c.price, '#,### VNĐ'), FORMAT(SUM(b.count) * c.price, '#,### VNĐ')
		FROM Bill a, BillInfo b, Food c 
		WHERE a.id = b.idBill AND 
			b.idFood = c.id AND 
			DateCheckIn >= @dateFrom AND 
			DateCheckOut <= @dateTo
		GROUP BY c.name, c.price 
		ORDER BY c.name 
	END
GO

ALTER DATABASE [Coffee] SET  READ_WRITE 
GO