/* Check if procedure already exists */
IF OBJECT_ID('StoreOrder', 'P') IS NOT NULL
BEGIN
   DROP PROCEDURE StoreOrder
END
GO

CREATE PROCEDURE StoreOrder @CustomerId INT, @ProductId INT, @Quantity INT, @IsDelivered INT
AS
BEGIN
INSERT INTO [tblOrders] ([CustomerID], [ProductID], [Quantity], [IsDelivered]) VALUES (@CustomerId, @ProductId, @Quantity, @IsDelivered)
END

/* Use case scenario */
EXEC StoreOrder @CustomerId = 4, @ProductId = 4, @Quantity = 4, @IsDelivered = 0