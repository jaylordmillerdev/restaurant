/* Check if procedure already exists */
IF OBJECT_ID('FilterProductByName', 'P') IS NOT NULL
BEGIN
   DROP PROCEDURE FilterProductByName
END
GO

CREATE PROCEDURE FilterProductByName @ProductName VARCHAR(255)
AS
BEGIN
SELECT [ProductID],
	   [Name],
	   [Quantity],
	   [Price],
	   [DateCreated]
  FROM [restaurant].[dbo].[tblProducts] WHERE [NAME] LIKE '%'+@ProductName+'%' ORDER BY [Name]

END

/* Use case scenario */
EXEC FilterProductByName @ProductName = 'Test';