using System;

class Program
{
    static void Main()
    {
        int[] vector = { 8, 3, 10, 1, 6, 4, 2 };

        Console.WriteLine("Vector desordenado:");
        MostrarVector(vector);

        OrdenarVector(vector, vector.Length);

        Console.WriteLine("\nVector ordenado:");
        MostrarVector(vector);
    }

    static void OrdenarVector(int[] vector, int cantidad)
    {
        if (cantidad <= 1)
        {
            return;
        }

        CompararElementos(vector, 0, cantidad);

        OrdenarVector(vector, cantidad - 1);
    }

    static void CompararElementos(
        int[] vector,
        int posicion,
        int cantidad
    )
    {
        if (posicion >= cantidad - 1)
        {
            return;
        }

        if (vector[posicion] > vector[posicion + 1])
        {
            int auxiliar = vector[posicion];

            vector[posicion] = vector[posicion + 1];
            vector[posicion + 1] = auxiliar;
        }

        CompararElementos(vector, posicion + 1, cantidad);
    }

    static void MostrarVector(int[] vector)
    {
        foreach (int numero in vector)
        {
            Console.Write(numero + " ");
        }

        Console.WriteLine();
    }
}