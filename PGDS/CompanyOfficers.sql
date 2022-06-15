CREATE TABLE [dbo].[CompanyOfficers]
(
	[CompanyOfficerId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CompanyOfficerIdentityNo] BIGINT NOT NULL, 
    [CompanyOfficerFirstName] NVARCHAR(50) NOT NULL, 
    [CompanyOfficerLastName] NVARCHAR(50) NOT NULL, 
    [CompanyOfficerTitle] NVARCHAR(50) NOT NULL
)
