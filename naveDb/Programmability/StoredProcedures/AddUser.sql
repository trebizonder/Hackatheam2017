CREATE PROCEDURE [dbo].[AddUser]
	@Firstname varchar(50),
	@Lastname varchar(50),
	@Sex char(1),
	@Mail varchar(100),
	@Passwd varchar(128),
	@FK_Address int,
	@FK_Voiture int,
	@BirthDate datetime,
	@OutId int
AS
BEGIN
	INSERT INTO [User] (Firstname, Lastname, Sex, Mail, Passwd, FK_Address, FK_Voiture, BirthDate) 
	OUTPUT inserted.Id
	VALUES (@Firstname, @Lastname, @Sex, @Mail, @Passwd, @FK_Address, @FK_Voiture, @BirthDate)
END

