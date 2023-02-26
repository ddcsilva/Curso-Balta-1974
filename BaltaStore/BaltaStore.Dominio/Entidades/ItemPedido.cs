using BaltaStore.Comum.Entities;
using FluentValidator;

namespace BaltaStore.Dominio.Entidades;

public class ItemPedido : Entity
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

        produto.DiminuirQuantidade(quantidade);
    }

    public Produto Produto { get; private set; }
    public decimal Quantidade { get; private set; }
    public decimal Preco { get; private set; }
}