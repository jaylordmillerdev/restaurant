/* Check if procedure already exists */
IF OBJECT_ID('FetchAllProduct', 'P') IS NOT NULL
BEGIN
   DROP PROCEDURE FetchAllProduct
END
GO

CREATE PROCEDURE FetchAllProduct
AS
BEGIN
SELECT [ProductID],
	   [Name],
	   [Quantity],
	   [Price],
	   [DateCreated]
  FROM [restaurant].[dbo].[tblProducts] ORDER BY [Name]

END

/* Use case scenario */
EXEC FetchAllProduct;