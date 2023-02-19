using BaltaStore.Comum.Commands;
using FluentValidator;
using FluentValidator.Validation;

namespace BaltaStore.Dominio.Commands.PedidoCommands.Inputs
{
  public class CriarPedidoCommand : Notifiable, ICommand
  {
    public CriarPedidoCommand(Guid cliente, IList<CriarItemPedidoCommand> itensPedido)
    {
      ItensPedido = new List<CriarItemPedidoCommand>();
    }

    public Guid Cliente { get; set; }
    public IList<CriarItemPedidoCommand> ItensPedido { get; set; }

    public bool Valido()
    {
      AddNotifications(new ValidationContract()
                  .HasLen(Cliente.ToString(), 36, "Cliente", "Identificador do Cliente inválido")
                  .IsGreaterThan(ItensPedido.Count, 0, "ItensPedido", "Nenhum item do pedido foi encontrado")
              );

      return Valido();
    }
  }
}