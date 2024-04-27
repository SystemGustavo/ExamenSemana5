using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SistGestionPedidos
{
    public class GestorPedidos
    {
        private readonly IProveedor _proveedor;
        private Pedidos _pedido;

        public GestorPedidos(IProveedor proveedor, Pedidos pedido)
        {
            _proveedor = proveedor;
            _pedido = pedido;
        }

        public void EnviarPedidosTipoProducto()
        {
            Console.WriteLine($"Pedido : {_pedido.Id}\n Cliente : {_pedido.Cliente.Nombre}\n Estado {_pedido.EstadoPedido.ToString() } \n");
            _proveedor.EnviarPedido(_pedido);
        }
        public void EnviarPedidoSegunTipoProducto(Pedidos Pedido, IProveedor proveedor)
        {
        }
    }
}
