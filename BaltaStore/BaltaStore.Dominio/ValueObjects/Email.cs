using FluentValidator;
using FluentValidator.Validation;

namespace BaltaStore.Dominio.ValueObjects;

public class Email : Notifiable
{
    public Email(string endereco)
    {
        Endereco = endereco;

        AddNotifications(new ValidationContract()
            .Requires()
            .IsEmail(Endereco, "Email", "O email é inválido")
        );
    }

    public string Endereco { get; private set; }

    public override string ToString()
    {
        return Endereco;
    }
}