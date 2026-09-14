using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_7_listas
{
    public class ListaEnlazadaSimple
    {
        public NodoSimple NodoInicial { get; set; }

        public void AgregarAlPrincipio(string numero)
        {
            int valor = int.Parse(numero);

            NodoSimple nuevo = new NodoSimple(valor);

            nuevo.Siguiente = NodoInicial;
            NodoInicial = nuevo;
        }

        public void AgregarAlFinal(string numero)
        {
            int valor = int.Parse(numero);

            NodoSimple nuevo = new NodoSimple(valor);

            if (NodoInicial == null)
            {
                NodoInicial = nuevo;
                return;
            }

            NodoSimple actual = NodoInicial;

            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }

            actual.Siguiente = nuevo;
        }

        public void QuitarPrimero()
        {
            if (NodoInicial != null)
            {
                NodoInicial = NodoInicial.Siguiente;
            }
        }

        public void QuitarUltimo()
        {
            if (NodoInicial == null)
            {
                return;
            }

            if (NodoInicial.Siguiente == null)
            {
                NodoInicial = null;
                return;
            }

            NodoSimple actual = NodoInicial;

            while (actual.Siguiente.Siguiente != null)
            {
                actual = actual.Siguiente;
            }

            actual.Siguiente = null;
        }

        public void QuitarPosicion(int numero)
        {
            if (NodoInicial == null)
            {
                return;
            }

            if (NodoInicial.Numero == numero)
            {
                NodoInicial = NodoInicial.Siguiente;
                return;
            }

            NodoSimple actual = NodoInicial;

            while (actual.Siguiente != null)
            {
                if (actual.Siguiente.Numero == numero)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                    return;
                }

                actual = actual.Siguiente;
            }
        }

        private NodoSimple Buscar(int numero)
        {
            NodoSimple actual = NodoInicial;

            while (actual != null)
            {
                if (actual.Numero == numero)
                {
                    return actual;
                }

                actual = actual.Siguiente;
            }

            return null;
        }

        public void Intercambiar(int numero1, int numero2)
        {
            NodoSimple nodo1 = Buscar(numero1);
            NodoSimple nodo2 = Buscar(numero2);

            if (nodo1 != null && nodo2 != null)
            {
                int auxiliar = nodo1.Numero;

                nodo1.Numero = nodo2.Numero;
                nodo2.Numero = auxiliar;
            }
        }

        public void IntercambiarDerecha(int numero)
        {
            NodoSimple actual = Buscar(numero);

            if (actual != null && actual.Siguiente != null)
            {
                int auxiliar = actual.Numero;

                actual.Numero = actual.Siguiente.Numero;
                actual.Siguiente.Numero = auxiliar;
            }
        }

        public void IntercambiarIzquierda(int numero)
        {
            if (NodoInicial == null)
            {
                return;
            }

            NodoSimple anterior = null;
            NodoSimple actual = NodoInicial;

            while (actual != null)
            {
                if (actual.Numero == numero)
                {
                    if (anterior != null)
                    {
                        int auxiliar = actual.Numero;

                        actual.Numero = anterior.Numero;
                        anterior.Numero = auxiliar;
                    }

                    return;
                }

                anterior = actual;
                actual = actual.Siguiente;
            }
        }
    }
}