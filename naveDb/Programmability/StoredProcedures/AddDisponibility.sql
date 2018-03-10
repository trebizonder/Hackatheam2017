CREATE PROCEDURE [dbo].[AddDisponibility]
	@Date datetime,
	@FK_Path int
AS
BEGIN
	INSERT INTO Disponibility ([Date], FK_Path) 
	OUTPUT inserted.Id
	VALUES (@Date, @FK_Path)
END
