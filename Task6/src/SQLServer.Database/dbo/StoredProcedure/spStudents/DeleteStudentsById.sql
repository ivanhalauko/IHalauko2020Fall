CREATE PROCEDURE [dbo].[DeleteStudentsById]
	@Id int 
AS 
	DELETE
	FROM Students 
	WHERE Id = @Id
GO
