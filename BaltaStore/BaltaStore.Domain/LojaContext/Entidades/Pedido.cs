using BaltaStore.Domain.LojaContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BaltaStore.Domain.LojaContext.Entidades
{
    public class Pedido
    {
        private readonly IList<ItemPedido> _itens;
        private readonly IList<Entrega> _entregas;

        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
            Numero = Guid.NewGuid().ToString().Replace("-", "").Substring(0,8).ToUpper();
            DataCriacao = DateTime.Now;
            Status = StatusPedidoEnum.Criado;
            _itens = new List<ItemPedido>();
            _entregas = new List<Entrega>();
        }

        public string Numero { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public StatusPedidoEnum Status { get; private set; }
        public Cliente Cliente { get; private set; }
        public IReadOnlyCollection<ItemPedido> Itens => _itens.ToArray();
        public IReadOnlyCollection<Entrega> Entregas => _entregas.ToArray();

        public void AdicionarItem(ItemPedido item)
        {
            _itens.Add(item);
        }

        public void AdicionarEntrega(Entrega entrega)
        {
            _entregas.Add(entrega);
        }

        public void Finalizar()
        {
            // Finalizar Pedido
        }
    }
}
