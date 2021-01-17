CREATE PROCEDURE [dbo].[ShowExamStudResultsById]
	@Id int
AS
	SELECT * FROM dbo.ExamStudResults WHERE Id=@Id
GO

