namespace BaltaStore.Dominio.Commands.PedidoCommands.Inputs
{
    public class CriarPedidoCommand
    {
        public Guid Cliente { get; set; }
        public IList<CriarItemPedidoCommand>? ItensPedido { get; set; }
    }
}