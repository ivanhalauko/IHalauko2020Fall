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
CREATE PROCEDURE GroupsPostDeploy
as
IF not exists(select * from dbo.Groups WHERE GroupeName='MT' and IDSpecialties=0)
	BEGIN
		INSERT INTO Groups (GroupeName,IDSpecialties) VALUES('MT',1)
		INSERT INTO Groups (GroupeName,IDSpecialties) VALUES('IE',2)
		INSERT INTO Groups (GroupeName,IDSpecialties) VALUES('HP',3)
		--INSERT INTO Groups (GroupeName,IDSpecialties) VALUES('MF',4)
	END
	GO