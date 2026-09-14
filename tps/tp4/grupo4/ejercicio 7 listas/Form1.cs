using System;
using System.Windows.Forms;

namespace ejercicio_7_listas
{
    public partial class Form1 : Form
    {
        ListaEnlazadaSimple miListaEnlazadaSimple =
            new ListaEnlazadaSimple();

        public Form1()
        {
            InitializeComponent();
        }

        private void GenerarLista()
        {
            listaNodos.Items.Clear();

            Listar(miListaEnlazadaSimple.NodoInicial);
        }

        private void Listar(NodoSimple? nodo)
        {
            if (nodo != null)
            {
                listaNodos.Items.Add(nodo);

                if (nodo.Siguiente != null)
                {
                    Listar(nodo.Siguiente);
                }
            }
        }

        private void cmdAgregarAlPrincipio_Click(object sender, EventArgs e)
        {
            miListaEnlazadaSimple.AgregarAlPrincipio(textBox1.Text);

            GenerarLista();

            textBox1.Clear();
            textBox1.Focus();
        }

        private void cmdAgregarAlFinal_Click(object sender, EventArgs e)
        {
            miListaEnlazadaSimple.AgregarAlFinal(textBox1.Text);

            GenerarLista();

            textBox1.Clear();
            textBox1.Focus();
        }

        private void btnQuitarPrimero_Click_1(object sender, EventArgs e)
        {
            miListaEnlazadaSimple.QuitarPrimero();

            GenerarLista();
        }

        private void btnQuitarUltimo_Click_1(object sender, EventArgs e)
        {
            miListaEnlazadaSimple.QuitarUltimo();

            GenerarLista();
        }

        private void btnQuitarSeleccionado_Click_1(object sender, EventArgs e)
        {
            NodoSimple? nodo = listaNodos.SelectedItem as NodoSimple;

            if (nodo != null)
            {
                miListaEnlazadaSimple.QuitarPosicion(nodo.Numero);

                GenerarLista();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un nodo.");
            }
        }

        private void btnIntercambiarDerecha_Click_1(object sender, EventArgs e)
        {
            NodoSimple? nodo = listaNodos.SelectedItem as NodoSimple;

            if (nodo != null)
            {
                miListaEnlazadaSimple.IntercambiarDerecha(nodo.Numero);

                GenerarLista();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un nodo.");
            }
        }

        private void btnIntercambiarIzquierda_Click_1(object sender, EventArgs e)
        {
            NodoSimple? nodo = listaNodos.SelectedItem as NodoSimple;

            if (nodo != null)
            {
                miListaEnlazadaSimple.IntercambiarIzquierda(nodo.Numero);

                GenerarLista();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un nodo.");
            }
        }

        private void btnIntercambiar_Click_1(object sender, EventArgs e)
        {
            int numero1;
            int numero2;

            if (int.TryParse(textBox1.Text, out numero1) &&
                int.TryParse(textBox2.Text, out numero2))
            {
                miListaEnlazadaSimple.Intercambiar(numero1, numero2);

                GenerarLista();

                textBox1.Clear();
                textBox2.Clear();

                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Ingrese los dos números correctamente.");
            }
        }
    }
}