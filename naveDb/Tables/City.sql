﻿CREATE TABLE [dbo].[City]
(
	[Id] INT NOT NULL IDENTITY, 
    [PostalCode] VARCHAR(4) NOT NULL, 
    [Name] VARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_City] PRIMARY KEY ([Id])
)
