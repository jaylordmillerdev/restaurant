/* Check if procedure already exists */
IF OBJECT_ID('StoreProduct', 'P') IS NOT NULL
BEGIN
   DROP PROCEDURE StoreProduct
END
GO

CREATE PROCEDURE StoreProduct @Name VARCHAR(255), @Quantity INT, @Price DECIMAL
AS
BEGIN
INSERT INTO [tblProducts] ( [Name], [Quantity], [Price]) VALUES (@Name, @Quantity, @Price)
END

/* Use case scenario */
EXEC StoreProduct @Name = 'Test name', @Quantity = 10, @Price = 10.0