namespace BaltaStore.Domain.LojaContext.Entidades
{
    public class ItemPedido
    {
        public ItemPedido(Produto produto, decimal quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
            Preco = produto.Preco;
        }

        public Produto Produto { get; private set; }
        public decimal Quantidade { get; private set; }
        public decimal Preco { get; private set; }
    }
}
