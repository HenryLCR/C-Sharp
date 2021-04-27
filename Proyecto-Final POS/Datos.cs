using System;
using System.Collections.Generic;
public class Datos
{
    public List<Producto> ListadeProductos { get; set; }
    public List<Cliente> ListadeClientes { get; set; }
    public List<Orden> ListaOrdenes { get; set; }

    public Datos()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListaOrdenes = new List<Orden>();
    }

    private void cargarProductos()
    {
        Producto p1 = new Producto(1, "Mouse                  ",250);
        ListadeProductos.Add(p1);
        Producto p2 = new Producto(2, "Teclado                ", 350);
        ListadeProductos.Add(p2);
        Producto p3 = new Producto(3, "Monitor                ", 4000);
        ListadeProductos.Add(p3);
        Producto p4 = new Producto(4, "USB 16GB               ", 322);
        ListadeProductos.Add(p4);
        Producto p5 = new Producto(5, "Auricular Inalambrico  ", 570);
        ListadeProductos.Add(p5);
        Producto p6 = new Producto(6, "Monitor Acer           ", 1125);
        ListadeProductos.Add(p6);
        Producto p7 = new Producto(7, "Mouse Gaming           ", 950);
        ListadeProductos.Add(p7);
        Producto p8 = new Producto(8, "Silla Gaming           ", 3500);
        ListadeProductos.Add(p8);
    }

    private void cargarClientes()
    {
        Cliente c1 = new Cliente(1, " Juan Perez   ", "77790232", "050123232343" );
        ListadeClientes.Add(c1);
        Cliente c2 = new Cliente(2, "Pedro Escobar ", "98976573", "050234343434");
        ListadeClientes.Add(c2);
        Cliente c3 = new Cliente(3, "Raul Ramos    ", "87654534", "054534342123");
        ListadeClientes.Add(c3);
        Cliente c4 = new Cliente(4, "Henry La Chira", "34212343", "045323234343");
        ListadeClientes.Add(c4);
        Cliente c5 = new Cliente(5, "Abdel Ramirez ", "98673412", "050232343432");
        ListadeClientes.Add(c5);
        Cliente c6 = new Cliente(6, "Fiallos Mendez", "84567654", "050123434324");
        ListadeClientes.Add(c6);
        Cliente c7 = new Cliente(7, "Brayan Paz    ", "99980023", "050732434233");
        ListadeClientes.Add(c7);
        Cliente c8 = new Cliente(8, "Fiallos Mendez", "98873422", "050834322322");
        ListadeClientes.Add(c8);
    }


    public void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine("========      =========");
        Console.WriteLine("-------Productos-------");
        Console.WriteLine("========     ==========");
        Console.WriteLine("");
        
        Console.WriteLine("Codigo  |    Producto              |   Precio");
        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + "       | " + producto.Descripcion + "  |    " + producto.Precio);
        }

        Console.ReadLine();
    }

    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("========        =========");
        Console.WriteLine(" -------Clientes---------");
        Console.WriteLine("========        =========");
        Console.WriteLine("");
        
        Console.WriteLine("Codigo  |    Nombre Cliente       |   Telefono    |       RTN");
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + "       |   " + cliente.Nombre + "        |    " + cliente.Telefono + "   |    " + cliente.Rtn );
        }

        Console.ReadLine();
    }

    public void CrearOrden()
    {
        Console.Clear();
        Console.WriteLine("======       =======");
        Console.WriteLine("---Creando Venta---");
        Console.WriteLine("======       =======");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el codigo del cliente: ");
        string codigoCliente = Console.ReadLine();

        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);        
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

        int nuevoCodigo = ListaOrdenes.Count + 1;

        Orden nuevaOrden = new Orden(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente );
        ListaOrdenes.Add(nuevaOrden);

        while(true)
        {
            Console.WriteLine("Ingrese el producto: ");
            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);        
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                nuevaOrden.AgregarProducto(producto);
            }

            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
        }
        Console.WriteLine("SubTotal de la orden es de:    " + nuevaOrden.SubTotal);
        Console.WriteLine("Impuesto:                      " + nuevaOrden.Impuesto);
        Console.WriteLine("Total de la orden es de:       " + nuevaOrden.Total);
        Console.ReadLine();
    }

    public void ListarOrdenes()
    {
        Console.Clear();
        Console.WriteLine("========      ========");
        Console.WriteLine("---Reporte de Ventas---");
        Console.WriteLine("========      ========");
        Console.WriteLine("");  
        Console.WriteLine("===================================");
        Console.WriteLine("");  

        foreach (var orden in ListaOrdenes)
        {
            Console.WriteLine("");
            Console.WriteLine("-Codigo | Fecha ");
            Console.WriteLine(orden.Codigo + "         |   " + orden.Fecha);
            Console.WriteLine("");
            Console.WriteLine("-Subtotal | Impuesto | Total ");
            Console.WriteLine(orden.SubTotal + "      | " + orden.Impuesto + "      | " + orden.Total);
            Console.WriteLine("");
      
            
            Console.WriteLine(""); 
            Console.WriteLine("-Descripcion                 | Cantidad         | Precio");
            foreach (var detalle in orden.ListaOrdenDetalle)
            {
                Console.WriteLine("     " + detalle.Producto.Descripcion + " | " + detalle.Cantidad + "                | " + detalle.Precio);
            }

            Console.WriteLine();
            Console.WriteLine("=====================================");
        } 

        Console.ReadLine();
    }
}