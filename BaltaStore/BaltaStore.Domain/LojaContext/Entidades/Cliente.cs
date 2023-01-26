namespace BaltaStore.Domain.LojaContext.Entidades
{
    public class Cliente
    {
        public Cliente(string nome, string sobrenome, string documento, string email, string telefone, string endereco)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Documento = documento;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
        }

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Documento { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public string Endereco { get; private set; }

        public override string ToString()
        {
            return $"{Nome} {Sobrenome}";
        }
    }
}
