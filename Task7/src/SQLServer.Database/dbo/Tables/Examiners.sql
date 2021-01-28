CREATE TABLE [dbo].[Examiners]
(
	[Id] INT IDENTITY(1,1)	PRIMARY KEY,
    [Name] NVARCHAR(50) NOT NULL, 
    [Surname] NVARCHAR(50) NOT NULL, 
    [Patronymic] NVARCHAR(50) NOT NULL
)
