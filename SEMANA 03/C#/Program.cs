using System;

internal class Program
{
    static void Main(string[] args)
    {
        int stock = 500;
        int totalVendido = 0;

        Console.Write("Unidades vendidas (0 para salir): ");
        int venta = int.Parse(Console.ReadLine());

        // El while continúa mientras no se ingrese el valor centinela 0
        while (venta != 0)
        {
            // Validar que la venta no sea negativa
            if (venta < 0)
            {
                Console.WriteLine("Error: cantidad no puede ser negativa.");
            }
            // Validar que exista stock suficiente
            else if (venta > stock)
            {
                Console.WriteLine($"Error: stock insuficiente. Quedan {stock}");
            }
            else
            {
                // Si la venta es válida, se descuenta del stock
                stock = stock - venta;

                // Se acumulan solo las ventas válidas
                totalVendido = totalVendido + venta;

                Console.WriteLine($"Venta registrada. Stock: {stock}");
            }

            // Nueva lectura para actualizar la condición del while
            Console.Write("Unidades vendidas (0 para salir): ");
            venta = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Stock restante: {stock}");
        Console.WriteLine($"Total vendido: {totalVendido}");
    }
}