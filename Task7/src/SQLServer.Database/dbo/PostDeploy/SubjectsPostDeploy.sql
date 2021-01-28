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
CREATE PROCEDURE SubjectsPostDeploy
AS
IF not exists (SELECT * from dbo.Subjects WHERE SubjectsName='Phisics' and IsAssessment = 'Assesment' and IDExaminers=0)
	begin
		INSERT INTO Subjects(SubjectsName,IsAssessment, IDExaminers) VALUES('Phisics', 'Assesment', 1)
		INSERT INTO Subjects(SubjectsName,IsAssessment, IDExaminers) VALUES('Chemist', 'Test', 2)
		INSERT INTO Subjects(SubjectsName,IsAssessment, IDExaminers) VALUES('Math', 'Assesment', 3)
		INSERT INTO Subjects(SubjectsName,IsAssessment, IDExaminers) VALUES('English', 'Test', 4)
	end
GO