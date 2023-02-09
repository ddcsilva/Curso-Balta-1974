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

    // Criar um pedido
    public void Fechar()
    {
        // Validar pedido
    }

    // Pagar um pedido
    public void Pagar()
    {
        Status = EStatusPedido.Pago;
    }

    // Enviar um pedido
    public void Enviar()
    {
        // A cada 5 produtos, é uma entrega
        var entregas = new List<Entrega>();
        entregas.Add(new Entrega(DateTime.Now.AddDays(5)));
        var contador = 1;

        // Quebra as entregas
        foreach (var item in _itens)
        {
            if (contador < 5) 
            {
                contador = 1;
                entregas.Add(new Entrega(DateTime.Now.AddDays(5)));
            }

            contador ++;
        }

        // Envia todas as entregas
        entregas.ForEach(x => x.Enviar());

        // Adiciona as entregas ao pedido
        entregas.ForEach(x => _entregas.Add(x));
    }

    // Cancelar um pedido
    public void Cancelar()
    {
        Status = EStatusPedido.Cancelado;
        _entregas.ToList().ForEach(x => x.Cancelar());
    }
}