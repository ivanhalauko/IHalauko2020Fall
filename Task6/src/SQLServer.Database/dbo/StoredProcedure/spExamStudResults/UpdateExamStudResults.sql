CREATE PROCEDURE [dbo].[UpdateExamStudResults]
	@Id INT,
	@IDStudent INT,
	@IDExamForGroupe INT,
	@Rating INT
AS
	UPDATE ExamStudResults
	SET IDStudent=@IDStudent, IDExamForGroupe=@IDExamForGroupe, Rating=@Rating
    WHERE Id=@Id
	SELECT* FROM ExamStudResults WHERE Id=@Id
GO
