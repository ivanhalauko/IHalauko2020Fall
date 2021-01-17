CREATE PROCEDURE [dbo].[DeleteExamStudResultsById]
	@Id int
AS
	DELETE FROM ExamStudResults WHERE Id=@Id
GO