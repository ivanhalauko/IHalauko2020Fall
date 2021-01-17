CREATE PROCEDURE [dbo].[ShowExamTermsById]
	@Id INT
AS
	SELECT * FROM dbo.ExamTerms WHERE Id=@Id
GO

