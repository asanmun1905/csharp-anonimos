delegate int ContarCaracteres(string palabra);

class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 7");
        Console.WriteLine();

        ContarCaracteres contar = delegate (string palabra)
        {
            return palabra.Length;
        };

        Console.WriteLine($"La palabra 'mundo' tiene {contar("mundo")} caracteres");
        Console.WriteLine($"La palabra 'programa' tiene {contar("programa")} caracteres");
    }
}
