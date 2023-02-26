using BaltaStore.Dominio.ValueObjects;
using FluentValidator;

namespace BaltaStore.Dominio.Entidades;

public class Cliente : Notifiable
{
    private readonly IList<Endereco> _enderecos;

    public Cliente(Nome nome, Documento documento, Email email, string telefone)
    {
        Nome = nome;
        Documento = documento;
        Email = email;
        Telefone = telefone;

        _enderecos = new List<Endereco>();
    }

    public Nome Nome { get; private set; }
    public Documento Documento { get; private set; }
    public Email Email { get; private set; }
    public string Telefone { get; private set; }
    public IReadOnlyCollection<Endereco> Enderecos => _enderecos.ToArray();

    public void AdicionarEndereco(Endereco endereco)
    {
        // Validar o endereço
        // Adicionar o endereço
        _enderecos.Add(endereco);
    }

    public override string ToString()
    {
        return Nome.ToString();
    }
}