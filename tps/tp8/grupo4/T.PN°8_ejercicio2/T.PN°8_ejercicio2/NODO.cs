using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.PN_8_ejercicio2
{
    internal class Nodo
    {
        public string Nombre;
        public Nodo(string nombre)
        {
            Nombre = nombre;
            Izquierdo = null;
            Derecho = null;
        }
        public Nodo Derecho;
        public Nodo Izquierdo;
    }
}
