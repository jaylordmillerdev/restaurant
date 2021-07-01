/* Check if procedure already exists */
IF OBJECT_ID('UpdateProduct', 'P') IS NOT NULL
BEGIN
   DROP PROCEDURE UpdateProduct
END
GO

CREATE PROCEDURE UpdateProduct @Name VARCHAR(255), @Quantity INT, @Price DECIMAL, @Id INT
AS
BEGIN
	UPDATE [tblProducts] SET [Name]=@Name, [Quantity]=@Quantity, [Price]=@Price WHERE ProductID=@Id 
END

/* Use case scenario */
EXEC UpdateProduct @Name = 'Test New name', @Quantity = 4, @Price = 20.0, @Id = 2