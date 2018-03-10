CREATE TABLE [dbo].[Adress]
(
	[Id] INT NOT NULL, 
    [Number] VARCHAR(50) NOT NULL, 
    [Street] VARCHAR(100) NOT NULL, 
    [FK_City] INT NOT NULL, 
    CONSTRAINT [PK_Adress] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Adress_City] FOREIGN KEY ([FK_City]) REFERENCES [City]([Id]) 
)
