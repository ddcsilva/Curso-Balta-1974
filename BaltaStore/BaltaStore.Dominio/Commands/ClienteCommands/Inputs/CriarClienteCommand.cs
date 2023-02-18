namespace BaltaStore.Dominio.Commands.CustomerCommands.Inputs
{
    public class CriarClienteCommand
    {
        public string? PrimeiroNome { get; set; }
        public string? Sobrenome { get; set; }
        public string? Documento { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
    }
}