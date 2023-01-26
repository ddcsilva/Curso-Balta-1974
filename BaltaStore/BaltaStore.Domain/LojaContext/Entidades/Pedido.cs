using BaltaStore.Domain.LojaContext.Enums;
using System;
using System.Collections.Generic;

namespace BaltaStore.Domain.LojaContext.Entidades
{
    public class Pedido
    {
        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
            Numero = Guid.NewGuid().ToString().Replace("-", "").Substring(0,8).ToUpper();
            DataCriacao = DateTime.Now;
            Status = StatusPedidoEnum.Criado;
            Items = new List<ItemPedido>();
            Entregas = new List<Entrega>();
        }

        public string Numero { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public StatusPedidoEnum Status { get; private set; }
        public Cliente Cliente { get; private set; }
        public IReadOnlyCollection<ItemPedido> Items { get; private set; }
        public IReadOnlyCollection<Entrega> Entregas { get; private set; }

        public void AdicionarItem(ItemPedido item)
        {
            // Valida item
            // Adiciona item ao pedido
        }

        public void Finalizar()
        {
            // Finalizar Pedido
        }
    }
}
