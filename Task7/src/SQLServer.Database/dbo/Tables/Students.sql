CREATE TABLE [dbo].[Students]
(
	[Id] INT IDENTITY(1,1)   PRIMARY KEY,
    [Name] NVARCHAR(50) NOT NULL, 
    [Surname] NVARCHAR(50) NOT NULL, 
    [Patronymic] NVARCHAR(50) NOT NULL, 
    [BirthDate] DATE NOT NULL, 
    [IDGroupe] INT NOT NULL, 
    CONSTRAINT [FK_Students_Groups] FOREIGN KEY ([IDGroupe]) REFERENCES [Groups]([Id]) 
)
