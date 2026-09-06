namespace tp3_ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btbTirar_Click(object sender, EventArgs e)
        {
            Random dado = new Random();

            int resultado;

            resultado = dado.Next(1, 7);

            lblResultado.Text = "Resultado: " + resultado;
        }
    }
}
