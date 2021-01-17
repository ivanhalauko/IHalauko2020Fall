CREATE PROCEDURE [dbo].[UpdateGroups]
	@Id INT,
	@GroupeName nvarchar(50)
AS
	UPDATE Groups
	SET GroupeName=@GroupeName
    WHERE Id=@Id
	SELECT* FROM Groups WHERE Id=@Id
GO
