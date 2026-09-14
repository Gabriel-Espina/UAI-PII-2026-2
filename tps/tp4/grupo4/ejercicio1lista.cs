using System;

class Program
{
    static void Main(string[] args)
    {
        ListaPacientes lista = new ListaPacientes();
        int opcion;

        do
        {
            Console.WriteLine("\n--- Sistema de Registro de Pacientes ---");
            Console.WriteLine("1. Registrar nuevo paciente");
            Console.WriteLine("2. Eliminar paciente");
            Console.WriteLine("3. Actualizar pacientes");
            Console.WriteLine("4. Agregar después del seleccionado");
            Console.WriteLine("5. Mostrar listado");
            Console.WriteLine("0. Salir");
            Console.Write("Opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    RegistrarPaciente(lista);
                    break;
                case 2:
                    Console.Write("Codigo del paciente a eliminar: ");
                    int codEliminar = int.Parse(Console.ReadLine());
                    if (lista.Eliminar(codEliminar))
                        Console.WriteLine("Paciente eliminado.");
                    else
                        Console.WriteLine("No se encontro el codigo.");
                    break;
                case 3:
                    ActualizarPaciente(lista);
                    break;
                case 4:
                    AgregarDespues(lista);
                    break;
                case 5:
                    lista.Mostrar();
                    break;
            }

        } while (opcion != 0);
    }

    static void RegistrarPaciente(ListaPacientes lista)
    {
        Paciente p = PedirDatosPaciente();
        lista.Agregar(p);
        Console.WriteLine("Paciente registrado.");
    }

    static void ActualizarPaciente(ListaPacientes lista)
    {
        Console.Write("Codigo del paciente a actualizar: ");
        int codigo = int.Parse(Console.ReadLine());

        Nodo nodo = lista.Buscar(codigo);
        if (nodo == null)
        {
            Console.WriteLine("No se encontro el codigo.");
            return;
        }

        Console.WriteLine("Deje vacio el dato que no quiera modificar.");

        Console.Write($"Nombres ({nodo.Datos.Nombres}): ");
        string nombres = Console.ReadLine();
        if (nombres != "") nodo.Datos.Nombres = nombres;

        Console.Write($"Apellido ({nodo.Datos.Apellido}): ");
        string apellido = Console.ReadLine();
        if (apellido != "") nodo.Datos.Apellido = apellido;

        Console.Write($"Direccion ({nodo.Datos.Direccion}): ");
        string direccion = Console.ReadLine();
        if (direccion != "") nodo.Datos.Direccion = direccion;

        Console.Write($"Telefono ({nodo.Datos.Telefono}): ");
        string telefono = Console.ReadLine();
        if (telefono != "") nodo.Datos.Telefono = telefono;

        Console.WriteLine("Paciente actualizado.");
    }

    static void AgregarDespues(ListaPacientes lista)
    {
        Console.Write("Codigo del paciente de referencia: ");
        int codigoRef = int.Parse(Console.ReadLine());

        if (lista.Buscar(codigoRef) == null)
        {
            Console.WriteLine("No se encontro el codigo.");
            return;
        }

        Paciente nuevo = PedirDatosPaciente();
        lista.AgregarDespuesDe(codigoRef, nuevo);
        Console.WriteLine("Paciente agregado.");
    }

    static Paciente PedirDatosPaciente()
    {
        Paciente p = new Paciente();

        Console.Write("Codigo: ");
        p.Codigo = int.Parse(Console.ReadLine());
        Console.Write("Nombres: ");
        p.Nombres = Console.ReadLine();
        Console.Write("Apellido: ");
        p.Apellido = Console.ReadLine();
        Console.Write("Direccion: ");
        p.Direccion = Console.ReadLine();
        Console.Write("Telefono: ");
        p.Telefono = Console.ReadLine();

        return p;
    }
}

class Paciente
{
    public int Codigo;
    public string Nombres;
    public string Apellido;
    public string Direccion;
    public string Telefono;
}

class Nodo
{
    public Paciente Datos;
    public Nodo Proximo;

    public Nodo(Paciente datos)
    {
        Datos = datos;
    }
}

class ListaPacientes
{
    public Nodo Primero;

    public void Agregar(Paciente datos)
    {
        Nodo nuevo = new Nodo(datos);

        if (Primero == null)
        {
            Primero = nuevo;
            return;
        }

        Nodo actual = Primero;
        while (actual.Proximo != null)
        {
            actual = actual.Proximo;
        }

        actual.Proximo = nuevo;
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
        if (Primero == null)
            return false;

        if (Primero.Datos.Codigo == codigo)
        {
            Primero = Primero.Proximo;
            return true;
        }

        Nodo anterior = Primero;
        Nodo actual = Primero.Proximo;

        while (actual != null)
        {
            if (actual.Datos.Codigo == codigo)
            {
                anterior.Proximo = actual.Proximo;
                return true;
            }

            anterior = actual;
            actual = actual.Proximo;
        }

        return false;
    }

    public void AgregarDespuesDe(int codigoReferencia, Paciente nuevoPaciente)
    {
        Nodo referencia = Buscar(codigoReferencia);
        if (referencia == null)
            return;

        Nodo nuevo = new Nodo(nuevoPaciente);
        nuevo.Proximo = referencia.Proximo;
        referencia.Proximo = nuevo;
    }

    public void Mostrar()
    {
        if (Primero == null)
        {
            Console.WriteLine("No hay pacientes registrados.");
            return;
        }

        Nodo actual = Primero;
        while (actual != null)
        {
            Paciente p = actual.Datos;
            Console.WriteLine($"Codigo: {p.Codigo} | {p.Nombres} {p.Apellido} | {p.Direccion} | {p.Telefono}");
            actual = actual.Proximo;
        }
    }
}