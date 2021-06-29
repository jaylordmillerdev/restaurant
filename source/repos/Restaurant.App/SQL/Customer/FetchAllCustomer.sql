/* Check if procedure already exists */
IF OBJECT_ID('FetchAllCustomer', 'P') IS NOT NULL
BEGIN
   DROP PROCEDURE FetchAllCustomer
END
GO

CREATE PROCEDURE FetchAllCustomer
AS
BEGIN
SELECT [ID]
      ,[Firstname]
      ,[Lastname]
      ,[Address]
      ,[DateCreated]
  FROM [restaurant].[dbo].[tblCustomer] ORDER BY [Firstname]

END

EXEC FetchAllCustomer;