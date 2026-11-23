delegate bool FiltroEmpleado(Empleado empleado);

class Program
{
    static void FiltrarEmpleados(List<Empleado> empleados, FiltroEmpleado filtro)
    {
        foreach (Empleado empleado in empleados)
        {
            if (filtro(empleado))
            {
                Console.WriteLine($"- {empleado.Nombre} (Edad: {empleado.Edad})");
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Ejercicio 10");
        Console.WriteLine();

        List<Empleado> empleados = new List<Empleado>
        {
            new Empleado("Ana", 35),
            new Empleado("Luis", 42),
            new Empleado("Marta", 28),
            new Empleado("Pedro", 30)
        };

        FiltroEmpleado mayoresDe30 = delegate (Empleado empleado)
        {
            return empleado.Edad > 30;
        };

        Console.WriteLine("Empleados mayores de 30 años:");
        FiltrarEmpleados(empleados, mayoresDe30);
    }
}
