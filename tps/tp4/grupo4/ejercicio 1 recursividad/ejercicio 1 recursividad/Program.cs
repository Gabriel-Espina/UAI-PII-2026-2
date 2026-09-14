using System;

class Program
{
    static void MostrarNumeros(int numero)
    {
        if (numero == 0)
        {
            return;
        }

        Console.Write(numero + " ");

        MostrarNumeros(numero - 1);
    }

    static void Main()
    {
        MostrarNumeros(10);

        Console.ReadKey();
    }
}