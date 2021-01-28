CREATE PROCEDURE ExamForGroupPostDeploy
AS
if not exists (SELECT*FROM dbo.ExamForGroup WHERE 
IDExamTerm=1) -- and IDSubjects=3 and IDGroupe=1 and DateGroupeExam='10.4.2015' and IdExaminers=0)
begin
INSERT INTO ExamForGroup (IDExamTerm, IDSubjects, IDGroupe,DateGroupeExam, IdExaminers) VALUES(1, 3, 1, '10.4.2015',1)
INSERT INTO ExamForGroup (IDExamTerm, IDSubjects, IDGroupe,DateGroupeExam, IdExaminers) VALUES(2, 2, 2, '2015.10.5',2)
INSERT INTO ExamForGroup (IDExamTerm, IDSubjects, IDGroupe,DateGroupeExam, IdExaminers) VALUES(3, 1, 3, '2015.10.2',3)
INSERT INTO ExamForGroup (IDExamTerm, IDSubjects, IDGroupe,DateGroupeExam, IdExaminers) VALUES(4, 1, 3, '2015.10.2',4)
end
go

