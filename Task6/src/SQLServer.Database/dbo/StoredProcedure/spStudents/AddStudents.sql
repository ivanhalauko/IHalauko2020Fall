CREATE PROCEDURE [dbo].[AddStudents]
	@Name nvarchar(50),
	@Surname nvarchar(50),
	@Patronymic nvarchar(50),
	@BirthDate date,
	@IDGroupe int
AS
	INSERT INTO Students(Name, Surname, Patronymic, BirthDate, IDGroupe)
    VALUES (@Name, @Surname, @Patronymic, @BirthDate, @IDGroupe)
	SELECT SCOPE_IDENTITY()
GO
