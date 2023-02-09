namespace BaltaStore.Dominio.ValueObjects;

public class Documento
{
    public Documento(string numero)
    {
        Numero = numero;
    }

    public string Numero { get; private set; }

    public override string ToString()
    {
        return Numero;
    }
}