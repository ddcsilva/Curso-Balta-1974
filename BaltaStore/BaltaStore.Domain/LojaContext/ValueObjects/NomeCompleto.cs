namespace BaltaStore.Domain.LojaContext.ValueObjects
{
    public class NomeCompleto
    {
        public NomeCompleto(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }

        public override string ToString()
        {
            return $"{Nome} {Sobrenome}";
        }
    }
}
