using BaltaStore.Dominio.Enumeradores;

namespace BaltaStore.Dominio.Entidades;

public class Pedido
{
    private readonly IList<ItemPedido> _itens;
    private readonly IList<Entrega> _entregas;

    public Pedido(Cliente cliente)
    {
        Cliente = cliente;
        Numero = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();
        DataCriacao = DateTime.Now;
        Status = EStatusPedido.Criado;

        _itens = new List<ItemPedido>();
        _entregas = new List<Entrega>();
    }

    public Cliente Cliente { get; private set; }
    public string Numero { get; private set; }
    public DateTime DataCriacao { get; private set; }
    public EStatusPedido Status { get; private set; }
    public IReadOnlyCollection<ItemPedido> Items => _itens.ToArray();
    public IReadOnlyCollection<Entrega> Entregas => _entregas.ToArray();

    public void adicionarItem(ItemPedido item)
    {
        _itens.Add(item);
    }

    public void adicionarEntrega(Entrega entrega)
    {
        _entregas.Add(entrega);
    }

    public void Fechar()
    {

    }
}