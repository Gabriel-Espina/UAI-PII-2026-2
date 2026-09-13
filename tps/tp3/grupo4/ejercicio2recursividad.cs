using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("No se puede calcular el factorial de un número negativo.");
        }
        else
        {
            long resultado = CalcularFactorial(numero);
            Console.WriteLine($"El factorial de {numero} es: {resultado}");
        }
    }

    static long CalcularFactorial(int numero)
    {
        if (numero == 0 || numero == 1)
        {
            return 1;
        }

        return numero * CalcularFactorial(numero - 1);
    }
}