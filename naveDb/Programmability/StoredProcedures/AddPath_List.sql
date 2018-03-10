CREATE PROCEDURE [dbo].[AddPath_List]
	@FK_Path int,
	@FK_User int
AS

	INSERT INTO Path_List (FK_Path, FK_User) 
	OUTPUT inserted.Id
	VALUES (@FK_Path, @FK_User)
RETURN 0
