using BaltaStore.Dominio.Enumeradores;

namespace BaltaStore.Dominio.Entidades;

public class Endereco
{
    public Endereco(string rua, string numero, string complemento, string distrito, string cidade, string estado, string pais, string cep, ETipoEndereco tipo)
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
    public ETipoEndereco Tipo { get; private set; }

    public override string ToString()
    {
        return $"{Rua}, {Numero} - {Cidade}/{Estado}";
    }
}