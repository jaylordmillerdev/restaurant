/* Check if procedure already exists */
IF OBJECT_ID('DeliverOrder', 'P') IS NOT NULL
BEGIN
   DROP PROCEDURE DeliverOrder
END
GO

CREATE PROCEDURE DeliverOrder @Id INT, @Quantity INT
AS
BEGIN
	UPDATE [tblOrders] SET [IsDelivered]=1 WHERE ID=@Id
	DECLARE @ProductId INT = (SELECT [ProductID] FROM [tblOrders] WHERE [ID] = @Id)
	UPDATE [tblProducts] SET [Quantity]=[Quantity]-@Quantity WHERE [ProductID]=@ProductId
END

/* Use case scenario */
EXEC DeliverOrder @Id = 2, @Quantity = 1