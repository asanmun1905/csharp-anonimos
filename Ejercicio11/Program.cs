delegate bool FiltroLibros(Libro libro);

class Program
{
    static void MostrarLibrosPorCategoria(List<Libro> libros, FiltroLibros filtro)
    {
        foreach (Libro libro in libros)
        {
            if (filtro(libro))
            {
                Console.WriteLine($"- {libro.Titulo}");
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Ejercicio 11");
        Console.WriteLine();

        List<Libro> libros = new List<Libro>
        {
            new Libro("El Hobbit", "Ficción"),
            new Libro("Harry Potter", "Ficción"),
            new Libro("Sapiens", "Historia"),
            new Libro("El origen de las especies", "Ciencia")
        };

        FiltroLibros soloFiccion = delegate (Libro libro)
        {
            return libro.Categoria == "Ficción";
        };

        Console.WriteLine("Libros de la categoría Ficción:");
        MostrarLibrosPorCategoria(libros, soloFiccion);
    }
}
