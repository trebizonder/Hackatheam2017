CREATE PROCEDURE [dbo].[AddHours]
	@FK_Dispo int,
	@Hour_Departure time(7),
	@Hour_Arrival time(7),
	@OutId int
AS
BEGIN
	INSERT INTO [Hours] (FK_Dispo, Hour_Departure, Hour_Arival) 
	OUTPUT inserted.Id INTO @OutId
	VALUES (@FK_Dispo, @Hour_Departure, @Hour_Arrival)
END
