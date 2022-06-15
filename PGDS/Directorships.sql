CREATE TABLE [dbo].[Directorships]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DirectorshipName] NVARCHAR(50) NOT NULL, 
    [DistrictId] INT NOT NULL, 
    CONSTRAINT [Directorships_Districts] FOREIGN KEY ([DistrictId]) REFERENCES [Districts]([Id])
)
