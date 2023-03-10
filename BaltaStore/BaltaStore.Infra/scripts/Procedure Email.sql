CREATE PROCEDURE spVerificarEmail
    @Email VARCHAR(160)
AS
SELECT CASE WHEN EXISTS (
		SELECT [Id]
    FROM [Cliente]
    WHERE [Email] = @Email
	)
	THEN CAST(1 AS BIT)
	ELSE CAST(0 AS BIT) END