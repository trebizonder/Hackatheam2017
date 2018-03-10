CREATE PROCEDURE [dbo].[AddCity]
	@PostalCode varchar(4),
	@Name varchar(50),
	@OutId int
AS
BEGIN
	INSERT INTO City(PostalCode,[Name]) 
	OUTPUT inserted.Id INTO @OutId
	VALUES (@PostalCode,@Name)
END
