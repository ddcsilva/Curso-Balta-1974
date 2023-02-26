using BaltaStore.Comum.Commands;
using BaltaStore.Dominio.Commands.ClienteCommands.Outputs;
using BaltaStore.Dominio.Commands.CustomerCommands.Inputs;
using BaltaStore.Dominio.Entidades;
using BaltaStore.Dominio.ValueObjects;
using FluentValidator;

namespace BaltaStore.Dominio.Handlers;

public class ClienteHandler : Notifiable, ICommandHandler<CriarClienteCommand>, ICommandHandler<AdicionarEnderecoCommand>
{
    public ICommandResult Handle(CriarClienteCommand command)
    {
        // Verificar se o CPF já existe na base

        // Verificar se o E-mail já existe na base

        // Criar os VOs
        var nome = new Nome("Danilo", "Silva");
        var documento = new Documento("12345678911");
        var email = new Email("danilo.silva@msn.com");

        // Criar a entidade
        var cliente = new Cliente(nome, documento, email, "11996662200");

        // Validar entidades e VOs
        AddNotifications(nome.Notifications);
        AddNotifications(documento.Notifications);
        AddNotifications(email.Notifications);
        AddNotifications(cliente.Notifications);

        // Persistir o cliene

        // Enviar um E-mail de boas vindas

        // Retornar o resultado para tela

        return new CriarClienteCommandResult(Guid.NewGuid(), nome.ToString(), email.Endereco);
    }

    public ICommandResult Handle(AdicionarEnderecoCommand command)
    {
        throw new NotImplementedException();
    }
}
