CREATE PROCEDURE [dbo].[AddDisponibility]
	@Date datetime,
	@FK_Path int,
	@OutId int
AS
BEGIN
	INSERT INTO Disponibility ([Date], FK_Path) 
	OUTPUT inserted.Id INTO @OutId
	VALUES (@Date, @FK_Path)
END
