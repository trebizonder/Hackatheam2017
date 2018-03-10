CREATE PROCEDURE [dbo].[AddCar]
	@CarModel varchar(50),
	@MaxPlace int
AS
BEGIN
	INSERT INTO Car (CarModel,MaxPlace) 
	OUTPUT inserted.Id
	VALUES (@CarModel,@MaxPlace)
END
