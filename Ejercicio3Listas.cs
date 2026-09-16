using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Ejercicio3Listas
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();

            int opcion;
            do
            {
                MostrarMenu(personas.Count);
                opcion = LeerEntero("Opcion: ", 0, 5);

                switch (opcion)
                {
                    case 1:
                        RegistrarPersona(personas);
                        break;
                    case 2:
                        EliminarPersona(personas);
                        break;
                    case 3:
                        ModificarPersona(personas);
                        break;
                    case 4:
                        AgregarDespues(personas);
                        break;
                    case 5:
                        MostrarPersonas(personas);
                        break;
                }
            } while (opcion != 0);

            Console.WriteLine($"Total recaudado: ${CalcularRecaudacion(personas):N2}");
        }

        static void MostrarMenu(int cantidadPersonas)
        {
            Console.WriteLine("\n--- Cine ---");
            Console.WriteLine($"Personas en la lista: {cantidadPersonas}");
            Console.WriteLine("1. Registrar nueva persona");
            Console.WriteLine("2. Eliminar persona");
            Console.WriteLine("3. Modificar persona");
            Console.WriteLine("4. Agregar despues de una persona");
            Console.WriteLine("5. Mostrar listado");
            Console.WriteLine("0. Salir y mostrar recaudacion");
        }

        static void RegistrarPersona(List<Persona> personas)
        {
            Persona persona = LeerPersona();
            if (BuscarPorDni(personas, persona.Dni) != -1)
            {
                Console.WriteLine("Ya existe una persona con ese DNI.");
                return;
            }

            personas.Add(persona);
            Console.WriteLine("Persona registrada correctamente.");
        }

        static void EliminarPersona(List<Persona> personas)
        {
            if (!HayPersonas(personas)) return;

            Console.Write("Ingrese el DNI de la persona a eliminar: ");
            string dni = Console.ReadLine() ?? "";
            int posicion = BuscarPorDni(personas, dni);

            if (posicion == -1)
            {
                Console.WriteLine("No se encontro una persona con ese DNI.");
                return;
            }

            personas.RemoveAt(posicion);
            Console.WriteLine("Persona eliminada correctamente.");
        }

        static void ModificarPersona(List<Persona> personas)
        {
            if (!HayPersonas(personas)) return;

            MostrarPersonas(personas);
            int posicion = LeerPosicion("Posicion a modificar: ", personas.Count);
            Console.WriteLine("Ingrese los nuevos datos:");
            personas[posicion] = LeerPersona();
            Console.WriteLine("Persona modificada correctamente.");
        }

        static void AgregarDespues(List<Persona> personas)
        {
            if (!HayPersonas(personas)) return;

            MostrarPersonas(personas);
            int posicion = LeerPosicion("Posicion seleccionada: ", personas.Count);
            personas.Insert(posicion + 1, LeerPersona());
            Console.WriteLine("Persona agregada correctamente.");
        }

        static Persona LeerPersona()
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine() ?? "";
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine() ?? "";
            Console.Write("DNI: ");
            string dni = Console.ReadLine() ?? "";
            int edad = LeerEntero("Edad (5 a 60): ", 5, 60);

            return new Persona
            {
                Nombre = nombre,
                Apellido = apellido,
                Dni = dni,
                Edad = edad
            };
        }

        static void MostrarPersonas(List<Persona> personas)
        {
            if (!HayPersonas(personas)) return;

            Console.WriteLine("\nListado de personas:");
            for (int i = 0; i < personas.Count; i++)
            {
                Persona persona = personas[i];
                Console.WriteLine($"{i}. {persona} - Entrada: ${CalcularEntrada(persona.Edad):N2}");
            }
        }

        static decimal CalcularEntrada(int edad)
        {
            if (edad <= 12) return 5000m;
            if (edad <= 17) return 7000m;
            return 10000m;
        }

        static decimal CalcularRecaudacion(List<Persona> personas)
        {
            decimal total = 0;

            foreach (Persona persona in personas)
            {
                total += CalcularEntrada(persona.Edad);
            }

            return total;
        }

        static int BuscarPorDni(List<Persona> personas, string dni)
        {
            return personas.FindIndex(persona => persona.Dni == dni);
        }

        static int LeerPosicion(string mensaje, int cantidad)
        {
            return LeerEntero(mensaje, 0, cantidad - 1);
        }

        static int LeerEntero(string mensaje, int minimo, int maximo)
        {
            int valor;
            do
            {
                Console.Write(mensaje);
                if (int.TryParse(Console.ReadLine(), out valor) && valor >= minimo && valor <= maximo)
                {
                    return valor;
                }

                Console.WriteLine($"Ingrese un numero entre {minimo} y {maximo}.");
            } while (true);
        }

        static bool HayPersonas(List<Persona> personas)
        {
            if (personas.Count > 0) return true;

            Console.WriteLine("No hay personas en la lista.");
            return false;
        }
    }

    class Persona
    {
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public string Dni { get; set; } = "";
        public int Edad { get; set; }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}, DNI: {Dni}, Edad: {Edad}";
        }
    }
}        