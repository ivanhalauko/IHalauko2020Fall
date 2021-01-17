CREATE PROCEDURE [dbo].[ShowExamForGroupById]
	@Id INT
AS
	SELECT * FROM dbo.ExamForGroup WHERE Id=@Id
GO
