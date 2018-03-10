CREATE PROCEDURE [dbo].[AddCity]
	@PostalCode varchar(4),
	@Name varchar(50)
AS
BEGIN
	INSERT INTO City(PostalCode,[Name]) 
	OUTPUT inserted.Id
	VALUES (@PostalCode,@Name)
END
