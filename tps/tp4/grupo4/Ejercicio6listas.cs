using System;

class Program
{
    static void Main(string[] args)
    {
        ListaPersonas lista = new ListaPersonas();
        Random rnd = new Random();

        int cantidadInicial = rnd.Next(0, 51); 

        for (int i = 1; i <= cantidadInicial; i++)
        {
            int edad = rnd.Next(5, 61);
            Persona p = new Persona(i, "Persona" + i, edad);
            lista.Agregar(p);
        }

        Console.WriteLine($"Se generaron {cantidadInicial} personas en la fila.");

        int opcion;
        do
        {
            Console.WriteLine("\n--- Control de Ingreso al Cine ---");
            Console.WriteLine("1. Registrar nueva persona");
            Console.WriteLine("2. Eliminar persona (se va de la fila)");
            Console.WriteLine("3. Actualizar datos de una persona");
            Console.WriteLine("4. Mostrar listado");
            Console.WriteLine("5. Mostrar total recaudado");
            Console.WriteLine("0. Salir");
            Console.Write("Opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    RegistrarPersona(lista);
                    break;
                case 2:
                    Console.Write("Codigo de la persona a eliminar: ");
                    int codEliminar = int.Parse(Console.ReadLine());
                    if (lista.Eliminar(codEliminar))
                        Console.WriteLine("Persona eliminada de la fila.");
                    else
                        Console.WriteLine("No se encontro el codigo.");
                    break;
                case 3:
                    ActualizarPersona(lista);
                    break;
                case 4:
                    lista.Mostrar();
                    break;
                case 5:
                    Console.WriteLine($"Total recaudado: ${lista.CalcularTotalRecaudado()}");
                    break;
            }

        } while (opcion != 0);
    }

    static void RegistrarPersona(ListaPersonas lista)
    {
        Console.Write("Codigo: ");
        int codigo = int.Parse(Console.ReadLine());
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Edad (minimo 5): ");
        int edad = int.Parse(Console.ReadLine());

        if (edad < 5)
        {
            Console.WriteLine("La edad minima para comprar entrada es 5 anios.");
            return;
        }

        Persona p = new Persona(codigo, nombre, edad);
        lista.Agregar(p);
        Console.WriteLine("Persona registrada.");
    }

    static void ActualizarPersona(ListaPersonas lista)
    {
        Console.Write("Codigo de la persona a actualizar: ");
        int codigo = int.Parse(Console.ReadLine());

        Nodo nodo = lista.Buscar(codigo);
        if (nodo == null)
        {
            Console.WriteLine("No se encontro el codigo.");
            return;
        }

        Console.WriteLine("Deje vacio el dato que no quiera modificar.");

        Console.Write($"Nombre ({nodo.Datos.Nombre}): ");
        string nombre = Console.ReadLine();
        if (nombre != "") nodo.Datos.Nombre = nombre;

        Console.Write($"Edad ({nodo.Datos.Edad}): ");
        string edadTexto = Console.ReadLine();
        if (edadTexto != "") nodo.Datos.Edad = int.Parse(edadTexto);

        Console.WriteLine("Datos actualizados.");
    }
}

class Persona
{
    public int Codigo;
    public string Nombre;
    public int Edad;

    public Persona(int codigo, string nombre, int edad)
    {
        Codigo = codigo;
        Nombre = nombre;
        Edad = edad;
    }

    public int PrecioEntrada()
    {
        if (Edad <= 12)
            return 500;
        else if (Edad <= 17)
            return 1000;
        else if (Edad <= 59)
            return 1500;
        else
            return 500;
    }
}

class Nodo
{
    public Persona Datos;
    public Nodo Proximo;
    public Nodo Anterior;

    public Nodo(Persona datos)
    {
        Datos = datos;
    }
}

class ListaPersonas
{
    public Nodo Primero;
    public Nodo Ultimo; 

    public void Agregar(Persona datos)
    {
        Nodo nuevo = new Nodo(datos);

        if (Primero == null)
        {
            Primero = nuevo;
            Ultimo = nuevo;
            return;
        }

        nuevo.Anterior = Ultimo;
        Ultimo.Proximo = nuevo;
        Ultimo = nuevo;
    }

    public Nodo Buscar(int codigo)
    {
        Nodo actual = Primero;
        while (actual != null)
        {
            if (actual.Datos.Codigo == codigo)
                return actual;

            actual = actual.Proximo;
        }

        return null;
    }

    public bool Eliminar(int codigo)
    {
        Nodo actual = Buscar(codigo);
        if (actual == null)
            return false;

        if (actual.Anterior != null)
            actual.Anterior.Proximo = actual.Proximo; 
        else
            Primero = actual.Proximo; 

        if (actual.Proximo != null)
            actual.Proximo.Anterior = actual.Anterior; 
        else
            Ultimo = actual.Anterior; 

        return true;
    }

    public void Mostrar()
    {
        if (Primero == null)
        {
            Console.WriteLine("No hay personas en la fila.");
            return;
        }

        Nodo actual = Primero;
        while (actual != null)
        {
            Persona p = actual.Datos;
            Console.WriteLine($"Codigo: {p.Codigo} | {p.Nombre} | Edad: {p.Edad} | Entrada: ${p.PrecioEntrada()}");
            actual = actual.Proximo;
        }
    }

    public int CalcularTotalRecaudado()
    {
        int total = 0;
        Nodo actual = Primero;

        while (actual != null)
        {
            total += actual.Datos.PrecioEntrada();
            actual = actual.Proximo;
        }

        return total;
    }
}