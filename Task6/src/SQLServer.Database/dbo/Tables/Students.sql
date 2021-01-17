CREATE TABLE [dbo].[Students]
(
	[Id] INT IDENTITY(1,1)   PRIMARY KEY,
    [Name] NVARCHAR(50) NULL, 
    [Surname] NVARCHAR(50) NULL, 
    [Patronymic] NVARCHAR(50) NULL, 
    [BirthDate] DATE NULL, 
    [IDGroupe] INT NOT NULL, 
    CONSTRAINT [FK_Students_Groups] FOREIGN KEY ([IDGroupe]) REFERENCES [Groups]([Id]) 
)
