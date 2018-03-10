CREATE TABLE [dbo].[Evaluation]
(
	[Id] INT NOT NULL IDENTITY, 
    [FK_Driver] INT NOT NULL, 
    [FK_Passager] INT NOT NULL, 
    [Note] INT NOT NULL, 
    [Description] TEXT NOT NULL, 
    CONSTRAINT [PK_Evaluation] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Evaluation_User_Driver] FOREIGN KEY ([FK_Driver]) REFERENCES [User]([Id]), 
    CONSTRAINT [FK_Evaluation_User_Passager] FOREIGN KEY ([FK_Passager]) REFERENCES [User]([Id])
)
