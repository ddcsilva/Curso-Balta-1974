using BaltaStore.Dominio.Entidades;

namespace BaltaStore.Dominio.Repositories;

public interface IClienteRepository
{
    bool VerificarDocumento(string documento);
    bool VerificarEmail(string email);
    void Gravar(Cliente cliente);
}
