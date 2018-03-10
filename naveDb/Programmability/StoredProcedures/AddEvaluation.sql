CREATE PROCEDURE [dbo].[AddEvaluation]
	@FK_Driver int,
	@FK_Passager int,
	@Note int,
	@Description text,
	@OutId int
AS
BEGIN
	INSERT INTO Evaluation (FK_Driver,FK_Passager,Note,[Description]) 
	OUTPUT inserted.Id INTO @OutId
	VALUES (@FK_Driver,@FK_Passager,@Note,@Description)
END
