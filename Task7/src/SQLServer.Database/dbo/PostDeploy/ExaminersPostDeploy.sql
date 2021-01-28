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
CREATE PROCEDURE [dbo].[ExaminersPostDeploy]
	
AS
IF not exists(select * from dbo.Examiners WHERE Name='Vasiliy' and Surname='Petrovich' and Patronymic='Hrenov')
	BEGIN
		INSERT INTO Examiners (Name,Surname,Patronymic) VALUES('Vasiliy','Petrovich','Hrenov')
		INSERT INTO Examiners (Name,Surname,Patronymic) VALUES('Grigoriy','Nikolayevich','Ivanov')
		INSERT INTO Examiners (Name,Surname,Patronymic) VALUES('Maxim','Leonovich','Jukov')
		INSERT INTO Examiners (Name,Surname,Patronymic) VALUES('Vitaliy','Ivanovich','Zaycev')
	END
	GO
