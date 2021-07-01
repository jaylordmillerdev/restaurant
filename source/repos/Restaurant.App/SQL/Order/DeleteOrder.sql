/* Check if procedure already exists */
IF OBJECT_ID('DeleteOrder', 'P') IS NOT NULL
BEGIN
   DROP PROCEDURE DeleteOrder
END
GO

CREATE PROCEDURE DeleteOrder @Id INT
AS
BEGIN
	DELETE FROM [tblOrders] WHERE [Id] = @Id
END

/* Use case scenario */
EXEC DeleteOrder @id = 1