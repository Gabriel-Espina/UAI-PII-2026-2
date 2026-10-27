using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace T.PN_8_ejercicio2
{
    public partial class Form1 : Form
    {
        Nodo raiz;
        Nodo seleccionado;
        public Form1()
        {
            InitializeComponent();
            treeView1.AfterSelect += treeView1_AfterSelect;
        }

        Nodo CrearNodo()
        {
            string nombre;
            do
            {
                nombre = Interaction.InputBox("Ingrese el nombre del nodo:");
                if(string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El nombre no puede estar vacio");
                }

            }
            while(string.IsNullOrWhiteSpace(nombre));

            return new Nodo(nombre);
        }

        void EvaluarArbol()
        {
            this.lblAltura.Text = $"Altura: {Alto(raiz)}";
            int inicio = 0;
            this.lblAncho.Text = $"Ancho: {Ancho(raiz,ref inicio)}";

        }

        int Ancho(Nodo n,ref int ancho)
        {
            if(n.Derecho == null && n.Izquierdo == null)
            {
                ancho+=1;
                
            }
            if (n.Derecho != null)
            {
                Ancho(n.Derecho, ref ancho);
            }
            if(n.Izquierdo != null)
            {
                Ancho(n.Izquierdo, ref ancho);
            }
            return ancho;
        }

        int Alto(Nodo n)
        {
            if (n == null)
            {
                return 0;
            }
            else
            {
                int alturaIzquierda = Alto(n.Izquierdo)+1;
                int alturaDerecha = Alto(n.Derecho)+1;
                return Math.Max(alturaIzquierda, alturaDerecha);
            }
        }

        private void btnAgregarRaiz_Click(object sender, EventArgs e)
        {
            if(raiz != null)
            {
                DialogResult r= MessageBox.Show("Se eliminará el arbol, desea continuar?","Consulta",MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    raiz = CrearNodo();
                }
            }
            else
            {
                raiz = CrearNodo();
            }

            CambiarSeleccion(raiz);
            LlenarTreeView();

        }
        public void LlenarTreeView()
        {
            treeView1.Nodes.Clear();
            MostrarNodo(raiz,null,string.Empty);
            treeView1.ExpandAll();
            EvaluarArbol();
        }

        private void MostrarNodo(Nodo n,TreeNode tnpadre,string lado)
        {
            if (n == null)
            {
                return;
            }
            TreeNode nodoActual = new TreeNode();
            if (tnpadre == null && lado == String.Empty)
            {
                tnpadre = new TreeNode();
                nodoActual.Text = n.Nombre;
                nodoActual.Tag = n;
                treeView1.Nodes.Add(nodoActual);
            }
            else
            {
                nodoActual.Text = $"{lado}-{n.Nombre}";
                nodoActual.Tag = n;
                tnpadre.Nodes.Add(nodoActual);
            }
           if(n.Derecho != null)
            {
                MostrarNodo(n.Derecho, nodoActual, "D");
            }
            if(n.Izquierdo != null)
            {
                MostrarNodo(n.Izquierdo, nodoActual, "I");
            }
        }

        void CambiarSeleccion(Nodo n)
        {
            seleccionado = n;
            this.lblNombreNodo.Text = n.Nombre;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Nodo n = (Nodo)e.Node.Tag;
            CambiarSeleccion(n);
        }

        private void btnAgregarDerecha_Click(object sender, EventArgs e)
        {
            if(seleccionado!= null)
            {
                if(seleccionado.Derecho == null)
                {
                    seleccionado.Derecho = CrearNodo();
                    LlenarTreeView();
                }
                else
                {
                    MessageBox.Show("El nodo ya tiene un hijo derecho");
                }
                
            }
            else
            {
                MessageBox.Show("Debe tener algun nodo seleccionado");
            }
        }

        private void btnAgregarIzquierda_Click(object sender, EventArgs e)
        {
            if(seleccionado != null)
            {
                if (seleccionado.Izquierdo == null)
                {
                    seleccionado.Izquierdo = CrearNodo();
                    LlenarTreeView();
                }
                else
                {
                    MessageBox.Show("El nodo ya tiene un hijo izquierdo");
                }
            }
            else
            {
                MessageBox.Show("Debe tener algun nodo seleccionado");
            }
        }

        private void btnRecorrerPreorden_Click(object sender, EventArgs e)
        {
            if (raiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }
            this.txtRecorrido.Text = string.Empty;
            RecorrerPreorden(raiz);
        }

        private void btnRecorrerInorden_Click(object sender, EventArgs e)
        {
            if (raiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }
            this.txtRecorrido.Text = string.Empty;
            RecorrerInorden(raiz);

        }

        private void btnRecorrerPostorden_Click(object sender, EventArgs e)
        {
            if (raiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }
            this.txtRecorrido.Text = string.Empty;
            RecorrerPostorden(raiz);
        }

        void RecorrerPreorden(Nodo n)
        {
            Visitar(n);
            if(n.Izquierdo != null)
            {
                RecorrerPreorden(n.Izquierdo);
            }
            if(n.Derecho != null)
            {
                RecorrerPreorden(n.Derecho);
            }
        }

        void RecorrerInorden(Nodo n)
        {
            if (n.Izquierdo != null)
            {
                RecorrerInorden(n.Izquierdo);
            }
            Visitar(n);
            if (n.Derecho != null)
            {
                RecorrerInorden(n.Derecho);
            }
        }

        void RecorrerPostorden(Nodo n)
        {
            if (n.Izquierdo != null)
            {
                RecorrerPostorden(n.Izquierdo);
            }
            if (n.Derecho != null)
            {
                RecorrerPostorden(n.Derecho);
            }
            Visitar(n);
        }

        void Visitar(Nodo n)
        {
            this.txtRecorrido.Text += " - "+ n.Nombre ;
        }

        private void lblAltura_Click(object sender, EventArgs e)
        {

        }
    }
}
