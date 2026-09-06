namespace Tp3_ejercicio7
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double monto;
            double tasa;
            double dias;
            double interes;

            monto = double.Parse(txtMonto.Text);
            tasa = double.Parse(txtTasa.Text);
            dias = double.Parse(txtDias.Text);

            interes = monto * tasa * dias / 36500;

            dgvResultado.Rows.Add(monto, tasa, dias, interes);
        }
    }
}
