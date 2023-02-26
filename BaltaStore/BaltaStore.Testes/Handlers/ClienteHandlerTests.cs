using BaltaStore.Dominio.Commands.CustomerCommands.Inputs;
using BaltaStore.Dominio.Handlers;
using BaltaStore.Testes.Fakes;

namespace BaltaStore.Testes.Handlers;

[TestClass]
public class ClienteHandlerTests
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

        var handler = new ClienteHandler(new FakeClienteRepository(), new FakeEmailService());
        var result = handler.Handle(command);

        Assert.AreNotEqual(null, result);
        Assert.AreEqual(true, handler.IsValid);
    }
}
