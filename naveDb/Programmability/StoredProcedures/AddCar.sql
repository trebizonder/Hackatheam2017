CREATE PROCEDURE [dbo].[AddCar]
	@CarModel varchar(50),
	@MaxPlace int,
	@OutId int
AS
BEGIN
	INSERT INTO Car (CarModel,MaxPlace) 
	OUTPUT inserted.Id INTO @OutId
	VALUES (@CarModel,@MaxPlace)
END
