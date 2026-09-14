using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_7_listas
{
    public class NodoSimple
    {
        public int Numero { get; set; }

        public NodoSimple Siguiente { get; set; }

        public NodoSimple(int numero)
        {
            Numero = numero;
            Siguiente = null;
        }

        public override string ToString()
        {
            return Numero.ToString();
        }
    }
}
