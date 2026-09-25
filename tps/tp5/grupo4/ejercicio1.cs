using System;
using System.Collections.Generic;
//Pilas


class Ejercicio1Pilas
{
    static void Main(string[] args)
    {
        Stack<string> contenedores = new Stack<string>();
        contenedores.Push("ID: 3153");
        contenedores.Push("ID: 4934");
        contenedores.Push("ID: 5678");
        contenedores.Push("ID: 2345");
        contenedores.Push("ID: 7890");


        foreach (string contenedor in contenedores)
        {
            Console.WriteLine(contenedor);
        }


        Console.WriteLine("Ingrese el ID del contenedor desea retirar: ");
        string idRetirar = Console.ReadLine();
        Stack<string> auxiliar = new Stack<string>();
        bool retirado = false;


        while (contenedores.Count > 0)
        {
            string contenedor = contenedores.Pop();


            if (contenedor == $"ID: {idRetirar}" && !retirado)
            {
                retirado = true;
            }
            else
            {
                auxiliar.Push(contenedor);
            }
        }


        while (auxiliar.Count > 0)
        {
            contenedores.Push(auxiliar.Pop());
        }


        Console.WriteLine(retirado
            ? "Contenedor retirado."
            : "No se encontro un contenedor con ese ID.");
        Console.WriteLine("Contenedores restantes:");
        foreach (string contenedor in contenedores)
        {
            Console.WriteLine(contenedor);
        }
    }
}
