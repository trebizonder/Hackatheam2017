CREATE TABLE [dbo].[Path]
(
	[Id] INT NOT NULL IDENTITY, 
    [FK_Departure_City] INT NOT NULL, 
    [FK_Arrival_City] INT NOT NULL, 
    [FK_Driver] INT NOT NULL, 
    [Active] BIT NOT NULL DEFAULT 1, 
    CONSTRAINT [PK_Path] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Path_User] FOREIGN KEY ([FK_Driver]) REFERENCES [User]([Id]), 
    CONSTRAINT [FK_Path_City_Departure] FOREIGN KEY ([FK_Departure_City]) REFERENCES [City]([Id]), 
    CONSTRAINT [FK_Path_City_Arrival] FOREIGN KEY ([FK_Arrival_City]) REFERENCES [City]([Id]) 
)
