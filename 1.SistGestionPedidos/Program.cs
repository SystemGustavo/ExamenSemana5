using _1.SistGestionPedidos;

public class Program
{
    public static void Main()
    {
        ProveedorElectronica provElect = new ProveedorElectronica();
        ProveedorRopa provRopa = new ProveedorRopa();
        GestorPedidos gestor1 = new GestorPedidos(new ProveedorRopa() 
        { 
            Nombre = "Kevin",
            Apellidos = "Diaz",
            Correo = "Kevin@gmail.com",
        }
        
        ,new Pedidos
        {
            Id = 1,
            EstadoPedido = EstadoPedido.Enviado,
            FechaPedido = DateTime.Now,
            Cliente = new Cliente
            {
                Nombre = "Pedro",
                Apellidos = "Perez",
                Correo = "pedro@gmail.com"
            }
        }
       );

        GestorPedidos gestor2 = new GestorPedidos(new ProveedorElectronica()
        {
            Nombre = "Ana",
            Apellidos = "Quispe",
            Correo = "Ana@gmail.com",
        }

        , new Pedidos
        {
            Id = 2,
            EstadoPedido = EstadoPedido.Cancelado,
            FechaPedido = DateTime.Now,
            Cliente = new Cliente
            {
                Nombre = "Lucia",
                Apellidos = "Huaman",
                Correo = "Lucia@gmail.com"
            }
        }
       );

        gestor1.EnviarPedidosTipoProducto();
        gestor2.EnviarPedidosTipoProducto();
        Console.ReadKey();

    }
}