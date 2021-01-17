CREATE PROCEDURE [dbo].[UpdateExamForGroup]
	@Id INT,
	@IDExamTerm INT,
	@IDExam INT,
	@IDGroupe INT,
	@DateGroupeExam date

AS
	UPDATE ExamForGroup
	SET IDExamTerm=@IDExamTerm,	IDExam=@IDExam, IDGroupe=@IDGroupe, 	DateGroupeExam=@DateGroupeExam
    WHERE Id=@Id
	SELECT* FROM ExamForGroup WHERE Id=@Id
GO
