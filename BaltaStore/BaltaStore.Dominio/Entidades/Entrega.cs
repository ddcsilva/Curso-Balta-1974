
using BaltaStore.Dominio.Enumeradores;

namespace BaltaStore.Dominio.Entidades;

public class Entrega
{
    public Entrega(DateTime dataCriacao, DateTime dataEntregaEstimada, EStatusEntrega status)
    {
        DataCriacao = DateTime.Now;
        DataEntregaEstimada = dataEntregaEstimada;
        Status = EStatusEntrega.Aguardando;
    }

    public DateTime DataCriacao { get; private set; }
    public DateTime DataEntregaEstimada { get; private set; }
    public EStatusEntrega Status { get; private set; }
}