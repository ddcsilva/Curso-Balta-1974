namespace BaltaStore.Dominio.Services;

public interface IEmailService
{
    void Send(string destinatario, string remetente, string assunto, string corpo);
}
