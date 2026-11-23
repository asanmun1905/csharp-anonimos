delegate bool FiltroVehiculo(Vehiculo vehiculo);

class Program
{
    static void MostrarVehiculosAntiguos(List<Vehiculo> vehiculos, FiltroVehiculo filtro)
    {
        foreach (Vehiculo vehiculo in vehiculos)
        {
            if (filtro(vehiculo))
            {
                Console.WriteLine($"- {vehiculo.Marca} {vehiculo.Modelo} ({vehiculo.AnioFabricacion})");
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Ejercicio 12");
        Console.WriteLine();

        List<Vehiculo> vehiculos = new List<Vehiculo>
        {
            new Vehiculo("Toyota", "Corolla", 2005),
            new Vehiculo("Honda", "Civic", 2008),
            new Vehiculo("Ford", "Focus", 2015),
            new Vehiculo("Tesla", "Model 3", 2020)
        };

        FiltroVehiculo anteriorA2010 = delegate (Vehiculo vehiculo)
        {
            return vehiculo.AnioFabricacion < 2010;
        };

        Console.WriteLine("Vehículos fabricados antes de 2010:");
        MostrarVehiculosAntiguos(vehiculos, anteriorA2010);
    }
}
