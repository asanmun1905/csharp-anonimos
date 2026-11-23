delegate bool Filtro(Producto producto);

class Program
{
    static void MostrarProductosFiltrados(List<Producto> productos, Filtro filtro)
    {
        foreach (Producto producto in productos)
        {
            if (filtro(producto))
            {
                Console.WriteLine($"- {producto.Nombre} (Cantidad: {producto.Cantidad})");
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Ejercicio 9");
        Console.WriteLine();

        List<Producto> productos = new List<Producto>
        {
            new Producto("Televisor", 10),
            new Producto("Refrigerador", 7),
            new Producto("Microondas", 3),
            new Producto("Plancha", 5)
        };

        int minimo = 5;

        Filtro mayorQueMinimo = delegate (Producto producto)
        {
            return producto.Cantidad > minimo;
        };

        Console.WriteLine($"Productos con cantidad mayor a {minimo}:");
        MostrarProductosFiltrados(productos, mayorQueMinimo);
    }
}
