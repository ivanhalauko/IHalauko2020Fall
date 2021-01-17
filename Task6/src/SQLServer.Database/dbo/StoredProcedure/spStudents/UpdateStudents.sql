CREATE PROCEDURE [dbo].[UpdateStudents]
	@Id int,
	@Name nvarchar(50),
	@Surname nvarchar(50),
	@Patronymic nvarchar(50),
	@BirthDate date,
	@IDGroupe int
AS
	UPDATE Students
	SET Name=@Name, Surname=@Surname,Patronymic=@Patronymic, BirthDate=@BirthDate, IDGroupe=@IDGroupe
    WHERE Id=@Id
	SELECT* FROM Students WHERE Id=@Id
GO
