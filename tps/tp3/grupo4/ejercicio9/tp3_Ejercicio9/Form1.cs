namespace tp3_Ejercicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTirar_Click(object sender, EventArgs e)
        {
            int cantidadTiradas;
            int[] resultados = new int[13];

            Random dado = new Random();

            cantidadTiradas = int.Parse(txtTiradas.Text);

            for (int i = 0; i < cantidadTiradas; i++)
            {
                int dado1 = dado.Next(1, 7);
                int dado2 = dado.Next(1, 7);

                int suma = dado1 + dado2;

                resultados[suma]++;
            }

            dgvResultados.Rows.Clear();

            for (int i = 2; i <= 12; i++)
            {
                double porcentaje;

                porcentaje = resultados[i] * 100.0 / cantidadTiradas;

                dgvResultados.Rows.Add(i, resultados[i], porcentaje.ToString("0.00") + "%");
            }
        }
    }
}