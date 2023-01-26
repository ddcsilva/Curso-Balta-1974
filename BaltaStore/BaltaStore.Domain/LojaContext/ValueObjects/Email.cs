namespace BaltaStore.Domain.LojaContext.ValueObjects
{
    public class Email
    {
        public Email(string endereco)
        {
            Endereco = endereco;
        }

        public string Endereco { get; set; }

        public override string ToString()
        {
            return Endereco;
        }
    }
}
