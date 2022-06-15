CREATE TABLE [dbo].[InspectionServices]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [InspectionServiceName] NVARCHAR(50) NOT NULL, 
    [DistrictId] INT NOT NULL, 
    [DirectorshipId] INT NOT NULL, 
    CONSTRAINT [InspectionServices_Districts] FOREIGN KEY ([DistrictId]) REFERENCES [Districts]([Id]),
    CONSTRAINT [InspectionServices_Directorships] FOREIGN KEY ([DirectorshipId]) REFERENCES [Directorships]([Id])
)
