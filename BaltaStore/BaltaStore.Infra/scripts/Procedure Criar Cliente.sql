CREATE PROCEDURE spCriarCliente
    @Id UNIQUEIDENTIFIER,
    @PrimeiroNome VARCHAR(40),
    @UltimoNome VARCHAR(40),
    @Documento CHAR(11),
    @Email VARCHAR(160),
    @Telefone VARCHAR(13)
AS
    INSERT INTO [Cliente] (
        [Id], 
        [PrimeiroNome], 
        [Sobrenome], 
        [Documento], 
        [Email], 
        [Telefone]
    ) VALUES (
        @Id,
        @PrimeiroNome,
        @UltimoNome,
        @Documento,
        @Email,
        @Telefone
    )