USE restaurant;

/* Check if procedure already exists */
IF OBJECT_ID('GenerateRequiredTable', 'P') IS NOT NULL
BEGIN
   DROP PROCEDURE GenerateRequiredTable
END
GO

CREATE PROCEDURE GenerateRequiredTable
AS
/* Generate table for products */
CREATE TABLE tblProducts (
    [ProductID] INT IDENTITY(1,1) PRIMARY KEY,
    [Name] VARCHAR(255),
    [Quantity] INT,
	[Price] decimal(19,4),
	[DateCreated] DATE default CURRENT_TIMESTAMP
);
/* Generate table for orders */
CREATE TABLE tblOrders (
    [ID] INT IDENTITY(1,1) PRIMARY KEY,
    [CustomerID] INT,
    [ProductID] INT,
	[DateCreated] DATE default CURRENT_TIMESTAMP,
    [Quantity] INT,
    [IsDelivered] SMALLINT,
);
/* Generate table for customer */
CREATE TABLE tblCustomer (
    [ID] int IDENTITY(1,1) PRIMARY KEY,
	[Firstname] VARCHAR(255),
	[Lastname] VARCHAR(255),
	[Address] VARCHAR(255),
	[DateCreated] DATE default CURRENT_TIMESTAMP
);

EXEC GenerateRequiredTable;