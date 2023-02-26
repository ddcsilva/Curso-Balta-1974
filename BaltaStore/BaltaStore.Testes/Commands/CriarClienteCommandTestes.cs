using BaltaStore.Dominio.Commands.CustomerCommands.Inputs;

namespace BaltaStore.Testes.Entidades;

[TestClass]
public class CriarClienteCommandTestes
{
    [TestMethod]
    public void Deve_Validar_Quando_Command_For_Valido()
    {
        var command = new CriarClienteCommand();
        command.PrimeiroNome = "Danilo";
        command.Sobrenome = "Silva";
        command.Documento = "28659170377";
        command.Email = "danilo.silva@msn.com";
        command.Telefone = "11999999997";

        Assert.AreEqual(true, command.Valido());
    }
}