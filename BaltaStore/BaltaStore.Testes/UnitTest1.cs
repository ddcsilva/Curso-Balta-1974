using BaltaStore.Dominio.Entidades;

namespace BaltaStore.Testes;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var cliente = new Cliente("Danilo", "Silva", "33311100033", "danilo.silva@msn.com", "11996662200", "Rua XV de Novembro");
        var pedido = new Pedido(cliente);
    }
}