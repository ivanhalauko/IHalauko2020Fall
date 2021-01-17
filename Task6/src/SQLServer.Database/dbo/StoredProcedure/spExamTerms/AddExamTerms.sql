CREATE PROCEDURE [dbo].[AddExamTerms]
	@ExamTermName nvarchar(50)
AS
	INSERT INTO ExamTerms(ExamTermName)
	VALUES(@ExamTermName)

	SELECT SCOPE_IDENTITY()
GO
