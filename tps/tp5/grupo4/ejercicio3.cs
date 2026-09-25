using System;
using System.Collections.Generic;
using System.Linq;
class Ejercicio3Pilas
{
    static void Main(string[] args)
    {
        List<Expediente> expedientes = new List<Expediente>
        {
            new Expediente(new DateTime(2026, 9, 15), 7832, "Robo"),
            new Expediente(new DateTime(2026, 9, 20), 8041, "Hurto"),
            new Expediente(new DateTime(2026, 9, 20), 8100, "Fraude"),
            new Expediente(new DateTime(2026, 9, 20), 8205, "Estafa"),
            new Expediente(new DateTime(2026, 10, 5), 8302, "Asalto")
        };


        List<Expediente> ordenados = expedientes
            .OrderBy(expediente => expediente.Fecha)
            .ThenBy(expediente => expediente.Numero)
            .ToList();


        Stack<Expediente> pila = new Stack<Expediente>();
        for (int i = ordenados.Count - 1; i >= 0; i--)
        {
            pila.Push(ordenados[i]);
        }


        Console.WriteLine("----Juzgado---- ");


        foreach (Expediente expediente in pila.Reverse())
        {
            Console.WriteLine(expediente);
        }
    }
}


class Expediente
{
    public DateTime Fecha { get; }
    public int Numero { get; }
    public string Caratula { get; }


    public Expediente(DateTime fecha, int numero, string caratula)
    {
        Fecha = fecha;
        Numero = numero;
        Caratula = caratula;
    }


    public override string ToString()
    {
        return $"Fecha: {Fecha:dd/MM/yyyy}, Expediente: {Numero}, Caratula: {Caratula}";
    }
}
