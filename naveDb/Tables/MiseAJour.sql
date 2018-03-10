ALTER TABLE dbo.Evalutation ADD FK_Path int(20) NOT NULL,
CONSTRAINT [FK_Evalutation_Path] FOREIGN KEY ([FK_Path]) REFERENCES [Path]([Id]);