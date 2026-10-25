using System;

namespace Ejercicio5
{
    class NodoCola
    {
        public string Dato;
        public NodoCola Siguiente;
    }

    class Cola
    {
        private NodoCola Frente;
        private NodoCola Fin;

        public bool ColaVacia()
        {
            return Frente == null;
        }

        public void Encolar(string dato)
        {
            NodoCola nuevo = new NodoCola();
            nuevo.Dato = dato;
            nuevo.Siguiente = null;

            if (ColaVacia())
            {
                Frente = nuevo;
            }
            else
            {
                Fin.Siguiente = nuevo;
            }
            Fin = nuevo;
        }

        public string Desencolar()
        {
            if (ColaVacia())
            {
                throw new Exception("La cola está vacía");
            }
            string dato = Frente.Dato;
            Frente = Frente.Siguiente;
            if (Frente == null)
            {
                Fin = null;
            }
            return dato;
        }

        public string VerFrente()
        {
            if (ColaVacia())
            {
                throw new Exception("La cola está vacía");
            }
            return Frente.Dato;
        }

        public string VerFin()
        {
            if (ColaVacia())
            {
                throw new Exception("La cola está vacía");
            }
            return Fin.Dato;
        }
    }

    class ColaConPrioridad
    {
        private Cola cola1;
        private Cola cola2;
        private Cola cola3;

        public ColaConPrioridad()
        {
            cola1 = new Cola();
            cola2 = new Cola();
            cola3 = new Cola();
        }

        public void Encolar(string nombreCliente, int prioridad)
        {
            if (prioridad == 1)
            {
                cola1.Encolar(nombreCliente);
            }
            else if (prioridad == 2)
            {
                cola2.Encolar(nombreCliente);
            }
            else if (prioridad == 3)
            {
                cola3.Encolar(nombreCliente);
            }
            else
            {
                throw new ArgumentException("La prioridad debe ser 1, 2 o 3.");
            }
        }

        public string Desencolar()
        {
            if (!cola1.ColaVacia())
            {
                return cola1.Desencolar();
            }
            if (!cola2.ColaVacia())
            {
                return cola2.Desencolar();
            }
            if (!cola3.ColaVacia())
            {
                return cola3.Desencolar();
            }

            throw new Exception("Todas las colas están vacías.");
        }

        public bool ColaVacia()
        {
            return cola1.ColaVacia() && cola2.ColaVacia() && cola3.ColaVacia();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ColaConPrioridad colaPrioridad = new ColaConPrioridad();

            Console.WriteLine("Sistema de Cola con Prioridad para Clientes\n");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"--- Cliente {i + 1} ---");
                Console.Write("Ingrese el nombre del cliente: ");
                string nombre = Console.ReadLine();

                bool prioridadValida = false;

                while (!prioridadValida)
                {
                    try
                    {
                        Console.Write("Ingrese la prioridad (1=Alta, 2=Media, 3=Baja): ");
                        int prioridad = Convert.ToInt32(Console.ReadLine());

                        colaPrioridad.Encolar(nombre, prioridad);
                        Console.WriteLine($"Cliente '{nombre}' agregado exitosamente con prioridad {prioridad}.\n");
                        prioridadValida = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: La prioridad debe ser un número entero (1, 2 o 3).");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }

            Console.WriteLine("\nAtendiendo a los clientes por orden de prioridad (1 -> 2 -> 3)..");

            while (!colaPrioridad.ColaVacia())
            {
                Console.WriteLine($"Atendiendo a: {colaPrioridad.Desencolar()}");
            }
            Console.ReadKey();
        }
    }
}
