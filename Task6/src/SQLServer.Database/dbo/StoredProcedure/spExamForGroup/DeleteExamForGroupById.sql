CREATE PROCEDURE [dbo].[DeleteExamForGroupById]
	@Id int
AS
	DELETE FROM ExamForGroup
	WHERE Id=@Id
GO
