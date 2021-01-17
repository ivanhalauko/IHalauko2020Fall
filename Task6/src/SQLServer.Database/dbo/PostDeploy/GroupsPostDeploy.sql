CREATE PROCEDURE GroupsPostDeploy
as
IF not exists(select * from dbo.Groups WHERE GroupeName='MT')
	BEGIN
		INSERT INTO Groups (GroupeName) VALUES('MT')
		INSERT INTO Groups (GroupeName) VALUES('TK')
		INSERT INTO Groups (GroupeName) VALUES('DF')
		INSERT INTO Groups (GroupeName) VALUES('WE')
		INSERT INTO Groups (GroupeName) VALUES('TR')
	END
	GO