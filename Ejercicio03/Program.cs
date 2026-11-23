delegate double ConvertirTemperatura(double celsius);

class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 3");
        Console.WriteLine();

        ConvertirTemperatura convertir = delegate (double celsius)
        {
            return celsius * 9 / 5 + 32;
        };

        Console.WriteLine($"0°C -> {convertir(0)}°F");
        Console.WriteLine($"30°C -> {convertir(30)}°F");
    }
}
