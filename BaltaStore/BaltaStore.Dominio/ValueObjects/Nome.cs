using FluentValidator;
using FluentValidator.Validation;

namespace BaltaStore.Dominio.ValueObjects;

public class Nome : Notifiable
{
    public Nome(string primeiroNome, string sobrenome)
    {
        PrimeiroNome = primeiroNome;
        Sobrenome = sobrenome;

        AddNotifications(new ValidationContract()
            .Requires()
            .HasMinLen(PrimeiroNome, 3, "Primeiro Nome", "O nome deve conter pelo menos 3 caracteres")
            .HasMaxLen(PrimeiroNome, 40, "Primeiro Nome", "O nome deve conter pelo menos 40 caracteres")
            .HasMinLen(Sobrenome, 3, "Sobrenome", "O sobrenome deve conter pelo menos 3 caracteres")
            .HasMaxLen(Sobrenome, 40, "Sobrenome", "O sobrenome deve conter pelo menos 40 caracteres")
        );
    }

    public string PrimeiroNome { get; private set; }
    public string Sobrenome { get; private set; }

    public override string ToString()
    {
        return $"{PrimeiroNome} {Sobrenome}";
    }
}