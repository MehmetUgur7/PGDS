CREATE TABLE [dbo].[Companies]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CompanyTypeId] INT NOT NULL, 
    [CompanyName] NVARCHAR(250) NOT NULL, 
    [CompanyFiscalNumber] BIGINT NOT NULL, 
    [Address] NVARCHAR(250) NOT NULL, 
    [PhoneNumber] NVARCHAR(50) NOT NULL, 
    [City] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [Companies_CompanyTypes] FOREIGN KEY ([CompanyTypeId]) REFERENCES [CompanyTypes]([CompanyTypeId])
)
