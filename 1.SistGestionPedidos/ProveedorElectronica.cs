using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SistGestionPedidos
{
    public class ProveedorElectronica : IProveedor
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Tipo { get; } = "Proveedor Electronica";
        public void EnviarPedido(Pedidos Pedido)
        {
            Console.WriteLine($"Proveedor : {Nombre} \n TipoProveedor : {Tipo}");
        }
    }
}
