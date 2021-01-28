CREATE TABLE [dbo].[Specialties]
(
	[Id] INT IDENTITY(1,1)   PRIMARY KEY, 
    [NameOfSpecialty] NVARCHAR(50) NOT NULL, 
    [InfoOfSpecialty] NVARCHAR(MAX) NULL
)
