using BaltaStore.Dominio.Services;

namespace BaltaStore.Testes.Fakes;

public class FakeEmailService : IEmailService
{
    public void Send(string destinatario, string remetente, string assunto, string corpo)
    {
        
    }
}
