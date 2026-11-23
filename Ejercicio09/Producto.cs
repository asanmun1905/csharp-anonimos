class Producto
{
    public string Nombre { get; set; }
    public int Cantidad { get; set; }

    public Producto(string nombre, int cantidad)
    {
        Nombre = nombre;
        Cantidad = cantidad;
    }
}
