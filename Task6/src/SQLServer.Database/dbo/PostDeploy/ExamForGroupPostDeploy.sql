CREATE PROCEDURE ExamForGroupPostDeploy
AS
if not exists (SELECT*FROM dbo.ExamForGroup WHERE 
IDExamTerm=1 and IDExam=3 and IDGroupe=1 and DateGroupeExam='10.4.2015')
begin
INSERT INTO ExamForGroup (IDExamTerm, IDExam, IDGroupe,DateGroupeExam) VALUES(1, 3, 1, '10.4.2015')
INSERT INTO ExamForGroup (IDExamTerm, IDExam, IDGroupe,DateGroupeExam) VALUES(2, 2, 2, '2015.10.5')
INSERT INTO ExamForGroup (IDExamTerm, IDExam, IDGroupe,DateGroupeExam) VALUES(3, 1, 3, '2015.10.2')
end
go
