/* Check if procedure already exists */
IF OBJECT_ID('FilterByDate', 'P') IS NOT NULL
BEGIN
   DROP PROCEDURE FilterByDate
END
GO

CREATE PROCEDURE FilterByDate @StartDate VARCHAR(100), @EndDate VARCHAR(100)
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
  JOIN [tblCustomer] AS C ON O.[CustomerID] = C.[ID] WHERE (O.[DateCreated] BETWEEN @StartDate AND @EndDate)  ORDER BY O.[DateCreated]
END

/* Use case scenario */
EXEC FilterByDate @StartDate = '2021-07-01', @EndDate = '2021-07-02' 