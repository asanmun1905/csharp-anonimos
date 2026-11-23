delegate bool CompararLongitud(string a, string b);

class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 5");
        Console.WriteLine();

        CompararLongitud comparar = delegate (string a, string b)
        {
            return a.Length == b.Length;
        };

        Console.WriteLine($"Las palabras 'gato' y 'perro' tienen la misma longitud: {comparar("gato", "perro")}");
    }
}
