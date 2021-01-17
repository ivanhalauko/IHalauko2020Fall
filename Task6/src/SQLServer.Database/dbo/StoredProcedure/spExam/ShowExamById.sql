CREATE PROCEDURE [dbo].[ShowExamById]
	@Id INT
AS
	SELECT * FROM dbo.Exam WHERE Id=@Id
GO
