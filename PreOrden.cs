using System
public class PreOrden:OrdenBase
{
    public override double CalculoTotalPrecio()
    {
        Console.WriteLine("Calculo del precio total en una preorden");
        return productos.Sum(x => x.Precio) * 0.9;
    }
}