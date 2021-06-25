/* Check if procedure already exists */
IF OBJECT_ID('StoreCustomer', 'P') IS NOT NULL
BEGIN
   DROP PROCEDURE StoreCustomer
END
GO

CREATE PROCEDURE GenerateRequiredTable @Firstname VARCHAR(255), @Lastname VARCHAR(255), @Address VARCHAR(255), @DateCreated DATE
AS
BEGIN
INSERT INTO [tblCustomer] ( [Firstname], [Lastname], [Address], [DateCreated] VALUES (@Firstname, @Lastname, @Address, @DateCreated))
END