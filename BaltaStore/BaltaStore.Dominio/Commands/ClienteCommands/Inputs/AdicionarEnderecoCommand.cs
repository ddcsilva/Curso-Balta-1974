using BaltaStore.Dominio.Enumeradores;

namespace BaltaStore.Dominio.Commands.CustomerCommands.Inputs;

public class AdicionarEnderecoCommand
{
    public Guid Id { get; set; }
    public string? Rua { get; private set; }
    public string? Numero { get; private set; }
    public string? Complemento { get; private set; }
    public string? Distrito { get; private set; }
    public string? Cidade { get; private set; }
    public string? Estado { get; private set; }
    public string? Pais { get; private set; }
    public string? Cep { get; private set; }
    public ETipoEndereco Tipo { get; private set; }
}