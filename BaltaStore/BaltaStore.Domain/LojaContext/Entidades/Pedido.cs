using BaltaStore.Domain.LojaContext.Enums;
using FluentValidator;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BaltaStore.Domain.LojaContext.Entidades
{
    public class Pedido : Notifiable
    {
        private readonly IList<ItemPedido> _itens;
        private readonly IList<Entrega> _entregas;

        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
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

        public void Gerar()
        {
            // Gera o número do pedido
            Numero = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();

            if (_itens.Count == 0)
                AddNotification("Pedido", "Este pedido não possui itens");
        }

        public void Pagar()
        {
            Status = StatusPedidoEnum.Pago;
        }

        // Enviar
        public void Enviar()
        {
            // A cada 5 produtos é uma entrega
            var entregas = new List<Entrega>();
            entregas.Add(new Entrega(DateTime.Now.AddDays(5)));

            var quantidadeProdutos = 1;

            // Quebra as entregas
            foreach (var item in _itens)
            {
                if (quantidadeProdutos == 5)
                {
                    entregas.Add(new Entrega(DateTime.Now.AddDays(5)));
                    quantidadeProdutos = 1;
                }

                quantidadeProdutos++;
            }

            // Envia todas as entregas
            entregas.ForEach(x => x.Enviar());

            // Adiciona as entregas ao pedido
            entregas.ForEach(x => _entregas.Add(x));
        }

        public void Cancelar()
        {
            Status = StatusPedidoEnum.Cancelado;
            _entregas.ToList().ForEach(x => x.Cancelar());
        }
    }
}
