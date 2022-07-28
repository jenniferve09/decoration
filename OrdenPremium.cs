public class OrdenPremium : Decorador
{
    public OrdenPremium(OrdenBase orden) : base(orden)
    {

    }
    public override double CalculoTotalPrecio()
    {
        Console.WriteLine("Calculo Total del precio orden premium");
        var precioOrdenPrecio =base.CalculoTotalPrecio();
        return precioOrdenPrecio *0.9;

    }
}