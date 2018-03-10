CREATE TABLE [dbo].[Path_List]
(
	[Id] INT NOT NULL IDENTITY, 
    [FK_Path] INT NOT NULL, 
    [FK_User] INT NOT NULL, 
    CONSTRAINT [PK_Path_List] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Path_List_Path] FOREIGN KEY ([FK_Path]) REFERENCES [Path]([Id]), 
    CONSTRAINT [FK_Path_List_User] FOREIGN KEY ([FK_User]) REFERENCES [User]([Id]) 
)
