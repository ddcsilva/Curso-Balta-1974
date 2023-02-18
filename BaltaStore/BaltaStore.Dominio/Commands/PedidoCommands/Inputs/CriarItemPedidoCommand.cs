namespace BaltaStore.Dominio.Commands.PedidoCommands.Inputs
{
    public class CriarItemPedidoCommand
    {
        public Guid Produto { get; set; }
        public decimal Quantidade { get; set; }
    }
}