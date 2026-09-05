using System;
using System.Windows.Forms;

namespace NumerosPrimos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Función que determina si un número es primo
        static bool EsPrimo(int numero)
        {
            if (numero < 2)
            {
                return false;
            }

            for (int divisor = 2; divisor <= Math.Sqrt(numero); divisor++)
            {
                if (numero % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int minimo;
            int maximo;

            // Limpiar resultados anteriores
            lstPrimos.Items.Clear();

            // Validar los números ingresados
            if (!int.TryParse(txtMinimo.Text, out minimo) ||
                !int.TryParse(txtMaximo.Text, out maximo))
            {
                MessageBox.Show("Ingrese números enteros válidos.");
                return;
            }

            if (minimo > maximo)
            {
                MessageBox.Show(
                    "El número mínimo no puede ser mayor que el máximo."
                );

                return;
            }

            // Buscar los números primos
            for (int numero = minimo; numero <= maximo; numero++)
            {
                if (EsPrimo(numero))
                {
                    lstPrimos.Items.Add(numero);
                }
            }

            if (lstPrimos.Items.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron números primos en ese intervalo."
                );
            }
        }
    }
}