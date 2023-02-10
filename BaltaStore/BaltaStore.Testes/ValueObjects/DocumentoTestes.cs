using BaltaStore.Dominio.ValueObjects;

namespace BaltaStore.Testes;

[TestClass]
public class DocumentoTestes
{
    private Documento _documentoValido;
    private Documento _documentoInvalido;

    public DocumentoTestes()
    {
        _documentoValido =  new Documento("32084234468");
        _documentoInvalido =  new Documento("12345678911");
    }

    [TestMethod]
    public void Deve_Retornar_Notificacao_Quando_Documento_Invalido()
    {
        Assert.AreEqual(false, _documentoInvalido.IsValid);
    }

    [TestMethod]
    public void Nao_Deve_Retornar_Notificacao_Quando_Documento_Valido()
    {
        Assert.AreEqual(true, _documentoValido.IsValid);
    }
}