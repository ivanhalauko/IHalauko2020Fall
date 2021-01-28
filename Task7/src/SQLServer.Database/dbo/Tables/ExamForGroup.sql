CREATE TABLE [dbo].[ExamForGroup]
(
	[Id] INT IDENTITY(1,1)   PRIMARY KEY,
    [IDExamTerm] INT NOT NULL, 
    [IDSubjects] INT NOT NULL, 
    [IDGroupe] INT NOT NULL, 
    [DateGroupeExam] DATE NOT NULL, 
    [IdExaminers] INT NOT NULL, 
    CONSTRAINT [FK_ExamForGroup_ExamTerms] FOREIGN KEY ([IDExamTerm]) REFERENCES [ExamTerms]([Id]), 
    CONSTRAINT [FK_ExamForGroup_Subjects] FOREIGN KEY ([IDSubjects]) REFERENCES [Subjects]([Id]), 
    CONSTRAINT [FK_ExamForGroup_Groupe] FOREIGN KEY ([IDGroupe]) REFERENCES [Groups]([Id]), 
    CONSTRAINT [FK_ExamForGroup_ToExaminers] FOREIGN KEY ([IdExaminers]) REFERENCES [Examiners]([Id])
)
