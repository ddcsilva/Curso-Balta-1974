namespace BaltaStore.Dominio.Entidades;

public class Produto
{
    public Produto(string titulo, string descricao, string imagem, decimal preco, decimal quantidadeEmEstoque)
    {
        Titulo = titulo;
        Descricao = descricao;
        Imagem = imagem;
        Preco = preco;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }

    public string Titulo { get; private set; }
    public string Descricao { get; private set; }
    public string Imagem { get; private set; }
    public decimal Preco { get; private set; }
    public decimal QuantidadeEmEstoque { get; private set; }

    public override string ToString()
    {
        return Titulo;
    }
}