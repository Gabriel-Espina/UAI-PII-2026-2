using System;

class Ejercicio6
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la cantidad de números de Fibonacci: ");
        int n = int.Parse(Console.ReadLine());

        int anterior = 0;
        int actual = 1;

        Console.WriteLine($"Los primeros {n} números de Fibonacci son:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(anterior + " ");

            int siguiente = anterior + actual;
            anterior = actual;
            actual = siguiente;
        }
    }
}