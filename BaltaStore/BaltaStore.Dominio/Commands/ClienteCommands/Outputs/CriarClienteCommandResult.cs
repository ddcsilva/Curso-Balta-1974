using BaltaStore.Comum.Commands;

namespace BaltaStore.Dominio.Commands.ClienteCommands.Outputs;

public class CriarClienteCommandResult : ICommandResult
{
    public CriarClienteCommandResult() {}

    public CriarClienteCommandResult(Guid id, string nome, string email)
    {
        Id = id;
        Nome = nome;
        Email = email;
    }

    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
}
