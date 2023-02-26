using BaltaStore.Comum.Commands;
using BaltaStore.Dominio.Commands.ClienteCommands.Outputs;
using BaltaStore.Dominio.Commands.CustomerCommands.Inputs;
using BaltaStore.Dominio.Entidades;
using BaltaStore.Dominio.Repositories;
using BaltaStore.Dominio.Services;
using BaltaStore.Dominio.ValueObjects;
using FluentValidator;

namespace BaltaStore.Dominio.Handlers;

public class ClienteHandler : Notifiable, ICommandHandler<CriarClienteCommand>, ICommandHandler<AdicionarEnderecoCommand>
{
    private readonly IClienteRepository _repository;
    private readonly IEmailService _emailService;

    public ClienteHandler(IClienteRepository repository, IEmailService emailService)
    {
        _repository = repository;
        _emailService = emailService;
    }

    public ICommandResult Handle(CriarClienteCommand command)
    {
        // Verificar se o CPF já existe na base
        if (_repository.VerificarDocumento(command.Documento))
        {
            AddNotification("Documento", "Este CPF já está em uso");
        }

        // Verificar se o E-mail já existe na base
        if (_repository.VerificarEmail(command.Email))
        {
            AddNotification("Email", "Este E-mail já está em uso");
        }

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

        if (Invalid)
            return null;

        // Persistir o cliene
        _repository.Gravar(cliente);

        // Enviar um E-mail de boas vindas
        _emailService.Send(email.Endereco, "danilo.silva@msn.com", "Bem vindo", "Seja bem vindo ao Balta Store!");

        // Retornar o resultado para tela
        return new CriarClienteCommandResult(cliente.Id, nome.ToString(), email.Endereco);
    }

    public ICommandResult Handle(AdicionarEnderecoCommand command)
    {
        throw new NotImplementedException();
    }
}
