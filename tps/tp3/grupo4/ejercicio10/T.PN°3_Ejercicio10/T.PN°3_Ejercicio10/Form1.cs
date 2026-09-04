using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T.PN_3_Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if(txtCantidad.Text == "")
            {
                MessageBox.Show("Ingrese un valor");
                return;
            }else if (!double.TryParse(txtCantidad.Text, out _))
            {
                MessageBox.Show("Ingrese un valor numérico");
                return;
            }
            double cantidad = double.Parse(txtCantidad.Text);
            string inicial = cmbInicial.SelectedItem.ToString();
            string final = cmbFinal.SelectedItem.ToString();

            

            switch (inicial)
            {
                case "Celsius":
                    switch (final)
                    {
                        case "Fahrenheit":
                            double resultado = (cantidad * 9 / 5) + 32;
                            MessageBox.Show("El resultado de " + cantidad + " " + inicial + " a " + final + " es:" + resultado.ToString("F2"));
                            dataGridView1.Rows.Add(cantidad, inicial, final, resultado.ToString("F2"));
                            break;

                        case "Kelvin":
                            double resultado2 = cantidad + 273.15;
                            MessageBox.Show("El resultado de " + cantidad + " " + inicial + " a " + final + " es:" + resultado2.ToString("F2"));
                            dataGridView1.Rows.Add(cantidad, inicial, final, resultado2.ToString("F2"));
                            break;

                        case "Rankine":
                            double resultado3 = (cantidad + 273.15) * 9 / 5;
                            MessageBox.Show("El resultado de " + cantidad + " " + inicial + " a " + final + " es:" + resultado3.ToString("F2"));
                            dataGridView1.Rows.Add(cantidad, inicial, final, resultado3.ToString("F2"));
                            break;

                        case"Celsius":
                            MessageBox.Show("El resultado de " + cantidad + " " + inicial + " a " + final + " es:" + cantidad);
                            dataGridView1.Rows.Add(cantidad, inicial, final, cantidad); 
                            break;
                    }
                    break;
                case "Fahrenheit":
                    switch (final)
                    {
                        case "Celsius":
                            double resultado = (cantidad - 32) * 5 / 9;
                            MessageBox.Show("El resultado de " + cantidad+ " " + inicial + " a " + final + " es:" + resultado.ToString("F2"));
                            dataGridView1.Rows.Add(cantidad, inicial, final, resultado.ToString("F2"));
                            break;
                        case "Kelvin":
                            double resultado2 = (cantidad - 32) * 5 / 9 + 273.15;
                            MessageBox.Show("El resultado de " + cantidad + " " + inicial + " a " + final + " es:" + resultado2.ToString("F2"));
                            dataGridView1.Rows.Add(cantidad, inicial, final, resultado2.ToString("F2"));
                            break;
                        case "Rankine":
                            double resultado3 = cantidad + 459.67;
                            MessageBox.Show("El resultado de " + cantidad + " " + inicial + " a " + final + " es:" + resultado3.ToString("F2"));
                            dataGridView1.Rows.Add(cantidad, inicial, final, resultado3.ToString("F2"));
                            break;
                        case"Fahrenheit":
                            MessageBox.Show("El resultado de " + cantidad + " " + inicial + " a " + final + " es:" + cantidad);
                            dataGridView1.Rows.Add(cantidad, inicial, final, cantidad);
                            break;
                    }
                    break;
                    case"Kelvin":
                    switch(final)
                    {
                        case "Celsius":
                            double resultado = cantidad - 273.15;
                            MessageBox.Show("El resultado de " + cantidad + " " + inicial + " a " + final + " es:" + resultado.ToString("F2"));
                            dataGridView1.Rows.Add(cantidad, inicial, final, resultado.ToString("F2"));
                            break;
                        case "Fahrenheit":
                            double resultado2 = (cantidad - 273.15) * 9 / 5 + 32;
                            MessageBox.Show("El resultado de " + cantidad + " " + inicial + " a " + final + " es:" + resultado2.ToString("F2"));
                            dataGridView1.Rows.Add(cantidad, inicial, final, resultado2.ToString("F2"));
                            break;
                        case "Rankine":
                            double resultado3 = cantidad * 9 / 5;
                            MessageBox.Show("El resultado de " + cantidad + " " + inicial + " a " + final + " es:" + resultado3.ToString("F2"));
                            dataGridView1.Rows.Add(cantidad, inicial, final, resultado3.ToString("F2"));
                            break;
                        case "Kelvin":
                            MessageBox.Show("El resultado de " + cantidad + " " + inicial + " a " + final + " es:" + cantidad);
                            dataGridView1.Rows.Add(cantidad, inicial, final, cantidad);
                            break;
                    }
                    break;
                    case "Rankine":
                    switch (final)
                    {
                        case "Celsius":
                            double resultado = (cantidad - 491.67) * 5 / 9;
                            MessageBox.Show("El resultado de " + cantidad + " " + inicial + " a " + final + " es:" + resultado.ToString("F2"));
                            dataGridView1.Rows.Add(cantidad, inicial, final, resultado.ToString("F2"));
                            break;
                        case "Fahrenheit":
                            double resultado2 = cantidad - 459.67;
                            MessageBox.Show("El resultado de " + cantidad + " " + inicial + " a " + final + " es:" + resultado2.ToString("F2"));
                            dataGridView1.Rows.Add(cantidad, inicial, final, resultado2.ToString("F2"));
                            break;
                        case "Kelvin":
                            double resultado3 = cantidad * 5 / 9;
                            MessageBox.Show("El resultado de " + cantidad + " " + inicial + " a " + final + " es:" + resultado3.ToString("F2"));
                            dataGridView1.Rows.Add(cantidad, inicial, final, resultado3.ToString("F2"));
                            break;
                        case "Rankine":
                            MessageBox.Show("El resultado de " + cantidad + " " + inicial + " a " + final + " es:" + cantidad);
                            dataGridView1.Rows.Add(cantidad, inicial, final, cantidad);
                            break;
                    }
                   
                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbInicial.SelectedIndex = 0;
            cmbFinal.SelectedIndex = 1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
