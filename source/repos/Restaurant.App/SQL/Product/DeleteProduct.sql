/* Check if procedure already exists */
IF OBJECT_ID('DeleteProduct', 'P') IS NOT NULL
BEGIN
   DROP PROCEDURE DeleteProduct
END
GO

CREATE PROCEDURE DeleteProduct @id INT
AS
BEGIN
	DELETE FROM [tblProducts] WHERE ProductID = @id
END

/* Use case scenario */
EXEC DeleteProduct @id = 0