using System;

internal class Program
{
    static void Main(string[] args)
    {
        double suma = 0;
        int contador = 0;
        double mayor = 0;

        // Se usa un valor muy grande para que la primera nota válida pueda convertirse en la menor
        double menor = double.MaxValue;

        Console.Write("Ingrese nota (-1 para terminar): ");
        double nota = double.Parse(Console.ReadLine());

        // El while continúa mientras no se ingrese el valor centinela
        while (nota != -1)
        {
            // Validar que la nota esté dentro del rango permitido
            if (nota < 0 || nota > 20)
            {
                Console.WriteLine("Nota inválida. Debe estar entre 0 y 20.");
            }
            else
            {
                // Solo las notas válidas se suman y se cuentan
                suma = suma + nota;
                contador = contador + 1;

                // Actualizar la nota mayor si corresponde
                if (nota > mayor)
                {
                    mayor = nota;
                }

                // Actualizar la nota menor si corresponde
                if (nota < menor)
                {
                    menor = nota;
                }
            }

            // Nueva lectura para que la condición del while pueda cambiar
            Console.Write("Ingrese nota (-1 para terminar): ");
            nota = double.Parse(Console.ReadLine());
        }

        // Se verifica que exista al menos una nota válida antes de dividir
        if (contador > 0)
        {
            double promedio = suma / contador;

            Console.WriteLine($"Notas ingresadas: {contador}");
            Console.WriteLine($"Nota más alta: {mayor}");
            Console.WriteLine($"Nota más baja: {menor}");
            Console.WriteLine($"Promedio: {promedio:F2}");
        }
        else
        {
            Console.WriteLine("No se ingresaron notas válidas.");
        }
    }
}