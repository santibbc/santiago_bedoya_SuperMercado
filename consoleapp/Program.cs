// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var producto = new Producto();
var clientes = new Clientes();
Producto producto1 = new Producto();
Producto producto2 = new Producto();

producto.Id = 1;
producto.Nombre = "arroz roa";
producto.Precio = 4500m;
producto.Categoria = new Categorias() { Id = 1, Nombre = "tipo: arroz" };
producto.Proveedores = new List<Proveedores>();
producto.Proveedores.Add(new Proveedores() { Id = 1, Nombre = "proveedor: proveedor 1" });
producto.Proveedores.Add(new Proveedores() { Id = 2, Nombre = "proveedor: proveedor 2" });

clientes.Id_cliente = 1000567154;
clientes.Nombre_cliente = "santiago bedoya";
clientes.Direccion_cliente = "cra 27#55-10";
clientes.Telefono_cliente = "3003138337";
clientes.Productos = new List<Clientes>();
clientes.Productos.Add(new Clientes() { Id_cliente = 1000567154, Nombre_cliente = "santiago bedoya", Direccion_cliente = "cra 27#55-10", Telefono_cliente = "3003138337" });
clientes.Productos.Add(new Clientes() { Id_cliente = 1000567155, Nombre_cliente = "laura gomez", Direccion_cliente = "cra 30#20-15", Telefono_cliente = "3009876543" });




Console.WriteLine(producto.Nombre);
Console.WriteLine(producto.Categoria.Nombre);
Console.WriteLine(clientes.Productos[1].Nombre_cliente);
Console.WriteLine(clientes.Productos[1].Direccion_cliente);
Console.WriteLine(clientes.Productos[1].Telefono_cliente);




foreach (var elemento in producto.Proveedores)
{
    Console.WriteLine(elemento.Nombre);
}

public class Categorias
{
    public int Id = 0;
    public string? Nombre = "";

    public List<Producto> Productos = new List<Producto>();
}

public class Proveedores
{
    public int Id = 0;
    public string? Nombre = "";
}

public class Producto
{
    public int Id = 0;
    public string? Nombre = "";
    public decimal Precio = 0.0m;
    public Categorias Categoria = new Categorias();
    public List<Proveedores> Proveedores = new List<Proveedores>();
}

public class Clientes
{
    public int Id_cliente = 0;
    public string? Nombre_cliente = "";
    public string? Direccion_cliente = "";
    public string? Telefono_cliente = "";
    public List<Clientes> Productos = new List<Clientes>();
}

//cambio en main
//cambio local
