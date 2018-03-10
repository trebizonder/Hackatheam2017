﻿CREATE PROCEDURE [dbo].[AddPath]
	@FK_Departure_City int,
	@FK_Arrival_City int,
	@FK_Driver int
AS
BEGIN
	INSERT INTO [Path] (FK_Departure_City, FK_Arrival_City, FK_Driver) 
	OUTPUT inserted.Id
	VALUES (@FK_Departure_City, @FK_Arrival_City, @FK_Driver)
END
