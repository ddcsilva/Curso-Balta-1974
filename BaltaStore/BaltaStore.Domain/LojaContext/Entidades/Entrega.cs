using System;

namespace BaltaStore.Domain.LojaContext.Entidades
{
    public class Entrega
    {
        public DateTime DataCriacao { get; set; }
        public DateTime DataEntregaEstimada { get; set; }
        public string Status { get; set; }
    }
}
