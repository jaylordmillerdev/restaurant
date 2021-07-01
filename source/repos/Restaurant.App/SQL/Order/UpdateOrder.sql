/* Check if procedure already exists */
IF OBJECT_ID('UpdateOrder', 'P') IS NOT NULL
BEGIN
   DROP PROCEDURE UpdateOrder
END
GO

CREATE PROCEDURE UpdateOrder @CustomerId INT, @ProductId INT, @Quantity INT, @IsDelivered INT, @Id INT
AS
BEGIN
	UPDATE [tblOrders] SET [CustomerID]=@CustomerId, [ProductID]=@ProductId, @Quantity=[Quantity], [IsDelivered]=@IsDelivered WHERE ID=@Id 
END

/* Use case scenario */
EXEC UpdateOrder @CustomerId = 0, @ProductId = 0, @Quantity = 10, @IsDelivered = 1, @Id = 1