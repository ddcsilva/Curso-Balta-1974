namespace BaltaStore.Dominio;

public class Pedido
{
    public Cliente Cliente { get; set; }
    public string Numero { get; set; }
    public DateTime DataCriacao { get; set; }
    public string Status { get; set; }
    public string Status { get; set; }
    public IList<ItemPedido> Items { get; set; }
    public IList<Entrega> Entregas { get; set; }

    public void Fechar()
    {

    }
}