/* Check if procedure already exists */
IF OBJECT_ID('FetchAllOrder', 'P') IS NOT NULL
BEGIN
   DROP PROCEDURE FetchAllOrder
END
GO

CREATE PROCEDURE FetchAllOrder
AS
BEGIN
SELECT O.[ID],
	   O.[CustomerID],
	   O.[ProductID],
	   O.[DateCreated] AS [OrderCreated],
	   O.[Quantity] AS [OrderQuantity],
	   O.[IsDelivered],
	   P.[Name] AS [ProductName],
	   P.[Price],
	   C.[Firstname] AS [CustomerFirstname],
	   C.[Lastname] AS [CustomerLastname],
	   C.[Address] AS [CustomerAddress]
  FROM [restaurant].[dbo].[tblOrders] AS O JOIN [tblProducts] AS P ON O.[ProductID] = P.[ProductID] 
  JOIN [tblCustomer] AS C ON O.[CustomerID] = C.[ID] ORDER BY O.[DateCreated]
END

/* Use case scenario */
EXEC FetchAllOrder;