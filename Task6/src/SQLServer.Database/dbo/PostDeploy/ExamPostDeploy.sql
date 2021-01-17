CREATE PROCEDURE ExamPostDeploy
AS
IF not exists (SELECT * from dbo.Exam WHERE ExamName='Phisics')
begin
INSERT INTO Exam(ExamName) VALUES('Phisics')
INSERT INTO Exam(ExamName) VALUES('Chemist')
INSERT INTO Exam(ExamName) VALUES('Math')
INSERT INTO Exam(ExamName) VALUES('English')
end
GO