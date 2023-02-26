CREATE PROCEDURE spVerificarDocumento
    @Documento CHAR(11)
AS
SELECT CASE WHEN EXISTS (
		SELECT [Id]
    FROM [Cliente]
    WHERE [Documento] = @Documento
	)
	THEN CAST(1 AS BIT)
	ELSE CAST(0 AS BIT) END