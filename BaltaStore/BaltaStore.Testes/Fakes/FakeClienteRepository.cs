using BaltaStore.Dominio.Entidades;
using BaltaStore.Dominio.Repositories;

namespace BaltaStore.Testes.Fakes;

public class FakeClienteRepository : IClienteRepository
{
    public void Gravar(Cliente cliente)
    {
        
    }

    public bool VerificarDocumento(string documento)
    {
        return false;
    }

    public bool VerificarEmail(string email)
    {
        return false;
    }
}
