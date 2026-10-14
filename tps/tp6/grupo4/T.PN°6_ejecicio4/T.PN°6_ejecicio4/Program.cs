using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.PN_6_ejecicio4
{
    class NodoPersona
    {
        public string Nombre;
        public string Sexo;
        public NodoPersona Siguiente;
    }

    class ColaPersona
    {
        private NodoPersona Frente;
        private NodoPersona Fin;

        public void Encolar(string nombre, string sexo)
        {
            NodoPersona nodoPersona = new NodoPersona();
            nodoPersona.Nombre = nombre;
            nodoPersona.Sexo = sexo;
            nodoPersona.Siguiente = null;
            if (EstaVacio())
            {
                Frente = nodoPersona;
                Fin = nodoPersona;
            }
            else
            {
                Fin.Siguiente = nodoPersona;
                Fin = nodoPersona;

            }

        }
        public NodoPersona Desencolar()
        {
            if (EstaVacio())
            {
                throw new InvalidOperationException("La cola está vacia");
            }
            NodoPersona persona = Frente;
            Frente = Frente.Siguiente;

            if(Frente == null)
            {
                Fin = null;
            }
            return persona;
        }
        public bool EstaVacio()
        {
            return Frente == null;
        }
        public void VerCola()
        {
            if (EstaVacio())
            {
                throw new InvalidOperationException("La cola esta vacia");
            }
            NodoPersona actual = Frente;
            while (actual != null)
            {
                Console.WriteLine(actual.Nombre + " - " + actual.Sexo);
                actual = actual.Siguiente;
            }

        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ColaPersona colaPersona = new ColaPersona();
            ColaPersona colaHombres = new ColaPersona();
            ColaPersona colaMujeres = new ColaPersona();
            int opcion;
            do
            {
                Console.WriteLine("\n----MENU DE REVISION MEDICA----");
                Console.WriteLine("1. Ingresar persona");
                Console.WriteLine("2. Ver cola inicial");
                Console.WriteLine("3. Desencolar persona");
                Console.WriteLine("4. Ver cola mujeres");
                Console.WriteLine("5. Ver cola hombres");
                Console.WriteLine("6. Ver ambas colas");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese Nombre:");
                        string nombre = Console.ReadLine();

                        Console.Write("Ingrese Sexo (masculino/femenino):");
                        string sexo = Console.ReadLine();

                        
                        if (sexo == "masculino"|| sexo == "Masculino")
                        {
                            colaPersona.Encolar(nombre, sexo);
                            colaHombres.Encolar(nombre, sexo);
                            Console.WriteLine("Persona ingresada correctamente.");
                        }
                        else if (sexo == "femenino"|| sexo == "Femenino")
                        {
                            colaPersona.Encolar(nombre, sexo);
                            colaMujeres.Encolar(nombre, sexo);
                            Console.WriteLine("Persona ingresada correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("Sexo inválido. Coloque femenino o masculino.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Cola inicial:");
                        colaPersona.VerCola();
                        break;
                    case 3:
                        if (!colaPersona.EstaVacio())
                        {
                            NodoPersona personaDesencolada = colaPersona.Desencolar();
                            if(personaDesencolada.Sexo == "masculino" || personaDesencolada.Sexo == "Masculino")
                            {
                                colaHombres.Desencolar();
                            }
                            else if (personaDesencolada.Sexo == "femenino" || personaDesencolada.Sexo == "Femenino")
                            {
                                colaMujeres.Desencolar();
                            }
                            else
                            {

                            }
                            Console.WriteLine(personaDesencolada.Nombre + " ha sido desencolada de la cola.");
                        }
                        else
                        {
                            Console.WriteLine("La cola está vacía.");
                        }
                        break;
                    case 4:
                        try
                        {
                            Console.WriteLine("\nCOLA DE MUJERES:");
                            colaMujeres.VerCola();

                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 5:
                        try
                        {
                            Console.WriteLine("\nCOLA DE HOMBRES:");
                            colaHombres.VerCola();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 6:
                        try
                        {
                            Console.WriteLine("\nCOLA DE MUJERES:");
                            colaMujeres.VerCola();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        try
                        {
                            Console.WriteLine("\nCOLA DE HOMBRES:");
                            colaHombres.VerCola();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 7:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                }
            }
            while (opcion != 7);
            
        }
    }
}
