using System;
using System.Collections.Generic;
using System.Text;
using WSTowers.Models;

namespace WSTowers.Repository
{
    class PedidoRepository
    {
        private static List<Pedido> pedidos;
        private static int contador = 1;

        public PedidoRepository()
        {
            if (pedidos == null)
            {
                pedidos = new List<Pedido>();

            }
        }
        public List<Pedido> buscarPedido()
        {

            return pedidos;
        }

        public void adcionar(Pedido pedido)
        {
            pedido.Id = contador;
            pedidos.Add(pedido);
            contador++;
        }

        public void limpar()
        {
            pedidos.Clear();
        }
    }
}
