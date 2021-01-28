CREATE TABLE [dbo].[Groups]
(
	[Id] INT IDENTITY(1,1)   PRIMARY KEY,
    [GroupeName] NVARCHAR(50) NOT NULL, 
    [IDSpecialties] INT NOT NULL, 
    CONSTRAINT [FK_Groups_ToSpecialties] FOREIGN KEY ([IDSpecialties]) REFERENCES [Specialties]([Id])
)
