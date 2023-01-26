using BaltaStore.Domain.LojaContext.Entidades;
using BaltaStore.Domain.LojaContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var nome = new NomeCompleto("Danilo", "Silva");
            var documento = new Documento("12345678911");
            var email = new Email("danilo@danilo.com");
            var cliente = new Cliente(nome, documento, email, "129999999");

            var mouse = new Produto("Mouse", "Rato", "image.png", 59.90M, 10);
            var teclado = new Produto("Teclado", "Teclado", "image.png", 159, 10);
            var impressora = new Produto("Impressora", "Impressora", "image.png", 359, 10);
            var cadeira = new Produto("Cadeira", "Cadeira", "image.png", 559, 10);

            var pedido = new Pedido(cliente);
            pedido.AdicionarItem(new ItemPedido(mouse, 5));
            pedido.AdicionarItem(new ItemPedido(teclado, 5));
            pedido.AdicionarItem(new ItemPedido(impressora, 5));
            pedido.AdicionarItem(new ItemPedido(cadeira, 5));

            // Simular Pedido
            pedido.Gerar();

            // Simular pagamento
            pedido.Pagar();

            // Simular envio
            pedido.Enviar();

            // Simular cancelamento
            pedido.Cancelar();
        }
    }
}
