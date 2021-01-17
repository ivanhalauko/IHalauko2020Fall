CREATE PROCEDURE [dbo].[ShowGroupsById]
	@Id int
AS
	SELECT * FROM dbo.Groups WHERE Id=@Id
GO
