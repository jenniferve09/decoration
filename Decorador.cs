using System 
public class Decorador:OrdenBase
{
    protected OrdenBase orden;
    public Decorador (OrdenBase orden)
    {
        this.orden = orden;
    }
    public override double CalculoTotalPrecio()
    {
        Console.WriteLine("Calculo del precio total desde la clase decorador");
       return orden.CalculoTotalPrecio();
    }
}