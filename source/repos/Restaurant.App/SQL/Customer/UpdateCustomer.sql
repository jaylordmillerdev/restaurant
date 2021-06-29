/* Check if procedure already exists */
IF OBJECT_ID('UpdateCustomer', 'P') IS NOT NULL
BEGIN
   DROP PROCEDURE UpdateCustomer
END
GO

CREATE PROCEDURE UpdateCustomer @id INT, @Firstname VARCHAR(255), @Lastname VARCHAR(255), @Address VARCHAR(255)
AS
BEGIN
	UPDATE [tblCustomer] SET [Firstname]=@Firstname, [Lastname]=@Lastname, [Address]=@Address WHERE ID=@id 
END