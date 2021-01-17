CREATE PROCEDURE [dbo].[UpdateExam]
	@Id INT,
	@ExamName nvarchar(50)
AS
	UPDATE Exam
	SET ExamName=@ExamName
    WHERE Id=@Id
	SELECT* FROM Exam WHERE Id=@Id
GO
