CREATE PROCEDURE [dbo].[AddExam]
	@ExamName nvarchar(50)
AS
	INSERT INTO Exam(ExamName)
	VALUES (@ExamName)

	SELECT SCOPE_IDENTITY()
GO