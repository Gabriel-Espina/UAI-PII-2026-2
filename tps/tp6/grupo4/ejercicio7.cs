using System;
using System.Collections.Generic;
using System.Linq;

public enum EstadoCaja
{
    Abierta,
    Cobrando,
    Cerrada
}

public class Cliente
{
    public int Id { get; }

    public Cliente(int id)
    {
        Id = id;
    }
}

public class Caja
{
    public int Numero { get; }
    public EstadoCaja Estado { get; private set; }

    public Queue<Cliente> Cola { get; } = new Queue<Cliente>();
    public Cliente? ClienteActual { get; private set; }

    public decimal Recaudacion { get; private set; }

    public Caja(int numero)
    {
        Numero = numero;
        Estado = EstadoCaja.Abierta;
    }

    public void RecibirCliente(Cliente cliente)
    {
        if (Estado == EstadoCaja.Cerrada)
            throw new InvalidOperationException("La caja está cerrada.");

        Cola.Enqueue(cliente);
        AtenderSiguiente();
    }

    private void AtenderSiguiente()
    {
        if (ClienteActual == null && Cola.Count > 0)
        {
            ClienteActual = Cola.Dequeue();
            Estado = EstadoCaja.Cobrando;
        }
    }

    public void FinalizarCobro(decimal importe)
    {
        if (Estado != EstadoCaja.Cobrando)
            throw new InvalidOperationException(
                "La caja no tiene un cliente en proceso de cobro.");

        if (importe < 0)
            throw new ArgumentException("El importe no puede ser negativo.");

        Recaudacion += importe;
        ClienteActual = null;
        Estado = EstadoCaja.Abierta;

        AtenderSiguiente();
    }

    public List<Cliente> Cerrar()
    {
        var pendientes = new List<Cliente>();

        if (ClienteActual != null)
        {
            pendientes.Add(ClienteActual);
            ClienteActual = null;
        }

        while (Cola.Count > 0)
            pendientes.Add(Cola.Dequeue());

        Estado = EstadoCaja.Cerrada;

        return pendientes;
    }

    public void Abrir()
    {
        if (Estado == EstadoCaja.Cerrada)
            Estado = EstadoCaja.Abierta;
    }
}

public class Supermercado
{
    private readonly List<Caja> cajas = new List<Caja>
    {
        new Caja(1),
        new Caja(2),
        new Caja(3)
    };

    private Caja ObtenerCaja(int numero)
    {
        return cajas.FirstOrDefault(c => c.Numero == numero)
            ?? throw new ArgumentException("Número de caja inválido.");
    }

    private Caja ElegirCaja()
    {
        return cajas
            .Where(c => c.Estado != EstadoCaja.Cerrada)
            .OrderBy(c => c.Cola.Count)
            .ThenBy(c => c.ClienteActual == null ? 0 : 1)
            .ThenBy(c => c.Numero)
            .FirstOrDefault()
            ?? throw new InvalidOperationException(
                "No hay cajas habilitadas.");
    }

    public int AsignarCliente(Cliente cliente)
    {
        Caja caja = ElegirCaja();
        caja.RecibirCliente(cliente);

        return caja.Numero;
    }

    public void FinalizarCobro(int numeroCaja, decimal importe)
    {
        ObtenerCaja(numeroCaja).FinalizarCobro(importe);
    }

    public void CerrarCaja(int numeroCaja)
    {
        Caja caja = ObtenerCaja(numeroCaja);

        if (caja.Estado == EstadoCaja.Cerrada)
            return;

        bool tieneClientes =
            caja.ClienteActual != null || caja.Cola.Count > 0;

        bool hayOtraHabilitada = cajas.Any(c =>
            c.Numero != numeroCaja &&
            c.Estado != EstadoCaja.Cerrada);

        if (tieneClientes && !hayOtraHabilitada)
            throw new InvalidOperationException(
                "No se puede cerrar: hay clientes y no quedan otras cajas habilitadas.");

        List<Cliente> pendientes = caja.Cerrar();

        foreach (Cliente cliente in pendientes)
        {
            AsignarCliente(cliente);
        }
    }

    public void AbrirCaja(int numeroCaja)
    {
        ObtenerCaja(numeroCaja).Abrir();
    }

    public void MostrarEstado()
    {
        foreach (Caja caja in cajas)
        {
            string actual = caja.ClienteActual == null
                ? "ninguno"
                : caja.ClienteActual.Id.ToString();

            Console.WriteLine(
                $"Caja {caja.Numero}: {caja.Estado} | " +
                $"Cliente en cobro: {actual} | " +
                $"En espera: {caja.Cola.Count}");
        }
    }

    public void MostrarRecaudacion()
    {
        foreach (Caja caja in cajas)
        {
            Console.WriteLine(
                $"Caja {caja.Numero}: ${caja.Recaudacion:N2}");
        }

        Console.WriteLine(
            $"Total: ${cajas.Sum(c => c.Recaudacion):N2}");
    }
}

public class ejercicio7
{
    public static void Main()
    {
        var supermercado = new Supermercado();

        for (int id = 1; id <= 8; id++)
        {
            int numeroCaja = supermercado.AsignarCliente(new Cliente(id));

            Console.WriteLine(
                $"Cliente {id} asignado a caja {numeroCaja}.");
        }

        Console.WriteLine("\nEstado inicial:");
        supermercado.MostrarEstado();

        supermercado.FinalizarCobro(1, 15000m);
        supermercado.FinalizarCobro(2, 8500m);

        supermercado.CerrarCaja(3);

        Console.WriteLine("\nEstado después del cierre de caja 3:");
        supermercado.MostrarEstado();

        Console.WriteLine("\nRecaudación acumulada:");
        supermercado.MostrarRecaudacion();
    }
}