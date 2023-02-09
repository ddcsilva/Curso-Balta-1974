namespace BaltaStore.Dominio.Entidades;

public class Cliente
{
    public Cliente(string primeiroNome, string sobrenome, string documento, string email, string telefone, string endereco)
    {
        PrimeiroNome = primeiroNome;
        Sobrenome = sobrenome;
        Documento = documento;
        Email = email;
        Telefone = telefone;
        Endereco = endereco;
    }

    public string PrimeiroNome { get; private set; }
    public string Sobrenome { get; private set; }
    public string Documento { get; private set; }
    public string Email { get; private set; }
    public string Telefone { get; private set; }
    public string Endereco { get; private set; }

    public override string ToString()
    {
        return $"{PrimeiroNome} {Sobrenome}";
    }
}