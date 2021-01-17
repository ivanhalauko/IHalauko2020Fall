CREATE PROCEDURE [dbo].[DeleteGroupsById]
	@Id int
AS
	DELETE FROM Groups
	WHERE Id=@Id	
GO
