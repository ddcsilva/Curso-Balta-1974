namespace BaltaStore.Dominio.ValueObjects;

public class Nome
{
    public Nome(string primeiroNome, string sobrenome)
    {
        PrimeiroNome = primeiroNome;
        Sobrenome = sobrenome;
    }

    public string PrimeiroNome { get; private set; }
    public string Sobrenome { get; private set; }

    public override string ToString()
    {
        return $"{PrimeiroNome} {Sobrenome}";
    }
}