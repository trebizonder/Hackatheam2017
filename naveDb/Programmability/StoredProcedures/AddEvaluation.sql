CREATE PROCEDURE [dbo].[AddEvaluation]
	@FK_Driver int,
	@FK_Passager int,
	@Note int,
	@Description text
AS
BEGIN
	INSERT INTO Evaluation (FK_Driver,FK_Passager,Note,[Description]) 
	OUTPUT inserted.Id
	VALUES (@FK_Driver,@FK_Passager,@Note,@Description)
END
