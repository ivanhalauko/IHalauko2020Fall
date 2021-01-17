CREATE TABLE [dbo].[ExamForGroup]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IDExamTerm] INT NULL, 
    [IDExam] INT NULL, 
    [IDGroupe] INT NULL, 
    [DateGroupeExam] DATE NULL, 
    CONSTRAINT [FK_ExamForGroup_ExamTerms] FOREIGN KEY ([IDExamTerm]) REFERENCES [ExamTerms]([Id]), 
    CONSTRAINT [FK_ExamForGroup_Exam] FOREIGN KEY ([IDExam]) REFERENCES [Exam]([Id]), 
    CONSTRAINT [FK_ExamForGroup_Groupe] FOREIGN KEY ([IDGroupe]) REFERENCES [Groups]([Id])
)
