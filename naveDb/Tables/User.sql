CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL IDENTITY, 
    [Firstname] VARCHAR(50) NOT NULL, 
    [Lastname] VARCHAR(50) NOT NULL, 
    [Sex] CHAR NOT NULL, 
    [Mail] VARCHAR(100) NOT NULL, 
    [Passwd] VARCHAR(128) NOT NULL, 
    [FK_Address] INT NOT NULL, 
    [FK_Voiture] INT NULL, 
    [BirthDate] DATETIME NOT NULL, 
    [Active] BIT NOT NULL DEFAULT 1, 
    CONSTRAINT [PK_User] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_User_Address] FOREIGN KEY ([FK_Address]) REFERENCES [Adress]([Id]), 
    CONSTRAINT [FK_User_Voiture] FOREIGN KEY ([FK_Voiture]) REFERENCES [Car]([Id])
)
