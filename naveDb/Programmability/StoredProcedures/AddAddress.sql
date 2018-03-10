CREATE PROCEDURE [dbo].[AddAddress]
	@Number varchar(50),
	@Street varchar(100),
	@FK_City int
AS
BEGIN
	INSERT INTO Adress (Number,Street,FK_City) 
	OUTPUT inserted.Id
	VALUES (@Number,@Street,@FK_City)
END
