delegate int Multiplicar(int a, int b);

class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 1");
        Console.WriteLine();

        Multiplicar multiplicar = delegate (int a, int b)
        {
            return a * b;
        };

        Console.WriteLine($"4 * 3 = {multiplicar(4, 3)}");
        Console.WriteLine($"7 * 5 = {multiplicar(7, 5)}");
    }
}
