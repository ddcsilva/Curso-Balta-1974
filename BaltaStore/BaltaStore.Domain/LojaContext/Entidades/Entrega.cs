using BaltaStore.Domain.LojaContext.Enums;
using System;

namespace BaltaStore.Domain.LojaContext.Entidades
{
    public class Entrega
    {
        public Entrega(DateTime dataEntregaEstimada)
        {
            DataCriacao = DateTime.Now;
            DataEntregaEstimada = dataEntregaEstimada;
            Status = StatusEntregaEnum.Aguardando;
        }

        public DateTime DataCriacao { get; private set; }
        public DateTime DataEntregaEstimada { get; private set; }
        public StatusEntregaEnum Status { get; private set; }
    }
}
