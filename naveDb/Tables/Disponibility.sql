CREATE TABLE [dbo].[Disponibility]
(
	[Id] INT NOT NULL IDENTITY, 
    [Date] DATETIME NOT NULL, 
    [FK_Path] INT NOT NULL, 
    CONSTRAINT [PK_Disponibility] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Disponibility_Path] FOREIGN KEY ([FK_Path]) REFERENCES [Path]([Id])
)
