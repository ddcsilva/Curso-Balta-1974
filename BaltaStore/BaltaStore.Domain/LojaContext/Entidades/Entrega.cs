using BaltaStore.Domain.LojaContext.Enums;
using System;

namespace BaltaStore.Domain.LojaContext.Entidades
{
    public class Entrega
    {
        public Entrega(DateTime dataEstimadaEntrega)
        {
            DataCriacao = DateTime.Now;
            DataEstimadaEntrega = dataEstimadaEntrega;
            Status = StatusEntregaEnum.Aguardando;
        }

        public DateTime DataCriacao { get; private set; }
        public DateTime DataEstimadaEntrega { get; private set; }
        public StatusEntregaEnum Status { get; private set; }

        public void Enviar()
        {
            // Se a data estimada de entrega estiver no passado, não entregar
            Status = StatusEntregaEnum.Enviado;
        }

        public void Cancelar()
        {
            // Se o status já estiver entregue, não pode cancelar
            Status = StatusEntregaEnum.Cancelado;
        }
    }
}
