/* Check if procedure already exists */
IF OBJECT_ID('GetUndeliverCount', 'P') IS NOT NULL
BEGIN
   DROP PROCEDURE GetUndeliverCount
END
GO

CREATE PROCEDURE GetUndeliverCount
AS
BEGIN
	SELECT COUNT(*) AS Undelivered FROM [tblOrders] WHERE [IsDelivered] = 0;
END

/* Use case scenario */
EXEC GetUndeliverCount