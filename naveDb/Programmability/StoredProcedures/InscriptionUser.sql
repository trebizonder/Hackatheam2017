CREATE PROCEDURE [dbo].[InscriptionUser]
	@FirstName varchar(50),
	@LastName varchar(50),
	@Sex char(1),
	@Mail varchar(100),
	@Passwd varchar(128),
	@BirthDate datetime,
	@Street varchar(100),
	@Number varchar(50),
	@PostalCode varchar(4),
	@NameCity varchar(50),
	@CarModel varchar(50),
	@MaxPlace int
AS
	DECLARE @IdCity int;

	INSERT INTO Car (CarModel, MaxPlace)
	VALUES (@CarModel, @MaxPlace);

	SELECT @IdCity=Id FROM City WHERE PostalCode=@PostalCode AND [Name]=@NameCity;

	INSERT INTO Adress (Number, Street, FK_City)
	VALUES (@Number, @Street, IDENT_CURRENT('Car'));

	INSERT INTO [User] (Firstname, Lastname, Sex, Mail, Passwd, BirthDate, FK_Address, FK_Voiture)
	VALUES (@FirstName, @LastName, @Sex, @Mail, @Passwd, @BirthDate, IDENT_CURRENT('Adress'), @IdCity);
