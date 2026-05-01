using System;

internal class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int secreto = rand.Next(1, 51); // Número entre 1 y 50

        int intentos = 0;
        int maxIntentos = 7;
        bool adivino = false;

        Console.WriteLine("Adivina el número entre 1 y 50. Tienes 7 intentos.");

        // El while continúa mientras queden intentos y todavía no haya adivinado
        while (intentos < maxIntentos && !adivino)
        {
            intentos++;

            Console.Write($"Intento {intentos}: ");
            int intento = int.Parse(Console.ReadLine());

            if (intento == secreto)
            {
                adivino = true;
            }
            else if (intento < secreto)
            {
                Console.WriteLine("El número secreto es MAYOR.");
            }
            else
            {
                Console.WriteLine("El número secreto es MENOR.");
            }
        }

        // Al salir del while, se revisa si ganó o perdió
        if (adivino)
        {
            Console.WriteLine($"Ganaste en {intentos} intentos.");
        }
        else
        {
            Console.WriteLine($"Perdiste. El número era {secreto}.");
        }
    }
}