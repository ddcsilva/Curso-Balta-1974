namespace BaltaStore.Dominio.Entidades;

public class ItemPedido
{
    public Produto Produto { get; set; }
    public string Quantidade { get; set; }
    public string Preco { get; set; }
}