using System;

class Program
{
    static void ConvertirMaya(int numero, int[] niveles, out int cantidad)
    {
        cantidad = 0;

        if (numero == 0)
        {
            niveles[cantidad++] = 0;
            return;
        }

        while (numero > 0)
        {
            niveles[cantidad] = numero % 20;
            numero /= 20;
            cantidad++;
        }
    }

    static void DibujarNivel(int valor)
    {
        if (valor == 0)
        {
            Console.WriteLine("   0");
            return;
        }

        int barras = valor / 5;
        int puntos = valor % 5;

        for (int i = 0; i < puntos; i++)
            Console.Write(" ●");

        if (puntos > 0)
            Console.WriteLine();

        for (int i = 0; i < barras; i++)
            Console.WriteLine("═════");
    }

    static void MostrarNumeroMaya(int[] niveles, int cantidad)
    {
        Console.WriteLine("\n===== NUMERO MAYA =====\n");

        for (int i = cantidad - 1; i >= 0; i--)
        {
            Console.WriteLine("Nivel " + (cantidad - i));
            DibujarNivel(niveles[i]);
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int numero;
        int[] niveles = new int[20];
        int cantidad;

        Console.Write("Ingrese un numero decimal: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("Solo se permiten numeros positivos.");
            return;
        }

        ConvertirMaya(numero, niveles, out cantidad);

        MostrarNumeroMaya(niveles, cantidad);

        Console.WriteLine("Programa creado por Jose Argueta");
    }
}
