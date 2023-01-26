using System;
using System.Collections.Generic;

namespace BaltaStore.Domain.LojaContext.Entidades
{
    public class Pedido
    {
        public string Numero { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Status { get; set; }
        public Cliente Cliente { get; set; }
        public IList<ItemPedido> Items { get; set; }
        public IList<Entrega> Entregas { get; set; }

        public void Finalizar()
        {

        }
    }
}
