using BaltaStore.Enumeradores;

namespace BaltaStore.Dominio.Entidades;

public class Pedido
{
    public Pedido(Cliente cliente)
    {
        Cliente = cliente;
        Numero = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();
        DataCriacao = DateTime.Now;
        Status = EStatusPedido.Criado;
        Items = new List<ItemPedido>();
        Entregas = new List<Entrega>();
    }

    public Cliente Cliente { get; private set; }
    public string Numero { get; private set; }
    public DateTime DataCriacao { get; private set; }
    public EStatusPedido Status { get; private set; }
    public IReadOnlyCollection<ItemPedido> Items { get; private set; }
    public IReadOnlyCollection<Entrega> Entregas { get; private set; }

    public void adicionarItem(ItemPedido item)
    {
        // Valida item
        // Adiciona ao pedido
    }

    // Fechar o pedido
    public void Fechar()
    {

    }
}