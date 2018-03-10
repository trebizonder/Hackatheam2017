CREATE TABLE [dbo].[Car]
(
	[Id] INT NOT NULL IDENTITY, 
    [CarModel] VARCHAR(50) NOT NULL, 
    [MaxPlace] INT NOT NULL, 
    CONSTRAINT [PK_Car] PRIMARY KEY ([Id]) 
)
