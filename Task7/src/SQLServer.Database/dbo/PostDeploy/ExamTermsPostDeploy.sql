/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
CREATE PROCEDURE ExamTermsPostDeploy
AS
IF not Exists(Select *from dbo.ExamTerms where ExamTermName='First session')
begin
INSERT INTO ExamTerms(ExamTermName) VALUES('First session')
INSERT INTO ExamTerms(ExamTermName) VALUES('Second session')
INSERT INTO ExamTerms(ExamTermName) VALUES('Third session')
INSERT INTO ExamTerms(ExamTermName) VALUES('Fouth session')
INSERT INTO ExamTerms(ExamTermName) VALUES('Fifth session')
INSERT INTO ExamTerms(ExamTermName) VALUES('Sixth session')
INSERT INTO ExamTerms(ExamTermName) VALUES('Seventh session')
INSERT INTO ExamTerms(ExamTermName) VALUES('Eight session')
INSERT INTO ExamTerms(ExamTermName) VALUES('Ninth session')
INSERT INTO ExamTerms(ExamTermName) VALUES('Tenth session')
end
GO
