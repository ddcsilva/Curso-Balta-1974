using BaltaStore.Domain.LojaContext.ValueObjects;
using System.Collections.Generic;

namespace BaltaStore.Domain.LojaContext.Entidades
{
    public class Cliente
    {
        public Cliente(NomeCompleto nomeCompleto, Documento documento, Email email, string telefone)
        {
            NomeCompleto = nomeCompleto;
            Documento = documento;
            Email = email;
            Telefone = telefone;
            Enderecos = new List<Endereco>();
        }

        public NomeCompleto NomeCompleto { get; set; }
        public Documento Documento { get; private set; }
        public Email Email { get; private set; }
        public string Telefone { get; private set; }
        public IReadOnlyCollection<Endereco> Enderecos { get; private set; }

        public override string ToString()
        {
            return NomeCompleto.ToString();
        }
    }
}
