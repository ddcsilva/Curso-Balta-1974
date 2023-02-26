
using BaltaStore.Comum.Entities;
using BaltaStore.Dominio.Enumeradores;
using FluentValidator;

namespace BaltaStore.Dominio.Entidades;

public class Entrega : Entity
{
    public Entrega(DateTime dataEntregaEstimada)
    {
        DataCriacao = DateTime.Now;
        DataEntregaEstimada = dataEntregaEstimada;
        Status = EStatusEntrega.Aguardando;
    }

    public DateTime DataCriacao { get; private set; }
    public DateTime DataEntregaEstimada { get; private set; }
    public EStatusEntrega Status { get; private set; }

    public void Enviar()
    {
        // Se a Data Estimada de entrega for no passado, não entregar
        Status = EStatusEntrega.Enviado;
    }

    public void Cancelar()
    {
        // Se o Status estiver como Entregue, não pode cancelar
        Status = EStatusEntrega.Cancelado;
    }
}