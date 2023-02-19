using BaltaStore.Comum.Commands;
using FluentValidator;
using FluentValidator.Validation;

namespace BaltaStore.Dominio.Commands.CustomerCommands.Inputs
{
  public class CriarClienteCommand : Notifiable, ICommand
  {
    public string? PrimeiroNome { get; set; }
    public string? Sobrenome { get; set; }
    public string? Documento { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }

    public bool Valido()
    {
      AddNotifications(new ValidationContract()
                  .HasMinLen(PrimeiroNome, 3, "Primeiro Nome", "O nome deve conter pelo menos 3 caracteres")
                  .HasMaxLen(PrimeiroNome, 40, "Primeiro Nome", "O nome deve conter pelo menos 40 caracteres")
                  .HasMinLen(Sobrenome, 3, "Sobrenome", "O sobrenome deve conter pelo menos 3 caracteres")
                  .HasMaxLen(Sobrenome, 40, "Sobrenome", "O sobrenome deve conter pelo menos 40 caracteres")
                  .HasLen(Documento, 11, "Documento", "CPF Inválido")
              );

      return Valido();
    }
  }
}