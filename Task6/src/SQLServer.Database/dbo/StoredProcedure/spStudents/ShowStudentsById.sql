CREATE PROCEDURE [dbo].[ShowStudentsById]
@Id int 
AS
	SELECT *FROM Students Where Id=@Id
GO
