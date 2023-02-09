using BaltaStore.Dominio.ValueObjects;

namespace BaltaStore.Dominio.Entidades;

public class Cliente
{
    public Cliente(Nome nome, Documento documento, Email email, string telefone)
    {
        Nome = nome;
        Documento = documento;
        Email = email;
        Telefone = telefone;
        Enderecos = new List<Endereco>();
    }

    public Nome Nome { get; private set; }
    public Documento Documento { get; private set; }
    public Email Email { get; private set; }
    public string Telefone { get; private set; }
    public IReadOnlyCollection<Endereco> Enderecos { get; private set; }

    public override string ToString()
    {
        return Nome.ToString();
    }
}