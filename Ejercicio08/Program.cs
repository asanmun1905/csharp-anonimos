delegate bool Operacion(int numero);

class Program
{
    static void ProcesarNumero(int numero, Operacion operacion)
    {
        Console.WriteLine($"El número {numero} es par: {operacion(numero)}");
    }

    static void Main()
    {
        Console.WriteLine("Ejercicio 8");
        Console.WriteLine();

        Operacion esPar = delegate (int numero)
        {
            return numero % 2 == 0;
        };

        ProcesarNumero(4, esPar);
        ProcesarNumero(7, esPar);
    }
}
