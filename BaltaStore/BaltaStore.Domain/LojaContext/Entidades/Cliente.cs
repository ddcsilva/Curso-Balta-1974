using BaltaStore.Domain.LojaContext.ValueObjects;
using FluentValidator;
using System.Collections.Generic;
using System.Linq;

namespace BaltaStore.Domain.LojaContext.Entidades
{
    public class Cliente : Notifiable
    {
        private readonly IList<Endereco> _enderecos;

        public Cliente(NomeCompleto nomeCompleto, Documento documento, Email email, string telefone)
        {
            NomeCompleto = nomeCompleto;
            Documento = documento;
            Email = email;
            Telefone = telefone;

            _enderecos = new List<Endereco>();
        }

        public NomeCompleto NomeCompleto { get; set; }
        public Documento Documento { get; private set; }
        public Email Email { get; private set; }
        public string Telefone { get; private set; }
        public IReadOnlyCollection<Endereco> Enderecos => _enderecos.ToArray();

        public void AdicionarEndereco(Endereco endereco)
        {
            _enderecos.Add(endereco);
        }

        public override string ToString()
        {
            return NomeCompleto.ToString();
        }
    }
}
