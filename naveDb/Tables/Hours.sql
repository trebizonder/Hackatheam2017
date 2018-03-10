CREATE TABLE [dbo].[Hours]
(
	[Id] INT NOT NULL IDENTITY, 
    [FK_Dispo] INT NOT NULL, 
    [Hour_Departure] TIME NOT NULL, 
    [Hour_Arival] TIME NOT NULL, 
    CONSTRAINT [PK_Hours] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Hours_Disponibility] FOREIGN KEY ([FK_Dispo]) REFERENCES [Disponibility]([Id]) 
)
