CREATE TABLE [dbo].[SampleInfos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SampleInfoName] NVARCHAR(50) NOT NULL, 
    [SampleQuantity] INT NOT NULL, 
    [SampleStampNo] INT NOT NULL, 
    [ProductId] INT NOT NULL,
    CONSTRAINT [SampleInfos_Products] FOREIGN KEY ([ProductId]) REFERENCES [Products] ([ProductId]),
)
