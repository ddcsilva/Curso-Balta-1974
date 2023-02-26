CREATE PROCEDURE spCriarEndereco
    @Id UNIQUEIDENTIFIER,
    @ClienteId UNIQUEIDENTIFIER,
    @Numero VARCHAR(10),
    @Complemento VARCHAR(40),
    @Distrito VARCHAR(60),
    @Cidade VARCHAR(60),
    @Estado CHAR(2),
    @Pais CHAR(2),
    @Cep CHAR(8),
    @Tipo INT
AS
INSERT INTO [Endereco]
    (
    [Id],
    [ClienteId],
    [Numero],
    [Complemento],
    [Distrito],
    [Cidade],
    [Estado],
    [Pais],
    [Cep],
    [Tipo]
    )
VALUES
    (
        @Id,
        @ClienteId,
        @Numero,
        @Complemento,
        @Distrito,
        @Cidade,
        @Estado,
        @Pais,
        @Pais,
        @Tipo
    )