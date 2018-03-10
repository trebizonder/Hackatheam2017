CREATE PROCEDURE [dbo].[AddAddress]
	@Number varchar(50),
	@Street varchar(100),
	@FK_City int,
	@OutId int
AS
BEGIN
	INSERT INTO Adress (Number,Street,FK_City) 
	OUTPUT inserted.Id  INTO @OutId
	VALUES (@Number,@Street,@FK_City)
END
