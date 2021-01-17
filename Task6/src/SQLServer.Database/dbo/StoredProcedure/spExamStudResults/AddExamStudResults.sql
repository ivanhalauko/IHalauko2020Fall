CREATE PROCEDURE [dbo].[AddExamStudResults]
	@IDStudent INT,
	@IDExamForGroupe INT,
	@Rating INT
AS
	INSERT INTO ExamStudResults(IDStudent,IDExamForGroupe,Rating)
	VALUES(@IDStudent,@IDExamForGroupe,@Rating)
	
	SELECT SCOPE_IDENTITY()
GO