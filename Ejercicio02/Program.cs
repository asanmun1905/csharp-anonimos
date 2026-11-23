delegate bool VerificarPalindromo(string palabra);

class Program
{
    static void Main()
    {
        Console.WriteLine("Ejercicio 2");
        Console.WriteLine();

        VerificarPalindromo verificar = delegate (string palabra)
        {
            char[] letras = palabra.ToCharArray();
            Array.Reverse(letras);
            string alReves = new string(letras);
            return palabra == alReves;
        };

        Console.WriteLine($"'radar' es un palíndromo: {verificar("radar")}");
        Console.WriteLine($"'puerta' es un palíndromo: {verificar("puerta")}");
    }
}
