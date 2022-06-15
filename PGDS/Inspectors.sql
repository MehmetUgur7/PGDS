﻿CREATE TABLE [dbo].[Inspectors]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdentityNo] BIGINT NOT NULL, 
    [RegisterNo] BIGINT NOT NULL, 
    [InspectorFirstName] NVARCHAR(50) NOT NULL, 
    [InspectorLastName] NVARCHAR(50) NOT NULL, 
    [TitleName] NVARCHAR(50) NOT NULL, 
    [DistrictId] INT NOT NULL, 
    [DirectorshipId] INT NOT NULL, 
    [InspectionServiceId] INT NOT NULL,
    CONSTRAINT [Inspectors_Districts] FOREIGN KEY ([DistrictId]) REFERENCES [Districts]([Id]),
    CONSTRAINT [Inspectors_Directorships] FOREIGN KEY ([DirectorshipId]) REFERENCES [Directorships]([Id]),
    CONSTRAINT [Inspectors_InspectionServices] FOREIGN KEY ([InspectionServiceId]) REFERENCES [InspectionServices]([Id])
)
