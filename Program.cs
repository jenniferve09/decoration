using System;
internal class Program
{
    private static void Main (string[] args)
    {
        var ordenRegular = new OrdenRegular();
        Console.WriteLine(ordenRegular.CalculoTotalPrecio());
        Console.WriteLine();

        var preorden = new PreOrden();
        Console.WriteLine(preorden.CalculoTotalPrecio());
        Console.WriteLine();

        var OrdenPremium = new OrdenPremium(preorden);
        Console.WriteLine(OrdenPremium.CalculoTotalPrecio());
        Console.WriteLine();
    }
}
