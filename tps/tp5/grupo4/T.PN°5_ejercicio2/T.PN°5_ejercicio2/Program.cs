using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.PN_5_ejercicio2
{
    class NodoPueblo
    {
        public string NombrePueblo;
        public NodoPueblo Siguiente;
    }

    class ListaPueblos
    {
        private NodoPueblo Destino;
        public bool NoViajo()
        {
            return Destino == null;
        }
        public void Recorrido(string nombrePueblo)
        {
            NodoPueblo nuevo = new NodoPueblo();
            nuevo.NombrePueblo = nombrePueblo;
            nuevo.Siguiente = Destino;
            Destino = nuevo;

        }

        public string Regreso()
        {
            if (NoViajo())
            {
                throw new InvalidOperationException("No se realizó ningun recorrido");
            }
            string nombrePublo = Destino.NombrePueblo;
            Destino = Destino.Siguiente;
            return nombrePublo;


        }
        public string VerDestino()
        {
            if (NoViajo())
            {
                throw new InvalidOperationException("No se realizó ningún recorrido");

            }
            return Destino.NombrePueblo;
        }
    }
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            ListaPueblos listaPueblos = new ListaPueblos();
            Console.WriteLine("\n---VIAJE A PUEBLO DESTINO---\n");

            listaPueblos.Recorrido("Uribelarrea");
            Console.WriteLine("Recorrido por Uribelarrea, Destino: " + listaPueblos.VerDestino());

            listaPueblos.Recorrido("Lobos");
            Console.WriteLine("Recorrido por Lobos, Destino: " + listaPueblos.VerDestino());

            listaPueblos.Recorrido("Tomas Jofré");
            Console.WriteLine("Recorrido por Tomas Jofré, Destino: " + listaPueblos.VerDestino());

            listaPueblos.Recorrido("Gouin");
            Console.WriteLine("Recorrido por Gouin, Destino: " + listaPueblos.VerDestino());

            Console.WriteLine("\n---VOLVIENDO AL PUEBLO DE ORIGEN---\n");
            while (!listaPueblos.NoViajo())
            {
                Console.WriteLine(listaPueblos.Regreso());
            }
            Console.ReadKey();
        }
    }
}
