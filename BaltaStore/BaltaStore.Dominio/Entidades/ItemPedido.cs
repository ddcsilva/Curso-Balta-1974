using FluentValidator;

namespace BaltaStore.Dominio.Entidades;

public class ItemPedido : Notifiable
{
    public ItemPedido(Produto produto, decimal quantidade)
    {
        Produto = produto;
        Quantidade = quantidade;
        Preco = produto.Preco;

        if (produto.QuantidadeEmEstoque < quantidade)
        {
            AddNotification("Quantidade", "Produto fora de estoque");
        }
    }

    public Produto Produto { get; private set; }
    public decimal Quantidade { get; private set; }
    public decimal Preco { get; private set; }
}