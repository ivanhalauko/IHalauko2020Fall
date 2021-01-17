CREATE PROCEDURE [dbo].[AddExamForGroup]
	@IDExamTerm		INT,
	@IDExam			INT,
	@IDGroupe		INT,
	@DateGroupeExam	DATE
AS
	INSERT INTO ExamForGroup(IDExamTerm,IDExam,IDGroupe,DateGroupeExam)
	VALUES(@IDExamTerm,@IDExam,@IDGroupe,@DateGroupeExam)

	SELECT SCOPE_IDENTITY()
GO
