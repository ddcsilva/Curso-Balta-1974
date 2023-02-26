using BaltaStore.Comum.Commands;
using FluentValidator;

namespace BaltaStore.Dominio.Commands.PedidoCommands.Inputs;

public class CriarItemPedidoCommand : Notifiable, ICommand
{
    public Guid Produto { get; set; }
    public decimal Quantidade { get; set; }

    public bool Valido()
    {
        throw new NotImplementedException();
    }
}