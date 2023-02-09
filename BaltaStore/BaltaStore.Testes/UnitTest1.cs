using BaltaStore.Dominio.Entidades;
using BaltaStore.Dominio.ValueObjects;

namespace BaltaStore.Testes;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var nome = new Nome("Danilo", "Silva");
        var documento = new Documento("12345678911");
        var email = new Email("danilo.silva@msn.com");
        var cliente = new Cliente(nome, documento, email, "11996662200");

        var mouse = new Produto("Mouse", "Mouse", "Imagem.png", 59.90M, 10);
        var teclado = new Produto("Reclado", "Reclado", "Imagem.png", 159.90M, 10);
        var impressora = new Produto("Impressora", "Impressora", "Imagem.png", 359.90M, 10);
        var cadeira = new Produto("Cadeira", "Cadeira", "Imagem.png", 559.90M, 10);

        var pedido = new Pedido(cliente);
        pedido.adicionarItem(new ItemPedido(mouse, 5));
        pedido.adicionarItem(new ItemPedido(teclado, 5));
        pedido.adicionarItem(new ItemPedido(cadeira, 5));
        pedido.adicionarItem(new ItemPedido(impressora, 5));

        pedido.Fechar();

        pedido.Pagar();

        pedido.Enviar();

        pedido.Cancelar();
    }
}