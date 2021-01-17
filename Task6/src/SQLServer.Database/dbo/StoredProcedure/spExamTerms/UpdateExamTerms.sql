CREATE PROCEDURE [dbo].[UpdateExamTerms]
	@Id INT,
	@ExamTermName nvarchar(50)
AS
	UPDATE ExamTerms
	SET ExamTermName=@ExamTermName
    WHERE Id=@Id
	SELECT* FROM ExamTerms WHERE Id=@Id
GO
