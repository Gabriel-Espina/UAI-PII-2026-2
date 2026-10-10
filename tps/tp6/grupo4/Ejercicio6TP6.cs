using System;
using System.Collections.Generic;
using System.Linq;

class Cliente
{
    public string Nombre { get; }
    public bool TieneTicket { get; }
    public int NumeroTicket { get; }

    public Cliente(string nombre, bool tieneTicket, int numeroTicket)
    {
        Nombre = nombre;
        TieneTicket = tieneTicket;
        NumeroTicket = numeroTicket;
    }

    public override string ToString()
    {
        return TieneTicket
            ? $"{Nombre} (Ticket {NumeroTicket})"
            : $"{Nombre} (Sin ticket)";
    }
}

class Ejercicio6
{
    static void Main(string[] args)
    {
        Queue<Cliente> colaInicial = new Queue<Cliente>();
        colaInicial.Enqueue(new Cliente("Cliente 1", true, 1));
        colaInicial.Enqueue(new Cliente("Cliente 2", true, 2));
        colaInicial.Enqueue(new Cliente("Cliente 3", true, 3));
        colaInicial.Enqueue(new Cliente("Cliente 4", true, 4));
        colaInicial.Enqueue(new Cliente("Cliente 5", false, 5));
        colaInicial.Enqueue(new Cliente("Cliente 6", false, 6));
        colaInicial.Enqueue(new Cliente("Cliente 7", true, 7));

        Console.WriteLine("=== Cola inicial ===");
        MostrarCola(colaInicial);

        Queue<Cliente> colaFinal = new Queue<Cliente>();
        List<string> eliminados = new List<string>();
        int ultimoNumero = 0;

        while (colaInicial.Count > 0)
        {
            Cliente cliente = colaInicial.Dequeue();

            if (cliente.TieneTicket)
            {
                ultimoNumero = cliente.NumeroTicket;
                colaFinal.Enqueue(cliente);
                Console.WriteLine($"\nSe desencola: {cliente.Nombre} - tiene ticket. Se vuelve a encolar.");
            }
            else
            {
                eliminados.Add($"{cliente.Nombre} (sin ticket) -> se le asigna el último número de la cola: {ultimoNumero}");
                Console.WriteLine($"\nSe desencola: {cliente.Nombre} - no tiene ticket. Se retira de la cola.");
            }
        }

        Console.WriteLine("\n=== Elementos retirados ===");
        if (eliminados.Count == 0)
        {
            Console.WriteLine("No hubo colados.");
        }
        else
        {
            foreach (string elemento in eliminados)
            {
                Console.WriteLine($"- {elemento}");
            }
        }

        Console.WriteLine("\n=== Cola final ===");
        MostrarCola(colaFinal);
    }

    static void MostrarCola(Queue<Cliente> cola)
    {
        if (cola.Count == 0)
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }

        foreach (var cliente in cola)
        {
            Console.WriteLine($"- {cliente}");
        }
    }
}