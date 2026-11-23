delegate long CalcularFactorial(int numero);

class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 6");
        Console.WriteLine();

        CalcularFactorial factorial = delegate (int numero)
        {
            long resultado = 1;
            for (int i = numero; i >= 1; i--)
            {
                resultado = resultado * i;
            }
            return resultado;
        };

        Console.WriteLine($"Factorial de 4 es {factorial(4)}");
        Console.WriteLine($"Factorial de 6 es {factorial(6)}");
    }
}
