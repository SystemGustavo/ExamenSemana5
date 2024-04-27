using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SistGestionPedidos
{
    public class Pedidos
    {
        public int Id { get; set; }
        public DateTime FechaPedido { get; set; }
        public Cliente Cliente { get; set; }    
        public EstadoPedido EstadoPedido { get; set; }
        public ProveedorElectronica provElect { get; set; }
        public ProveedorRopa provRopa { get; set; }

    }
}
