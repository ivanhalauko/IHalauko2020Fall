CREATE PROCEDURE [dbo].[AddGroups]
	@GroupeName nvarchar(50)
AS
	INSERT INTO Groups(GroupeName)
	VALUES (@GroupeName)
	SELECT SCOPE_IDENTITY()
GO
