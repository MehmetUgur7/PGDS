CREATE TABLE [dbo].[Products]
(
	[ProductId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CategoryId] INT NOT NULL, 
    [Barcode] BIGINT NOT NULL, 
    [Brand] NVARCHAR(50) NOT NULL, 
    [Model] NVARCHAR(50) NOT NULL, 
    [BatchNo] INT NOT NULL, 
    [InvoiceDate] DATETIME NULL, 
    [InvoiceNo] NVARCHAR(50) NULL, 
    [Origin] NVARCHAR(50) NOT NULL, 
    [UnitPrice] MONEY NOT NULL, 
    [InspectedBatchQuantity] INT NOT NULL, 
    [InspectedQuantity] INT NOT NULL, 
    [InvoiceQuantity] INT NULL, 
    [RelatedRegulationId] INT NOT NULL,
    CONSTRAINT [Products_Categories] FOREIGN KEY ([CategoryID]) REFERENCES [Categories] ([CategoryID]),
)
