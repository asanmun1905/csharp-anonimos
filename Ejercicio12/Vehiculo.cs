class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int AnioFabricacion { get; set; }

    public Vehiculo(string marca, string modelo, int anioFabricacion)
    {
        Marca = marca;
        Modelo = modelo;
        AnioFabricacion = anioFabricacion;
    }
}
