using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPN_3_ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            string texto1;
            string texto2;
            double numero1;
            double numero2;

            do
            {
                texto1 = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el primer valor: ");
                if (texto1 == "")
                {
                    MessageBox.Show("Debe ingresar un valor");
                    return;
                }
                else if (!double.TryParse(texto1, out numero1))
                {
                    MessageBox.Show("Debe ingresar un valor numérico");
                    return;
                }
            }
            while (texto1 == "" || !double.TryParse(texto1, out numero1));
            

            do
            {
                texto2 = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el segundo valor: ");
                if (texto2 == "")
                {
                    MessageBox.Show("Debe ingresar un valor");
                    return;
                }
                else if (!double.TryParse(texto2, out numero2))
                {
                    MessageBox.Show("Debe ingresar un valor numérico");
                    return;
                }
            } while(texto2 == "" || !double.TryParse(texto2, out numero2));
            
            double sumar = numero1  + numero2;
            MessageBox.Show("La suma es: " + sumar);
        }
    }
}
