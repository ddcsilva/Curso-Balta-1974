using BaltaStore.Domain.LojaContext.Enums;
using FluentValidator;

namespace BaltaStore.Domain.LojaContext.Entidades
{
    public class Endereco : Notifiable
    {
        public Endereco(string rua, string numero, string complemento, string distrito, string cidade, string estado, string pais, string cep, TipoEnderecoEnum tipo)
        {
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Distrito = distrito;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
            Cep = cep;
            Tipo = tipo;
        }

        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Distrito { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Pais { get; private set; }
        public string Cep { get; private set; }
        public TipoEnderecoEnum Tipo { get; set; }

        public override string ToString()
        {
            return $"{Rua}, {Numero} - {Cidade}/{Estado}";
        }
    }
}
