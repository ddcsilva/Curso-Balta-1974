using BaltaStore.Dominio.Entidades;
using BaltaStore.Dominio.Enumeradores;
using BaltaStore.Dominio.ValueObjects;

namespace BaltaStore.Testes.Entidades;

[TestClass]
public class PedidoTestes
{
    private Cliente _cliente;
    private Pedido _pedido;
    private Produto _mouse;
    private Produto _teclado;
    private Produto _cadeira;
    private Produto _monitor;

    public PedidoTestes()
    {
        var nome = new Nome("Danilo", "Silva");
        var documento = new Documento("43259389075");
        var email = new Email("danilo.silva@msn.com");
        _cliente = new Cliente(nome, documento, email, "5512988888888");
        _pedido = new Pedido(_cliente);
        _mouse = new Produto("Mouse Gamer", "Mouse Gamer", "mouse.jpg", 100M, 10);
        _teclado = new Produto("Teclado Gamer", "Teclado Gamer", "teclado.jpg", 100M, 10);
        _cadeira = new Produto("Cadeira Gamer", "Cadeira Gamer", "cadeira.jpg", 100M, 10);
        _monitor = new Produto("Monitor Gamer", "Monitor Gamer", "Monitor.jpg", 100M, 10);
    }

    // Consigo criar um novo pedido
    [TestMethod]
    public void Deve_Criar_Pedido_Quando_For_Valido()
    {
        Assert.AreEqual(true, _pedido.IsValid);
    }

    // Ao criar o pedido, o status deve ser Criado
    [TestMethod]
    public void Status_Deve_Ficar_Como_Criado_Quando_Pedido_For_Criado()
    {
        Assert.AreEqual(EStatusPedido.Criado, _pedido.Status);
    }

    // Ao adicionar um novo item, a quantidade de itens deve mudar
    [TestMethod]
    public void Deve_Retornar_Dois_Quando_Adicionado_Dois_Itens_Validos()
    {
        _pedido.adicionarItem(_monitor, 5);
        _pedido.adicionarItem(_mouse, 5);
        Assert.AreEqual(2, _pedido.Items.Count);
    }

    // Ao adicionar um novo item, deve subtrair a quantidade do produto
    [TestMethod]
    public void Deve_Retornar_Cinco_Quando_Comprado_Cinco_Itens()
    {
        _pedido.adicionarItem(_monitor, 5);
        Assert.AreEqual(_monitor.QuantidadeEmEstoque, 5);
    }

    // Ao confirmar o pedido, deve gerar um número
    [TestMethod]
    public void Deve_Retornar_Um_Numero_Quando_Pedido_For_Gerado()
    {
        _pedido.Fechar();
        Assert.AreNotEqual("", _pedido.Numero);
    }

    // Ao gerar um pedido, o status deve ser PAGO
    [TestMethod]
    public void Deve_Retornar_Pago_Quando_Pedido_For_Pago()
    {
        _pedido.Pagar();
        Assert.AreEqual(EStatusPedido.Pago, _pedido.Status);
    }

    // Dado mais 10 produtos, devem haver duas entregas
    [TestMethod]
    public void Deve_Retornar_Dois_Enviados_Quando_Comprado_10_Produtos()
    {
        _pedido.adicionarItem(_mouse, 1);
        _pedido.adicionarItem(_mouse, 1);
        _pedido.adicionarItem(_mouse, 1);
        _pedido.adicionarItem(_mouse, 1);
        _pedido.adicionarItem(_mouse, 1);
        _pedido.adicionarItem(_mouse, 1);
        _pedido.adicionarItem(_mouse, 1);
        _pedido.adicionarItem(_mouse, 1);
        _pedido.adicionarItem(_mouse, 1);
        _pedido.adicionarItem(_mouse, 1);

        _pedido.Enviar();

        Assert.AreEqual(2, _pedido.Entregas.Count);
    }

    // Ao cancelar o pedido, o status deve ser cancelado
    [TestMethod]
    public void Status_Deve_Ficar_Como_Cancelado_Quando_Pedido_For_Cancelado()
    {
        _pedido.Cancelar();
        Assert.AreEqual(EStatusPedido.Cancelado, _pedido.Status);
    }

    // Ao cancelar o pedido, deve cancelar as entregas
    [TestMethod]
    public void Deve_Cancelar_Entrega_Quando_Pedido_Cancelado()
    {
        _pedido.adicionarItem(_mouse, 1);
        _pedido.adicionarItem(_mouse, 1);
        _pedido.adicionarItem(_mouse, 1);
        _pedido.adicionarItem(_mouse, 1);
        _pedido.adicionarItem(_mouse, 1);
        _pedido.adicionarItem(_mouse, 1);
        _pedido.adicionarItem(_mouse, 1);
        _pedido.adicionarItem(_mouse, 1);
        _pedido.adicionarItem(_mouse, 1);
        _pedido.adicionarItem(_mouse, 1);

        _pedido.Enviar();
        _pedido.Cancelar();

        foreach (var x in _pedido.Entregas)
        {
            Assert.AreEqual(EStatusEntrega.Cancelado, x.Status);
        }
    }
}