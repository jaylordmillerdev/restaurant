/* Check if procedure already exists */
IF OBJECT_ID('DeleteCustomer', 'P') IS NOT NULL
BEGIN
   DROP PROCEDURE DeleteCustomer
END
GO

CREATE PROCEDURE DeleteCustomer @id INT
AS
BEGIN
	DELETE FROM [tblCustomer] WHERE ID = @id
END

EXEC DeleteCustomer @id = 1