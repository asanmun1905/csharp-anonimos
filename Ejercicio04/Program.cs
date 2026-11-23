delegate bool EsMayorQueDiez(int numero);

class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 4");
        Console.WriteLine();

        EsMayorQueDiez esMayor = delegate (int numero)
        {
            return numero > 10;
        };

        Console.WriteLine($"8 es mayor que 10: {esMayor(8)}");
        Console.WriteLine($"15 es mayor que 10: {esMayor(15)}");
    }
}
