CREATE PROCEDURE [dbo].[DeleteExamTermsById]
	@Id INT
AS
	DELETE FROM dbo.ExamTerms WHERE Id=@Id
GO
